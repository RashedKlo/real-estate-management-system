using System;
using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Owners.Delete;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;
using System.Data.SqlClient;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Owner.Helpers;
using Microsoft.Extensions.Logging;

namespace RealEstateManagement.Data.Repositories.Owner.Commands
{
    public class DeleteOwnerCommand
    {
        private const string DeleteOwnerSql = @"
            EXEC [dbo].[sp_DeleteOwner] 
                @OwnerId";

        public static async Task<OperationResult<OwnerDeleteResponseDto>> ExecuteAsync(
            OwnerDeleteRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("DeleteOwnerCommand received null Owner data");
                return OperationResult<OwnerDeleteResponseDto>.Failure("Owner data is required");
            }

            logger.LogInformation("Executing Owner deletion for OwnerId: {OwnerId}",
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
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection failed during Owner deletion for OwnerId {OwnerId}",
                    dto.OwnerId);
                return OperationResult<OwnerDeleteResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "Database error during Owner deletion for OwnerId {OwnerId}. Error: {Error}",
                    dto.OwnerId, ex.Message);
                return OperationResult<OwnerDeleteResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during Owner deletion for OwnerId {OwnerId}",
                    dto.OwnerId);
                return OperationResult<OwnerDeleteResponseDto>.Failure("Owner deletion failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, OwnerDeleteRequestDto dto)
        {
            var command = new SqlCommand(DeleteOwnerSql, connection);
            command.AddParameter("@OwnerId", dto.OwnerId);
            return command;
        }

        private static async Task<OperationResult<OwnerDeleteResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int OwnerId)
        {
            if (!await reader.ReadAsync())
            {
                logger.LogWarning("No result returned from Owner deletion procedure for OwnerId {OwnerId}",
                    OwnerId);
                return OperationResult<OwnerDeleteResponseDto>.Failure("Owner deletion procedure returned no result");
            }

            var status = reader.GetValueOrDefault<string>("Status") ?? "Error";
            var message = reader.GetValueOrDefault<string>("Message") ?? "Owner deletion completed";

            if (status != "SUCCESS")
            {
                var errorNumber = reader.GetValueOrDefault<int>("ErrorNumber");
                logger.LogWarning("Owner deletion failed for OwnerId {OwnerId}: {Message} (Error: {ErrorNumber})",
                    OwnerId, message, errorNumber);
                return OperationResult<OwnerDeleteResponseDto>.Failure(message);
            }
            else
            {
                try
                {
                    var responseDto = OwnerMapper.MapDeleteResponseFromReader(reader);

                    logger.LogInformation("Owner deleted successfully - OwnerId: {OwnerId}",
                        OwnerId);

                    return OperationResult<OwnerDeleteResponseDto>.Success(responseDto, message);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Error mapping Owner deletion result for OwnerId {OwnerId}",
                        OwnerId);
                    return OperationResult<OwnerDeleteResponseDto>.Failure("Failed to process Owner deletion result");
                }
            }
        }
    }
}
   