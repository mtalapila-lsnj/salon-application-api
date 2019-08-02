using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class AddedDurationToAppointmentDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "AppointmentDetails",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AppointmentDetails",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "AppointmentDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AppointmentDetails");
        }
    }
}
