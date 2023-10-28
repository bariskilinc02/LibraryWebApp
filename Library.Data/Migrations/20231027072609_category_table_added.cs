using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class category_table_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c36e243c-5012-4585-8c80-a6e140f2e5f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "31f7bcea-1aff-4e63-9799-f75d76371e3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a99b4a1f-e37f-4504-90d4-c60f88d00026");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44f278fd-f3c9-4b73-a66f-ae3a5ac7b1ce", "AQAAAAEAACcQAAAAEAB4utT+zbuypyz45Y2xLC0I2O/GaHwnVjG9LhxSi5UBJvv7EJl2UQb/QycENA2DfQ==", "6ec52410-b4bb-414b-a9c6-19c316086e10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd295c87-b3fe-453f-8528-a22187844cd4", "AQAAAAEAACcQAAAAEF+sL4En/elLlO9liNQU3SW/7wPm++r8HrYfuWsHLn2cMeUpUJgFTONxhvpFZZsP1g==", "e3f233f3-39f3-4223-bf12-e3fdcfd5e3b2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a623cb2e-a921-4e3b-88ba-8028827a8f24");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ea737308-0678-47eb-ad84-b9e45c7d973e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "9a71dafa-ff44-4220-b41a-a49b6defc02a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6dd6fe5-652d-4c69-ab47-c7cfd67c7ee5", "AQAAAAEAACcQAAAAEJQiF4jOuGVdDOWcgw7xdEDLV500zKOiHsLKnaJp6Fu2w40vadvYZC3s3JLxG4za9Q==", "b887995e-6a52-4035-a55a-74001425fd91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4cdb6d5-fb77-47d1-a4f3-250f9ac8d8fc", "AQAAAAEAACcQAAAAEMJdbh895P3Qy/c5hwxxk9jm/kWZXE1TADB7pwyLj5oqWwj3LjvEm6sz10hiETvAQw==", "ec30f479-2bfd-4b58-b53b-138746a49dd1" });
        }
    }
}
