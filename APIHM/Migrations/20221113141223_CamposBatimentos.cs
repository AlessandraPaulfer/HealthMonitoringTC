using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIHM.Migrations
{
    public partial class CamposBatimentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Batimentos",
                table: "Hiper",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Batimentos",
                table: "Glico",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Categoria",
                table: "Glico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Batimentos",
                table: "Extra",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Batimentos",
                table: "Hiper");

            migrationBuilder.DropColumn(
                name: "Batimentos",
                table: "Glico");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Glico");

            migrationBuilder.DropColumn(
                name: "Batimentos",
                table: "Extra");
        }
    }
}
