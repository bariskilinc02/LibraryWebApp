using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    /// <inheritdoc />
    public partial class user_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "surname",
                table: "Users",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Users",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Users",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "last_login",
                table: "Users",
                newName: "LastLogin");

            migrationBuilder.RenameColumn(
                name: "account_create_time",
                table: "Users",
                newName: "AccountCreateTime");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ce8b3e9e-c26c-47c7-abb6-ab6e9e51784b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c3d75d2a-ea7d-4521-9a3b-1690749e0d05");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "87626408-05ba-4d19-9fa8-6c49e595b3d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b6ab66b-4218-4a84-a8c5-6950baae5fef", "AQAAAAEAACcQAAAAEOOATahccAC/lndJcl/y5UWlk7vuknWxQd3kE5mxZzhXfw/Yjqk1uA6ZTIWaGqW91Q==", "55c353cc-1336-43c0-ae5c-94aeb427339e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d41865d-aed7-4446-a130-bb8b7dfcbba0", "AQAAAAEAACcQAAAAED6hJ7OMKp53WU5E3+KlNFzt4bME+sEk2phY4FLJzga2LsUtG18S8XSiaA9inwKcGw==", "b765ed0e-e38b-41af-af7a-8639c724c66e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Users",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "LastLogin",
                table: "Users",
                newName: "last_login");

            migrationBuilder.RenameColumn(
                name: "AccountCreateTime",
                table: "Users",
                newName: "account_create_time");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "14abbbda-d870-4466-b9bb-fdbb7920be56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9f8afc75-bb5f-4176-ad56-ac0e91fd1a90");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6955a786-09e2-4204-9f37-3a1bbd354188");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3385d492-8451-4414-ac40-b37ab2b618b2", "AQAAAAEAACcQAAAAEPiRS3E1tGeq97cC0szTyferE5B54t70jbz9RwnIezPaQ7tbJcgk6kIMIySuzh8nvw==", "c2dea4d1-a5cf-4f91-b388-26ca9eaad30a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6a1b50d-c257-4e2a-97ae-3f7f970faf4b", "AQAAAAEAACcQAAAAEGcqCYkenLMMH/9+DI5YTAAlNVSmCKhv41aUMg/tG7c2pd9VhWPjRFk2cZ0v/B8rfA==", "ee85cb2a-0568-4a3b-90af-bb5cde02d96f" });
        }
    }
}
