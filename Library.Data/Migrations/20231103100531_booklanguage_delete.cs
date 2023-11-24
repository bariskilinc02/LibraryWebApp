using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class booklanguage_delete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookLanguageId",
                table: "Books",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookLanguageId",
                table: "Books",
                column: "BookLanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookLanguages_BookLanguageId",
                table: "Books",
                column: "BookLanguageId",
                principalTable: "BookLanguages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookLanguages_BookLanguageId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookLanguageId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookLanguageId",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "19c8dfaa-305b-4301-be9e-41f6a900434e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5fbc044e-d4de-4815-ba06-9426381df160");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f2c09350-c312-46de-8f72-bbc08df55702");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8438ff1-d5ba-4297-8906-c6d248c0ca39", "AQAAAAEAACcQAAAAEEst5vc2RIDSuSyv9tGGq+uPBpnw4ArwOn2QSAWRMO4LmGxbe/MRD8wOdjQAIIc3lg==", "40ba9aa8-289d-4daa-98b5-9243a8a6926b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e1dda6f-39a6-4911-bfac-4861708053b8", "AQAAAAEAACcQAAAAECVNxr9GG0VkQAF+JTm7dbQooatsg6mtiK+flF7iP9eF8IzsWxn3fA0Igsu3rdKqIQ==", "56779ef9-e4b7-49cf-987c-294e7f2b64c0" });
        }
    }
}
