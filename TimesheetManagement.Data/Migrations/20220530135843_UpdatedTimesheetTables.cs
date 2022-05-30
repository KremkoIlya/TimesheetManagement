using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimesheetManagement.Data.Migrations
{
    public partial class UpdatedTimesheetTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimesheetTimes");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "TimesheetDays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "TimesheetPeriods",
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
                    table.PrimaryKey("PK_TimesheetPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimesheetPeriods_TimesheetDays_TimesheetDayId",
                        column: x => x.TimesheetDayId,
                        principalTable: "TimesheetDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimesheetPeriods_TimesheetDayId",
                table: "TimesheetPeriods",
                column: "TimesheetDayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimesheetPeriods");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "TimesheetDays");

            migrationBuilder.CreateTable(
                name: "TimesheetTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimesheetDayId = table.Column<int>(type: "int", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
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
    }
}
