using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.WebAPI.Migrations
{
    public partial class updatecerveza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Cervezas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Precio",
                table: "Cervezas",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Cervezas");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Cervezas");
        }
    }
}
