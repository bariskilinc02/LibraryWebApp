using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserCreateed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "14abbbda-d870-4466-b9bb-fdbb7920be56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9f8afc75-bb5f-4176-ad56-ac0e91fd1a90");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6955a786-09e2-4204-9f37-3a1bbd354188");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3385d492-8451-4414-ac40-b37ab2b618b2", "AQAAAAEAACcQAAAAEPiRS3E1tGeq97cC0szTyferE5B54t70jbz9RwnIezPaQ7tbJcgk6kIMIySuzh8nvw==", "c2dea4d1-a5cf-4f91-b388-26ca9eaad30a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6a1b50d-c257-4e2a-97ae-3f7f970faf4b", "AQAAAAEAACcQAAAAEGcqCYkenLMMH/9+DI5YTAAlNVSmCKhv41aUMg/tG7c2pd9VhWPjRFk2cZ0v/B8rfA==", "ee85cb2a-0568-4a3b-90af-bb5cde02d96f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a5ca6511-4734-48cc-9380-34a552be04a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "50477eb0-5222-4775-8faf-8e7ff6e789eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "2fd45465-1dd3-483e-9955-5a03e74214a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fed9a791-624f-4ca8-846e-7e66273e0343", "AQAAAAEAACcQAAAAEF6+An15j2xacDyk4TaFStmm1YSAtPeROjC6xmWFCDqJ2LTOl4yC0N9rhamLl5QjSQ==", "0c221bdc-2429-4e07-8a2a-43cd86906682" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "205f67be-daa3-4ed5-882e-b8360cba213e", "AQAAAAEAACcQAAAAEGJsLK4o1FjnqfCA2UFKxX8Bz1lLXII6izepf87l7XtqGw2Gde6D+gaGZIr7bqHebg==", "1147f93d-9559-4e19-bb43-c87458a3a41c" });
        }
    }
}
