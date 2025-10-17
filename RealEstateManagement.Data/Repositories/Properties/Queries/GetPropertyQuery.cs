using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Properties.Queries;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Properties.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Properties.Queries
{
    public class GetPropertyQuery
    {
        private const string GetPropertySql = @"
            EXEC [dbo].[sp_GetProperty] @PropertyId";

        public static async Task<OperationResult<PropertyGetResponseDto>> ExecuteAsync(
            PropertyGetRequestDto dto,
            ILogger logger)
        {
            if (dto == null || dto.PropertyId <= 0)
            {
                logger.LogError("GetPropertyQuery received invalid PropertyId: {PropertyId}", dto?.PropertyId);
                return OperationResult<PropertyGetResponseDto>.Failure("Property ID is required and must be positive");
            }

            logger.LogInformation("Starting property retrieval - PropertyId: {PropertyId}", dto.PropertyId);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for property retrieval - PropertyId: {PropertyId}", dto.PropertyId);

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger, dto.PropertyId);
                            logger.LogInformation("Property retrieval process completed - PropertyId: {PropertyId}", dto.PropertyId);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during property retrieval - PropertyId: {PropertyId}", dto.PropertyId);
                return OperationResult<PropertyGetResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during property retrieval - PropertyId: {PropertyId}", dto.PropertyId);
                return OperationResult<PropertyGetResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during property retrieval - PropertyId: {PropertyId}", dto.PropertyId);
                return OperationResult<PropertyGetResponseDto>.Failure("Property retrieval failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, PropertyGetRequestDto dto)
        {
            var command = new SqlCommand(GetPropertySql, connection);
            command.AddParameter("@PropertyId", dto.PropertyId);
            return command;
        }

        private static async Task<OperationResult<PropertyGetResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int propertyId)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Get procedure returned no rows for PropertyId: {PropertyId}", propertyId);
                    return OperationResult<PropertyGetResponseDto>.Failure("No result returned from retrieval procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Property retrieval completed";

                if (status == "ERROR")
                {
                    logger.LogWarning("Property retrieval failed - PropertyId: {PropertyId}, Message: {Message}", propertyId, message);
                    return OperationResult<PropertyGetResponseDto>.Failure(message);
                }

                var responseDto = PropertyMapper.MapGetResponseFromReader(reader);
                logger.LogInformation("Property retrieved successfully - PropertyId: {PropertyId}", propertyId);

                return OperationResult<PropertyGetResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing retrieval result - PropertyId: {PropertyId}", propertyId);
                return OperationResult<PropertyGetResponseDto>.Failure("Failed to process property retrieval result");
            }
        }
    }
}