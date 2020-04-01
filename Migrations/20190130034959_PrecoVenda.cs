using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceLiteAlexandre.Migrations
{
    public partial class PrecoVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecoVenda",
                table: "Produto",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoVenda",
                table: "Produto");
        }
    }
}
