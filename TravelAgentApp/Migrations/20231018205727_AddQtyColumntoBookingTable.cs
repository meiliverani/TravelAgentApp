using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAgentApp.Migrations
{
    /// <inheritdoc />
    public partial class AddQtyColumntoBookingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Qty",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndValidDate", "StartValidDate" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Local) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qty",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndValidDate", "StartValidDate" },
                values: new object[] { new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 18, 17, 9, 59, 4, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 18, 17, 9, 59, 4, DateTimeKind.Local).AddTicks(1762));
        }
    }
}
