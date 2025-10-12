using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Owner.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Owner.Queries
{
    public class GetOwnerQuery
    {
        private const string GetOwnerSql = @"
            EXEC [dbo].[sp_GetOwner] @OwnerId";

        public static async Task<OperationResult<OwnerGetResponseDto>> ExecuteAsync(
            OwnerGetRequestDto dto,
            ILogger logger)
        {
            if (dto == null || dto.OwnerId <= 0)
            {
                logger.LogError("GetOwnerQuery received invalid OwnerId: {OwnerId}", dto?.OwnerId);
                return OperationResult<OwnerGetResponseDto>.Failure("Owner ID is required and must be positive");
            }

            logger.LogInformation("Starting owner retrieval - OwnerId: {OwnerId}", dto.OwnerId);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for retrieval - OwnerId: {OwnerId}", dto.OwnerId);

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger, dto.OwnerId);
                            logger.LogInformation("Owner retrieval process completed - OwnerId: {OwnerId}", dto.OwnerId);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during owner retrieval - OwnerId: {OwnerId}", dto.OwnerId);
                return OperationResult<OwnerGetResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during owner retrieval - OwnerId: {OwnerId}", dto.OwnerId);
                return OperationResult<OwnerGetResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during owner retrieval - OwnerId: {OwnerId}", dto.OwnerId);
                return OperationResult<OwnerGetResponseDto>.Failure("Owner retrieval failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, OwnerGetRequestDto dto)
        {
            var command = new SqlCommand(GetOwnerSql, connection);
            command.AddParameter("@OwnerId", dto.OwnerId);
            return command;
        }

        private static async Task<OperationResult<OwnerGetResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int ownerId)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Get procedure returned no rows for OwnerId: {OwnerId}", ownerId);
                    return OperationResult<OwnerGetResponseDto>.Failure("No result returned from retrieval procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Owner retrieval completed";

                var responseDto = OwnerMapper.MapGetResponseFromReader(reader);
                logger.LogInformation("Owner retrieved successfully - OwnerId: {OwnerId}", ownerId);

                return OperationResult<OwnerGetResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing retrieval result - OwnerId: {OwnerId}", ownerId);
                return OperationResult<OwnerGetResponseDto>.Failure("Failed to process owner retrieval result");
            }
        }
    }
}