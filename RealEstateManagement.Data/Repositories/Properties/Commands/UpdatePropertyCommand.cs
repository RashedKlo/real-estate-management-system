using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Properties.Update;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Properties.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Properties.Commands
{
    public class UpdatePropertyCommand
    {
        private const string UpdatePropertySql = @"
            EXEC [dbo].[sp_UpdateProperty] 
                @PropertyId, @Location, @NumOfRooms, @Status, @Availability, 
                @Price, @Description, @Area";

        public static async Task<OperationResult<PropertyUpdateResponseDto>> ExecuteAsync(
            PropertyUpdateRequestDto dto,
            ILogger logger)
        {
            if (dto == null || dto.PropertyId <= 0)
            {
                logger.LogError("UpdatePropertyCommand received invalid PropertyId: {PropertyId}", dto?.PropertyId);
                return OperationResult<PropertyUpdateResponseDto>.Failure("Property ID is required and must be positive");
            }

            logger.LogInformation("Starting property update - PropertyId: {PropertyId}", dto.PropertyId);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for property update - PropertyId: {PropertyId}", dto.PropertyId);

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger, dto.PropertyId);
                            logger.LogInformation("Property update process completed - PropertyId: {PropertyId}", dto.PropertyId);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during property update - PropertyId: {PropertyId}", dto.PropertyId);
                return OperationResult<PropertyUpdateResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during property update - PropertyId: {PropertyId}", dto.PropertyId);
                return OperationResult<PropertyUpdateResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during property update - PropertyId: {PropertyId}", dto.PropertyId);
                return OperationResult<PropertyUpdateResponseDto>.Failure("Property update failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, PropertyUpdateRequestDto dto)
        {
            var command = new SqlCommand(UpdatePropertySql, connection);
            command.AddParameter("@PropertyId", dto.PropertyId);
            command.AddParameter("@Location", dto.Location);
            command.AddParameter("@NumOfRooms", dto.NumOfRooms);
            command.AddParameter("@Status", dto.Status);
            command.AddParameter("@Availability", dto.Availability);
            command.AddParameter("@Price", dto.Price);
            command.AddParameter("@Description", dto.Description);
            command.AddParameter("@Area", dto.Area);
            return command;
        }

        private static async Task<OperationResult<PropertyUpdateResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int propertyId)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Update procedure returned no rows for PropertyId: {PropertyId}", propertyId);
                    return OperationResult<PropertyUpdateResponseDto>.Failure("No result returned from update procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Property update completed";

                if (status == "ERROR")
                {
                    logger.LogWarning("Property update failed - PropertyId: {PropertyId}, Message: {Message}", propertyId, message);
                    return OperationResult<PropertyUpdateResponseDto>.Failure(message);
                }

                var responseDto = PropertyMapper.MapUpdateResponseFromReader(reader);
                logger.LogInformation("Property updated successfully - PropertyId: {PropertyId}", propertyId);

                return OperationResult<PropertyUpdateResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing update result - PropertyId: {PropertyId}", propertyId);
                return OperationResult<PropertyUpdateResponseDto>.Failure("Failed to process property update result");
            }
        }
    }
}