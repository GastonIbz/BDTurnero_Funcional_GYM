using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turnero.BD.Migrations
{
    public partial class ClaveUnica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "AlumnoDni_UQ1",
                table: "TablaProfesores",
                newName: "ProfesorDNI_UQ");

            migrationBuilder.RenameIndex(
                name: "AlumnoDni_UQ",
                table: "TablaAlumnos",
                newName: "AlumnoDNI_UQ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "ProfesorDNI_UQ",
                table: "TablaProfesores",
                newName: "AlumnoDni_UQ1");

            migrationBuilder.RenameIndex(
                name: "AlumnoDNI_UQ",
                table: "TablaAlumnos",
                newName: "AlumnoDni_UQ");
        }
    }
}
