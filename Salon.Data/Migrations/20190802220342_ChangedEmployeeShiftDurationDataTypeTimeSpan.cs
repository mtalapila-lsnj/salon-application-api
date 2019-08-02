using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class ChangedEmployeeShiftDurationDataTypeTimeSpan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "EmployeeShifts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "EmployeeShifts");
        }
    }
}
