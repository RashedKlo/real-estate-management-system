using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Owners.Delete;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Owner.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Owner.Commands
{
    public class DeleteOwnerCommand
    {
        private const string DeleteOwnerSql = @"
            EXEC [dbo].[sp_DeleteOwner] @OwnerId";

        public static async Task<OperationResult<OwnerDeleteResponseDto>> ExecuteAsync(
            OwnerDeleteRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("DeleteOwnerCommand received null OwnerDeleteRequestDto");
                return OperationResult<OwnerDeleteResponseDto>.Failure("Owner data is required");
            }

            logger.LogInformation("Starting owner deletion - OwnerId: {OwnerId}", dto.OwnerId);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for deletion - OwnerId: {OwnerId}", dto.OwnerId);

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger, dto.OwnerId);
                            logger.LogInformation("Owner deletion process completed - OwnerId: {OwnerId}", dto.OwnerId);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during owner deletion - OwnerId: {OwnerId}", dto.OwnerId);
                return OperationResult<OwnerDeleteResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during owner deletion - OwnerId: {OwnerId}", dto.OwnerId);
                return OperationResult<OwnerDeleteResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during owner deletion - OwnerId: {OwnerId}", dto.OwnerId);
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
            int ownerId)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Delete procedure returned no rows for OwnerId: {OwnerId}", ownerId);
                    return OperationResult<OwnerDeleteResponseDto>.Failure("No result returned from deletion procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Owner deletion completed";

                var responseDto = OwnerMapper.MapDeleteResponseFromReader(reader);
                logger.LogInformation("Owner deleted successfully - OwnerId: {OwnerId}", ownerId);

                return OperationResult<OwnerDeleteResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing deletion result - OwnerId: {OwnerId}", ownerId);
                return OperationResult<OwnerDeleteResponseDto>.Failure("Failed to process owner deletion result");
            }
        }
    }
}