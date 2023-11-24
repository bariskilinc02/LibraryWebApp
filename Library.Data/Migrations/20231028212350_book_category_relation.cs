using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class book_category_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "18ddd80d-dd25-4a7f-87b3-c6876dc10cc3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e5029c21-85a6-49d7-91fe-f7275f2c0015");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "676542f3-4eed-4518-af12-5d25759210b2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e845e654-7608-4dff-9088-3daaef458cdc", "AQAAAAEAACcQAAAAEPTYGd1wD6Lk/vDECsdYIhpIBznzeMd4QYVbe94S+ityoAsVbLC2VPce7hW3mXRPqg==", "a51c5442-e96c-401e-a8aa-a07eb01ee52e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac17edb9-653c-42eb-a37c-ff2b2520f2d7", "AQAAAAEAACcQAAAAEJ1SUQedWY4HKH8objnm2AJO4Ltm6cEO0f8sGTjzvJday97hAh4ceFXCOJnEhoNQPQ==", "d13051a2-b975-49f2-9c72-a22d4f20e212" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryId",
                table: "Books");

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
    }
}
