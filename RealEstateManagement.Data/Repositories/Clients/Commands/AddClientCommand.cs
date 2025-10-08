using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Clients.Create;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Client.Helpers;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;

namespace RealEstateManagement.Data.Repositories.Client.Commands
{
    public class AddClientCommand
    {
        private const string AddClientSql = @"
            EXEC [dbo].[sp_AddClient] 
                @FullName, @PhoneNumber, @Address";

        public static async Task<OperationResult<ClientCreateResponseDto>> ExecuteAsync(
            ClientCreateRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("AddClientCommand received null ClientCreateRequestDto");
                return OperationResult<ClientCreateResponseDto>.Failure("Client data is required");
            }

            logger.LogInformation("Starting client creation - FullName: {FullName}", dto.FullName);

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
                            logger.LogInformation("Client creation process completed - FullName: {FullName}", dto.FullName);
                            return result;
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection error during client creation - FullName: {FullName}", dto.FullName);
                return OperationResult<ClientCreateResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "SQL error during client creation - FullName: {FullName}", dto.FullName);
                return OperationResult<ClientCreateResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error during client creation - FullName: {FullName}", dto.FullName);
                return OperationResult<ClientCreateResponseDto>.Failure("Client creation failed due to system error");
            }
        }

        private static SqlCommand CreateCommand(SqlConnection connection, ClientCreateRequestDto dto)
        {
            var command = new SqlCommand(AddClientSql, connection);
            command.AddParameter("@FullName", dto.FullName);
            command.AddParameter("@PhoneNumber", dto.PhoneNumber);
            command.AddParameter("@Address", dto.Address);
            return command;
        }

        private static async Task<OperationResult<ClientCreateResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            string fullName)
        {
            try
            {
                if (!await reader.ReadAsync())
                {
                    logger.LogWarning("Create procedure returned no rows for FullName: {FullName}", fullName);
                    return OperationResult<ClientCreateResponseDto>.Failure("No result returned from creation procedure");
                }

                string status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                string message = reader.GetValueOrDefault<string>("Message") ?? "Client creation completed";

                var responseDto = ClientMapper.MapCreateResponseFromReader(reader);
                logger.LogInformation("Client created successfully - ClientId: {ClientId}", responseDto.ClientId);

                return OperationResult<ClientCreateResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing creation result - FullName: {FullName}", fullName);
                return OperationResult<ClientCreateResponseDto>.Failure("Failed to process client creation result");
            }
        }
    }
}