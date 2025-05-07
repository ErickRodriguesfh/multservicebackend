using System.Reflection;
using FluentMigrator.Runner;
namespace MultService.API.Configuration
{
    public class FluentMigratorInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Connection");
            services.AddFluentMigratorCore()
                .ConfigureRunner(options =>
                {
                    options
                        .AddPostgres()
                        .WithGlobalConnectionString(connectionString)
                             .ScanIn(typeof(MultService.Infrastructure.Migrations.Versions.Version0000001).Assembly);
                });
        }
    }
}
