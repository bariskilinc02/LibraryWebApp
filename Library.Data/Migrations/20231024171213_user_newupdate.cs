using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class user_newupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "dd3700fb-1c71-4f08-b169-fc13af2a4802");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "636aadc5-1081-4295-8d8a-72cf30559ff9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "faec8ac9-93c1-430c-9f44-a40ec1b19d2b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15cd845a-e0fb-4b6f-be12-674ccbb497c9", "AQAAAAEAACcQAAAAEM0on1+88IW7kcFUs7VRJgbKv/Xc2SUlabct5CI7QxMAACipX8XcYlvnNIObBD3myg==", "9b267b43-58e0-476e-976c-53a3943128c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "018d62d8-fe87-472c-ac7c-706e1baa46fc", "AQAAAAEAACcQAAAAEO9YMsoKNLWkRlzL+UNXgzlSmdksmO7A0fQJXzMfznDItrsaxRltynh4F42/jOFAiQ==", "25b631ba-0daf-4e64-a72a-8af548a655b4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c6752027-c190-46e2-9829-816093b5768c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d60c8073-216a-4656-a91d-1d52d61f63b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "eadcd9c4-b7ec-4381-8697-3e8c7c72f652");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6b82eb0-f352-4211-9110-d38edc14dc35", "AQAAAAEAACcQAAAAEEQQZLslxh8n37loJhMZcBKsihC21mTs+Akckz1nieqVH7cat/9dCqqN+qgIk9+Qtg==", "a1e2612b-89cf-4cd6-86bb-1ac8a03a4cb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef76e7ba-1935-4827-8d70-90577d6de4a1", "AQAAAAEAACcQAAAAEEIA4wGJKFcGO7gDnlauPDMYHAGBjHqn+2mWd6rPmy0q6lD1r+MAeCMfGb3yIkl51g==", "c38a2d52-7f2a-450a-8398-f111a658a727" });
        }
    }
}
