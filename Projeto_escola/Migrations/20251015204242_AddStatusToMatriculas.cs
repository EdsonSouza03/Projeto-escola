using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_escola.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusToMatriculas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Matriculas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Matriculas");
        }
    }
}
