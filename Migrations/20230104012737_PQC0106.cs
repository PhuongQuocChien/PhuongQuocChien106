using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhuonQuocChien106.Migrations
{
    /// <inheritdoc />
    public partial class PQC0106 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PQC0106",
                columns: table => new
                {
                    PQCId = table.Column<string>(type: "TEXT", nullable: false),
                    PQCName = table.Column<string>(type: "TEXT", nullable: true),
                    PQCGender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PQC0106", x => x.PQCId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PQC0106");
        }
    }
}
