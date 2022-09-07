using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairManagement.API.Migrations
{
    public partial class SBillings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Billings");

            _ = migrationBuilder.DropColumn(
                name: "TypeOfService",
                table: "Billings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Billings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            _ = migrationBuilder.AddColumn<string>(
                name: "TypeOfService",
                table: "Billings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
