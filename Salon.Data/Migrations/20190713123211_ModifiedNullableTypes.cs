using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class ModifiedNullableTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentProducts_Appointments_AppointmentId",
                table: "AppointmentProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentProducts_Products_ProductId",
                table: "AppointmentProducts");

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

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProductPreferences_Customers_CustomerId",
                table: "CustomerProductPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProductPreferences_Products_ProductId",
                table: "CustomerProductPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerServicePreferences_Customers_CustomerId",
                table: "CustomerServicePreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerServicePreferences_Qualifications_QualificationId",
                table: "CustomerServicePreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSchedules_Employees_EmployeeId",
                table: "EmployeeSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSchedules_TimeSlots_TimeSlotId",
                table: "EmployeeSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_Employees_EmployeeId",
                table: "Qualifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_Services_ServiceId",
                table: "Qualifications");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "Visits",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "TimeSlots",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "SalonSchedules",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "SalonSchedules",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "Qualifications",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Qualifications",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ParticipantsQuantity",
                table: "GroupParties",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "GiftCardTransactions",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "TimeSlotId",
                table: "EmployeeSchedules",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeSchedules",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "QualificationId",
                table: "CustomerServicePreferences",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerServicePreferences",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "CustomerProductPreferences",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerProductPreferences",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "OkToContactOnWeekends",
                table: "CustomerContactPreferences",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "OkToContactOnHolidays",
                table: "CustomerContactPreferences",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "OkToContact",
                table: "CustomerContactPreferences",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "CustomerContactPreferences",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerContactPreferences",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ContactTypeId",
                table: "CustomerContactPreferences",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "ContactAcceptances",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsOkToCotact",
                table: "ContactAcceptances",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ContactAcceptances",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "ContactAcceptances",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "ContactAcceptances",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AcceptedOn",
                table: "ContactAcceptances",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "AppointmentTransactions",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Appointments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsSecondaryRequest",
                table: "Appointments",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsPrimaryRequest",
                table: "Appointments",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "AppointmentProducts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentId",
                table: "AppointmentProducts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "AppointmentDetails",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentProducts_Appointments_AppointmentId",
                table: "AppointmentProducts",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentProducts_Products_ProductId",
                table: "AppointmentProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactAcceptances_Customers_CustomerId",
                table: "ContactAcceptances",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactAcceptances_ContactTypes_TypeId",
                table: "ContactAcceptances",
                column: "TypeId",
                principalTable: "ContactTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContactPreferences_ContactTypes_ContactTypeId",
                table: "CustomerContactPreferences",
                column: "ContactTypeId",
                principalTable: "ContactTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContactPreferences_Customers_CustomerId",
                table: "CustomerContactPreferences",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProductPreferences_Customers_CustomerId",
                table: "CustomerProductPreferences",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProductPreferences_Products_ProductId",
                table: "CustomerProductPreferences",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerServicePreferences_Customers_CustomerId",
                table: "CustomerServicePreferences",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerServicePreferences_Qualifications_QualificationId",
                table: "CustomerServicePreferences",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSchedules_Employees_EmployeeId",
                table: "EmployeeSchedules",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSchedules_TimeSlots_TimeSlotId",
                table: "EmployeeSchedules",
                column: "TimeSlotId",
                principalTable: "TimeSlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_Employees_EmployeeId",
                table: "Qualifications",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_Services_ServiceId",
                table: "Qualifications",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentProducts_Appointments_AppointmentId",
                table: "AppointmentProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentProducts_Products_ProductId",
                table: "AppointmentProducts");

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

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProductPreferences_Customers_CustomerId",
                table: "CustomerProductPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProductPreferences_Products_ProductId",
                table: "CustomerProductPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerServicePreferences_Customers_CustomerId",
                table: "CustomerServicePreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerServicePreferences_Qualifications_QualificationId",
                table: "CustomerServicePreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSchedules_Employees_EmployeeId",
                table: "EmployeeSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSchedules_TimeSlots_TimeSlotId",
                table: "EmployeeSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_Employees_EmployeeId",
                table: "Qualifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_Services_ServiceId",
                table: "Qualifications");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "Visits",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "TimeSlots",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "SalonSchedules",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "SalonSchedules",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "Qualifications",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Qualifications",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParticipantsQuantity",
                table: "GroupParties",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "GiftCardTransactions",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TimeSlotId",
                table: "EmployeeSchedules",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeSchedules",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QualificationId",
                table: "CustomerServicePreferences",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerServicePreferences",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "CustomerProductPreferences",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerProductPreferences",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "OkToContactOnWeekends",
                table: "CustomerContactPreferences",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "OkToContactOnHolidays",
                table: "CustomerContactPreferences",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "OkToContact",
                table: "CustomerContactPreferences",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "CustomerContactPreferences",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerContactPreferences",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactTypeId",
                table: "CustomerContactPreferences",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "ContactAcceptances",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsOkToCotact",
                table: "ContactAcceptances",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "ContactAcceptances",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedOn",
                table: "ContactAcceptances",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "ContactAcceptances",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AcceptedOn",
                table: "ContactAcceptances",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "AppointmentTransactions",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Appointments",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsSecondaryRequest",
                table: "Appointments",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsPrimaryRequest",
                table: "Appointments",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "AppointmentProducts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentId",
                table: "AppointmentProducts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "AppointmentDetails",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentProducts_Appointments_AppointmentId",
                table: "AppointmentProducts",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentProducts_Products_ProductId",
                table: "AppointmentProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProductPreferences_Customers_CustomerId",
                table: "CustomerProductPreferences",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProductPreferences_Products_ProductId",
                table: "CustomerProductPreferences",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerServicePreferences_Customers_CustomerId",
                table: "CustomerServicePreferences",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerServicePreferences_Qualifications_QualificationId",
                table: "CustomerServicePreferences",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSchedules_Employees_EmployeeId",
                table: "EmployeeSchedules",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSchedules_TimeSlots_TimeSlotId",
                table: "EmployeeSchedules",
                column: "TimeSlotId",
                principalTable: "TimeSlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_Employees_EmployeeId",
                table: "Qualifications",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_Services_ServiceId",
                table: "Qualifications",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
