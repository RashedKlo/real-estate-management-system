using System;
using System.Threading.Tasks;
using RealEstateManagement.Data.DTOs.Owners.Update;
using RealEstateManagement.Data.DTOs.Owners.Delete;
using RealEstateManagement.Data.DTOs.Owners.Create;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Repositories.Owner.Commands;
using RealEstateManagement.Data.Repositories.Owner.Queries;
using RealEstateManagement.Data.Results;

using Microsoft.Extensions.Logging;

namespace RealEstateManagement.Data.Repositories.Owner
{
    public class OwnerRepository
    {
        private readonly ILogger<OwnerRepository> _logger;

        public OwnerRepository(ILogger<OwnerRepository> logger)
        {
            this._logger = logger;
        }

        public async Task<OperationResult<OwnerCreateResponseDto>> AddOwnerAsync(OwnerCreateRequestDto dto)
        {
            return await AddOwnerCommand.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<OwnerUpdateResponseDto>> UpdateOwnerAsync(OwnerUpdateRequestDto dto)
        {
            return await UpdateOwnerCommand.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<OwnerDeleteResponseDto>> DeleteOwnerAsync(OwnerDeleteRequestDto dto)
        {
            return await DeleteOwnerCommand.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<OwnerGetResponseDto>> GetOwnerAsync(OwnerGetRequestDto dto)
        {
            return await GetOwnerQuery.ExecuteAsync(dto, _logger);
        }

        public async Task<OperationResult<OwnersGetResponseDto>> GetOwnersAsync(OwnersGetRequestDto dto)
        {
            return await GetOwnersQuery.ExecuteAsync(dto, _logger);
        }
    }
}
