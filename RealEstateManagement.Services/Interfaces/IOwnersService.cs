using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Owners.Create;
using RealEstateManagement.Data.DTOs.Owners.Update;
using RealEstateManagement.Data.DTOs.Owners.Delete;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Results;

namespace RealEstateManagement.Services.Interfaces
{
    public interface IOwnersService
    {
        Task<OperationResult<OwnerCreateResponseDto>> AddOwnerAsync(OwnerCreateRequestDto dto);
        Task<OperationResult<OwnerUpdateResponseDto>> UpdateOwnerAsync(OwnerUpdateRequestDto dto);
        Task<OperationResult<OwnerDeleteResponseDto>> DeleteOwnerAsync(OwnerDeleteRequestDto dto);
        Task<OperationResult<OwnerGetResponseDto>> GetOwnerAsync(OwnerGetRequestDto dto);
        Task<OperationResult<OwnersGetResponseDto>> GetOwnersAsync(OwnersGetRequestDto dto);
        Task<OperationResult<OwnerPropertiesGetResponseDto>> GetOwnerPropertiesAsync(OwnerPropertiesGetRequestDto dto);
        
    }
}