

using MultService.Application.Communication.Response.ProviderDTOs;

namespace MultService.Application.UseCases
{
    public interface IProviderUseCase
    {
        Task<List<ProviderResponseDTO>> GetUsersAsync();
    }
}
