using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial_app_role_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "17baf5b3-bf8b-4f9a-9ae3-afa248e45bff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fee295a6-72b8-48df-b401-0c021723177d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "81e8b9ad-c0f2-4355-bcf7-e05fb6bc111a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c14d5dd5-fb1f-45d3-a346-eeeb4e798d07", "AQAAAAEAACcQAAAAEEKAoMvysVjpXFsT0aVNe2OE8/HaakXMjxRDqCvCVk5tCgV9clnSQ/kvUwcLC1b73g==", "b13bb9b1-0dfe-4767-ad4a-f414081d82ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "577295df-993c-4a17-9d9e-a9a16d23d6bc", "AQAAAAEAACcQAAAAEFKM3Fm2AFLmk8SuDC7fdJm0EG18gH3R7lviyuRJpg41HSSQHwOx3i3M9D9sLsEy2A==", "6dda9757-ba2f-4d62-a791-93e27ec04cca" });
        }
    }
}
