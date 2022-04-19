using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Genre_GenreId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c482a8b-d5c1-4009-ad90-b3a15ffd1fa6", "2545616f-08ae-48d3-8a70-24314092f517" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c482a8b-d5c1-4009-ad90-b3a15ffd1fa6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2545616f-08ae-48d3-8a70-24314092f517");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dcf90e9a-7d72-497d-8633-1baa510c2e19", "dcf90e9a-7d72-497d-8633-1baa510c2e19", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "17acf601-63c8-4810-b311-a2a4fe8a4a38", 0, "d36dfe1b-451e-4de9-b30a-1b564714baa0", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOuKwzBVi0Z/c6Z+ULgoQDWbKt9XnLJXLKhmf52dpSyvF2UAfy/LoHzhTwXznX7IgA==", null, false, null, "ce42bf48-f775-4f5a-b7e5-05e849e90db7", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "GenreId", "ImageUrl", "IsPhysical", "Name", "Price", "Producer" },
                values: new object[] { 51, "Huntsman med analoga och optiska switchar", null, "/Resources/Images/Products/All_Images/Product_51.avif", true, "Razer Huntsman V2 Analog", 400m, "Razor" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dcf90e9a-7d72-497d-8633-1baa510c2e19", "17acf601-63c8-4810-b311-a2a4fe8a4a38" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Genre_GenreId",
                table: "Product",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Genre_GenreId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dcf90e9a-7d72-497d-8633-1baa510c2e19", "17acf601-63c8-4810-b311-a2a4fe8a4a38" });

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcf90e9a-7d72-497d-8633-1baa510c2e19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17acf601-63c8-4810-b311-a2a4fe8a4a38");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c482a8b-d5c1-4009-ad90-b3a15ffd1fa6", "3c482a8b-d5c1-4009-ad90-b3a15ffd1fa6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2545616f-08ae-48d3-8a70-24314092f517", 0, "fdc688a9-c2fa-4787-a941-f1cd3f6645b9", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEAZKdot0YYMAZ3wkUFQJqdTWh1qw0iJSr9SS2Q9p1rBvY05GHpI9w9gfdxhEVL/Zew==", null, false, null, "292b75d1-0190-4c95-a584-761892b191e0", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3c482a8b-d5c1-4009-ad90-b3a15ffd1fa6", "2545616f-08ae-48d3-8a70-24314092f517" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Genre_GenreId",
                table: "Product",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
