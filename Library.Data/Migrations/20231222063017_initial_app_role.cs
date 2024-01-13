using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial_app_role : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppRoleId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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
                columns: new[] { "AppRoleId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "a6b69b59-bc88-4e7b-a6ff-e1463f9259c3", "AQAAAAEAACcQAAAAEE+q12XhavgujIkOzMLNP1i2jMFsxHG1Eulj0y8SacadGIqCC0bjDaHSFtkfD541DA==", "e11e21d4-5d38-4e82-94ad-851d3b1f08e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppRoleId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "83a16084-370d-435e-b99b-7322cc7006ec", "AQAAAAEAACcQAAAAEM+eLeRwf2TbpSii0QrhV4MmSc4c/6P1azQohhFsHtD02XazNsjCHNIhlm6KIWKCbw==", "1b72a152-1aeb-4dda-9c13-8efa9cf73b86" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AppRoleId",
                table: "AspNetUsers",
                column: "AppRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_AppRoleId",
                table: "AspNetUsers",
                column: "AppRoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_AppRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AppRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AppRoleId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4e42d37c-5d9e-446e-bbe0-ab7f21911637");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fe6b83c7-3053-4712-9f54-316cb713dc9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "23b9f470-1a33-4d79-b788-7d751a9726e9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca68b0bf-216d-4928-bb70-3c9d9dc3bb1f", "AQAAAAEAACcQAAAAEHqS8FXLp4Pp3qRWSedPKtoSrWbBeei+CXZt2kHedhTxRj/9UelNPr5WwmdJToBUWg==", "3d0a8844-14a5-4a63-8240-c8e5f4bcaf1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9150eda6-9a42-4b6c-946d-be143a549d36", "AQAAAAEAACcQAAAAEJEnm7BYTUFm/Ez3JJuDkpBEn6k8IYH3wTUwOWnfX2CggY+VWvdai2L47dNn0KZWpw==", "b8fa23e0-1df9-458e-a63c-b1772946a684" });
        }
    }
}
