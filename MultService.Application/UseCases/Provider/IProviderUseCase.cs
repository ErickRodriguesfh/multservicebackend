using MultService.Application.Communication.Response.ProviderDTOs;

namespace MultService.Application.UseCases.Provider
{
    public interface IProviderUseCase
    {
        Task<List<ProviderResponseDTO>> GetUsersAsync();
    }
}
