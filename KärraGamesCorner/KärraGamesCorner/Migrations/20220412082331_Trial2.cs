using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class Trial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6b40a84-e697-4391-ab3b-7c23ce7cb413", "bb45565e-76a4-44c5-b848-959d58881b02" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6b40a84-e697-4391-ab3b-7c23ce7cb413");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb45565e-76a4-44c5-b848-959d58881b02");

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
                keyValue: 1,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_1.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_2.png");

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
                keyValue: 6,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_6.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_7.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_8.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_9.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_10.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_11.png");

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
                keyValue: 14,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_14.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_15.png");

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
                keyValue: 21,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_21.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_22.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_23.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_24.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_25.png");

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
                keyValue: 29,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_29.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_30.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_31.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_32.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_33.png");

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
                keyValue: 36,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_36.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_37.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_38.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_39.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_40.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_41.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_42.png");

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
                keyValue: 45,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_45.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_46.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "/Resources/Images/Products/All_Images/Product_47.png");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "b6b40a84-e697-4391-ab3b-7c23ce7cb413", "b6b40a84-e697-4391-ab3b-7c23ce7cb413", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bb45565e-76a4-44c5-b848-959d58881b02", 0, "d58a4574-424e-4c64-b796-dcee55cf877c", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDqCqzZoCEkoOVqVe3oZ7kA2zJfEodgtNeaxDlU6PPBOsgZAeITbIPxfVMhsaMVxoQ==", null, false, "979679f5-f29b-4a93-8382-8a0cb44ace0a", false, "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/Resources/Images/Products/All_Images/Product_1.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/Resources/Images/Products/All_Images/Product_2.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/Resources/Images/Products/All_Images/Product_3.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "~/Resources/Images/Products/All_Images/Product_4.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "~/Resources/Images/Products/All_Images/Product_5.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "~/Resources/Images/Products/All_Images/Product_6.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: "");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b6b40a84-e697-4391-ab3b-7c23ce7cb413", "bb45565e-76a4-44c5-b848-959d58881b02" });
        }
    }
}
