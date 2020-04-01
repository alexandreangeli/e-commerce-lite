using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceLiteAlexandre.Migrations
{
    public partial class PrecoUnitarioVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecoUnitario",
                table: "ItemPedido",
                newName: "PrecoUnitarioVenda");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoUnitarioCompra",
                table: "ItemPedido",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoUnitarioCompra",
                table: "ItemPedido");

            migrationBuilder.RenameColumn(
                name: "PrecoUnitarioVenda",
                table: "ItemPedido",
                newName: "PrecoUnitario");
        }
    }
}
