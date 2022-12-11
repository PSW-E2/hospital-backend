using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalLibrary.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "VacationRequestId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 4, 2, 45, 240, DateTimeKind.Local).AddTicks(893), new DateTime(2022, 12, 21, 4, 2, 45, 237, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "VacationRequestId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 31, 4, 2, 45, 240, DateTimeKind.Local).AddTicks(2578), new DateTime(2022, 12, 26, 4, 2, 45, 240, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "VacationRequestId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 5, 4, 2, 45, 240, DateTimeKind.Local).AddTicks(2586), new DateTime(2022, 12, 31, 4, 2, 45, 240, DateTimeKind.Local).AddTicks(2582) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "VacationRequestId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 25, 17, 37, 32, 584, DateTimeKind.Local).AddTicks(3942), new DateTime(2022, 12, 20, 17, 37, 32, 577, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "VacationRequestId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 30, 17, 37, 32, 584, DateTimeKind.Local).AddTicks(6160), new DateTime(2022, 12, 25, 17, 37, 32, 584, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "VacationRequests",
                keyColumn: "VacationRequestId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 4, 17, 37, 32, 584, DateTimeKind.Local).AddTicks(6173), new DateTime(2022, 12, 30, 17, 37, 32, 584, DateTimeKind.Local).AddTicks(6169) });
        }
    }
}
