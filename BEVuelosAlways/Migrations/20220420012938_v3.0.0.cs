using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BEVuelosAlways.Migrations
{
    public partial class v300 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usuario = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    contraseña = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    rol = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vuelo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ciudadorigen = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    ciudaddestino = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    horasalida = table.Column<int>(type: "int", nullable: false),
                    horallegada = table.Column<int>(type: "int", nullable: false),
                    numerodevuelo = table.Column<int>(type: "int", nullable: false),
                    aerolinea = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    estado = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vuelo", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Vuelo");
        }
    }
}
