using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dcf90e9a-7d72-497d-8633-1baa510c2e19", "17acf601-63c8-4810-b311-a2a4fe8a4a38" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcf90e9a-7d72-497d-8633-1baa510c2e19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17acf601-63c8-4810-b311-a2a4fe8a4a38");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f99fb9fd-9017-4d03-b859-aaba73eb4333", "f99fb9fd-9017-4d03-b859-aaba73eb4333", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6682611b-9c78-4252-aee4-79e5ba54e401", 0, "5a861dc7-4872-4c5a-97b9-a3ee2bc1b1bb", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEN6ngmiUuL+xDoT75QivmyctQHxbGhTSqrBQ3kF9HvFV3k7oCZ0EbQeEDmczOXVq8g==", null, false, null, "ecf59bd1-29de-4c19-a65f-82c2af26a26d", false, "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_51.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f99fb9fd-9017-4d03-b859-aaba73eb4333", "6682611b-9c78-4252-aee4-79e5ba54e401" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "dcf90e9a-7d72-497d-8633-1baa510c2e19", "dcf90e9a-7d72-497d-8633-1baa510c2e19", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "17acf601-63c8-4810-b311-a2a4fe8a4a38", 0, "d36dfe1b-451e-4de9-b30a-1b564714baa0", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOuKwzBVi0Z/c6Z+ULgoQDWbKt9XnLJXLKhmf52dpSyvF2UAfy/LoHzhTwXznX7IgA==", null, false, null, "ce42bf48-f775-4f5a-b7e5-05e849e90db7", false, "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_51.avif");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dcf90e9a-7d72-497d-8633-1baa510c2e19", "17acf601-63c8-4810-b311-a2a4fe8a4a38" });
        }
    }
}
