using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Owners.Update;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Owner.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Owner.Commands
{
    public class UpdateOwnerCommand
    {
        private const string UpdateOwnerSql = @"
            EXEC [dbo].[sp_UpdateOwner] 
                @OwnerId, @FullName, @PhoneNumber, @Address";

        public static async Task<OperationResult<OwnerUpdateResponseDto>> ExecuteAsync(
            OwnerUpdateRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("UpdateOwnerCommand received null OwnerUpdateRequestDto");
                return OperationResult<OwnerUpdateResponseDto>.Failure("Owner data is required");
            }

            logger.LogInformation("Starting owner update - OwnerId: {OwnerId}", dto.OwnerId);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for update - OwnerId: {OwnerId}", dto.OwnerId);

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger, dto.OwnerId);
                            logger.LogInformation("Owner update process completed - OwnerId: {OwnerId}", dto.OwnerId);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during owner update - OwnerId: {OwnerId}", dto.OwnerId);
                return OperationResult<OwnerUpdateResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during owner update - OwnerId: {OwnerId}", dto.OwnerId);
                return OperationResult<OwnerUpdateResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during owner update - OwnerId: {OwnerId}", dto.OwnerId);
                return OperationResult<OwnerUpdateResponseDto>.Failure("Owner update failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, OwnerUpdateRequestDto dto)
        {
            var command = new SqlCommand(UpdateOwnerSql, connection);
            command.AddParameter("@OwnerId", dto.OwnerId);
            command.AddParameter("@FullName", dto.FullName);
            command.AddParameter("@PhoneNumber", dto.PhoneNumber);
            command.AddParameter("@Address", dto.Address);
            return command;
        }

        private static async Task<OperationResult<OwnerUpdateResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int ownerId)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Update procedure returned no rows for OwnerId: {OwnerId}", ownerId);
                    return OperationResult<OwnerUpdateResponseDto>.Failure("No result returned from update procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Owner update completed";

                var responseDto = OwnerMapper.MapUpdateResponseFromReader(reader);
                logger.LogInformation("Owner updated successfully - OwnerId: {OwnerId}", ownerId);

                return OperationResult<OwnerUpdateResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing update result - OwnerId: {OwnerId}", ownerId);
                return OperationResult<OwnerUpdateResponseDto>.Failure("Failed to process owner update result");
            }
        }
    }
}