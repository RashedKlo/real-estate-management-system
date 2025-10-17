using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Properties.Create;
using RealEstateManagement.Data.DTOs.Properties.Delete;
using RealEstateManagement.Data.DTOs.Properties.Queries;
using RealEstateManagement.Data.DTOs.Properties.Update;
using RealEstateManagement.Data.Interfaces;
using RealEstateManagement.Data.Repositories.Properties.Commands;
using RealEstateManagement.Data.Repositories.Properties.Queries;
using RealEstateManagement.Data.Results;

namespace RealEstateManagement.Data.Repositories.Properties
{
    public class PropertiesRepository : IPropertiesRepository
    {
        private readonly ILogger<PropertiesRepository> _logger;

        public PropertiesRepository(ILogger<PropertiesRepository> logger)
        {
            _logger = logger;
        }

        public async Task<OperationResult<PropertyCreateResponseDto>> AddPropertyAsync(PropertyCreateRequestDto dto)
        {
            _logger.LogInformation("PropertiesRepository: AddPropertyAsync called");
            return await AddPropertyCommand.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<PropertyUpdateResponseDto>> UpdatePropertyAsync(PropertyUpdateRequestDto dto)
        {
            _logger.LogInformation("PropertiesRepository: UpdatePropertyAsync called - PropertyId: {PropertyId}", dto?.PropertyId);
            return await UpdatePropertyCommand.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<PropertyDeleteResponseDto>> DeletePropertyAsync(PropertyDeleteRequestDto dto)
        {
            _logger.LogInformation("PropertiesRepository: DeletePropertyAsync called - PropertyId: {PropertyId}", dto?.PropertyId);
            return await DeletePropertyCommand.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<PropertyGetResponseDto>> GetPropertyAsync(PropertyGetRequestDto dto)
        {
            _logger.LogInformation("PropertiesRepository: GetPropertyAsync called - PropertyId: {PropertyId}", dto?.PropertyId);
            return await GetPropertyQuery.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<PropertiesGetResponseDto>> GetPropertiesAsync(PropertiesGetRequestDto dto)
        {
            _logger.LogInformation("PropertiesRepository: GetPropertiesAsync called - Page: {Page}, Limit: {Limit}",
                dto?.Page, dto?.Limit);
            return await GetPropertiesQuery.ExecuteAsync(dto, _logger);
        }
    }
}
