using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class bookcover_book_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCovers_BookCoverId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "BookCoverId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCovers_BookCoverId",
                table: "Books",
                column: "BookCoverId",
                principalTable: "BookCovers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCovers_BookCoverId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "BookCoverId",
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
                value: "2ac544ca-bee0-498a-9014-f11739de9ff1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "638c6156-1599-4ec8-b581-a71af73f7147");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c1f430ab-d0ab-4dbd-a2d8-9834e63b379e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65a410f4-bf82-45f0-b5f6-f64c249e505e", "AQAAAAEAACcQAAAAEIWtP/Rrw0C/4abWVW9XdcpCsqCWQPxIaYoUnYC293+ddh0ew4awuUDiw6eu9PFpZA==", "8e84d090-7eb7-4f55-9040-35453513e0b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "491a5dac-af4a-465d-8fcc-03911443fba5", "AQAAAAEAACcQAAAAEIn+WfpI+awtU9xyK2/aqTqh+4gOfczLXJekxLp3q5K4lcOiYse7lhCyveCvojFMHw==", "f11a62ff-610a-4a0c-b012-82f709554175" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCovers_BookCoverId",
                table: "Books",
                column: "BookCoverId",
                principalTable: "BookCovers",
                principalColumn: "Id");
        }
    }
}
