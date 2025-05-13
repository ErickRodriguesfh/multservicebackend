

using MultService.Domain.RepositoryInterface.UnitOfWork;

namespace MultService.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MultServiceDbContext _dbContext;
        
        public UnitOfWork(MultServiceDbContext dbContext) => _dbContext = dbContext;

        public async Task Commit() => await _dbContext.SaveChangesAsync();
    }
}
