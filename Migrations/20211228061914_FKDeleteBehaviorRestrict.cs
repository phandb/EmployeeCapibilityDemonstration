using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class FKDeleteBehaviorRestrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryMethod_Categories_CategoriesCategoryId",
                table: "CategoryMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryMethod_Methods_MethodId",
                table: "CategoryMethod");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "7cbc3437-3714-4f22-8752-14c03147b951");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "56c3ccee-c0ed-4f89-aaff-09123194935b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "be4a30d4-b81d-47fc-b555-4e9e7939b030", new DateTime(2021, 12, 28, 0, 19, 13, 169, DateTimeKind.Local).AddTicks(3373), new DateTime(2021, 12, 28, 0, 19, 13, 169, DateTimeKind.Local).AddTicks(3335), "AQAAAAEAACcQAAAAEPg6VviK3z5GT8rjjldG5fnSvdGVCFbxTzwaMHs1VY+14HfRf9cSs/jHrdojcRmElw==", "3b8ac819-d244-4289-b3ec-c18d07229d7c", new DateTime(2021, 12, 28, 0, 19, 13, 169, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "16f486dc-9e3a-436e-856c-7bcdf71757ce", new DateTime(2021, 12, 28, 0, 19, 13, 164, DateTimeKind.Local).AddTicks(9183), new DateTime(2021, 12, 28, 0, 19, 13, 164, DateTimeKind.Local).AddTicks(9117), "AQAAAAEAACcQAAAAEDWBkQBIAl15HzZev7yA3+D28G199xtPcQKl4nv+i+AIqagmEB+392FQ/+ny7HQtfA==", "11737788-3339-4db5-b5a3-66e267926d37", new DateTime(2021, 12, 28, 0, 19, 13, 164, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryMethod_Categories_CategoriesCategoryId",
                table: "CategoryMethod",
                column: "CategoriesCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryMethod_Methods_MethodId",
                table: "CategoryMethod",
                column: "MethodId",
                principalTable: "Methods",
                principalColumn: "MethodId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryMethod_Categories_CategoriesCategoryId",
                table: "CategoryMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryMethod_Methods_MethodId",
                table: "CategoryMethod");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "c3ef872e-d8c0-4ca1-a572-208f328a9f3d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "235f9e6e-ad7d-45d1-9b97-fba872adf8bd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "6f7d46dd-e636-4dd6-bb2b-0a1808f918d7", new DateTime(2021, 12, 27, 23, 55, 35, 598, DateTimeKind.Local).AddTicks(8461), new DateTime(2021, 12, 27, 23, 55, 35, 598, DateTimeKind.Local).AddTicks(8331), "AQAAAAEAACcQAAAAEAn/3AFMmuiu2ODscnHhFrPNb6V9/MnWKCmujkXEnBhcjQbqGxwL2IjWTH3ElXf97w==", "ff8e3ea7-f038-43ce-97b3-3ad73a440688", new DateTime(2021, 12, 27, 23, 55, 35, 598, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "ec7ef2ce-3958-4d65-a76a-5d3f5b3b4503", new DateTime(2021, 12, 27, 23, 55, 35, 593, DateTimeKind.Local).AddTicks(983), new DateTime(2021, 12, 27, 23, 55, 35, 593, DateTimeKind.Local).AddTicks(867), "AQAAAAEAACcQAAAAEJ+k0862A/yUUZd19RdCrpv5CL/AbAxQNegx2bYGXgxv3wi5y4IdrHEM9NtoSAU2Yw==", "3e137689-dbf0-4375-bf4e-f242c669d574", new DateTime(2021, 12, 27, 23, 55, 35, 593, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryMethod_Categories_CategoriesCategoryId",
                table: "CategoryMethod",
                column: "CategoriesCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryMethod_Methods_MethodId",
                table: "CategoryMethod",
                column: "MethodId",
                principalTable: "Methods",
                principalColumn: "MethodId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
