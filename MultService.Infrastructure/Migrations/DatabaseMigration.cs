using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace MultService.Infrastructure.Migrations
{
    public static class DatabaseMigration
    {
        public static void MigrationDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.ListMigrations();
            runner.MigrateUp();
        }
    }
}
