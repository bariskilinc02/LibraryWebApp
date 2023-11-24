using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class bookLanguageAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookLanguages", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookLanguages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1abb7cb2-0787-440f-a9f1-e2f4d5e3a7f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "faf8dc8e-b430-4354-8f88-b4f5884324bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "75f2dc8a-a3ed-46fa-beb4-d0fbe9997836");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f63a4621-5bd8-4cb5-a8b8-6a1066b0596c", "AQAAAAEAACcQAAAAECnJmH7N9t0HJX9kxAmSpGdaI3r6+67kwDvqXNsPdSVL2K80iMS3g0WCL91+BjYcug==", "4f4d45f0-6e24-4d3a-92c3-c9e6c36eb8e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "755656ca-14c8-423b-9f9b-135c183377a2", "AQAAAAEAACcQAAAAEM6qAoexCKmlPCgA4mS+XfUoYyiILfEni7n9WxYZM0ko/SGDnIDH29Bb7OrSTOSxXA==", "3e03842d-2386-4c23-a8b9-13cb6f69fbe9" });
        }
    }
}
