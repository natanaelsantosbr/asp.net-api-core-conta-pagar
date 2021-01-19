using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.EF.Migrations
{
    public partial class RetiradoColunaDiasDeAtraso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiasDeAtraso",
                table: "ContasPagar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiasDeAtraso",
                table: "ContasPagar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
