using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Clients.Queries;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Client.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Client.Queries
{
    public class GetClientQuery
    {
        private const string GetClientSql = @"
            EXEC [dbo].[sp_GetClient] @ClientId";

        public static async Task<OperationResult<ClientGetResponseDto>> ExecuteAsync(
            ClientGetRequestDto dto,
            ILogger logger)
        {
            if (dto == null || dto.ClientId <= 0)
            {
                logger.LogError("GetClientQuery received invalid ClientId: {ClientId}", dto?.ClientId);
                return OperationResult<ClientGetResponseDto>.Failure("Client ID is required and must be positive");
            }

            logger.LogInformation("Starting client retrieval - ClientId: {ClientId}", dto.ClientId);

            try
            {
                using (var connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();
                    logger.LogInformation("Database connection opened for retrieval - ClientId: {ClientId}", dto.ClientId);

                    using (var command = CreateCommand(connection, dto))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            var result = await ProcessResultAsync(reader, logger, dto.ClientId);
                            logger.LogInformation("Client retrieval process completed - ClientId: {ClientId}", dto.ClientId);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during client retrieval - ClientId: {ClientId}", dto.ClientId);
                return OperationResult<ClientGetResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during client retrieval - ClientId: {ClientId}", dto.ClientId);
                return OperationResult<ClientGetResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during client retrieval - ClientId: {ClientId}", dto.ClientId);
                return OperationResult<ClientGetResponseDto>.Failure("Client retrieval failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, ClientGetRequestDto dto)
        {
            var command = new SqlCommand(GetClientSql, connection);
            command.AddParameter("@ClientId", dto.ClientId);
            return command;
        }

        private static async Task<OperationResult<ClientGetResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int clientId)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Get procedure returned no rows for ClientId: {ClientId}", clientId);
                    return OperationResult<ClientGetResponseDto>.Failure("No result returned from retrieval procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Client retrieval completed";

                var responseDto = ClientMapper.MapGetResponseFromReader(reader);
                logger.LogInformation("Client retrieved successfully - ClientId: {ClientId}", clientId);

                return OperationResult<ClientGetResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing retrieval result - ClientId: {ClientId}", clientId);
                return OperationResult<ClientGetResponseDto>.Failure("Failed to process client retrieval result");
            }
        }
    }
}