using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turnero.BD.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TablaAlumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagenPerfil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaAlumnos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaProfesores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagenPerfil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaProfesores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaTurnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaTurno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdAlumno = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlumnoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaTurnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablaTurnos_TablaAlumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "TablaAlumnos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TablaTurnos_AlumnoId",
                table: "TablaTurnos",
                column: "AlumnoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablaProfesores");

            migrationBuilder.DropTable(
                name: "TablaTurnos");

            migrationBuilder.DropTable(
                name: "TablaAlumnos");
        }
    }
}
