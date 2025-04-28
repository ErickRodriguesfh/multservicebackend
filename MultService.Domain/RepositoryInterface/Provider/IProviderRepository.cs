
using MultService.Domain.Entities;

namespace MultService.Domain.RepositoryInterface
{
    public interface IProviderRepository
    {
        Task<List<Provider>> GetUsersAsync();
    }
}
