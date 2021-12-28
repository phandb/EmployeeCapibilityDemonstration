using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class UpdateOneMethodManyCategoryRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Methods_MethodId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_MethodId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "MethodId",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "CategoryMethod",
                columns: table => new
                {
                    CategoriesCategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MethodId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMethod", x => new { x.CategoriesCategoryId, x.MethodId });
                    table.ForeignKey(
                        name: "FK_CategoryMethod_Categories_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryMethod_Methods_MethodId",
                        column: x => x.MethodId,
                        principalTable: "Methods",
                        principalColumn: "MethodId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMethod_MethodId",
                table: "CategoryMethod",
                column: "MethodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryMethod");

            migrationBuilder.AddColumn<string>(
                name: "MethodId",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "b9f50d55-1fa7-47e5-9d52-d8d1fa93cb2a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "17ad2f93-5723-480e-a1bf-f7354fb1f08a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "7a2c5f74-bcf0-4789-9633-2fb0f72c5785", new DateTime(2021, 12, 24, 0, 9, 11, 62, DateTimeKind.Local).AddTicks(6712), new DateTime(2021, 12, 24, 0, 9, 11, 62, DateTimeKind.Local).AddTicks(6624), "AQAAAAEAACcQAAAAEC4T0CD/9Ext+6LpOfcupi0cCMB578VoBt5XY6v/wbdV7+eDgsYsirru86/rsH4jIg==", "73018045-dc6d-457c-a750-5bd11629cb8a", new DateTime(2021, 12, 24, 0, 9, 11, 62, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "26573f1a-6fba-4b23-b1e5-c920026ee10d", new DateTime(2021, 12, 24, 0, 9, 11, 57, DateTimeKind.Local).AddTicks(4328), new DateTime(2021, 12, 24, 0, 9, 11, 57, DateTimeKind.Local).AddTicks(4264), "AQAAAAEAACcQAAAAEJZAL54VjFasg/tPoq74DCm7MapAQP3S0P5sSRAJy1Jw8GCYYzRE1EKDkTJtYlQ2VQ==", "42e5f3a1-3a85-4686-aedd-612a311b5d40", new DateTime(2021, 12, 24, 0, 9, 11, 57, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MethodId",
                table: "Categories",
                column: "MethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Methods_MethodId",
                table: "Categories",
                column: "MethodId",
                principalTable: "Methods",
                principalColumn: "MethodId");
        }
    }
}
