using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Owners.Create;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Owner.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Owner.Commands
{
    public class AddOwnerCommand
    {
        private const string AddOwnerSql = @"
            EXEC [dbo].[sp_AddOwner] 
                @FullName, @PhoneNumber, @Address";

        public static async Task<OperationResult<OwnerCreateResponseDto>> ExecuteAsync(
            OwnerCreateRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("AddOwnerCommand received null OwnerCreateRequestDto");
                return OperationResult<OwnerCreateResponseDto>.Failure("Owner data is required");
            }

            logger.LogInformation("Starting owner creation - FullName: {FullName}", dto.FullName);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for creation - FullName: {FullName}", dto.FullName);

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger, dto.FullName);
                            logger.LogInformation("Owner creation process completed - FullName: {FullName}", dto.FullName);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during owner creation - FullName: {FullName}", dto.FullName);
                return OperationResult<OwnerCreateResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during owner creation - FullName: {FullName}", dto.FullName);
                return OperationResult<OwnerCreateResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during owner creation - FullName: {FullName}", dto.FullName);
                return OperationResult<OwnerCreateResponseDto>.Failure("Owner creation failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, OwnerCreateRequestDto dto)
        {
            var command = new SqlCommand(AddOwnerSql, connection);
            command.AddParameter("@FullName", dto.FullName);
            command.AddParameter("@PhoneNumber", dto.PhoneNumber);
            command.AddParameter("@Address", dto.Address);
            return command;
        }

        private static async Task<OperationResult<OwnerCreateResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            string fullName)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Create procedure returned no rows for FullName: {FullName}", fullName);
                    return OperationResult<OwnerCreateResponseDto>.Failure("No result returned from creation procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Owner creation completed";

                var responseDto = OwnerMapper.MapCreateResponseFromReader(reader);
                logger.LogInformation("Owner created successfully - OwnerId: {OwnerId}", responseDto.OwnerId);

                return OperationResult<OwnerCreateResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing creation result - FullName: {FullName}", fullName);
                return OperationResult<OwnerCreateResponseDto>.Failure("Failed to process owner creation result");
            }
        }
    }
}