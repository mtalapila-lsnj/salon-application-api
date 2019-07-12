using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class RenamedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_GroupParty_GroupPartyId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Visit_VisitId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceStep_Services_ServiceId",
                table: "ServiceStep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visit",
                table: "Visit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceStep",
                table: "ServiceStep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupParty",
                table: "GroupParty");

            migrationBuilder.RenameTable(
                name: "Visit",
                newName: "Visits");

            migrationBuilder.RenameTable(
                name: "ServiceStep",
                newName: "ServiceSteps");

            migrationBuilder.RenameTable(
                name: "GroupParty",
                newName: "GroupParties");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceStep_ServiceId",
                table: "ServiceSteps",
                newName: "IX_ServiceSteps_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visits",
                table: "Visits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceSteps",
                table: "ServiceSteps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupParties",
                table: "GroupParties",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AppointmentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppointmentId = table.Column<int>(nullable: true),
                    Start = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: true),
                    ServiceStepId = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentDetails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentDetails_ServiceSteps_ServiceStepId",
                        column: x => x.ServiceStepId,
                        principalTable: "ServiceSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_EmployeeId",
                table: "AppointmentDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_ServiceStepId",
                table: "AppointmentDetails",
                column: "ServiceStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_GroupParties_GroupPartyId",
                table: "Appointments",
                column: "GroupPartyId",
                principalTable: "GroupParties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Visits_VisitId",
                table: "Appointments",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceSteps_Services_ServiceId",
                table: "ServiceSteps",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_GroupParties_GroupPartyId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Visits_VisitId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceSteps_Services_ServiceId",
                table: "ServiceSteps");

            migrationBuilder.DropTable(
                name: "AppointmentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visits",
                table: "Visits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceSteps",
                table: "ServiceSteps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupParties",
                table: "GroupParties");

            migrationBuilder.RenameTable(
                name: "Visits",
                newName: "Visit");

            migrationBuilder.RenameTable(
                name: "ServiceSteps",
                newName: "ServiceStep");

            migrationBuilder.RenameTable(
                name: "GroupParties",
                newName: "GroupParty");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceSteps_ServiceId",
                table: "ServiceStep",
                newName: "IX_ServiceStep_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visit",
                table: "Visit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceStep",
                table: "ServiceStep",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupParty",
                table: "GroupParty",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_GroupParty_GroupPartyId",
                table: "Appointments",
                column: "GroupPartyId",
                principalTable: "GroupParty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Visit_VisitId",
                table: "Appointments",
                column: "VisitId",
                principalTable: "Visit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceStep_Services_ServiceId",
                table: "ServiceStep",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
