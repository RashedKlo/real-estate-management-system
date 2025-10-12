using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Models;
using RealEstateManagement.Data.Repositories.Owner.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Owner.Queries
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
            string status = "SUCCESS";
            string message = "Owner properties retrieved successfully";
            int currentPage = page, pageSize = limit, totalRecords = 0, totalPages = 0;

            string ownerFullName = string.Empty;
            string ownerPhoneNumber = string.Empty;
            string ownerAddress = string.Empty;

            try
            {
                bool hasRows = false;

                while (await reader.ReadAsync())
                {
                    hasRows = true;

                    // Check if this is an error row (OwnerPropertyId will be NULL in error case)
                    var ownerPropertyId = reader.GetValueOrDefault<int?>("OwnerPropertyId");

                    if (ownerPropertyId.HasValue)
                    {
                        // This is a valid property row - map it
                        var property = OwnerMapper.MapOwnerPropertyFromReader(reader);
                        properties.Add(property);
                    }

                    // Read owner info and pagination from every row (they're repeated)
                    // In case of error row or success row, these fields are always present
                    ownerFullName = reader.GetValueOrDefault<string>("OwnerFullName") ?? string.Empty;
                    ownerPhoneNumber = reader.GetValueOrDefault<string>("OwnerPhoneNumber") ?? string.Empty;
                    ownerAddress = reader.GetValueOrDefault<string>("OwnerAddress") ?? string.Empty;

                    currentPage = reader.GetValueOrDefault<int>("CurrentPage");
                    pageSize = reader.GetValueOrDefault<int>("PageSize");
                    totalRecords = reader.GetValueOrDefault<int>("TotalRecords");
                    totalPages = (int)(totalRecords / limit);

                    status = reader.GetValueOrDefault<string>("Status") ?? "SUCCESS";
                    message = reader.GetValueOrDefault<string>("Message") ?? "Owner properties retrieved successfully";
                }

                // If no rows were returned at all (shouldn't happen with your SP, but handle it)
                if (!hasRows)
                {
                    logger.LogWarning("No rows returned from stored procedure - OwnerId: {OwnerId}", ownerId);
                    message = "No data returned from database";
                    status = "ERROR";
                }

                // Check if we got an error status from the stored procedure
                if (status == "ERROR")
                {
                    logger.LogError("Stored procedure returned error - OwnerId: {OwnerId}, Message: {Message}",
                        ownerId, message);
                    return OperationResult<OwnerPropertiesGetResponseDto>.Failure(message);
                }

                var responseDto = new OwnerPropertiesGetResponseDto
                {
                    Properties = properties,
                    OwnerFullName = ownerFullName,
                    OwnerPhoneNumber = ownerPhoneNumber,
                    OwnerAddress = ownerAddress,
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                    TotalRecords = totalRecords,
                    TotalPages = totalPages
                };

                logger.LogInformation(
                    "Owner properties retrieved successfully - OwnerId: {OwnerId}, Page: {Page}, Count: {Count}, Total: {Total}",
                    ownerId, page, properties.Count, totalRecords);

                return OperationResult<OwnerPropertiesGetResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex,
                    "Error processing owner properties data - OwnerId: {OwnerId}, Page: {Page}, Limit: {Limit}",
                    ownerId, page, limit);

                return OperationResult<OwnerPropertiesGetResponseDto>.Failure("Failed to process owner properties data");
            }
        }
    }
}