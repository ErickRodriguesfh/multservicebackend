
using MultService.Domain.RepositoryInterface;
using MultService.Domain.RepositoryInterface.UnitOfWork;
using MultService.Infrastructure.Persistence;
using MultService.Infrastructure.RepositoryImplementation.Specialty;

namespace MultService.API.Configuration
{
    public class ApplicationRepositorieInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ISpecialtyRepository, SpecialtyRepository>();
        }
    }
}
