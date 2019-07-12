using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Salon.Data.Migrations
{
    public partial class AddedGroupPartiesAndVisitEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupPartyId",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VisitId",
                table: "Appointments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GroupParty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Start = table.Column<DateTime>(nullable: false),
                    ParticipantsQuantity = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupParty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Start = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_GroupPartyId",
                table: "Appointments",
                column: "GroupPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_VisitId",
                table: "Appointments",
                column: "VisitId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_GroupParty_GroupPartyId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Visit_VisitId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "GroupParty");

            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_GroupPartyId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_VisitId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "GroupPartyId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "VisitId",
                table: "Appointments");
        }
    }
}
