

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

            Create.Table("Provider")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Name").AsString(255).NotNullable()
                .WithColumn("ContactNumber").AsString(90).NotNullable();

            Create.ForeignKey("FK_Provider_Specialty")
                .FromTable("Provider").ForeignColumn("Id")
                .ToTable("Specialty").PrimaryColumn("Id");
        }
    }
}
