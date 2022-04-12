using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class CopositeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserProduct");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8112d4f2-8ad2-41ef-8bfc-8acf11bc9d27", "f94f3071-fccc-431f-975f-d5aa5e4bd614" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8112d4f2-8ad2-41ef-8bfc-8acf11bc9d27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f94f3071-fccc-431f-975f-d5aa5e4bd614");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CartProduct",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProduct", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_CartProduct_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProductId",
                table: "AspNetUsers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_ApplicationUserId",
                table: "CartProduct",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Product_ProductId",
                table: "AspNetUsers",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Product_ProductId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CartProduct");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProductId",
                table: "AspNetUsers");

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

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "ApplicationUserProduct",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false),
                    UserCartId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserProduct", x => new { x.CartId, x.UserCartId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserProduct_AspNetUsers_UserCartId",
                        column: x => x.UserCartId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserProduct_Product_CartId",
                        column: x => x.CartId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8112d4f2-8ad2-41ef-8bfc-8acf11bc9d27", "8112d4f2-8ad2-41ef-8bfc-8acf11bc9d27", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f94f3071-fccc-431f-975f-d5aa5e4bd614", 0, "889eb84e-0a79-4624-b053-7f450e15c36f", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPpzCQmIzqIghFNChwnIN6p7Xb8FQy6lJPFFr8AdzmZLT8XLzW8699DOw8LY9mP/tw==", null, false, "99d140cb-b0db-44ce-bc14-e796d5389cf4", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8112d4f2-8ad2-41ef-8bfc-8acf11bc9d27", "f94f3071-fccc-431f-975f-d5aa5e4bd614" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserProduct_UserCartId",
                table: "ApplicationUserProduct",
                column: "UserCartId");
        }
    }
}
