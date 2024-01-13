using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial_app_role_finish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "206ef70d-eb9b-45fe-9d2e-3e633657c0fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "36ea02bd-ff1f-469d-b63f-df1d3c75959c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1c86d9cf-b922-4a38-bbf4-f6b7b6a9d04c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6b69b59-bc88-4e7b-a6ff-e1463f9259c3", "AQAAAAEAACcQAAAAEE+q12XhavgujIkOzMLNP1i2jMFsxHG1Eulj0y8SacadGIqCC0bjDaHSFtkfD541DA==", "e11e21d4-5d38-4e82-94ad-851d3b1f08e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83a16084-370d-435e-b99b-7322cc7006ec", "AQAAAAEAACcQAAAAEM+eLeRwf2TbpSii0QrhV4MmSc4c/6P1azQohhFsHtD02XazNsjCHNIhlm6KIWKCbw==", "1b72a152-1aeb-4dda-9c13-8efa9cf73b86" });
        }
    }
}
