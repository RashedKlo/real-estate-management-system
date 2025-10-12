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
    public class GetOwnersQuery
    {
        private const string GetOwnersSql = @"
            EXEC [dbo].[sp_GetOwners] 
                @Page, 
                @Limit,
@FullName,@PhoneNumber";

        public static async Task<OperationResult<OwnersGetResponseDto>> ExecuteAsync(
            OwnersGetRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("Request data is null");
                return OperationResult<OwnersGetResponseDto>.Failure("Request data is required");
            }

            logger.LogInformation("Retrieving owners - Page: {Page}, Limit: {Limit}", dto.Page, dto.Limit);

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
                                return OperationResult<OwnersGetResponseDto>.Failure("Failed to retrieve data from database");
                            }

                            return await ProcessResultAsync(reader, logger, dto.Page, dto.Limit);
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection failed - Page: {Page}, Limit: {Limit}", dto.Page, dto.Limit);
                return OperationResult<OwnersGetResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "Database error - Page: {Page}, Limit: {Limit}, SqlError: {ErrorNumber}",
                    dto.Page, dto.Limit, ex.Number);
                return OperationResult<OwnersGetResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error - Page: {Page}, Limit: {Limit}", dto.Page, dto.Limit);
                return OperationResult<OwnersGetResponseDto>.Failure("System error occurred during owner retrieval");
            }
        }

        // ---------------- Helper Methods ----------------

        private static SqlCommand CreateCommand(SqlConnection connection, OwnersGetRequestDto dto)
        {
            if (connection == null)
                throw new ArgumentNullException(nameof(connection), "Database connection is null");

            SqlCommand command = new SqlCommand(GetOwnersSql, connection)
            {
                CommandType = System.Data.CommandType.Text
            };

            command.AddParameter("@Page", dto.Page);
            command.AddParameter("@Limit", dto.Limit);
            command.AddParameter("@PhoneNumber", dto.PhoneNumber);
            command.AddParameter("@FullName", dto.FullName);
            return command;
        }

        private static async Task<OperationResult<OwnersGetResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int page,
            int limit)
        {
            if (reader == null)
            {
                logger.LogError("Reader is null in ProcessResultAsync");
                return OperationResult<OwnersGetResponseDto>.Failure("Failed to process database results");
            }

            List<OwnerModel> owners = new List<OwnerModel>();
            string status = "ERROR";
            string message = "No data retrieved";
            int currentPage = 0, pageSize = 0, totalRecords = 0, totalPages = 0;
            bool hasNextPage = false, hasPreviousPage = false;

            try
            {
                while (await reader.ReadAsync())
                {
                    OwnerModel owner = OwnerMapper.MapOwnerFromReader(reader);

                    if (owner != null)
                        owners.Add(owner);

                    // Only read pagination info from the first row
                    if (owners.Count == 1)
                    {
                        currentPage = reader.GetValueOrDefault<int>("CurrentPage");
                        pageSize = reader.GetValueOrDefault<int>("PageSize");
                        totalRecords = reader.GetValueOrDefault<int>("TotalRecords");
                        totalPages = reader.GetValueOrDefault<int>("TotalPages");
                        hasNextPage = reader.GetValueOrDefault<int>("HasNextPage") == 1;
                        hasPreviousPage = reader.GetValueOrDefault<int>("HasPreviousPage") == 1;
                        status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                        message = reader.GetValueOrDefault<string>("Message") ?? "Owners retrieval failed";
                    }
                }

                OwnersGetResponseDto responseDto = new OwnersGetResponseDto
                {
                    Owners = owners,
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                    TotalRecords = totalRecords,
                    TotalPages = totalPages,
                    HasNextPage = hasNextPage,
                    HasPreviousPage = hasPreviousPage
                };

                logger.LogInformation("Owners retrieved successfully - Page: {Page}, Count: {Count}, Total: {Total}",
                    page, owners.Count, totalRecords);

                return OperationResult<OwnersGetResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing owner data - Page: {Page}, Limit: {Limit}", page, limit);
                return OperationResult<OwnersGetResponseDto>.Failure("Failed to process owner data");
            }
        }
    }
}