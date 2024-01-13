using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class favoritebookaddingagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "646562c7-bcb6-43d3-bb37-bb83b11373b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "926433f1-f5bf-42f8-9644-5dd84eb11012");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "47a77eff-63aa-45c4-ab43-5ba05f937167");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b706a2c0-5640-4f9e-93b2-b82829115823", "AQAAAAEAACcQAAAAEKWw/iI8K/W/OF/krcJAjyy/X8YyzSaEgCN+g77lf5gHKskhf80laCQkxpCN4WMW0g==", "8cf5ab64-809a-444e-9c5d-21701286481f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c1aea75-8dc9-4ac3-9227-09d95f65813c", "AQAAAAEAACcQAAAAEJ7jIr94mpdfZ9gJnf9mf6l0jvTUdYiGbsJVAC8EF+KoCI4yDtzV9Oql8MslghqQmQ==", "dfc140ab-399d-4a14-8db8-907c01537bf2" });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_BookId",
                table: "FavoriteBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_UserId",
                table: "FavoriteBooks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteBooks");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "85bb7188-3f93-490b-9c84-82e8cc0a4d3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3890a84c-71b8-493d-9246-44ae56a09b4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0e3a135a-82f7-42f7-b69b-36579151f214");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fceb68a-6a99-407c-8c92-d3b1468aea09", "AQAAAAEAACcQAAAAEMsCxzXpqUBZD2aRsBbHNCtLKhMEzxTiyMfGsLU09QFsuD3f2tkyFWGcow+Y12iddA==", "bc32bcef-a16a-41cc-8aa1-ecda11f40cbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4f6a5a6-139a-4597-a265-3a6a664fdbe0", "AQAAAAEAACcQAAAAEAZTHYnR/3i8ODRNeusYchME0NPj4zzOBAhcnsZLmAG/NZI1nITwHNjqAg++uzcpcw==", "657645ec-f4d5-4fea-afbc-540f4e71197b" });
        }
    }
}
