using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlOS.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoNumeroRuaParaNumero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumeroRua",
                table: "Clientes",
                newName: "Numero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Clientes",
                newName: "NumeroRua");
        }
    }
}
