using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.Models;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.DTOs.Clients.Queries;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;
using RealEstateManagement.Data.Repositories.Client.Helpers;

namespace RealEstateManagement.Data.Repositories.ClientProperties.Queries
{
    public class GetClientPropertiesQuery
    {
        private const string GetClientPropertiesSql = @"
            EXEC [dbo].[sp_GetClientProperties] 
                @ClientId, @Page, @Limit";

        public static async Task<OperationResult<ClientPropertiesGetResponseDto>> ExecuteAsync(
            ClientPropertiesGetRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("Request data is null");
                return OperationResult<ClientPropertiesGetResponseDto>.Failure("Request data is required");
            }

            logger.LogInformation("Retrieving client properties - ClientId: {ClientId}, Page: {Page}, Limit: {Limit}",
                dto.ClientId, dto.Page, dto.Limit);

            try
            {
                using (SqlConnection connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = CreateCommand(connection, dto))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader == null)
                            {
                                logger.LogError("Reader is null after ExecuteReaderAsync");
                                return OperationResult<ClientPropertiesGetResponseDto>.Failure("Failed to retrieve data from database");
                            }

                            return await ProcessResultAsync(reader, logger, dto.ClientId, dto.Page, dto.Limit);
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection failed - ClientId: {ClientId}, Page: {Page}, Limit: {Limit}",
                    dto.ClientId, dto.Page, dto.Limit);
                return OperationResult<ClientPropertiesGetResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "Database error - ClientId: {ClientId}, Page: {Page}, Limit: {Limit}, SqlError: {ErrorNumber}",
                    dto.ClientId, dto.Page, dto.Limit, ex.Number);
                return OperationResult<ClientPropertiesGetResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error - ClientId: {ClientId}, Page: {Page}, Limit: {Limit}",
                    dto.ClientId, dto.Page, dto.Limit);
                return OperationResult<ClientPropertiesGetResponseDto>.Failure("System error occurred during retrieval");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, ClientPropertiesGetRequestDto dto)
        {
            if (connection == null)
                throw new ArgumentNullException(nameof(connection), "Database connection is null");

            SqlCommand command = new SqlCommand(GetClientPropertiesSql, connection);
            command.AddParameter("@ClientId", dto.ClientId);
            command.AddParameter("@Page", dto.Page);
            command.AddParameter("@Limit", dto.Limit);
            return command;
        }

        private static async Task<OperationResult<ClientPropertiesGetResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int clientId,
            int page,
            int limit)
        {
            if (reader == null)
            {
                logger.LogError("Reader is null in ProcessResultAsync");
                return OperationResult<ClientPropertiesGetResponseDto>.Failure("Failed to process database results");
            }

            List<ClientPropertyModel> properties = new List<ClientPropertyModel>();
            string status = "ERROR";
            string message = "Client properties retrieval completed";
            int currentPage = 0, pageSize = 0, totalRecords = 0, totalPages = 0;

            try
            {
                bool isFirstRow = true;

                while (await reader.ReadAsync())
                {
                    // Debug logging for first row
                    if (isFirstRow)
                    {
                        logger.LogInformation("===== FIRST ROW DEBUG =====");
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string colName = reader.GetName(i);
                            object colValue = reader.IsDBNull(i) ? null : reader.GetValue(i);
                            logger.LogInformation("Column[{Index}] '{Name}' = '{Value}'", i, colName, colValue);
                        }
                        logger.LogInformation("===== END FIRST ROW DEBUG =====");
                    }

                    // Get metadata from first row
                    if (properties.Count == 0)
                    {
                        currentPage = reader.GetValueOrDefault<int>("CurrentPage");
                        pageSize = reader.GetValueOrDefault<int>("PageSize");
                        totalRecords = reader.GetValueOrDefault<int>("TotalRecords");
                        totalPages = reader.GetValueOrDefault<int>("TotalPages");

                        // Get Status with detailed logging
                        string rawStatus = null;
                        try
                        {
                            int statusOrdinal = reader.GetOrdinal("Status");
                            if (!reader.IsDBNull(statusOrdinal))
                            {
                                rawStatus = reader.GetString(statusOrdinal);
                            }
                        }
                        catch (Exception ex)
                        {
                            logger.LogError(ex, "Error reading Status column");
                        }

                        status = rawStatus?.Trim() ?? "ERROR";
                        message = reader.GetValueOrDefault<string>("Message")?.Trim() ?? "Client properties retrieval completed";

                        logger.LogInformation("Metadata - RawStatus: '{Raw}', Status: '{Status}', Message: '{Message}', TotalRecords: {TotalRecords}",
                            rawStatus, status, message, totalRecords);

                        bool isSuccess = status.Equals("SUCCESS", StringComparison.Ordinal);
                        logger.LogInformation("Status comparison - Value: '{Status}', Length: {Length}, IsSuccess: {IsSuccess}",
                            status, status.Length, isSuccess);

                        if (!isSuccess)
                        {
                            logger.LogWarning("Database returned non-SUCCESS status - Status: '{Status}', Message: '{Message}'",
                                status, message);
                            return OperationResult<ClientPropertiesGetResponseDto>.Failure(message);
                        }

                        isFirstRow = false;
                    }

                    ClientPropertyModel property = ClientMapper. MapClientPropertyFromReader(reader);

                    if (property == null)
                    {
                        logger.LogWarning("MapClientPropertyFromReader returned null for a row");
                        continue;
                    }

                    properties.Add(property);
                }

                if (!status.Equals("SUCCESS", StringComparison.Ordinal))
                {
                    logger.LogWarning("Final status check failed - Status: '{Status}', Message: '{Message}'",
                        status, message);
                    return OperationResult<ClientPropertiesGetResponseDto>.Failure(message);
                }

                logger.LogInformation("Status check passed - Status: '{Status}', Properties count: {Count}",
                    status, properties.Count);

                ClientPropertiesGetResponseDto responseDto = new ClientPropertiesGetResponseDto
                {
                    Properties = properties ?? new List<ClientPropertyModel>(),
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                    TotalRecords = totalRecords,
                    TotalPages = totalPages
                };

                logger.LogInformation("Client properties retrieved successfully - ClientId: {ClientId}, Page: {Page}, Count: {Count}, Total: {Total}",
                    clientId, page, properties.Count, totalRecords);

                return OperationResult<ClientPropertiesGetResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing client properties data - ClientId: {ClientId}, Page: {Page}, Limit: {Limit}",
                    clientId, page, limit);
                return OperationResult<ClientPropertiesGetResponseDto>.Failure("Failed to process client properties data");
            }
        }


    }
}