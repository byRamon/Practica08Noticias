using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica08Noticias.Data.Migrations
{
    public partial class Noticias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriasID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriasID);
                });

            migrationBuilder.CreateTable(
                name: "Noticias",
                columns: table => new
                {
                    NoticiaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(nullable: false),
                    Contenido = table.Column<string>(nullable: false),
                    FechaPublicacion = table.Column<DateTime>(nullable: false),
                    CategoriaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticias", x => x.NoticiaID);
                    table.ForeignKey(
                        name: "FK_Noticias_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "CategoriasID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Noticias_CategoriaID",
                table: "Noticias",
                column: "CategoriaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noticias");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
