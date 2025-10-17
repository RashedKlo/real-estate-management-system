using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Properties.Create;
using RealEstateManagement.Data.DTOs.Properties.Delete;
using RealEstateManagement.Data.DTOs.Properties.Queries;
using RealEstateManagement.Data.DTOs.Properties.Update;
using RealEstateManagement.Data.Interfaces;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Services.Properties;

namespace RealEstateManagement.Services.Properties
{
    public class PropertiesService : IPropertiesService
    {
        private readonly IPropertiesRepository _propertiesRepository;
        private readonly ILogger<PropertiesService> _logger;

        public PropertiesService(IPropertiesRepository propertiesRepository, ILogger<PropertiesService> logger)
        {
            _propertiesRepository = propertiesRepository ?? throw new ArgumentNullException(nameof(propertiesRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<OperationResult<PropertyCreateResponseDto>> AddPropertyAsync(PropertyCreateRequestDto dto)
        {
            try
            {
                _logger.LogInformation("PropertiesService: AddPropertyAsync called");

                if (dto == null)
                {
                    _logger.LogWarning("PropertiesService: AddPropertyAsync received null dto");
                    return OperationResult<PropertyCreateResponseDto>.Failure("Property data is required");
                }

                // Validate input data
                var validationResult = PropertiesValidation.ValidatePropertyCreation(dto, _logger);
                if (!validationResult.IsSuccess)
                {
                    _logger.LogWarning("PropertiesService: Property creation validation failed - {Message}", validationResult.Message);
                    return OperationResult<PropertyCreateResponseDto>.Failure(validationResult.Message);
                }

                var result = await _propertiesRepository.AddPropertyAsync(dto);

                if (result.IsSuccess)
                    _logger.LogInformation("PropertiesService: Property added successfully - PropertyId: {PropertyId}",
                        result.Data?.PropertyId);
                else
                    _logger.LogWarning("PropertiesService: Property addition failed - Message: {Message}", result.Message);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "PropertiesService: Error in AddPropertyAsync");
                return OperationResult<PropertyCreateResponseDto>.Failure("Failed to add property");
            }
        }

        public async Task<OperationResult<PropertyUpdateResponseDto>> UpdatePropertyAsync(PropertyUpdateRequestDto dto)
        {
            try
            {
                _logger.LogInformation("PropertiesService: UpdatePropertyAsync called - PropertyId: {PropertyId}", dto?.PropertyId);

                if (dto == null)
                {
                    _logger.LogWarning("PropertiesService: UpdatePropertyAsync received null dto");
                    return OperationResult<PropertyUpdateResponseDto>.Failure("Property data is required");
                }

                // Validate input data
                var validationResult = PropertiesValidation.ValidatePropertyUpdate(dto, _logger);
                if (!validationResult.IsSuccess)
                {
                    _logger.LogWarning("PropertiesService: Property update validation failed - PropertyId: {PropertyId}, Message: {Message}",
                        dto.PropertyId, validationResult.Message);
                    return OperationResult<PropertyUpdateResponseDto>.Failure(validationResult.Message);
                }

                var result = await _propertiesRepository.UpdatePropertyAsync(dto);

                if (result.IsSuccess)
                    _logger.LogInformation("PropertiesService: Property updated successfully - PropertyId: {PropertyId}", dto.PropertyId);
                else
                    _logger.LogWarning("PropertiesService: Property update failed - PropertyId: {PropertyId}, Message: {Message}",
                        dto.PropertyId, result.Message);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "PropertiesService: Error in UpdatePropertyAsync - PropertyId: {PropertyId}", dto?.PropertyId);
                return OperationResult<PropertyUpdateResponseDto>.Failure("Failed to update property");
            }
        }

        public async Task<OperationResult<PropertyDeleteResponseDto>> DeletePropertyAsync(PropertyDeleteRequestDto dto)
        {
            try
            {
                _logger.LogInformation("PropertiesService: DeletePropertyAsync called - PropertyId: {PropertyId}", dto?.PropertyId);

                if (dto == null)
                {
                    _logger.LogWarning("PropertiesService: DeletePropertyAsync received null dto");
                    return OperationResult<PropertyDeleteResponseDto>.Failure("Property ID is required");
                }

                // Validate input data
                var validationResult = PropertiesValidation.ValidatePropertyDeletion(dto, _logger);
                if (!validationResult.IsSuccess)
                {
                    _logger.LogWarning("PropertiesService: Property deletion validation failed - PropertyId: {PropertyId}, Message: {Message}",
                        dto.PropertyId, validationResult.Message);
                    return OperationResult<PropertyDeleteResponseDto>.Failure(validationResult.Message);
                }

                var result = await _propertiesRepository.DeletePropertyAsync(dto);

                if (result.IsSuccess)
                    _logger.LogInformation("PropertiesService: Property deleted successfully - PropertyId: {PropertyId}", dto.PropertyId);
                else
                    _logger.LogWarning("PropertiesService: Property deletion failed - PropertyId: {PropertyId}, Message: {Message}",
                        dto.PropertyId, result.Message);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "PropertiesService: Error in DeletePropertyAsync - PropertyId: {PropertyId}", dto?.PropertyId);
                return OperationResult<PropertyDeleteResponseDto>.Failure("Failed to delete property");
            }
        }

        public async Task<OperationResult<PropertyGetResponseDto>> GetPropertyAsync(PropertyGetRequestDto dto)
        {
            try
            {
                _logger.LogInformation("PropertiesService: GetPropertyAsync called - PropertyId: {PropertyId}", dto?.PropertyId);

                if (dto == null)
                {
                    _logger.LogWarning("PropertiesService: GetPropertyAsync received null dto");
                    return OperationResult<PropertyGetResponseDto>.Failure("Property ID is required");
                }

                // Validate input data
                var validationResult = PropertiesValidation.ValidateGetProperty(dto, _logger);
                if (!validationResult.IsSuccess)
                {
                    _logger.LogWarning("PropertiesService: Get property validation failed - PropertyId: {PropertyId}, Message: {Message}",
                        dto.PropertyId, validationResult.Message);
                    return OperationResult<PropertyGetResponseDto>.Failure(validationResult.Message);
                }

                var result = await _propertiesRepository.GetPropertyAsync(dto);

                if (result.IsSuccess)
                    _logger.LogInformation("PropertiesService: Property retrieved successfully - PropertyId: {PropertyId}", dto.PropertyId);
                else
                    _logger.LogWarning("PropertiesService: Property retrieval failed - PropertyId: {PropertyId}, Message: {Message}",
                        dto.PropertyId, result.Message);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "PropertiesService: Error in GetPropertyAsync - PropertyId: {PropertyId}", dto?.PropertyId);
                return OperationResult<PropertyGetResponseDto>.Failure("Failed to retrieve property");
            }
        }

        public async Task<OperationResult<PropertiesGetResponseDto>> GetPropertiesAsync(PropertiesGetRequestDto dto)
        {
            try
            {
                _logger.LogInformation("PropertiesService: GetPropertiesAsync called - Page: {Page}, Limit: {Limit}",
                    dto?.Page, dto?.Limit);

                if (dto == null)
                {
                    _logger.LogWarning("PropertiesService: GetPropertiesAsync received null dto");
                    return OperationResult<PropertiesGetResponseDto>.Failure("Request data is required");
                }

                // Validate input data
                var validationResult = PropertiesValidation.ValidateGetProperties(dto, _logger);
                if (!validationResult.IsSuccess)
                {
                    _logger.LogWarning("PropertiesService: Get properties validation failed - Message: {Message}", validationResult.Message);
                    return OperationResult<PropertiesGetResponseDto>.Failure(validationResult.Message);
                }

                var result = await _propertiesRepository.GetPropertiesAsync(dto);

                if (result.IsSuccess)
                    _logger.LogInformation("PropertiesService: Properties retrieved successfully - Count: {Count}",
                        result.Data?.Properties?.Count ?? 0);
                else
                    _logger.LogWarning("PropertiesService: Properties retrieval failed - Message: {Message}", result.Message);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "PropertiesService: Error in GetPropertiesAsync");
                return OperationResult<PropertiesGetResponseDto>.Failure("Failed to retrieve properties");
            }
        }
    }
}