using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turnero.BD.Migrations
{
    public partial class FechaCreacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "TablaProfesores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaTurno",
                table: "TablaProfesores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "TablaAlumnos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaTurno",
                table: "TablaAlumnos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "TablaProfesores");

            migrationBuilder.DropColumn(
                name: "FechaTurno",
                table: "TablaProfesores");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "TablaAlumnos");

            migrationBuilder.DropColumn(
                name: "FechaTurno",
                table: "TablaAlumnos");
        }
    }
}
