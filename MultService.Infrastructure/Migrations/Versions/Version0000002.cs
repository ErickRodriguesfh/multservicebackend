
using FluentMigrator;

namespace MultService.Infrastructure.Migrations.Versions
{
    [Migration(DatabaseVersions.RENAME_COLUMNS, "Rename columns")]
    public class Version0000002 : ForwardOnlyMigration
    {
        public override void Up()
        {
            Rename.Column("Id").OnTable("Specialty").To("Id");
            Rename.Column("Name").OnTable("Specialty").To("Name");
        }
    }
}
