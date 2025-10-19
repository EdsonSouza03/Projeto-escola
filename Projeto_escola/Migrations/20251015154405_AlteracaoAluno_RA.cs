using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_escola.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoAluno_RA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Alunos",
                newName: "RA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RA",
                table: "Alunos",
                newName: "Email");
        }
    }
}
