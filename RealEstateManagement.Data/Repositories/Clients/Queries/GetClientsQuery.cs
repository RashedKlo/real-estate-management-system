using System;
using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Clients.Queries;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Settings;
using RealEstateManagement.Data.Models;
using System.Data.SqlClient;
using RealEstateManagement.Data.Helpers;
using RealEstateManagement.Data.Repositories.Client.Helpers;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace RealEstateManagement.Data.Repositories.Client.Queries
{
    public class GetClientsQuery
    {
        private const string GetClientsSql = @"
            EXEC [dbo].[sp_GetClients] 
                @Page, 
                @Limit";

        public static async Task<OperationResult<ClientsGetResponseDto>> ExecuteAsync(
            ClientsGetRequestDto dto,
            ILogger logger)
        {
            if (dto == null)
            {
                logger.LogError("Request data is null");
                return OperationResult<ClientsGetResponseDto>.Failure("Request data is required");
            }

            logger.LogInformation("Retrieving clients - Page: {Page}, Limit: {Limit}", dto.Page, dto.Limit);

            try
            {
                using (SqlConnection connection = new SqlConnection(DBSettings.connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = CreateCommand(connection, dto))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader == null)
                            {
                                logger.LogError("Reader is null after ExecuteReaderAsync");
                                return OperationResult<ClientsGetResponseDto>.Failure("Failed to retrieve data from database");
                            }

                            return await ProcessResultAsync(reader, logger, dto.Page, dto.Limit);
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number >= 2 && ex.Number <= 53)
            {
                logger.LogError(ex, "Database connection failed - Page: {Page}, Limit: {Limit}", dto.Page, dto.Limit);
                return OperationResult<ClientsGetResponseDto>.Failure("Database connection failed. Please try again.");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "Database error - Page: {Page}, Limit: {Limit}, SqlError: {ErrorNumber}",
                    dto.Page, dto.Limit, ex.Number);
                return OperationResult<ClientsGetResponseDto>.Failure("Database operation failed");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unexpected error - Page: {Page}, Limit: {Limit}", dto.Page, dto.Limit);
                return OperationResult<ClientsGetResponseDto>.Failure("System error occurred during client retrieval");
            }
        }

        // ---------------- Helper Methods ----------------

        private static SqlCommand CreateCommand(SqlConnection connection, ClientsGetRequestDto dto)
        {
            if (connection == null)
                throw new ArgumentNullException(nameof(connection), "Database connection is null");

            SqlCommand command = new SqlCommand(GetClientsSql, connection)
            {
                CommandType = System.Data.CommandType.Text
            };

            command.AddParameter("@Page", dto.Page);
            command.AddParameter("@Limit", dto.Limit);
            return command;
        }

        private static async Task<OperationResult<ClientsGetResponseDto>> ProcessResultAsync(
            SqlDataReader reader,
            ILogger logger,
            int page,
            int limit)
        {
            if (reader == null)
            {
                logger.LogError("Reader is null in ProcessResultAsync");
                return OperationResult<ClientsGetResponseDto>.Failure("Failed to process database results");
            }

            List<ClientModel> clients = new List<ClientModel>();
            string status = "ERROR";
            string message = "No data retrieved";
            int currentPage = 0, pageSize = 0, totalRecords = 0, totalPages = 0;
            bool hasNextPage = false, hasPreviousPage = false;

            try
            {
                while (await reader.ReadAsync())
                {
                    ClientModel client = ClientMapper.MapClientFromReader(reader);

                    if (client != null)
                        clients.Add(client);

                    // Only read pagination info from the first row
                    if (clients.Count == 1)
                    {
                        currentPage = reader.GetValueOrDefault<int>("CurrentPage");
                        pageSize = reader.GetValueOrDefault<int>("PageSize");
                        totalRecords = reader.GetValueOrDefault<int>("TotalRecords");
                        totalPages = reader.GetValueOrDefault<int>("TotalPages");
                        hasNextPage = reader.GetValueOrDefault<int>("HasNextPage") == 1;
                        hasPreviousPage = reader.GetValueOrDefault<int>("HasPreviousPage") == 1;
                        status = reader.GetValueOrDefault<string>("Status") ?? "ERROR";
                        message = reader.GetValueOrDefault<string>("Message") ?? "Clients retrieval failed";
                    }
                }

                ClientsGetResponseDto responseDto = new ClientsGetResponseDto
                {
                    Clients = clients,
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                    TotalRecords = totalRecords,
                    TotalPages = totalPages,
                    HasNextPage = hasNextPage,
                    HasPreviousPage = hasPreviousPage
                };

                logger.LogInformation("Clients retrieved successfully - Page: {Page}, Count: {Count}, Total: {Total}",
                    page, clients.Count, totalRecords);

                return OperationResult<ClientsGetResponseDto>.Success(responseDto, message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error processing client data - Page: {Page}, Limit: {Limit}", page, limit);
                return OperationResult<ClientsGetResponseDto>.Failure("Failed to process client data");
            }
        }
    }
}
