using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class AddedForeignKeyToAppointmentDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_AppointmentId",
                table: "AppointmentDetails",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentDetails_Appointments_AppointmentId",
                table: "AppointmentDetails",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentDetails_Appointments_AppointmentId",
                table: "AppointmentDetails");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentDetails_AppointmentId",
                table: "AppointmentDetails");
        }
    }
}
