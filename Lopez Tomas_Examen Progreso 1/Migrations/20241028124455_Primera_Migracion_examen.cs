using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lopez_Tomas_Examen_Progreso_1.Migrations
{
    /// <inheritdoc />
    public partial class Primera_Migracion_examen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    IDcelular = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    año = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    precio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.IDcelular);
                });

            migrationBuilder.CreateTable(
                name: "Lopez",
                columns: table => new
                {
                    IDlopez = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    celularIDcelular = table.Column<int>(type: "int", nullable: true),
                    Ncelular = table.Column<int>(type: "int", nullable: false),
                    afiliado = table.Column<bool>(type: "bit", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    decFav = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lopez", x => x.IDlopez);
                    table.ForeignKey(
                        name: "FK_Lopez_Celular_celularIDcelular",
                        column: x => x.celularIDcelular,
                        principalTable: "Celular",
                        principalColumn: "IDcelular");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lopez_celularIDcelular",
                table: "Lopez",
                column: "celularIDcelular");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lopez");

            migrationBuilder.DropTable(
                name: "Celular");
        }
    }
}
