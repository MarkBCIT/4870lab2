using Microsoft.EntityFrameworkCore.Migrations;

namespace lab2.Data.Migrations
{
    public partial class PAC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProvinceName",
                table: "CitiesDbset");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProvinceName",
                table: "CitiesDbset",
                nullable: true);
        }
    }
}
