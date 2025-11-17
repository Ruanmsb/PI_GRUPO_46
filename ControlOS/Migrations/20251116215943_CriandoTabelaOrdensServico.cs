using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlOS.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaOrdensServico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdensServico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoServico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternoInterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoServico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataOS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RuaCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroResidenciaCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeTecnico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdensServico", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdensServico");
        }
    }
}
