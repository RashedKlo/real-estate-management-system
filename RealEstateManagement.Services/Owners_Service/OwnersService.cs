using System;
using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Owners.Create;
using RealEstateManagement.Data.DTOs.Owners.Update;
using RealEstateManagement.Data.DTOs.Owners.Delete;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.Interfaces;
using Microsoft.Extensions.Logging;

namespace RealEstateManagement.Services.Owner
{
    public sealed class OwnersService : IOwnersService
    {
        private readonly IOwnersRepository _ownerRepository;
        private readonly ILogger<OwnersService> _logger;

        public OwnersService(IOwnersRepository ownerRepository, ILogger<OwnersService> logger)
        {
            _ownerRepository = ownerRepository ?? throw new ArgumentNullException(nameof(ownerRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<OperationResult<OwnerCreateResponseDto>> AddOwnerAsync(OwnerCreateRequestDto dto)
        {
            _logger.LogInformation("Starting owner creation process");

            if (dto == null)
            {
                _logger.LogWarning("Owner data is null");
                return Failure<OwnerCreateResponseDto>("Owner data is required");
            }

            OperationResult<bool> validation = OwnersValidation.ValidateOwnerCreation(dto, _logger);
            if (!validation.IsSuccess)
            {
                _logger.LogWarning("Owner validation failed - Message: {Message}", validation.Message);
                return Failure<OwnerCreateResponseDto>(validation.Message);
            }

            OperationResult<OwnerCreateResponseDto> result = await _ownerRepository.AddOwnerAsync(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for AddOwnerAsync");
                return Failure<OwnerCreateResponseDto>("Failed to create owner - null result");
            }

            if (result.IsSuccess)
            {
                _logger.LogInformation("Owner created successfully - FullName: {FullName}, Phone: {PhoneNumber}",
                    dto.FullName, dto.PhoneNumber);
            }
            else
            {
                _logger.LogWarning("Failed to create owner - FullName: {FullName}, Phone: {PhoneNumber}, Error: {Error}",
                    dto.FullName, dto.PhoneNumber, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<OwnerCreateResponseDto>(result.Message);
        }

        public async Task<OperationResult<OwnerUpdateResponseDto>> UpdateOwnerAsync(OwnerUpdateRequestDto dto)
        {
            _logger.LogInformation("Starting owner update - OwnerId: {OwnerId}", dto?.OwnerId);

            if (dto == null)
            {
                _logger.LogWarning("Owner update data is null");
                return Failure<OwnerUpdateResponseDto>("Owner data is required");
            }

            OperationResult<bool> validation = OwnersValidation.ValidateOwnerUpdate(dto, _logger);
            if (!validation.IsSuccess)
            {
                _logger.LogWarning("Owner update validation failed - OwnerId: {OwnerId}, Message: {Message}",
                    dto.OwnerId, validation.Message);
                return Failure<OwnerUpdateResponseDto>(validation.Message);
            }

            OperationResult<OwnerUpdateResponseDto> result = await _ownerRepository.UpdateOwnerAsync(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for UpdateOwnerAsync - OwnerId: {OwnerId}", dto.OwnerId);
                return Failure<OwnerUpdateResponseDto>("Failed to update owner - null result");
            }

            if (result.IsSuccess)
            {
                _logger.LogInformation("Owner updated successfully - OwnerId: {OwnerId}", dto.OwnerId);
            }
            else
            {
                _logger.LogWarning("Failed to update owner - OwnerId: {OwnerId}, Error: {Error}",
                    dto.OwnerId, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<OwnerUpdateResponseDto>(result.Message);
        }

        public async Task<OperationResult<OwnerDeleteResponseDto>> DeleteOwnerAsync(OwnerDeleteRequestDto dto)
        {
            _logger.LogInformation("Starting owner deletion - OwnerId: {OwnerId}", dto?.OwnerId);

            if (dto == null)
            {
                _logger.LogWarning("Owner delete data is null");
                return Failure<OwnerDeleteResponseDto>("Owner data is required");
            }

            OperationResult<bool> validation = OwnersValidation.ValidateOwnerDeletion(dto, _logger);
            if (!validation.IsSuccess)
            {
                _logger.LogWarning("Owner deletion validation failed - OwnerId: {OwnerId}, Message: {Message}",
                    dto.OwnerId, validation.Message);
                return Failure<OwnerDeleteResponseDto>(validation.Message);
            }

            OperationResult<OwnerDeleteResponseDto> result = await _ownerRepository.DeleteOwnerAsync(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for DeleteOwnerAsync - OwnerId: {OwnerId}", dto.OwnerId);
                return Failure<OwnerDeleteResponseDto>("Failed to delete owner - null result");
            }

            if (result.IsSuccess)
            {
                _logger.LogInformation("Owner deleted successfully - OwnerId: {OwnerId}", dto.OwnerId);
            }
            else
            {
                _logger.LogWarning("Failed to delete owner - OwnerId: {OwnerId}, Error: {Error}",
                    dto.OwnerId, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<OwnerDeleteResponseDto>(result.Message);
        }

        public async Task<OperationResult<OwnerGetResponseDto>> GetOwnerAsync(OwnerGetRequestDto dto)
        {
            _logger.LogInformation("Starting owner retrieval - OwnerId: {OwnerId}", dto?.OwnerId);

            if (dto == null || dto.OwnerId <= 0)
            {
                _logger.LogWarning("Invalid owner ID - OwnerId: {OwnerId}", dto?.OwnerId);
                return Failure<OwnerGetResponseDto>("Invalid owner ID");
            }

            OperationResult<OwnerGetResponseDto> result = await _ownerRepository.GetOwnerAsync(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for GetOwnerAsync - OwnerId: {OwnerId}", dto.OwnerId);
                return Failure<OwnerGetResponseDto>("Failed to retrieve owner - null result");
            }

            if (result.IsSuccess)
            {
                _logger.LogInformation("Owner retrieved successfully - OwnerId: {OwnerId}", dto.OwnerId);
            }
            else
            {
                _logger.LogWarning("Failed to retrieve owner - OwnerId: {OwnerId}, Error: {Error}",
                    dto.OwnerId, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<OwnerGetResponseDto>(result.Message);
        }

        public async Task<OperationResult<OwnersGetResponseDto>> GetOwnersAsync(OwnersGetRequestDto dto)
        {
            _logger.LogInformation("Starting owners list retrieval - Page: {Page}, Limit: {Limit}", dto?.Page, dto?.Limit);

            if (dto == null)
            {
                _logger.LogWarning("Request data is null for GetOwnersAsync");
                return Failure<OwnersGetResponseDto>("Request data is required");
            }

            OperationResult<bool> validation = OwnersValidation.ValidateGetOwners(dto, _logger);
            if (!validation.IsSuccess)
            {
                _logger.LogWarning("Owners retrieval validation failed - Page: {Page}, Limit: {Limit}, Message: {Message}",
                    dto.Page, dto.Limit, validation.Message);
                return Failure<OwnersGetResponseDto>(validation.Message);
            }

            OperationResult<OwnersGetResponseDto> result = await _ownerRepository.GetOwnersAsync(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for GetOwnersAsync - Page: {Page}, Limit: {Limit}",
                    dto.Page, dto.Limit);
                return Failure<OwnersGetResponseDto>("Failed to retrieve owners - null result");
            }

            if (result.IsSuccess)
            {
                int totalRecords = result.Data?.TotalRecords ?? 0;
                _logger.LogInformation("Owners retrieved successfully - Page: {Page}, Limit: {Limit}, Total: {TotalRecords}",
                    dto.Page, dto.Limit, totalRecords);
            }
            else
            {
                _logger.LogWarning("Failed to retrieve owners - Page: {Page}, Limit: {Limit}, Error: {Error}",
                    dto.Page, dto.Limit, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<OwnersGetResponseDto>(result.Message);
        }

        public async Task<OperationResult<OwnerPropertiesGetResponseDto>> GetOwnerPropertiesAsync(
             OwnerPropertiesGetRequestDto dto)
        {
            _logger.LogInformation("Starting owner properties retrieval - OwnerId: {OwnerId}, Page: {Page}, Limit: {Limit}",
                dto?.OwnerId, dto?.Page, dto?.Limit);

            if (dto == null)
            {
                _logger.LogWarning("Request data is null for GetOwnerPropertiesAsync");
                return Failure<OwnerPropertiesGetResponseDto>("Request data is required");
            }

            OperationResult<bool> validation = OwnersValidation.ValidateGetOwnerProperties(dto, _logger);
            if (!validation.IsSuccess)
            {
                _logger.LogWarning("Owner properties validation failed - OwnerId: {OwnerId}, Message: {Message}",
                    dto.OwnerId, validation.Message);
                return Failure<OwnerPropertiesGetResponseDto>(validation.Message);
            }

            OperationResult<OwnerPropertiesGetResponseDto> result =
                await _ownerRepository.GetOwnerPropertiesAsync(dto);

            if (result == null)
            {
                _logger.LogError("Repository returned null result for GetOwnerPropertiesAsync - OwnerId: {OwnerId}",
                    dto.OwnerId);
                return Failure<OwnerPropertiesGetResponseDto>("Failed to retrieve owner properties - null result");
            }

            if (result.IsSuccess)
            {
                int totalRecords = result.Data?.TotalRecords ?? 0;
                _logger.LogInformation("Owner properties retrieved successfully - OwnerId: {OwnerId}, Page: {Page}, Total: {TotalRecords}",
                    dto.OwnerId, dto.Page, totalRecords);
            }
            else
            {
                _logger.LogWarning("Failed to retrieve owner properties - OwnerId: {OwnerId}, Error: {Error}",
                    dto.OwnerId, result.Message);
            }

            return result.IsSuccess ? Success(result) : Failure<OwnerPropertiesGetResponseDto>(result.Message);
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