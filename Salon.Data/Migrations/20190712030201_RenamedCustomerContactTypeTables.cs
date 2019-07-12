using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class RenamedCustomerContactTypeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactAcceptance_Customers_CustomerId",
                table: "ContactAcceptance");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactAcceptance_ContactType_TypeId",
                table: "ContactAcceptance");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerContactPreference_ContactType_ContactTypeId",
                table: "CustomerContactPreference");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerContactPreference_Customers_CustomerId",
                table: "CustomerContactPreference");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerContactPreference",
                table: "CustomerContactPreference");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactType",
                table: "ContactType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactAcceptance",
                table: "ContactAcceptance");

            migrationBuilder.RenameTable(
                name: "CustomerContactPreference",
                newName: "CustomerContactPreferences");

            migrationBuilder.RenameTable(
                name: "ContactType",
                newName: "ContactTypes");

            migrationBuilder.RenameTable(
                name: "ContactAcceptance",
                newName: "ContactAcceptances");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerContactPreference_CustomerId",
                table: "CustomerContactPreferences",
                newName: "IX_CustomerContactPreferences_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerContactPreference_ContactTypeId",
                table: "CustomerContactPreferences",
                newName: "IX_CustomerContactPreferences_ContactTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactAcceptance_TypeId",
                table: "ContactAcceptances",
                newName: "IX_ContactAcceptances_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactAcceptance_CustomerId",
                table: "ContactAcceptances",
                newName: "IX_ContactAcceptances_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerContactPreferences",
                table: "CustomerContactPreferences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactTypes",
                table: "ContactTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactAcceptances",
                table: "ContactAcceptances",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactAcceptances_Customers_CustomerId",
                table: "ContactAcceptances",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactAcceptances_ContactTypes_TypeId",
                table: "ContactAcceptances",
                column: "TypeId",
                principalTable: "ContactTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContactPreferences_ContactTypes_ContactTypeId",
                table: "CustomerContactPreferences",
                column: "ContactTypeId",
                principalTable: "ContactTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContactPreferences_Customers_CustomerId",
                table: "CustomerContactPreferences",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactAcceptances_Customers_CustomerId",
                table: "ContactAcceptances");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactAcceptances_ContactTypes_TypeId",
                table: "ContactAcceptances");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerContactPreferences_ContactTypes_ContactTypeId",
                table: "CustomerContactPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerContactPreferences_Customers_CustomerId",
                table: "CustomerContactPreferences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerContactPreferences",
                table: "CustomerContactPreferences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactTypes",
                table: "ContactTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactAcceptances",
                table: "ContactAcceptances");

            migrationBuilder.RenameTable(
                name: "CustomerContactPreferences",
                newName: "CustomerContactPreference");

            migrationBuilder.RenameTable(
                name: "ContactTypes",
                newName: "ContactType");

            migrationBuilder.RenameTable(
                name: "ContactAcceptances",
                newName: "ContactAcceptance");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerContactPreferences_CustomerId",
                table: "CustomerContactPreference",
                newName: "IX_CustomerContactPreference_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerContactPreferences_ContactTypeId",
                table: "CustomerContactPreference",
                newName: "IX_CustomerContactPreference_ContactTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactAcceptances_TypeId",
                table: "ContactAcceptance",
                newName: "IX_ContactAcceptance_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactAcceptances_CustomerId",
                table: "ContactAcceptance",
                newName: "IX_ContactAcceptance_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerContactPreference",
                table: "CustomerContactPreference",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactType",
                table: "ContactType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactAcceptance",
                table: "ContactAcceptance",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactAcceptance_Customers_CustomerId",
                table: "ContactAcceptance",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactAcceptance_ContactType_TypeId",
                table: "ContactAcceptance",
                column: "TypeId",
                principalTable: "ContactType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContactPreference_ContactType_ContactTypeId",
                table: "CustomerContactPreference",
                column: "ContactTypeId",
                principalTable: "ContactType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContactPreference_Customers_CustomerId",
                table: "CustomerContactPreference",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
