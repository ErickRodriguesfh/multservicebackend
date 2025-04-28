using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class startdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MultService");

            migrationBuilder.RenameTable(
                name: "Specialties",
                newName: "Specialties",
                newSchema: "MultService");

            migrationBuilder.RenameTable(
                name: "Providers",
                newName: "Providers",
                newSchema: "MultService");

            migrationBuilder.RenameTable(
                name: "Contractors",
                newName: "Contractors",
                newSchema: "MultService");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Specialties",
                schema: "MultService",
                newName: "Specialties");

            migrationBuilder.RenameTable(
                name: "Providers",
                schema: "MultService",
                newName: "Providers");

            migrationBuilder.RenameTable(
                name: "Contractors",
                schema: "MultService",
                newName: "Contractors");
        }
    }
}
