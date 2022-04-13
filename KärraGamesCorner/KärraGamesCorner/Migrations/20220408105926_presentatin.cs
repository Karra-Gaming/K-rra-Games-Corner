using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class presentatin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ff92b11-d124-4993-9c56-7e59caede9a8", "c9146dcb-33dd-486f-a474-89f3350e3968" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ff92b11-d124-4993-9c56-7e59caede9a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9146dcb-33dd-486f-a474-89f3350e3968");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e4a1e3b-1a09-431d-ac77-2db5642d2884", "0e4a1e3b-1a09-431d-ac77-2db5642d2884", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f9ae95ad-d872-4d2c-b0f9-754e703704fd", 0, "366120cb-568a-4552-8811-cc350f130fdf", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGjO4Hgy/3hYu/RMS3ARSHITXxr0Qwdxz2Oq86osWQIAREXsOUhcEG2zqaJ8zsU7QQ==", null, false, "f3593a72-a427-4265-881d-9a1c20192b49", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0e4a1e3b-1a09-431d-ac77-2db5642d2884", "f9ae95ad-d872-4d2c-b0f9-754e703704fd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e4a1e3b-1a09-431d-ac77-2db5642d2884", "f9ae95ad-d872-4d2c-b0f9-754e703704fd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e4a1e3b-1a09-431d-ac77-2db5642d2884");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9ae95ad-d872-4d2c-b0f9-754e703704fd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ff92b11-d124-4993-9c56-7e59caede9a8", "5ff92b11-d124-4993-9c56-7e59caede9a8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c9146dcb-33dd-486f-a474-89f3350e3968", 0, "fd096154-eac0-4651-844a-2e7fe21f3565", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPNBL+0yDA6PdynS4qw6Eku74nfzjknzsGj0F/1x1nSe855kKFefFc0UwGfJ5tcinQ==", null, false, "032e8cc0-01c0-4da4-a7f3-502eef5978b6", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ff92b11-d124-4993-9c56-7e59caede9a8", "c9146dcb-33dd-486f-a474-89f3350e3968" });
        }
    }
}
