using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabaseschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_Providers_ProviderId",
                schema: "MultService",
                table: "Specialties");

            migrationBuilder.DropIndex(
                name: "IX_Specialties_ProviderId",
                schema: "MultService",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                schema: "MultService",
                table: "Specialties");

            migrationBuilder.CreateTable(
                name: "ProviderSpecialty",
                schema: "MultService",
                columns: table => new
                {
                    ProvidersId = table.Column<long>(type: "bigint", nullable: false),
                    SpecialtiesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderSpecialty", x => new { x.ProvidersId, x.SpecialtiesId });
                    table.ForeignKey(
                        name: "FK_ProviderSpecialty_Providers_ProvidersId",
                        column: x => x.ProvidersId,
                        principalSchema: "MultService",
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProviderSpecialty_Specialties_SpecialtiesId",
                        column: x => x.SpecialtiesId,
                        principalSchema: "MultService",
                        principalTable: "Specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProviderSpecialty_SpecialtiesId",
                schema: "MultService",
                table: "ProviderSpecialty",
                column: "SpecialtiesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProviderSpecialty",
                schema: "MultService");

            migrationBuilder.AddColumn<long>(
                name: "ProviderId",
                schema: "MultService",
                table: "Specialties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_ProviderId",
                schema: "MultService",
                table: "Specialties",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_Providers_ProviderId",
                schema: "MultService",
                table: "Specialties",
                column: "ProviderId",
                principalSchema: "MultService",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
