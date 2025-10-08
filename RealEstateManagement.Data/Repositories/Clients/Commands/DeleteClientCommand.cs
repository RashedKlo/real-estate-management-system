using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Clients.Delete;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Client.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Client.Commands
{
    public class DeleteClientCommand
    {
        private const string DeleteClientSql = @"
            EXEC [dbo].[sp_DeleteClient] @ClientId";

        public static async Task<OperationResult<ClientDeleteResponseDto>> ExecuteAsync(
            ClientDeleteRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("DeleteClientCommand received null ClientDeleteRequestDto");
                return OperationResult<ClientDeleteResponseDto>.Failure("Client data is required");
            }

            logger.LogInformation("Starting client deletion - ClientId: {ClientId}", dto.ClientId);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for deletion - ClientId: {ClientId}", dto.ClientId);

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger, dto.ClientId);
                            logger.LogInformation("Client deletion process completed - ClientId: {ClientId}", dto.ClientId);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during client deletion - ClientId: {ClientId}", dto.ClientId);
                return OperationResult<ClientDeleteResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during client deletion - ClientId: {ClientId}", dto.ClientId);
                return OperationResult<ClientDeleteResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during client deletion - ClientId: {ClientId}", dto.ClientId);
                return OperationResult<ClientDeleteResponseDto>.Failure("Client deletion failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, ClientDeleteRequestDto dto)
        {
            var command = new SqlCommand(DeleteClientSql, connection);
            command.AddParameter("@ClientId", dto.ClientId);
            return command;
        }

        private static async Task<OperationResult<ClientDeleteResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int clientId)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Delete procedure returned no rows for ClientId: {ClientId}", clientId);
                    return OperationResult<ClientDeleteResponseDto>.Failure("No result returned from deletion procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Client deletion completed";

                var responseDto = ClientMapper.MapDeleteResponseFromReader(reader);
                logger.LogInformation("Client deleted successfully - ClientId: {ClientId}", clientId);

                return OperationResult<ClientDeleteResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing deletion result - ClientId: {ClientId}", clientId);
                return OperationResult<ClientDeleteResponseDto>.Failure("Failed to process client deletion result");
            }
        }
    }
}
