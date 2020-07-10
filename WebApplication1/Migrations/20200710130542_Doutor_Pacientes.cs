using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Doutor_Pacientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doutores_Pacientes_PacienteId",
                table: "Doutores");

            migrationBuilder.DropIndex(
                name: "IX_Doutores_PacienteId",
                table: "Doutores");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Doutores");

            migrationBuilder.CreateTable(
                name: "DoutorPacientes",
                columns: table => new
                {
                    DoutorId = table.Column<int>(nullable: false),
                    PacienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoutorPacientes", x => new { x.DoutorId, x.PacienteId });
                    table.ForeignKey(
                        name: "FK_DoutorPacientes_Doutores_DoutorId",
                        column: x => x.DoutorId,
                        principalTable: "Doutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoutorPacientes_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoutorPacientes_PacienteId",
                table: "DoutorPacientes",
                column: "PacienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoutorPacientes");

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "Doutores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Doutores_PacienteId",
                table: "Doutores",
                column: "PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doutores_Pacientes_PacienteId",
                table: "Doutores",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
