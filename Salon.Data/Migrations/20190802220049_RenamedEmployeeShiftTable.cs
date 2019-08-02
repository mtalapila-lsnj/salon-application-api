using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class RenamedEmployeeShiftTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeShift_Employees_EmployeeId",
                table: "EmployeeShift");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeShift",
                table: "EmployeeShift");

            migrationBuilder.RenameTable(
                name: "EmployeeShift",
                newName: "EmployeeShifts");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeShift_EmployeeId",
                table: "EmployeeShifts",
                newName: "IX_EmployeeShifts_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeShifts",
                table: "EmployeeShifts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeShifts_Employees_EmployeeId",
                table: "EmployeeShifts",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeShifts_Employees_EmployeeId",
                table: "EmployeeShifts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeShifts",
                table: "EmployeeShifts");

            migrationBuilder.RenameTable(
                name: "EmployeeShifts",
                newName: "EmployeeShift");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeShifts_EmployeeId",
                table: "EmployeeShift",
                newName: "IX_EmployeeShift_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeShift",
                table: "EmployeeShift",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeShift_Employees_EmployeeId",
                table: "EmployeeShift",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
