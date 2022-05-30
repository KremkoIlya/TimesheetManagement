using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimesheetManagement.Data.Migrations
{
    public partial class BaseTimesheetEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimesheetDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesheetDays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimesheetTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    TimesheetDayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesheetTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimesheetTimes_TimesheetDays_TimesheetDayId",
                        column: x => x.TimesheetDayId,
                        principalTable: "TimesheetDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimesheetTimes_TimesheetDayId",
                table: "TimesheetTimes",
                column: "TimesheetDayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimesheetTimes");

            migrationBuilder.DropTable(
                name: "TimesheetDays");
        }
    }
}
