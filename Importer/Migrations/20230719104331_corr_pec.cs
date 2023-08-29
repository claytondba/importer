using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Importer.Migrations
{
    /// <inheritdoc />
    public partial class corr_pec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "mic",
                table: "pecas_nova",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mic",
                table: "pecas_nova");
        }
    }
}
