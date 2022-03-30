using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaFinal.Migrations
{
    public partial class Intaial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id_Pais = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisId_Pais = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id_Pais);
                    table.ForeignKey(
                        name: "FK_Pais_Pais_PaisId_Pais",
                        column: x => x.PaisId_Pais,
                        principalTable: "Pais",
                        principalColumn: "Id_Pais");
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_Identidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisId_Pais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id_Cliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Pais_PaisId_Pais",
                        column: x => x.PaisId_Pais,
                        principalTable: "Pais",
                        principalColumn: "Id_Pais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PaisId_Pais",
                table: "Cliente",
                column: "PaisId_Pais");

            migrationBuilder.CreateIndex(
                name: "IX_Pais_PaisId_Pais",
                table: "Pais",
                column: "PaisId_Pais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
