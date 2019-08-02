using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class ChangedEmployeeShiftDurationDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "EmployeeShifts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "EmployeeShifts",
                nullable: true);
        }
    }
}
