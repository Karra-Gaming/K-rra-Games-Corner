using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class Trial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2eef4c53-4968-4b1b-b01d-3fe24efe8da5", "ced72c51-7481-42bd-9c4c-4fef5da49b33" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2eef4c53-4968-4b1b-b01d-3fe24efe8da5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ced72c51-7481-42bd-9c4c-4fef5da49b33");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8112d4f2-8ad2-41ef-8bfc-8acf11bc9d27", "8112d4f2-8ad2-41ef-8bfc-8acf11bc9d27", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f94f3071-fccc-431f-975f-d5aa5e4bd614", 0, "889eb84e-0a79-4624-b053-7f450e15c36f", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPpzCQmIzqIghFNChwnIN6p7Xb8FQy6lJPFFr8AdzmZLT8XLzW8699DOw8LY9mP/tw==", null, false, "99d140cb-b0db-44ce-bc14-e796d5389cf4", false, "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_3.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_4.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_5.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_8.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_10.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_12.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_13.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_16.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_17.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_18.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_19.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_20.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_26.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_27.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_28.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_32.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_34.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_35.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_38.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_41.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_43.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_44.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_46.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_48.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_49.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_50.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8112d4f2-8ad2-41ef-8bfc-8acf11bc9d27", "f94f3071-fccc-431f-975f-d5aa5e4bd614" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2eef4c53-4968-4b1b-b01d-3fe24efe8da5", "2eef4c53-4968-4b1b-b01d-3fe24efe8da5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ced72c51-7481-42bd-9c4c-4fef5da49b33", 0, "f84127e9-f905-4bf3-90da-51516c1f636d", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELQoAoaVWRrzuIVJEPd3sktPUtp2XElnO2GvnXGFnqW8noGGd/4C7zWZr9/wctYAsg==", null, false, "6e0b6609-673b-485d-9704-8ff6baa0e639", false, "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_3.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_4.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_5.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_8.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_10.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_12.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_13.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_16.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_17.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_18.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_19.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_20.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_26.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_27.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_28.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_32.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_34.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_35.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_38.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_41.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_43.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_44.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_46.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_48.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_49.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_50.png");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2eef4c53-4968-4b1b-b01d-3fe24efe8da5", "ced72c51-7481-42bd-9c4c-4fef5da49b33" });
        }
    }
}
