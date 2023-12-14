using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmesAPI.Migrations
{
    public partial class CriandoTabelaFilme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AAAA",
                table: "AAAA");

            migrationBuilder.RenameTable(
                name: "AAAA",
                newName: "Filmes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filmes",
                table: "Filmes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Filmes",
                table: "Filmes");

            migrationBuilder.RenameTable(
                name: "Filmes",
                newName: "AAAA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AAAA",
                table: "AAAA",
                column: "Id");
        }
    }
}
