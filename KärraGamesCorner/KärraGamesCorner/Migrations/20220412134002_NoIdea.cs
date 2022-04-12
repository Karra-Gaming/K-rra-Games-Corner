using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class NoIdea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57079364-671b-4ec1-8917-bc08cc617976", "7be77e7c-25bb-4f4c-9db5-9ffb8fe12a08" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57079364-671b-4ec1-8917-bc08cc617976");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7be77e7c-25bb-4f4c-9db5-9ffb8fe12a08");

            migrationBuilder.AddColumn<bool>(
                name: "IsPhysical",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "557c23b1-65e8-4c5e-a834-4b35a4004308", "557c23b1-65e8-4c5e-a834-4b35a4004308", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9da6dec2-1c4e-4193-b9c9-29f6407b3d96", 0, "c0e58d5a-5bab-4ff9-aafc-26b6f4b9f33d", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENGrSmAbNXesMxefJrz8vVW9e9dfxZ6boH3guUBRsFFm5lRJge89NOb/X0u8jkoDVg==", null, false, null, "e55d2b23-9623-45f6-802d-7e8870a8e2eb", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "557c23b1-65e8-4c5e-a834-4b35a4004308", "9da6dec2-1c4e-4193-b9c9-29f6407b3d96" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "557c23b1-65e8-4c5e-a834-4b35a4004308", "9da6dec2-1c4e-4193-b9c9-29f6407b3d96" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "557c23b1-65e8-4c5e-a834-4b35a4004308");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9da6dec2-1c4e-4193-b9c9-29f6407b3d96");

            migrationBuilder.DropColumn(
                name: "IsPhysical",
                table: "Product");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57079364-671b-4ec1-8917-bc08cc617976", "57079364-671b-4ec1-8917-bc08cc617976", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7be77e7c-25bb-4f4c-9db5-9ffb8fe12a08", 0, "4980efea-3e88-4d93-ae13-f41da657dad4", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELDFF91bktN1XcdPdjOJWNCF3HCD8M+XWBVMjJYKJOWqUtnnoOHLgGQ6kcI+4DTXrw==", null, false, null, "3f049847-3b3b-4fa4-9e65-14c8f807d0be", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "57079364-671b-4ec1-8917-bc08cc617976", "7be77e7c-25bb-4f4c-9db5-9ffb8fe12a08" });
        }
    }
}
