using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAgentApp.Migrations
{
    /// <inheritdoc />
    public partial class EditColumnNullableonTableBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 19, 4, 0, 46, 278, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 19, 4, 0, 46, 278, DateTimeKind.Local).AddTicks(3503));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 19, 3, 57, 27, 649, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 19, 3, 57, 27, 649, DateTimeKind.Local).AddTicks(5491));
        }
    }
}
