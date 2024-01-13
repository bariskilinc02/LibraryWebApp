using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class bookTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Floor",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationInformation",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d2cf6256-f0da-42b1-ba4e-70fbe2a9bc04");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "25b723e2-d46b-415c-b496-aacecb474102");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c409dfbe-ded0-403f-9456-4d3014950ce3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7366ce1-1a1a-429b-86fd-bbed5dea8f11", "AQAAAAEAACcQAAAAEJPC6hJ+/6yfh9JMwa2I5Lixt3RICyRBrCUxXUDIpkW9ZZtqdxeZcRcmsrwQrjDPvg==", "51f95375-6148-4bbd-b70a-6c313147b8db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "646dd036-0cd8-468d-9564-bbbe4631290d", "AQAAAAEAACcQAAAAENldrVzOllWphCc5eu8/qBFQzrkcDDHHA1GGXh6UBYyYWhCbtfgiO6+qYWjlXWJ85g==", "934fa8fc-5cc6-4c73-a657-863c12f84559" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Floor",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "LocationInformation",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fd3a471a-20f9-4568-8cb2-ceb7cfbbc66b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "369e1e25-9cb1-42ab-8e20-55bb13a82ea6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0f34d205-330c-45c8-b73e-182706c79da1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ba1ecb0-a677-4a66-b024-b70b6dc6a3f2", "AQAAAAEAACcQAAAAEHP29myLdAtvhnx4372MfMuR99bDO64LduChZZnoeJg/fAJGWyNnfbQwA00NT3WTkQ==", "eae1794b-d472-4935-99e7-6009cfdbcd00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3c41948-bdec-4a63-abd0-c99572856a9d", "AQAAAAEAACcQAAAAEEjrc8yINVkV3z20IfkLzXz9RZ2hbcS8kQFLjPYLdErn0E24FVwPVWMITl2j8PvDwA==", "e088ba4e-fd11-49c8-a968-08f174914ff8" });
        }
    }
}
