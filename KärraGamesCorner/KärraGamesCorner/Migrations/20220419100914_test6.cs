using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b495115-a57f-43d1-bf29-b003554e3de2", "87e32a95-2d37-40eb-8b08-4ded4680da4a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b495115-a57f-43d1-bf29-b003554e3de2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87e32a95-2d37-40eb-8b08-4ded4680da4a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16539feb-f988-4673-8de3-3575ea482e4c", "16539feb-f988-4673-8de3-3575ea482e4c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "96ef2256-26a6-4dec-aca2-91d54a43b16a", 0, "97cafd9b-7cc4-4c2a-bf22-ed54ddc8547a", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEG4KidRG9GlBbKNzO0mlqIgjsdQ7BruaqojvO7rvnx+YxFI8QVppMRlsQdqTVkXhNA==", null, false, null, "4e986a0a-5ee5-44c2-ba55-e5ca29279ed5", false, "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51,
                column: "Price",
                value: 2990m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52,
                column: "Price",
                value: 1749m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53,
                column: "Price",
                value: 649m);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "GenreId", "ImageUrl", "IsPhysical", "Name", "Price", "Producer" },
                values: new object[] { 54, "Trådlöst haptiskt spelheadset för ultimat spelinlevelse", null, "/Resources/Images/Products/All_Images/Product_54.jpg", true, "Razer Kraken V3 Pro", 2199m, "Razor" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "16539feb-f988-4673-8de3-3575ea482e4c", "96ef2256-26a6-4dec-aca2-91d54a43b16a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "16539feb-f988-4673-8de3-3575ea482e4c", "96ef2256-26a6-4dec-aca2-91d54a43b16a" });

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54);

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
                values: new object[] { "1b495115-a57f-43d1-bf29-b003554e3de2", "1b495115-a57f-43d1-bf29-b003554e3de2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "87e32a95-2d37-40eb-8b08-4ded4680da4a", 0, "1c1b1ef1-20e1-4898-bab3-d2112454b2d2", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBvFV0aGgLHjEbuPkry8OZ343NJ1nyhL2nbD03sLa3jyEsiLHMFLsZqbDpUa/utbSA==", null, false, null, "044dea45-f2b6-4056-a37c-e6abf5eb652f", false, "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51,
                column: "Price",
                value: 400m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52,
                column: "Price",
                value: 500m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53,
                column: "Price",
                value: 800m);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1b495115-a57f-43d1-bf29-b003554e3de2", "87e32a95-2d37-40eb-8b08-4ded4680da4a" });
        }
    }
}
