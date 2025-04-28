using Microsoft.EntityFrameworkCore;
using MultService.Infrastructure.Persistence;

namespace MultService.API.Configuration
{
    public interface InfrastructureServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Connection");
            services.AddDbContext<MultServiceDbContext>(options => options.UseNpgsql(connectionString));
        }
    }
}
