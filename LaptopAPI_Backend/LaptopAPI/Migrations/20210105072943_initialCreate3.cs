using Microsoft.EntityFrameworkCore.Migrations;

namespace LaptopAPI.Migrations
{
    public partial class initialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegistrationId",
                table: "laptopDetails",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "laptopDetails");
        }
    }
}
