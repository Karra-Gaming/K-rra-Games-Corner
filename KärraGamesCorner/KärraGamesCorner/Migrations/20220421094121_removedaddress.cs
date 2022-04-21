using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class removedaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c34bf244-0174-4d78-8996-17da8bb59119", "7ede46ae-1952-4ff1-bd77-f497ccb3fad1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c34bf244-0174-4d78-8996-17da8bb59119");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ede46ae-1952-4ff1-bd77-f497ccb3fad1");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Order");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "766341c6-f84e-4530-a935-5f3b0baade4f", "766341c6-f84e-4530-a935-5f3b0baade4f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "21e88c45-b0d5-4e9c-8a6b-d1583912c6ba", 0, "4664a4b2-7905-4073-b408-4e3181a8bf9a", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELLEnfMpl1oIYijaj2r4C3D5ZpZjxtOEj/U2QwgAvl0RSiTTmv4SJQaerlnXZej5NQ==", null, false, null, "997780b5-a959-4565-b6bf-957c1d831588", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "766341c6-f84e-4530-a935-5f3b0baade4f", "21e88c45-b0d5-4e9c-8a6b-d1583912c6ba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "766341c6-f84e-4530-a935-5f3b0baade4f", "21e88c45-b0d5-4e9c-8a6b-d1583912c6ba" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "766341c6-f84e-4530-a935-5f3b0baade4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21e88c45-b0d5-4e9c-8a6b-d1583912c6ba");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c34bf244-0174-4d78-8996-17da8bb59119", "c34bf244-0174-4d78-8996-17da8bb59119", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7ede46ae-1952-4ff1-bd77-f497ccb3fad1", 0, "fc8e4d90-0543-410c-8cda-a8d8e4d0c79a", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGhwJoY7acsVOR9LdnA0r2dNNQ4P33ctf3LfTz6tUScarbwNjwFfqxu4PViFpiCjZA==", null, false, null, "fc86aad0-c687-4614-b262-0e0064d7ce35", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c34bf244-0174-4d78-8996-17da8bb59119", "7ede46ae-1952-4ff1-bd77-f497ccb3fad1" });
        }
    }
}
