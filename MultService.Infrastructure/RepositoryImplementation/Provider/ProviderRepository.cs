
using Microsoft.EntityFrameworkCore;
using MultService.Domain.RepositoryInterface;
using MultService.Infrastructure.Persistence;

namespace MultService.Infrastructure.RepositoryImplementation.Provider
{
    public class ProviderRepository : IProviderRepository
    {
        private readonly MultServiceDbContext _context;

        public ProviderRepository(MultServiceDbContext context) => _context = context;
      
        public async Task<List<Domain.Entities.Provider>> GetUsersAsync() =>
            await _context.Providers
                .Include(p => p.Specialties)
                .ToListAsync();
    }
}
