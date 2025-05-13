

using Microsoft.EntityFrameworkCore;
using MultService.Domain.RepositoryInterface;
using MultService.Infrastructure.Persistence;

namespace MultService.Infrastructure.RepositoryImplementation.Specialty
{
    public class SpecialtyRepository : ISpecialtyRepository
    {
        private readonly MultServiceDbContext _context;

        public SpecialtyRepository(MultServiceDbContext context) => _context = context;

        public async Task<IEnumerable<Domain.Entities.Specialty>> GetSpecialtiesAsync()
        {
           return await _context.Specialties
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
