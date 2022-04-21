using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class Task162_Start_Creating_Task : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e5e5c88-da7c-453f-b289-9a77a79e0f7c", "d1faeb66-d59c-4e07-b4a0-b1e9402f0a8b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e5e5c88-da7c-453f-b289-9a77a79e0f7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1faeb66-d59c-4e07-b4a0-b1e9402f0a8b");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Order",
                type: "decimal(8,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d237214-aceb-481e-b698-403d0c17a95b", "7d237214-aceb-481e-b698-403d0c17a95b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3c3ac63b-c9a5-4f4e-a615-f7faaddaf9c0", 0, "e41c594f-f32c-4081-a97e-3405e360e655", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEO0k+shEJwPsfhIk9rxozkI7DEshNek2ENG6p+A4YbAtaRv0ANBLKo7cN0Rx0qjgWw==", null, false, null, "673b08f7-9c01-4297-82c2-1f1b393e47e7", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7d237214-aceb-481e-b698-403d0c17a95b", "3c3ac63b-c9a5-4f4e-a615-f7faaddaf9c0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d237214-aceb-481e-b698-403d0c17a95b", "3c3ac63b-c9a5-4f4e-a615-f7faaddaf9c0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d237214-aceb-481e-b698-403d0c17a95b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c3ac63b-c9a5-4f4e-a615-f7faaddaf9c0");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Order");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e5e5c88-da7c-453f-b289-9a77a79e0f7c", "9e5e5c88-da7c-453f-b289-9a77a79e0f7c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d1faeb66-d59c-4e07-b4a0-b1e9402f0a8b", 0, "f3f21296-cefa-4cab-b219-8a04bfcd94f5", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDRwC/6FtTzZHkeASOOcesB8s2rzE22Sgs7/+HWC35HhCTGCTWSMnTKGcp+KjIdFzg==", null, false, null, "0edcb52f-c54e-4ee3-a59c-c23514d84a5d", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9e5e5c88-da7c-453f-b289-9a77a79e0f7c", "d1faeb66-d59c-4e07-b4a0-b1e9402f0a8b" });
        }
    }
}
