

using MultService.Domain.Entities;

namespace MultService.Domain.RepositoryInterface
{
    public interface ISpecialtyRepository
    {
        Task<List<Specialty>> GetSpecialtiesAsync();
    }
}
