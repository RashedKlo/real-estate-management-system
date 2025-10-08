using System;
using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;
using RealEstateManagement.Data.Models ;
using System.Data.SqlClient;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Owner.Helpers;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace RealEstateManagement.Data.Repositories.Owner.Queries
{
    public class GetOwnersQuery
    {
        private const string GetOwnersSql = @"
            EXEC [dbo].[sp_GetOwners] 
                @Page, @Limit";

        public static async Task<OperationResult<OwnersGetResponseDto>> ExecuteAsync(
            OwnersGetRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("GetOwnersQuery received null request data");
                return OperationResult<OwnersGetResponseDto>.Failure("Request data is required");
            }

            logger.LogInformation("Executing Owners retrieval for Page: {Page}, Limit: {Limit}",
                dto.Page, dto.Limit);

            try
            {
                 var connection = new SqlConnection(DBSettings.connectionString);
                await connection.OpenAsync();

                 var command = CreateCommand(connection, dto);
                 var reader = await command.ExecuteReaderAsync();

                return await ProcessResultAsync(reader, logger, dto.Page, dto.Limit);
            }
            catch (SqlException ex) when (ex.Number >=2 && ex.Number<= 53)
            {
                logger.LogError(ex, "Database connection failed during Owners retrieval for Page {Page}, Limit {Limit}",
                    dto.Page, dto.Limit);
                return OperationResult<OwnersGetResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "Database error during Owners retrieval for Page {Page}, Limit {Limit}. Error: {Error}",
                    dto.Page, dto.Limit, ex.Message);
                return OperationResult<OwnersGetResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during Owners retrieval for Page {Page}, Limit {Limit}",
                    dto.Page, dto.Limit);
                return OperationResult<OwnersGetResponseDto>.Failure("Owners retrieval failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, OwnersGetRequestDto dto)
        {
            var command = new SqlCommand(GetOwnersSql, connection);
            command.AddParameter("@Page", dto.Page);
            command.AddParameter("@Limit", dto.Limit);
            return command;
        }

        private static async Task<OperationResult<OwnersGetResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int page,
            int limit)
        {
            var Owners = new List<OwnerModel>();
            string status = "Error";
            string message = "Owners retrieval completed";
            int currentPage = 0, pageSize = 0, totalRecords = 0, totalPages = 0;
            bool hasNextPage = false, hasPreviousPage = false;

            try
            {
                // Read all Owner records
                while (await reader.ReadAsync())
                {
                    var Owner = OwnerMapper.MapOwnerFromReader(reader);

                    // Get pagination metadata from first row
                    if (Owners.Count == 0)
                    {
                        currentPage = reader.GetValueOrDefault<int>("CurrentPage");
                        pageSize = reader.GetValueOrDefault<int>("PageSize");
                        totalRecords = reader.GetValueOrDefault<int>("TotalRecords");
                        totalPages = reader.GetValueOrDefault<int>("TotalPages");
                        hasNextPage = reader.GetValueOrDefault<int>("HasNextPage") == 1;
                        hasPreviousPage = reader.GetValueOrDefault<int>("HasPreviousPage") == 1;
                        status = reader.GetValueOrDefault<string>("Status") ?? "Error";
                        message = reader.GetValueOrDefault<string>("Message") ?? "Owners retrieval completed";
                    }

                    Owners.Add(Owner);
                }

                if (status != "SUCCESS")
                {
                    logger.LogWarning("Owners retrieval failed for Page {Page}, Limit {Limit}: {Message}",
                        page, limit, message);
                    return OperationResult<OwnersGetResponseDto>.Failure(message);
                }

                var responseDto = new OwnersGetResponseDto
                {
                    Owners = Owners,
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                    TotalRecords = totalRecords,
                    TotalPages = totalPages,
                    HasNextPage = hasNextPage,
                    HasPreviousPage = hasPreviousPage
                };

                logger.LogInformation("Owners retrieved successfully - Page: {Page}, Count: {Count}, Total: {Total}",
                    page, Owners.Count, totalRecords);

                return OperationResult<OwnersGetResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error mapping Owners retrieval result for Page {Page}, Limit {Limit}",
                    page, limit);
                return OperationResult<OwnersGetResponseDto>.Failure("Failed to process Owners retrieval result");
            }
        }
    }
}
