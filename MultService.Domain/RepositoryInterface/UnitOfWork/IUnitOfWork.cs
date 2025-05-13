
namespace MultService.Domain.RepositoryInterface.UnitOfWork
{
    public interface IUnitOfWork
    {
        public Task Commit();
    }
}
