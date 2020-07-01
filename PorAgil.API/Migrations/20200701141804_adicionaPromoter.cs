using Microsoft.EntityFrameworkCore.Migrations;

namespace PorAgil.API.Migrations
{
    public partial class adicionaPromoter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Promoter",
                table: "Eventos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Promoter",
                table: "Eventos");
        }
    }
}
