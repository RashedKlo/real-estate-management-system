using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Properties.Delete;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Properties.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Properties.Commands
{
    public class DeletePropertyCommand
    {
        private const string DeletePropertySql = @"
            EXEC [dbo].[sp_DeleteProperty] @PropertyId";

        public static async Task<OperationResult<PropertyDeleteResponseDto>> ExecuteAsync(
            PropertyDeleteRequestDto dto,
            ILogger logger)
        {
            if (dto == null || dto.PropertyId <= 0)
            {
                logger.LogError("DeletePropertyCommand received invalid PropertyId: {PropertyId}", dto?.PropertyId);
                return OperationResult<PropertyDeleteResponseDto>.Failure("Property ID is required and must be positive");
            }

            logger.LogInformation("Starting property deletion - PropertyId: {PropertyId}", dto.PropertyId);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for property deletion - PropertyId: {PropertyId}", dto.PropertyId);

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger, dto.PropertyId);
                            logger.LogInformation("Property deletion process completed - PropertyId: {PropertyId}", dto.PropertyId);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during property deletion - PropertyId: {PropertyId}", dto.PropertyId);
                return OperationResult<PropertyDeleteResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during property deletion - PropertyId: {PropertyId}", dto.PropertyId);
                return OperationResult<PropertyDeleteResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during property deletion - PropertyId: {PropertyId}", dto.PropertyId);
                return OperationResult<PropertyDeleteResponseDto>.Failure("Property deletion failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, PropertyDeleteRequestDto dto)
        {
            var command = new SqlCommand(DeletePropertySql, connection);
            command.AddParameter("@PropertyId", dto.PropertyId);
            return command;
        }

        private static async Task<OperationResult<PropertyDeleteResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int propertyId)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Delete procedure returned no rows for PropertyId: {PropertyId}", propertyId);
                    return OperationResult<PropertyDeleteResponseDto>.Failure("No result returned from deletion procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Property deletion completed";

                if (status == "ERROR")
                {
                    logger.LogWarning("Property deletion failed - PropertyId: {PropertyId}, Message: {Message}", propertyId, message);
                    return OperationResult<PropertyDeleteResponseDto>.Failure(message);
                }

                var responseDto = PropertyMapper.MapDeleteResponseFromReader(reader);
                logger.LogInformation("Property deleted successfully - PropertyId: {PropertyId}", propertyId);

                return OperationResult<PropertyDeleteResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing deletion result - PropertyId: {PropertyId}", propertyId);
                return OperationResult<PropertyDeleteResponseDto>.Failure("Failed to process property deletion result");
            }
        }
    }
}
