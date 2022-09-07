using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairManagement.API.Migrations
{
    public partial class STypeOfServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropColumn(
                name: "Repair",
                table: "TypeOfServices");

            _ = migrationBuilder.DropColumn(
                name: "SparePart",
                table: "TypeOfServices");

            _ = migrationBuilder.DropColumn(
                name: "Billing",
                table: "Customers");

            _ = migrationBuilder.DropColumn(
                name: "Customer",
                table: "CustomerDevices");

            _ = migrationBuilder.CreateIndex(
                name: "IX_TypeOfServices_RepairId",
                table: "TypeOfServices",
                column: "RepairId");

            _ = migrationBuilder.CreateIndex(
                name: "IX_TypeOfServices_SparePartId",
                table: "TypeOfServices",
                column: "SparePartId");

            _ = migrationBuilder.CreateIndex(
                name: "IX_Customers_BillingId",
                table: "Customers",
                column: "BillingId");

            _ = migrationBuilder.CreateIndex(
                name: "IX_CustomerDevices_CustomerId",
                table: "CustomerDevices",
                column: "CustomerId");

            _ = migrationBuilder.CreateIndex(
                name: "IX_Billings_PaymentMethodId",
                table: "Billings",
                column: "PaymentMethodId");

            _ = migrationBuilder.CreateIndex(
                name: "IX_Billings_TypeOfServiceId",
                table: "Billings",
                column: "TypeOfServiceId");

            _ = migrationBuilder.AddForeignKey(
                name: "FK_Billings_PaymentMethods_PaymentMethodId",
                table: "Billings",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            _ = migrationBuilder.AddForeignKey(
                name: "FK_Billings_TypeOfServices_TypeOfServiceId",
                table: "Billings",
                column: "TypeOfServiceId",
                principalTable: "TypeOfServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            _ = migrationBuilder.AddForeignKey(
                name: "FK_CustomerDevices_Customers_CustomerId",
                table: "CustomerDevices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            _ = migrationBuilder.AddForeignKey(
                name: "FK_Customers_Billings_BillingId",
                table: "Customers",
                column: "BillingId",
                principalTable: "Billings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            _ = migrationBuilder.AddForeignKey(
                name: "FK_TypeOfServices_Repairs_RepairId",
                table: "TypeOfServices",
                column: "RepairId",
                principalTable: "Repairs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            _ = migrationBuilder.AddForeignKey(
                name: "FK_TypeOfServices_SpareParts_SparePartId",
                table: "TypeOfServices",
                column: "SparePartId",
                principalTable: "SpareParts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropForeignKey(
                name: "FK_Billings_PaymentMethods_PaymentMethodId",
                table: "Billings");

            _ = migrationBuilder.DropForeignKey(
                name: "FK_Billings_TypeOfServices_TypeOfServiceId",
                table: "Billings");

            _ = migrationBuilder.DropForeignKey(
                name: "FK_CustomerDevices_Customers_CustomerId",
                table: "CustomerDevices");

            _ = migrationBuilder.DropForeignKey(
                name: "FK_Customers_Billings_BillingId",
                table: "Customers");

            _ = migrationBuilder.DropForeignKey(
                name: "FK_TypeOfServices_Repairs_RepairId",
                table: "TypeOfServices");

            _ = migrationBuilder.DropForeignKey(
                name: "FK_TypeOfServices_SpareParts_SparePartId",
                table: "TypeOfServices");

            _ = migrationBuilder.DropIndex(
                name: "IX_TypeOfServices_RepairId",
                table: "TypeOfServices");

            _ = migrationBuilder.DropIndex(
                name: "IX_TypeOfServices_SparePartId",
                table: "TypeOfServices");

            _ = migrationBuilder.DropIndex(
                name: "IX_Customers_BillingId",
                table: "Customers");

            _ = migrationBuilder.DropIndex(
                name: "IX_CustomerDevices_CustomerId",
                table: "CustomerDevices");

            _ = migrationBuilder.DropIndex(
                name: "IX_Billings_PaymentMethodId",
                table: "Billings");

            _ = migrationBuilder.DropIndex(
                name: "IX_Billings_TypeOfServiceId",
                table: "Billings");

            _ = migrationBuilder.AddColumn<string>(
                name: "Repair",
                table: "TypeOfServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            _ = migrationBuilder.AddColumn<int>(
                name: "SparePart",
                table: "TypeOfServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            _ = migrationBuilder.AddColumn<string>(
                name: "Billing",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            _ = migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "CustomerDevices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
