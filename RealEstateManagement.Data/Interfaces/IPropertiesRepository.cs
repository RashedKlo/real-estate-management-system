using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Properties.Create;
using RealEstateManagement.Data.DTOs.Properties.Delete;
using RealEstateManagement.Data.DTOs.Properties.Queries;
using RealEstateManagement.Data.DTOs.Properties.Update;
using RealEstateManagement.Data.Results;

namespace RealEstateManagement.Data.Interfaces
{
    public interface IPropertiesRepository
    {
        Task<OperationResult<PropertyCreateResponseDto>> AddPropertyAsync(PropertyCreateRequestDto dto);
        Task<OperationResult<PropertyUpdateResponseDto>> UpdatePropertyAsync(PropertyUpdateRequestDto dto);
        Task<OperationResult<PropertyDeleteResponseDto>> DeletePropertyAsync(PropertyDeleteRequestDto dto);
        Task<OperationResult<PropertyGetResponseDto>> GetPropertyAsync(PropertyGetRequestDto dto);
        Task<OperationResult<PropertiesGetResponseDto>> GetPropertiesAsync(PropertiesGetRequestDto dto);
    }
}
