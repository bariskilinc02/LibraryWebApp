using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class bookcover : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookCoverId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookCovers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookCoverPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCovers", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookCoverId",
                table: "Books",
                column: "BookCoverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCovers_BookCoverId",
                table: "Books",
                column: "BookCoverId",
                principalTable: "BookCovers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCovers_BookCoverId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookCovers");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookCoverId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookCoverId",
                table: "Books");

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
        }
    }
}
