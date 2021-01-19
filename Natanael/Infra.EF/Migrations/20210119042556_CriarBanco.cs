using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.EF.Migrations
{
    public partial class CriarBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContasPagar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    DataDeVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDePagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiasDeAtraso = table.Column<int>(type: "int", nullable: false),
                    PercentualDaMulta = table.Column<double>(type: "float", nullable: false),
                    ValorDaMulta = table.Column<double>(type: "float", nullable: false),
                    PercentualDosJuros = table.Column<double>(type: "float", nullable: false),
                    ValorDosJuros = table.Column<double>(type: "float", nullable: false),
                    ValorCorrigido = table.Column<double>(type: "float", nullable: false),
                    QuantidadeDeDiasEmAtraso = table.Column<int>(type: "int", nullable: false),
                    DataDoCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasPagar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasPagar");
        }
    }
}
