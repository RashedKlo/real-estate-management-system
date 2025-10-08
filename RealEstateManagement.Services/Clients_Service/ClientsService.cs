using System;
using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Clients.Create;
using RealEstateManagement.Data.DTOs.Clients.Update;
using RealEstateManagement.Data.DTOs.Clients.Delete;
using RealEstateManagement.Data.DTOs.Clients.Queries;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.Interfaces;
using Microsoft.Extensions.Logging;

namespace RealEstateManagement.Services.Client
{
    public sealed class ClientsService : IClientsService
    {
        private readonly IClientsRepository _clientRepository;
        private readonly ILogger<ClientsService> _logger;

        public ClientsService(IClientsRepository clientRepository, ILogger<ClientsService> logger)
        {
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<OperationResult<ClientCreateResponseDto>> AddClientAsync(ClientCreateRequestDto dto)
        {
            _logger.LogInformation("Starting client creation process");

            if (dto == null)
            {
                _logger.LogWarning("Client data is null");
                return Failure<ClientCreateResponseDto>("Client data is required");
            }

            OperationResult<bool> validation = ClientsValidation.ValidateClientCreation(dto, _logger);
            if (!validation.IsSuccess)
            {
                _logger.LogWarning("Client validation failed - Message: {Message}", validation.Message);
                return Failure<ClientCreateResponseDto>(validation.Message);
            }

            OperationResult<ClientCreateResponseDto> result = await _clientRepository.AddClientAsync(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for AddClientAsync");
                return Failure<ClientCreateResponseDto>("Failed to create client - null result");
            }

            if (result.IsSuccess)
            {
                _logger.LogInformation("Client created successfully - FullName: {FullName}, Phone: {PhoneNumber}",
                    dto.FullName, dto.PhoneNumber);
            }
            else
            {
                _logger.LogWarning("Failed to create client - FullName: {FullName}, Phone: {PhoneNumber}, Error: {Error}",
                    dto.FullName, dto.PhoneNumber, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<ClientCreateResponseDto>(result.Message);
        }

        public async Task<OperationResult<ClientUpdateResponseDto>> UpdateClientAsync(ClientUpdateRequestDto dto)
        {
            _logger.LogInformation("Starting client update - ClientId: {ClientId}", dto?.ClientId);

            if (dto == null)
            {
                _logger.LogWarning("Client update data is null");
                return Failure<ClientUpdateResponseDto>("Client data is required");
            }

            OperationResult<bool> validation = ClientsValidation.ValidateClientUpdate(dto, _logger);
            if (!validation.IsSuccess)
            {
                _logger.LogWarning("Client update validation failed - ClientId: {ClientId}, Message: {Message}",
                    dto.ClientId, validation.Message);
                return Failure<ClientUpdateResponseDto>(validation.Message);
            }

            OperationResult<ClientUpdateResponseDto> result = await _clientRepository.UpdateClientAsync(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for UpdateClientAsync - ClientId: {ClientId}", dto.ClientId);
                return Failure<ClientUpdateResponseDto>("Failed to update client - null result");
            }

            if (result.IsSuccess)
            {
                _logger.LogInformation("Client updated successfully - ClientId: {ClientId}", dto.ClientId);
            }
            else
            {
                _logger.LogWarning("Failed to update client - ClientId: {ClientId}, Error: {Error}",
                    dto.ClientId, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<ClientUpdateResponseDto>(result.Message);
        }

        public async Task<OperationResult<ClientDeleteResponseDto>> DeleteClientAsync(ClientDeleteRequestDto dto)
        {
            _logger.LogInformation("Starting client deletion - ClientId: {ClientId}", dto?.ClientId);

            if (dto == null)
            {
                _logger.LogWarning("Client delete data is null");
                return Failure<ClientDeleteResponseDto>("Client data is required");
            }

            OperationResult<bool> validation = ClientsValidation.ValidateClientDeletion(dto, _logger);
            if (!validation.IsSuccess)
            {
                _logger.LogWarning("Client deletion validation failed - ClientId: {ClientId}, Message: {Message}",
                    dto.ClientId, validation.Message);
                return Failure<ClientDeleteResponseDto>(validation.Message);
            }

            OperationResult<ClientDeleteResponseDto> result = await _clientRepository.DeleteClientAsync(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for DeleteClientAsync - ClientId: {ClientId}", dto.ClientId);
                return Failure<ClientDeleteResponseDto>("Failed to delete client - null result");
            }

            if (result.IsSuccess)
            {
                _logger.LogInformation("Client deleted successfully - ClientId: {ClientId}", dto.ClientId);
            }
            else
            {
                _logger.LogWarning("Failed to delete client - ClientId: {ClientId}, Error: {Error}",
                    dto.ClientId, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<ClientDeleteResponseDto>(result.Message);
        }

        public async Task<OperationResult<ClientGetResponseDto>> GetClientAsync(ClientGetRequestDto dto)
        {
            _logger.LogInformation("Starting client retrieval - ClientId: {ClientId}", dto?.ClientId);

            if (dto == null || dto.ClientId <= 0)
            {
                _logger.LogWarning("Invalid client ID - ClientId: {ClientId}", dto?.ClientId);
                return Failure<ClientGetResponseDto>("Invalid client ID");
            }

            OperationResult<ClientGetResponseDto> result = await _clientRepository.GetClientAsync(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for GetClientAsync - ClientId: {ClientId}", dto.ClientId);
                return Failure<ClientGetResponseDto>("Failed to retrieve client - null result");
            }

            if (result.IsSuccess)
            {
                _logger.LogInformation("Client retrieved successfully - ClientId: {ClientId}", dto.ClientId);
            }
            else
            {
                _logger.LogWarning("Failed to retrieve client - ClientId: {ClientId}, Error: {Error}",
                    dto.ClientId, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<ClientGetResponseDto>(result.Message);
        }

        public async Task<OperationResult<ClientsGetResponseDto>> GetClientsAsync(ClientsGetRequestDto dto)
        {
            _logger.LogInformation("Starting clients list retrieval - Page: {Page}, Limit: {Limit}", dto?.Page, dto?.Limit);

            if (dto == null)
            {
                _logger.LogWarning("Request data is null for GetClientsAsync");
                return Failure<ClientsGetResponseDto>("Request data is required");
            }

            OperationResult<bool> validation = ClientsValidation.ValidateGetClients(dto, _logger);
            if (!validation.IsSuccess)
            {
                _logger.LogWarning("Clients retrieval validation failed - Page: {Page}, Limit: {Limit}, Message: {Message}",
                    dto.Page, dto.Limit, validation.Message);
                return Failure<ClientsGetResponseDto>(validation.Message);
            }

            OperationResult<ClientsGetResponseDto> result = await _clientRepository.GetClientsAsync(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for GetClientsAsync - Page: {Page}, Limit: {Limit}",
                    dto.Page, dto.Limit);
                return Failure<ClientsGetResponseDto>("Failed to retrieve clients - null result");
            }

            if (result.IsSuccess)
            {
                int totalRecords = result.Data?.TotalRecords ?? 0;
                _logger.LogInformation("Clients retrieved successfully - Page: {Page}, Limit: {Limit}, Total: {TotalRecords}",
                    dto.Page, dto.Limit, totalRecords);
            }
            else
            {
                _logger.LogWarning("Failed to retrieve clients - Page: {Page}, Limit: {Limit}, Error: {Error}",
                    dto.Page, dto.Limit, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<ClientsGetResponseDto>(result.Message);
        }

        public async Task<OperationResult<ClientPropertiesGetResponseDto>> GetClientPropertiesAsync(
             ClientPropertiesGetRequestDto dto)
        {
            _logger.LogInformation("Starting client properties retrieval - ClientId: {ClientId}, Page: {Page}, Limit: {Limit}",
                dto?.ClientId, dto?.Page, dto?.Limit);

            if (dto == null)
            {
                _logger.LogWarning("Request data is null for GetClientPropertiesAsync");
                return Failure<ClientPropertiesGetResponseDto>("Request data is required");
            }

            OperationResult<bool> validation =ClientsValidation.ValidateGetClientProperties(dto,_logger);
            if (!validation.IsSuccess)
            {
                _logger.LogWarning("Client properties validation failed - ClientId: {ClientId}, Message: {Message}",
                    dto.ClientId, validation.Message);
                return Failure<ClientPropertiesGetResponseDto>(validation.Message);
            }

            OperationResult<ClientPropertiesGetResponseDto> result =
                await _clientRepository.get(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for GetClientPropertiesAsync - ClientId: {ClientId}",
                    dto.ClientId);
                return Failure<ClientPropertiesGetResponseDto>("Failed to retrieve client properties - null result");
            }

            if (result.IsSuccess)
            {
                int totalRecords = result.Data?.TotalRecords ?? 0;
                _logger.LogInformation("Client properties retrieved successfully - ClientId: {ClientId}, Page: {Page}, Total: {TotalRecords}",
                    dto.ClientId, dto.Page, totalRecords);
            }
            else
            {
                _logger.LogWarning("Failed to retrieve client properties - ClientId: {ClientId}, Error: {Error}",
                    dto.ClientId, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<ClientPropertiesGetResponseDto>(result.Message);
        }

  

        // Helper methods
        private OperationResult<T> Success<T>(OperationResult<T> result)
        {
            if (result == null)
            {
                _logger.LogWarning("Success helper received null result");
                return OperationResult<T>.Success(default(T), "Operation completed");
            }
            return OperationResult<T>.Success(result.Data, result.Message);
        }

        private OperationResult<T> Failure<T>(string message)
        {
            _logger.LogWarning("Operation failed - Message: {Message}", message);
            return OperationResult<T>.Failure(message ?? "Operation failed");
        }
    }
}