using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class RemovedPersonInheritance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Person_CustomerId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Person_EmployeeId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSchedules_Person_EmployeeId",
                table: "EmployeeSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_GiftCards_Person_CustomerId",
                table: "GiftCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Person_CreatedBy",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_EmployeeTitles_TitleId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_Person_EmployeeId",
                table: "Qualifications");

            migrationBuilder.DropIndex(
                name: "IX_Person_TitleId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PrimaryEmail",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PrimaryPhoneNumber",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "SecondaryEmail",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "SecondaryPhoneNumber",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "AlternatePhoneNumber",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ImageSource",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "LastInitial",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    GenderId = table.Column<int>(nullable: true),
                    PrimaryEmail = table.Column<string>(nullable: true),
                    SecondaryEmail = table.Column<string>(nullable: true),
                    PrimaryPhoneNumber = table.Column<string>(nullable: true),
                    SecondaryPhoneNumber = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    LastInitial = table.Column<string>(nullable: true),
                    GenderId = table.Column<int>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    AlternatePhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ImageSource = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    TitleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeTitles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "EmployeeTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderId",
                table: "Customers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GenderId",
                table: "Employees",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TitleId",
                table: "Employees",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customers_CustomerId",
                table: "Appointments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Employees_EmployeeId",
                table: "Appointments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSchedules_Employees_EmployeeId",
                table: "EmployeeSchedules",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GiftCards_Customers_CustomerId",
                table: "GiftCards",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Employees_CreatedBy",
                table: "Notes",
                column: "CreatedBy",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_Employees_EmployeeId",
                table: "Qualifications",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customers_CustomerId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Employees_EmployeeId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSchedules_Employees_EmployeeId",
                table: "EmployeeSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_GiftCards_Customers_CustomerId",
                table: "GiftCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Employees_CreatedBy",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_Employees_EmployeeId",
                table: "Qualifications");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryEmail",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryPhoneNumber",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryEmail",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryPhoneNumber",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlternatePhoneNumber",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSource",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastInitial",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Person_TitleId",
                table: "Person",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Person_CustomerId",
                table: "Appointments",
                column: "CustomerId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Person_EmployeeId",
                table: "Appointments",
                column: "EmployeeId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSchedules_Person_EmployeeId",
                table: "EmployeeSchedules",
                column: "EmployeeId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GiftCards_Person_CustomerId",
                table: "GiftCards",
                column: "CustomerId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Person_CreatedBy",
                table: "Notes",
                column: "CreatedBy",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_EmployeeTitles_TitleId",
                table: "Person",
                column: "TitleId",
                principalTable: "EmployeeTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_Person_EmployeeId",
                table: "Qualifications",
                column: "EmployeeId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
