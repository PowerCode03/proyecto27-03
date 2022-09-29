using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificacionU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerNombreU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombreU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellidoU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellidoU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DireccionU = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
