using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Properties.Queries;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Models;
using RealEstateManagement.Data.Repositories.Properties.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Properties.Queries
{
    public class GetPropertiesQuery
    {
        private const string GetPropertiesSql = @"
            EXEC [dbo].[sp_GetProperties] 
                @Page, @Limit, @Location, @NumOfRooms, @Status, 
                @Availability, @PriceFrom, @PriceTo, @AreaFrom, @AreaTo";

        public static async Task<OperationResult<PropertiesGetResponseDto>> ExecuteAsync(
            PropertiesGetRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("GetPropertiesQuery received null PropertiesGetRequestDto");
                return OperationResult<PropertiesGetResponseDto>.Failure("Request data is required");
            }

            logger.LogInformation("Starting properties retrieval - Page: {Page}, Limit: {Limit}", dto.Page, dto.Limit);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for properties retrieval");

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger);
                            logger.LogInformation("Properties retrieval process completed");
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during properties retrieval");
                return OperationResult<PropertiesGetResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during properties retrieval");
                return OperationResult<PropertiesGetResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during properties retrieval");
                return OperationResult<PropertiesGetResponseDto>.Failure("Properties retrieval failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, PropertiesGetRequestDto dto)
        {
            var command = new SqlCommand(GetPropertiesSql, connection);
            command.AddParameter("@Page", dto.Page);
            command.AddParameter("@Limit", dto.Limit);
            command.AddParameter("@Location", dto.Location);
            command.AddParameter("@NumOfRooms", dto.NumOfRooms);
            command.AddParameter("@Status", dto.Status);
            command.AddParameter("@Availability", dto.Availability);
            command.AddParameter("@PriceFrom", dto.PriceFrom);
            command.AddParameter("@PriceTo", dto.PriceTo);
            command.AddParameter("@AreaFrom", dto.AreaFrom);
            command.AddParameter("@AreaTo", dto.AreaTo);
            return command;
        }

        private static async Task<OperationResult<PropertiesGetResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger)
        {
            try
            {
                var properties = new List<PropertyModel>();
                int currentPage = 0;
                int pageSize = 0;
                int totalRecords = 0;
                int totalPages = 0;
                bool hasNextPage = false;
                bool hasPreviousPage = false;
                string status = "ERROR";
                string message = "Properties retrieval completed";

                while (await reader.ReadAsync())
                {
                    // Read pagination info from first row
                    if (properties.Count == 0)
                    {
                        currentPage = reader.GetValueOrDefault<int>("CurrentPage");
                        pageSize = reader.GetValueOrDefault<int>("PageSize");
                        totalRecords = reader.GetValueOrDefault<int>("TotalRecords");
                        totalPages = reader.GetValueOrDefault<int>("TotalPages");
                        hasNextPage = reader.GetValueOrDefault<int>("HasNextPage") == 1;
                        hasPreviousPage = reader.GetValueOrDefault<int>("HasPreviousPage") == 1;
                        status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                        message = reader.GetValueOrDefault<string>("Message") ?? "Properties retrieval completed";
                    }

                    // Map property data
                    var property = PropertyMapper.MapPropertyFromReader(reader);
                    properties.Add(property);
                }

                if (status == "ERROR")
                {
                    logger.LogWarning("Properties retrieval failed - Message: {Message}", message);
                    return OperationResult<PropertiesGetResponseDto>.Failure(message);
                }

                var responseDto = new PropertiesGetResponseDto
                {
                    Properties = properties,
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                    TotalRecords = totalRecords,
                    TotalPages = totalPages,
                    HasNextPage = hasNextPage,
                    HasPreviousPage = hasPreviousPage
                };

                logger.LogInformation("Properties retrieved successfully - Count: {Count}, TotalRecords: {TotalRecords}",
                    properties.Count, totalRecords);

                return OperationResult<PropertiesGetResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing properties retrieval result");
                return OperationResult<PropertiesGetResponseDto>.Failure("Failed to process properties retrieval result");
            }
        }
    }
}