using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class ChangedAppointmentDateTimeDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Appointments");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Start",
                table: "Appointments",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "Appointments",
                nullable: false,
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);
        }
    }
}
