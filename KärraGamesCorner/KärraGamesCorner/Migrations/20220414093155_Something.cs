using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class Something : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "795e343f-3806-4ece-9f27-06d3707249f2", "8d05da10-5e3d-42a9-b458-74dfe1b3c2ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "795e343f-3806-4ece-9f27-06d3707249f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d05da10-5e3d-42a9-b458-74dfe1b3c2ce");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d9945d6-c253-4671-8977-ff61debb0ecc", "4d9945d6-c253-4671-8977-ff61debb0ecc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f7dd7f4c-942e-4422-a7e1-51fa11a19773", 0, "4b5754cc-30b8-4793-96ec-5fabb054cf4f", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEIdOMBu+cHhxt1vnN4kbKvXrYmpeUYpFMzF3WJaOEWvyV9uU5ABRjIpJ7p1XiXPSPg==", null, false, null, "2b4ac3f6-936b-44a3-bb85-28431ce58990", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d9945d6-c253-4671-8977-ff61debb0ecc", "f7dd7f4c-942e-4422-a7e1-51fa11a19773" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d9945d6-c253-4671-8977-ff61debb0ecc", "f7dd7f4c-942e-4422-a7e1-51fa11a19773" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d9945d6-c253-4671-8977-ff61debb0ecc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7dd7f4c-942e-4422-a7e1-51fa11a19773");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "795e343f-3806-4ece-9f27-06d3707249f2", "795e343f-3806-4ece-9f27-06d3707249f2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8d05da10-5e3d-42a9-b458-74dfe1b3c2ce", 0, "5cc20ff9-ef43-43b1-83a9-4adb66ae8b1a", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEILtkA7c+My9ZFJr9Roj3GDNEnPGe6qz4InYDczeclsWP7X7MbRevvtoVQtiF7iSNg==", null, false, null, "6e882a3c-2367-4bae-b66f-00f1352abfa1", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "795e343f-3806-4ece-9f27-06d3707249f2", "8d05da10-5e3d-42a9-b458-74dfe1b3c2ce" });
        }
    }
}
