using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica08Noticias.Data.Migrations
{
    public partial class autor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Noticias",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Noticias");
        }
    }
}
