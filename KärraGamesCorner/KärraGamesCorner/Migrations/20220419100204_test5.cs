using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f99fb9fd-9017-4d03-b859-aaba73eb4333", "6682611b-9c78-4252-aee4-79e5ba54e401" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f99fb9fd-9017-4d03-b859-aaba73eb4333");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6682611b-9c78-4252-aee4-79e5ba54e401");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b495115-a57f-43d1-bf29-b003554e3de2", "1b495115-a57f-43d1-bf29-b003554e3de2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "87e32a95-2d37-40eb-8b08-4ded4680da4a", 0, "1c1b1ef1-20e1-4898-bab3-d2112454b2d2", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBvFV0aGgLHjEbuPkry8OZ343NJ1nyhL2nbD03sLa3jyEsiLHMFLsZqbDpUa/utbSA==", null, false, null, "044dea45-f2b6-4056-a37c-e6abf5eb652f", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "GenreId", "ImageUrl", "IsPhysical", "Name", "Price", "Producer" },
                values: new object[,]
                {
                    { 52, "Trådlös mus med utbytbar sidopanel", null, "/Resources/Images/Products/All_Images/Product_52.jpg", true, "Razer Naga Pro MOBA/MMO", 500m, "Razor" },
                    { 53, "Musmatta med RGB-belysning", null, "/Resources/Images/Products/All_Images/Product_53.jpg", true, "Razer Firefly V2", 800m, "Razor" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1b495115-a57f-43d1-bf29-b003554e3de2", "87e32a95-2d37-40eb-8b08-4ded4680da4a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b495115-a57f-43d1-bf29-b003554e3de2", "87e32a95-2d37-40eb-8b08-4ded4680da4a" });

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53);

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
                values: new object[] { "f99fb9fd-9017-4d03-b859-aaba73eb4333", "f99fb9fd-9017-4d03-b859-aaba73eb4333", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6682611b-9c78-4252-aee4-79e5ba54e401", 0, "5a861dc7-4872-4c5a-97b9-a3ee2bc1b1bb", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEN6ngmiUuL+xDoT75QivmyctQHxbGhTSqrBQ3kF9HvFV3k7oCZ0EbQeEDmczOXVq8g==", null, false, null, "ecf59bd1-29de-4c19-a65f-82c2af26a26d", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f99fb9fd-9017-4d03-b859-aaba73eb4333", "6682611b-9c78-4252-aee4-79e5ba54e401" });
        }
    }
}
