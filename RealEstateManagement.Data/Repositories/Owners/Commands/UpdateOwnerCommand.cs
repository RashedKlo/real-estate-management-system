using System;
using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Owners.Update;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;
using System.Data.SqlClient;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Owner.Helpers;
using Microsoft.Extensions.Logging;

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
                logger.LogError("UpdateOwnerCommand received null Owner data");
                return OperationResult<OwnerUpdateResponseDto>.Failure("Owner data is required");
            }

            logger.LogInformation("Executing Owner update for OwnerId: {OwnerId}",
                dto.OwnerId);

            try
            {
                 var connection = new SqlConnection(DBSettings.connectionString);
                await connection.OpenAsync();

                 var command = CreateCommand(connection, dto);
                 var reader = await command.ExecuteReaderAsync();
                reader.Close();
                connection.Close();
                return await ProcessResultAsync(reader, logger, dto.OwnerId);
            }
            catch (SqlException ex) when (ex.Number>= 2 && ex.Number<= 53)
            {
                logger.LogError(ex, "Database connection failed during Owner update for OwnerId {OwnerId}",
                    dto.OwnerId);
                return OperationResult<OwnerUpdateResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "Database error during Owner update for OwnerId {OwnerId}. Error: {Error}",
                    dto.OwnerId, ex.Message);
                return OperationResult<OwnerUpdateResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during Owner update for OwnerId {OwnerId}",
                    dto.OwnerId);
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
            int OwnerId)
        {
            if (!await reader.ReadAsync())
            {
                logger.LogWarning("No result returned from Owner update procedure for OwnerId {OwnerId}",
                    OwnerId);
                return OperationResult<OwnerUpdateResponseDto>.Failure("Owner update procedure returned no result");
            }

            var status = reader.GetValueOrDefault<string>("Status") ?? "Error";
            var message = reader.GetValueOrDefault<string>("Message") ?? "Owner update completed";

            if (status != "SUCCESS")
            {
                var errorNumber = reader.GetValueOrDefault<int>("ErrorNumber");
                logger.LogWarning("Owner update failed for OwnerId {OwnerId}: {Message} (Error: {ErrorNumber})",
                    OwnerId, message, errorNumber);
                return OperationResult<OwnerUpdateResponseDto>.Failure(message);
            }
            else
            {
                try
                {
                    var responseDto = OwnerMapper.MapUpdateResponseFromReader(reader);

                    logger.LogInformation("Owner updated successfully - OwnerId: {OwnerId}",
                        OwnerId);

                    return OperationResult<OwnerUpdateResponseDto>.Success(responseDto, message);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Error mapping Owner update result for OwnerId {OwnerId}",
                        OwnerId);
                    return OperationResult<OwnerUpdateResponseDto>.Failure("Failed to process Owner update result");
                }
            }
        }
    }
}