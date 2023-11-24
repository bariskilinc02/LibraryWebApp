using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class book_language_connected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookLanguages_BookLanguageId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "BookLanguageId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookLanguages_BookLanguageId",
                table: "Books",
                column: "BookLanguageId",
                principalTable: "BookLanguages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookLanguages_BookLanguageId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "BookLanguageId",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f7db77a0-d597-4304-8034-98bc18e43cba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "35761449-36cd-41b1-b9bd-b0d2ef3c7f02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "8cfb5237-4a7b-4f69-b9cd-51abb2b0a264");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e14c34a-3c45-49ca-abaa-af61bf4f7cc4", "AQAAAAEAACcQAAAAEJY/SpBWCv1MG/jqj1AmHwifeYKIVByqcAyez4HiDfax5q3zNhthbGv7rp3WFN5qzg==", "e061bb4b-07d8-42c5-9ea6-b71cf6e74f30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbdf9fc5-da18-49d0-8d9d-e3a980369c20", "AQAAAAEAACcQAAAAEEypWMS1G5j9vlMucztc2/w+XsMvgifIdlHBhvHMIrKXIKDBI4NwjxwLhB/K12B4ew==", "3f7c963e-b481-47fa-ac92-78feeb834e01" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookLanguages_BookLanguageId",
                table: "Books",
                column: "BookLanguageId",
                principalTable: "BookLanguages",
                principalColumn: "Id");
        }
    }
}
