using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Clients.Create;
using RealEstateManagement.Data.DTOs.Clients.Update;
using RealEstateManagement.Data.DTOs.Clients.Delete;
using RealEstateManagement.Data.DTOs.Clients.Queries;
using RealEstateManagement.Data.Results;

namespace RealEstateManagement.Data.Interfaces
{
    public interface IClientsRepository
    {
        Task<OperationResult<ClientCreateResponseDto>> AddClientAsync(ClientCreateRequestDto dto);
        Task<OperationResult<ClientUpdateResponseDto>> UpdateClientAsync(ClientUpdateRequestDto dto);
        Task<OperationResult<ClientDeleteResponseDto>> DeleteClientAsync(ClientDeleteRequestDto dto);
        Task<OperationResult<ClientGetResponseDto>> GetClientAsync(ClientGetRequestDto dto);
        Task<OperationResult<ClientsGetResponseDto>> GetClientsAsync(ClientsGetRequestDto dto);
        Task<OperationResult<ClientPropertiesGetResponseDto>> GetClientPropertiesAsync(ClientPropertiesGetRequestDto dto);

    }
}