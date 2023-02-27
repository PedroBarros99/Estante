using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFEstante.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeAutor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    nomeLivro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDAutor = table.Column<int>(type: "int", nullable: false),
                    precoLivro = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autors");

            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
