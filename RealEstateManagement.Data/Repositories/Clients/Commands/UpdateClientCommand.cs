using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Clients.Update;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Client.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Client.Commands
{
    public class UpdateClientCommand
    {
        private const string UpdateClientSql = @"
            EXEC [dbo].[sp_UpdateClient] 
                @ClientId, @FullName, @PhoneNumber, @Address";

        public static async Task<OperationResult<ClientUpdateResponseDto>> ExecuteAsync(
            ClientUpdateRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("UpdateClientCommand received null ClientUpdateRequestDto");
                return OperationResult<ClientUpdateResponseDto>.Failure("Client data is required");
            }

            logger.LogInformation("Starting client update - ClientId: {ClientId}", dto.ClientId);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for update - ClientId: {ClientId}", dto.ClientId);

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger, dto.ClientId);
                            logger.LogInformation("Client update process completed - ClientId: {ClientId}", dto.ClientId);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during client update - ClientId: {ClientId}", dto.ClientId);
                return OperationResult<ClientUpdateResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during client update - ClientId: {ClientId}", dto.ClientId);
                return OperationResult<ClientUpdateResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during client update - ClientId: {ClientId}", dto.ClientId);
                return OperationResult<ClientUpdateResponseDto>.Failure("Client update failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, ClientUpdateRequestDto dto)
        {
            var command = new SqlCommand(UpdateClientSql, connection);
            command.AddParameter("@ClientId", dto.ClientId);
            command.AddParameter("@FullName", dto.FullName);
            command.AddParameter("@PhoneNumber", dto.PhoneNumber);
            command.AddParameter("@Address", dto.Address);
            return command;
        }

        private static async Task<OperationResult<ClientUpdateResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int clientId)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Update procedure returned no rows for ClientId: {ClientId}", clientId);
                    return OperationResult<ClientUpdateResponseDto>.Failure("No result returned from update procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Client update completed";

                var responseDto = ClientMapper.MapUpdateResponseFromReader(reader);
                logger.LogInformation("Client updated successfully - ClientId: {ClientId}", clientId);

                return OperationResult<ClientUpdateResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing update result - ClientId: {ClientId}", clientId);
                return OperationResult<ClientUpdateResponseDto>.Failure("Failed to process client update result");
            }
        }
    }
}