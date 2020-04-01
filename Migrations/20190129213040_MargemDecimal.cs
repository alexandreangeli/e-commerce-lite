using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceLiteAlexandre.Migrations
{
    public partial class MargemDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "MargemLucro",
                table: "Pedido",
                nullable: false,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "MargemLucro",
                table: "Pedido",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
