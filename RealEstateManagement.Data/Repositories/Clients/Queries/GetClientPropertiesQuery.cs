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

namespace RealEstateManagement.Data.Repositories.Client.Queries
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
            string status = "SUCCESS";
            string message = "Client properties retrieved successfully";
            int currentPage = page, pageSize = limit, totalRecords = 0, totalPages = 0;

            string clientFullName = string.Empty;
            string clientPhoneNumber = string.Empty;
            string clientAddress = string.Empty;

            try
            {
                bool hasRows = false;

                while (await reader.ReadAsync())
                {
                    hasRows = true;

                    // Check if this is an error row (ClientPropertyId will be NULL in error case)
                    var clientPropertyId = reader.GetValueOrDefault<int?>("ClientPropertyId");

                    if (clientPropertyId.HasValue)
                    {
                        // This is a valid property row - map it
                        var property = ClientMapper.MapClientPropertyFromReader(reader);
                        properties.Add(property);
                    }

                    // Read client info and pagination from every row (they're repeated)
                    // In case of error row or success row, these fields are always present
                    clientFullName = reader.GetValueOrDefault<string>("ClientFullName") ?? string.Empty;
                    clientPhoneNumber = reader.GetValueOrDefault<string>("ClientPhoneNumber") ?? string.Empty;
                    clientAddress = reader.GetValueOrDefault<string>("ClientAddress") ?? string.Empty;

                    currentPage = reader.GetValueOrDefault<int>("CurrentPage");
                    pageSize = reader.GetValueOrDefault<int>("PageSize");
                    totalRecords = reader.GetValueOrDefault<int>("TotalRecords");
                    totalPages = (int)(totalRecords / limit);

                    status = reader.GetValueOrDefault<string>("Status") ?? "SUCCESS";
                    message = reader.GetValueOrDefault<string>("Message") ?? "Client properties retrieved successfully";
                }

                // If no rows were returned at all (shouldn't happen with your SP, but handle it)
                if (!hasRows)
                {
                    logger.LogWarning("No rows returned from stored procedure - ClientId: {ClientId}", clientId);
                    message = "No data returned from database";
                    status = "ERROR";
                }

                // Check if we got an error status from the stored procedure
                if (status == "ERROR")
                {
                    logger.LogError("Stored procedure returned error - ClientId: {ClientId}, Message: {Message}",
                        clientId, message);
                    return OperationResult<ClientPropertiesGetResponseDto>.Failure(message);
                }

                var responseDto = new ClientPropertiesGetResponseDto
                {
                    Properties = properties,
                    ClientFullName = clientFullName,
                    ClientPhoneNumber = clientPhoneNumber,
                    ClientAddress = clientAddress,
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                    TotalRecords = totalRecords,
                    TotalPages = totalPages
                };

                logger.LogInformation(
                    "Client properties retrieved successfully - ClientId: {ClientId}, Page: {Page}, Count: {Count}, Total: {Total}",
                    clientId, page, properties.Count, totalRecords);

                return OperationResult<ClientPropertiesGetResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex,
                    "Error processing client properties data - ClientId: {ClientId}, Page: {Page}, Limit: {Limit}",
                    clientId, page, limit);

                return OperationResult<ClientPropertiesGetResponseDto>.Failure("Failed to process client properties data");
            }
        }
    }
}