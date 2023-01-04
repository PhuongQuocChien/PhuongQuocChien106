using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhuonQuocChien106.Migrations
{
    /// <inheritdoc />
    public partial class UniversityPQC106 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniversityPQC106",
                columns: table => new
                {
                    UniversityId = table.Column<string>(type: "TEXT", nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityPQC106", x => x.UniversityId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversityPQC106");
        }
    }
}
