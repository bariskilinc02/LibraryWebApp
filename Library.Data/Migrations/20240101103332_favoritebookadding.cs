using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class favoritebookadding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "85bb7188-3f93-490b-9c84-82e8cc0a4d3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3890a84c-71b8-493d-9246-44ae56a09b4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0e3a135a-82f7-42f7-b69b-36579151f214");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fceb68a-6a99-407c-8c92-d3b1468aea09", "AQAAAAEAACcQAAAAEMsCxzXpqUBZD2aRsBbHNCtLKhMEzxTiyMfGsLU09QFsuD3f2tkyFWGcow+Y12iddA==", "bc32bcef-a16a-41cc-8aa1-ecda11f40cbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4f6a5a6-139a-4597-a265-3a6a664fdbe0", "AQAAAAEAACcQAAAAEAZTHYnR/3i8ODRNeusYchME0NPj4zzOBAhcnsZLmAG/NZI1nITwHNjqAg++uzcpcw==", "657645ec-f4d5-4fea-afbc-540f4e71197b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
