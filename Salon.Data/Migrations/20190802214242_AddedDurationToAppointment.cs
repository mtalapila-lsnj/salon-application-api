using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class AddedDurationToAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Appointments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Appointments");
        }
    }
}
