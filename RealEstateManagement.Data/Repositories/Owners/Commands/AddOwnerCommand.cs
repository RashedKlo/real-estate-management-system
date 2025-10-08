using System;
using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Owners.Create;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;
using System.Data.SqlClient;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Owner.Helpers;
using Microsoft.Extensions.Logging;

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
                logger.LogError("AddOwnerCommand received null Owner data");
                return OperationResult<OwnerCreateResponseDto>.Failure("Owner data is required");
            }

            logger.LogInformation("Executing Owner creation for FullName: {FullName}, PhoneNumber: {PhoneNumber}",
                dto.FullName, dto.PhoneNumber);

            try
            {
                var connection = new SqlConnection(DBSettings.connectionString);

                await connection.OpenAsync();

                var command = CreateCommand(connection, dto);
                var reader = await command.ExecuteReaderAsync();

                reader.Close();
                connection.Close();
                return await ProcessResultAsync(reader, logger, dto.FullName, dto.PhoneNumber);
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection failed during Owner creation for FullName {FullName}, PhoneNumber {PhoneNumber}",
                    dto.FullName, dto.PhoneNumber);
                return OperationResult<OwnerCreateResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "Database error during Owner creation for FullName {FullName}, PhoneNumber {PhoneNumber}. Error: {Error}",
                    dto.FullName, dto.PhoneNumber, ex.Message);
                return OperationResult<OwnerCreateResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during Owner creation for FullName {FullName}, PhoneNumber {PhoneNumber}",
                    dto.FullName, dto.PhoneNumber);
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
            string fullName,
            string phoneNumber)
        {
            if (!await reader.ReadAsync())
            {
                logger.LogWarning("No result returned from Owner creation procedure for FullName {FullName}, PhoneNumber {PhoneNumber}",
                    fullName, phoneNumber);
                return OperationResult<OwnerCreateResponseDto>.Failure("Owner creation procedure returned no result");
            }

            var status = reader.GetValueOrDefault<string>("Status") ?? "Error";
            var message = reader.GetValueOrDefault<string>("Message") ?? "Owner creation completed";

            if (status != "SUCCESS")
            {
                var errorNumber = reader.GetValueOrDefault<int>("ErrorNumber");
                logger.LogWarning("Owner creation failed for FullName {FullName}, PhoneNumber {PhoneNumber}: {Message} (Error: {ErrorNumber})",
                    fullName, phoneNumber, message, errorNumber);
                return OperationResult<OwnerCreateResponseDto>.Failure(message);
            }
            else
            {
                try
                {
                    var responseDto = OwnerMapper.MapCreateResponseFromReader(reader);

                    logger.LogInformation("Owner created successfully - OwnerId: {OwnerId}, FullName: {FullName}, PhoneNumber: {PhoneNumber}",
                        responseDto.OwnerId, fullName, phoneNumber);

                    return OperationResult<OwnerCreateResponseDto>.Success(responseDto, message);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Error mapping Owner creation result for FullName {FullName}, PhoneNumber {PhoneNumber}",
                        fullName, phoneNumber);
                    return OperationResult<OwnerCreateResponseDto>.Failure("Failed to process Owner creation result");
                }
            } }
        }
    }