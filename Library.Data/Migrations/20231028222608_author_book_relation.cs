using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class author_book_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
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
                value: "910d71d8-2513-48c9-9aec-f4444049bd92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c97602eb-77e2-4bcb-b4a0-3b71d7382c79");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5f1a0d53-1df1-4734-90ae-5b8848f33204");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ea30d34-ebc6-43f4-ab40-e5edf4058666", "AQAAAAEAACcQAAAAEJz4yEae4NMGDxQKW86ZeyMY1EIH9iFlztCPI77y93cubNius3/d18L6XxRIaJ8obg==", "d30e6fee-dec1-4dc0-9005-b18d529863a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd379e2f-1a26-4ddd-a5b2-9f575a71b902", "AQAAAAEAACcQAAAAEFiA6e03mpkDIo4x4JOrmTm76w4xMBcYZxnUxgKJhCyyuveVSWCZW2wcUKX/V/TgNw==", "f66380c4-e180-4f85-824c-08e12b4295c0" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
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
                value: "231e3282-0b0d-4426-a044-4beb8cef8e69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "322ab7db-39c8-4ba0-84ab-9e9952f744be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a5473310-e08b-4857-9377-7d0605f54dc9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d705362-80a0-4473-8938-481afb248901", "AQAAAAEAACcQAAAAEMR6YYDXmHtFXNose91+/cHW1WmjzfSM6gM+Fl8IxEj14qocytH7h9B54QZoxCNRkA==", "29c40e5c-254b-4cfe-995d-3766afe85ca6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "883d27ac-d8c0-4ddb-915e-9c67e467cea3", "AQAAAAEAACcQAAAAEOU8RAM+MiODOaxVuG1lFXis7ChihA6PwLlt1C5Il4QIH3AcfWUmSGmCVGVgkFmxmg==", "1c923ab0-0883-49d5-a1dc-5dadd829f0e0" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");
        }
    }
}
