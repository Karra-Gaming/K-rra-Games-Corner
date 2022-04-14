using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class test123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57034861-89f1-473b-b5b0-a1a753f9e225", "51286879-85ae-4052-b78c-5660cb011cc4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57034861-89f1-473b-b5b0-a1a753f9e225");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51286879-85ae-4052-b78c-5660cb011cc4");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "CartProduct",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderOfDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5069e1e6-74de-47f3-97a2-add16b8d16ea", "5069e1e6-74de-47f3-97a2-add16b8d16ea", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "550964e4-d5a6-4480-b1d4-9f237b5e2831", 0, "7586dc10-05bd-4b75-b0c3-ddbe84613806", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENnaiJCR+8LCMIJsb0yQPoWRqnPl+z8zsVEWXGo3CiowxrlMiiPZRTL4vDUDQFCjvw==", null, false, null, "4a27ef8f-dbac-4a0a-b975-1b2f3e600803", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5069e1e6-74de-47f3-97a2-add16b8d16ea", "550964e4-d5a6-4480-b1d4-9f237b5e2831" });

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_OrderId",
                table: "CartProduct",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Order_OrderId",
                table: "CartProduct",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Order_OrderId",
                table: "CartProduct");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_CartProduct_OrderId",
                table: "CartProduct");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5069e1e6-74de-47f3-97a2-add16b8d16ea", "550964e4-d5a6-4480-b1d4-9f237b5e2831" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5069e1e6-74de-47f3-97a2-add16b8d16ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "550964e4-d5a6-4480-b1d4-9f237b5e2831");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "CartProduct");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57034861-89f1-473b-b5b0-a1a753f9e225", "57034861-89f1-473b-b5b0-a1a753f9e225", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "51286879-85ae-4052-b78c-5660cb011cc4", 0, "a177760f-9ffb-415d-870a-c9611b0676c1", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBvLSzi3Wd5cjzDo4ImB10LLfc9gXW9OeODTDNgZ7jgCgKagF+XK0HNuhodyE0U1vw==", null, false, null, "21e087ae-d1b9-4f53-a656-2e5a1a7181f5", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "57034861-89f1-473b-b5b0-a1a753f9e225", "51286879-85ae-4052-b78c-5660cb011cc4" });
        }
    }
}
