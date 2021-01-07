using Microsoft.EntityFrameworkCore.Migrations;

namespace LaptopAPI.Migrations
{
    public partial class ForgnKeyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegistrationId",
                table: "laptopDetails",
                newName: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "laptopDetails",
                newName: "RegistrationId");
        }
    }
}
