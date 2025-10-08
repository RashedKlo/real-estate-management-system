
using System;
using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;
using System.Data.SqlClient;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Owner.Helpers;
using Microsoft.Extensions.Logging;

namespace RealEstateManagement.Data.Repositories.Owner.Queries
{
    public class GetOwnerQuery
    {
        private const string GetOwnerSql = @"
            EXEC [dbo].[sp_GetOwner] 
                @OwnerId";

        public static async Task<OperationResult<OwnerGetResponseDto>> ExecuteAsync(
            OwnerGetRequestDto dto,
            ILogger logger)
        {
            if (dto == null || dto.OwnerId <= 0)
            {
                logger.LogError("GetOwnerQuery received invalid Owner ID: {OwnerId}", dto?.OwnerId);
                return OperationResult<OwnerGetResponseDto>.Failure("Owner ID is required and must be a positive integer");
            }

            logger.LogInformation("Executing Owner retrieval for OwnerId: {OwnerId}", dto.OwnerId);

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
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number<= 53)
            {
                logger.LogError(ex, "Database connection failed during Owner retrieval for OwnerId {OwnerId}", dto.OwnerId);
                return OperationResult<OwnerGetResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "Database error during Owner retrieval for OwnerId {OwnerId}. Error: {Error}",
                    dto.OwnerId, ex.Message);
                return OperationResult<OwnerGetResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during Owner retrieval for OwnerId {OwnerId}", dto.OwnerId);
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
            int OwnerId)
        {
            if (!await reader.ReadAsync())
            {
                logger.LogWarning("No result returned from Owner retrieval procedure for OwnerId {OwnerId}", OwnerId);
                return OperationResult<OwnerGetResponseDto>.Failure("Owner retrieval procedure returned no result");
            }

            var status = reader.GetValueOrDefault<string>("Status") ?? "Error";
            var message = reader.GetValueOrDefault<string>("Message") ?? "Owner retrieval completed";

            if (status != "SUCCESS")
            {
                var errorNumber = reader.GetValueOrDefault<int>("ErrorNumber");
                logger.LogWarning("Owner retrieval failed for OwnerId {OwnerId}: {Message} (Error: {ErrorNumber})",
                    OwnerId, message, errorNumber);
                return OperationResult<OwnerGetResponseDto>.Failure(message);
            }
            else
            {
                try
                {
                    var responseDto = OwnerMapper.MapGetResponseFromReader(reader);

                    logger.LogInformation("Owner retrieved successfully - OwnerId: {OwnerId}",
                        OwnerId);

                    return OperationResult<OwnerGetResponseDto>.Success(responseDto, message);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Error mapping Owner retrieval result for OwnerId {OwnerId}",
                        OwnerId);
                    return OperationResult<OwnerGetResponseDto>.Failure("Failed to process Owner retrieval result");
                }
            }
        }
    }
}