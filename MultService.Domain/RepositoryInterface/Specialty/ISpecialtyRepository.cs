

using MultService.Domain.Entities;

namespace MultService.Domain.RepositoryInterface
{
    public interface ISpecialtyRepository
    {
        Task<IEnumerable<Specialty>> GetSpecialtiesAsync();
    }
}
