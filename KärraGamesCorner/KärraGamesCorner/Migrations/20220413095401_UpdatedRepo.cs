using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class UpdatedRepo : Migration
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
                values: new object[] { "9e5e5c88-da7c-453f-b289-9a77a79e0f7c", "9e5e5c88-da7c-453f-b289-9a77a79e0f7c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d1faeb66-d59c-4e07-b4a0-b1e9402f0a8b", 0, "f3f21296-cefa-4cab-b219-8a04bfcd94f5", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDRwC/6FtTzZHkeASOOcesB8s2rzE22Sgs7/+HWC35HhCTGCTWSMnTKGcp+KjIdFzg==", null, false, null, "0edcb52f-c54e-4ee3-a59c-c23514d84a5d", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9e5e5c88-da7c-453f-b289-9a77a79e0f7c", "d1faeb66-d59c-4e07-b4a0-b1e9402f0a8b" });

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
                keyValues: new object[] { "9e5e5c88-da7c-453f-b289-9a77a79e0f7c", "d1faeb66-d59c-4e07-b4a0-b1e9402f0a8b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e5e5c88-da7c-453f-b289-9a77a79e0f7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1faeb66-d59c-4e07-b4a0-b1e9402f0a8b");

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
