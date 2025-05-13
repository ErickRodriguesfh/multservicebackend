

using FluentMigrator;

namespace MultService.Infrastructure.Migrations.Versions
{
    [Migration(DatabaseVersions.FIRST_STARTUP, "Initial migration")]
    public class Version0000001 : ForwardOnlyMigration
    {
        public override void Up()
        {
            Create.Table("Specialty")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString().NotNullable();
        }
    }
}
