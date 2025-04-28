

using MultService.Application.Communication.Response.ProviderDTOs;
using MultService.Application.UseCases;

namespace MultService.Application.UseCasesImplementation
{
    public class ProviderUseCase : IProviderUseCase
    {
        public Task<List<ProviderResponseDTO>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
