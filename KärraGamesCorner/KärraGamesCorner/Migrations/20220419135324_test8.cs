using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class test8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "16539feb-f988-4673-8de3-3575ea482e4c", "96ef2256-26a6-4dec-aca2-91d54a43b16a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16539feb-f988-4673-8de3-3575ea482e4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96ef2256-26a6-4dec-aca2-91d54a43b16a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cf64468-00a2-411b-b806-dd92d04e0b87", "6cf64468-00a2-411b-b806-dd92d04e0b87", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6de90be0-3e29-4578-b91e-d502b8b1e7eb", 0, "3f4244da-2e9b-4d8c-ac08-c955208aaa12", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAED4yt8ktrr0la/WJAeksiMrc+bIvNIvPKMF6Gela7NDBFOPkBWhBiflIrfu0hkDBww==", null, false, null, "cb2e3b5d-1130-438f-986b-00598c158bdf", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6cf64468-00a2-411b-b806-dd92d04e0b87", "6de90be0-3e29-4578-b91e-d502b8b1e7eb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cf64468-00a2-411b-b806-dd92d04e0b87", "6de90be0-3e29-4578-b91e-d502b8b1e7eb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cf64468-00a2-411b-b806-dd92d04e0b87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6de90be0-3e29-4578-b91e-d502b8b1e7eb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16539feb-f988-4673-8de3-3575ea482e4c", "16539feb-f988-4673-8de3-3575ea482e4c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "96ef2256-26a6-4dec-aca2-91d54a43b16a", 0, "97cafd9b-7cc4-4c2a-bf22-ed54ddc8547a", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEG4KidRG9GlBbKNzO0mlqIgjsdQ7BruaqojvO7rvnx+YxFI8QVppMRlsQdqTVkXhNA==", null, false, null, "4e986a0a-5ee5-44c2-ba55-e5ca29279ed5", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "16539feb-f988-4673-8de3-3575ea482e4c", "96ef2256-26a6-4dec-aca2-91d54a43b16a" });
        }
    }
}
