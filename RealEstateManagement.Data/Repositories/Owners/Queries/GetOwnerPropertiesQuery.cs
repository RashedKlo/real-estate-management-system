using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Models;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.OwnerProperties.Queries
{
    public class GetOwnerPropertiesQuery
    {
        private const string GetOwnerPropertiesSql = @"
            EXEC [dbo].[sp_GetOwnerProperties] 
                @OwnerId, @Page, @Limit";

        public static async Task<OperationResult<OwnerPropertiesGetResponseDto>> ExecuteAsync(
            OwnerPropertiesGetRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("Request data is null");
                return OperationResult<OwnerPropertiesGetResponseDto>.Failure("Request data is required");
            }

            logger.LogInformation("Retrieving owner properties - OwnerId: {OwnerId}, Page: {Page}, Limit: {Limit}",
                dto.OwnerId, dto.Page, dto.Limit);

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
                                return OperationResult<OwnerPropertiesGetResponseDto>.Failure("Failed to retrieve data from database");
                            }

                            return await ProcessResultAsync(reader, logger, dto.OwnerId, dto.Page, dto.Limit);
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection failed - OwnerId: {OwnerId}, Page: {Page}, Limit: {Limit}",
                    dto.OwnerId, dto.Page, dto.Limit);
                return OperationResult<OwnerPropertiesGetResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "Database error - OwnerId: {OwnerId}, Page: {Page}, Limit: {Limit}, SqlError: {ErrorNumber}",
                    dto.OwnerId, dto.Page, dto.Limit, ex.Number);
                return OperationResult<OwnerPropertiesGetResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error - OwnerId: {OwnerId}, Page: {Page}, Limit: {Limit}",
                    dto.OwnerId, dto.Page, dto.Limit);
                return OperationResult<OwnerPropertiesGetResponseDto>.Failure("System error occurred during retrieval");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, OwnerPropertiesGetRequestDto dto)
        {
            if (connection == null)
                throw new ArgumentNullException(nameof(connection), "Database connection is null");

            SqlCommand command = new SqlCommand(GetOwnerPropertiesSql, connection);
            command.AddParameter("@OwnerId", dto.OwnerId);
            command.AddParameter("@Page", dto.Page);
            command.AddParameter("@Limit", dto.Limit);
            return command;
        }

        private static async Task<OperationResult<OwnerPropertiesGetResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int ownerId,
            int page,
            int limit)
        {
            if (reader == null)
            {
                logger.LogError("Reader is null in ProcessResultAsync");
                return OperationResult<OwnerPropertiesGetResponseDto>.Failure("Failed to process database results");
            }

            List<OwnerPropertyModel> properties = new List<OwnerPropertyModel>();
            string status = "ERROR";
            string message = "Owner properties retrieval completed";
            int currentPage = 0, pageSize = 0, totalRecords = 0, totalPages = 0;

            try
            {
                bool isFirstRow = true;

                while (await reader.ReadAsync())
                {
                    // Debug logging for first row
                    if (isFirstRow)
                    {
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
                        message = reader.GetValueOrDefault<string>("Message")?.Trim() ?? "Owner properties retrieval completed";

                        logger.LogInformation("Metadata - RawStatus: '{Raw}', Status: '{Status}', Message: '{Message}', TotalRecords: {TotalRecords}",
                            rawStatus, status, message, totalRecords);

                        bool isSuccess = status.Equals("SUCCESS", StringComparison.Ordinal);
                        logger.LogInformation("Status comparison - Value: '{Status}', Length: {Length}, IsSuccess: {IsSuccess}",
                            status, status.Length, isSuccess);

                        if (!isSuccess)
                        {
                            logger.LogWarning("Database returned non-SUCCESS status - Status: '{Status}', Message: '{Message}'",
                                status, message);
                            return OperationResult<OwnerPropertiesGetResponseDto>.Failure(message);
                        }

                        isFirstRow = false;
                    }

                    OwnerPropertyModel property = MapOwnerPropertyFromReader(reader);

                    if (property == null)
                    {
                        logger.LogWarning("MapOwnerPropertyFromReader returned null for a row");
                        continue;
                    }

                    properties.Add(property);
                }

                if (!status.Equals("SUCCESS", StringComparison.Ordinal))
                {
                    logger.LogWarning("Final status check failed - Status: '{Status}', Message: '{Message}'",
                        status, message);
                    return OperationResult<OwnerPropertiesGetResponseDto>.Failure(message);
                }

                logger.LogInformation("Status check passed - Status: '{Status}', Properties count: {Count}",
                    status, properties.Count);

                OwnerPropertiesGetResponseDto responseDto = new OwnerPropertiesGetResponseDto
                {
                    Properties = properties ?? new List<OwnerPropertyModel>(),
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                    TotalRecords = totalRecords,
                    TotalPages = totalPages
                };

                logger.LogInformation("Owner properties retrieved successfully - OwnerId: {OwnerId}, Page: {Page}, Count: {Count}, Total: {Total}",
                    ownerId, page, properties.Count, totalRecords);

                return OperationResult<OwnerPropertiesGetResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing owner properties data - OwnerId: {OwnerId}, Page: {Page}, Limit: {Limit}",
                    ownerId, page, limit);
                return OperationResult<OwnerPropertiesGetResponseDto>.Failure("Failed to process owner properties data");
            }
        }

        private static OwnerPropertyModel MapOwnerPropertyFromReader(SqlDataReader reader)
        {
            return new OwnerPropertyModel
            {
                PropertyId = reader.GetValueOrDefault<int>("PropertyId"),
                Location = reader.GetValueOrDefault<string>("Location"),
                NumOfRooms = reader.GetValueOrDefault<int>("NumOfRooms"),
                Status = reader.GetValueOrDefault<string>("Status"),
                Availability = reader.GetValueOrDefault<string>("Availability"),
                RentPrice = reader.GetValueOrDefault<decimal?>("RentPrice"),
                SalePrice = reader.GetValueOrDefault<decimal?>("SalePrice"),
                MortgagePrice = reader.GetValueOrDefault<decimal?>("MortgagePrice"),
                OwnerId = reader.GetValueOrDefault<int>("OwnerId"),
                CreatedAt = reader.GetValueOrDefault<DateTime>("CreatedAt"),
                OwnerFullName = reader.GetValueOrDefault<string>("OwnerFullName"),
                OwnerPhoneNumber = reader.GetValueOrDefault<string>("OwnerPhoneNumber"),
                OwnerAddress = reader.GetValueOrDefault<string>("OwnerAddress"),
                OwnerCreatedAt = reader.GetValueOrDefault<DateTime>("OwnerCreatedAt")
            };
        }
    }
}