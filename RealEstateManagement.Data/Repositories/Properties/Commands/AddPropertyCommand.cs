using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Properties.Create;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Properties.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Properties.Commands
{
    public class AddPropertyCommand
    {
        private const string AddPropertySql = @"
            EXEC [dbo].[sp_AddProperty] 
                @Location, @NumOfRooms, @Status, @Availability, @Price, 
                @Description, @Area, @OwnerId, @OwnerFullName, @OwnerPhoneNumber, @OwnerAddress";

        public static async Task<OperationResult<PropertyCreateResponseDto>> ExecuteAsync(
            PropertyCreateRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("AddPropertyCommand received null PropertyCreateRequestDto");
                return OperationResult<PropertyCreateResponseDto>.Failure("Property data is required");
            }

            logger.LogInformation("Starting property creation - Location: {Location}", dto.Location);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for property creation - Location: {Location}", dto.Location);

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger, dto.Location);
                            logger.LogInformation("Property creation process completed - Location: {Location}", dto.Location);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during property creation - Location: {Location}", dto.Location);
                return OperationResult<PropertyCreateResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during property creation - Location: {Location}", dto.Location);
                return OperationResult<PropertyCreateResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during property creation - Location: {Location}", dto.Location);
                return OperationResult<PropertyCreateResponseDto>.Failure("Property creation failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, PropertyCreateRequestDto dto)
        {
            var command = new SqlCommand(AddPropertySql, connection);
            command.AddParameter("@Location", dto.Location);
            command.AddParameter("@NumOfRooms", dto.NumOfRooms);
            command.AddParameter("@Status", dto.Status);
            command.AddParameter("@Availability", dto.Availability);
            command.AddParameter("@Price", dto.Price);
            command.AddParameter("@Description", dto.Description);
            command.AddParameter("@Area", dto.Area);
            command.AddParameter("@OwnerId", dto.OwnerId);
            command.AddParameter("@OwnerFullName", dto.OwnerFullName);
            command.AddParameter("@OwnerPhoneNumber", dto.OwnerPhoneNumber);
            command.AddParameter("@OwnerAddress", dto.OwnerAddress);
            return command;
        }

        private static async Task<OperationResult<PropertyCreateResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            string location)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Create procedure returned no rows for Location: {Location}", location);
                    return OperationResult<PropertyCreateResponseDto>.Failure("No result returned from creation procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Property creation completed";

                if (status == "ERROR")
                {
                    logger.LogWarning("Property creation failed - Location: {Location}, Message: {Message}", location, message);
                    return OperationResult<PropertyCreateResponseDto>.Failure(message);
                }

                var responseDto = PropertyMapper.MapCreateResponseFromReader(reader);
                logger.LogInformation("Property created successfully - PropertyId: {PropertyId}", responseDto.PropertyId);

                return OperationResult<PropertyCreateResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing creation result - Location: {Location}", location);
                return OperationResult<PropertyCreateResponseDto>.Failure("Failed to process property creation result");
            }
        }
    }
}
