using System;
using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Clients.Update;
using RealEstateManagement.Data.DTOs.Clients.Delete;
using RealEstateManagement.Data.DTOs.Clients.Create;
using RealEstateManagement.Data.DTOs.Clients.Queries;
using RealEstateManagement.Data.Repositories.Client.Commands;
using RealEstateManagement.Data.Repositories.Client.Queries;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Interfaces;

using Microsoft.Extensions.Logging;

namespace RealEstateManagement.Data.Repositories.Client
{
    public class ClientsRepository:IClientsRepository
    {
        private readonly ILogger<ClientsRepository> _logger;

        public ClientsRepository(ILogger<ClientsRepository> logger)
        {
            this._logger = logger;
        }

        public async Task<OperationResult<ClientCreateResponseDto>> AddClientAsync(ClientCreateRequestDto dto)
        {
            return await AddClientCommand.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<ClientUpdateResponseDto>> UpdateClientAsync(ClientUpdateRequestDto dto)
        {
            return await UpdateClientCommand.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<ClientDeleteResponseDto>> DeleteClientAsync(ClientDeleteRequestDto dto)
        {
            return await DeleteClientCommand.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<ClientGetResponseDto>> GetClientAsync(ClientGetRequestDto dto)
        {
            return await GetClientQuery.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<ClientsGetResponseDto>> GetClientsAsync(ClientsGetRequestDto dto)
        {
            return await GetClientsQuery.ExecuteAsync(dto, _logger);
        }
    }
}
