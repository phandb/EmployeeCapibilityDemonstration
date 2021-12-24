using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class ReconventionMethodCategoryRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Methods_MethodId",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "MethodId",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Methods_MethodId",
                table: "Categories",
                column: "MethodId",
                principalTable: "Methods",
                principalColumn: "MethodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Methods_MethodId",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "MethodId",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "d1506941-9ffa-4a2d-b516-83a6f3f4cf29");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "52500f39-6f03-4a2c-9e36-bebe8fe12154");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "f37bcff6-50ae-4f9b-8899-5ac47aa0ca6e", new DateTime(2021, 12, 23, 12, 19, 40, 193, DateTimeKind.Local).AddTicks(7775), new DateTime(2021, 12, 23, 12, 19, 40, 193, DateTimeKind.Local).AddTicks(7698), "AQAAAAEAACcQAAAAEN/7vtegJD1SL+HPZC7DACLji8HAWewyEsv1ERIu7IXML/Y4CbazQhXkZBbYRAzzOw==", "88c93d4f-a112-454b-979b-aa40fd112e00", new DateTime(2021, 12, 23, 12, 19, 40, 193, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "14b588ae-2225-4af6-a3e3-9e98e0b4a614", new DateTime(2021, 12, 23, 12, 19, 40, 188, DateTimeKind.Local).AddTicks(6041), new DateTime(2021, 12, 23, 12, 19, 40, 188, DateTimeKind.Local).AddTicks(5953), "AQAAAAEAACcQAAAAEP6YC0+/qLLITg28mNakVFw57atQfs3ZavwlLClt2fb3xOE7BxosHh0Am3BTInvZrw==", "1de6500c-d710-4676-bf6d-a7e769ef10a9", new DateTime(2021, 12, 23, 12, 19, 40, 188, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Methods_MethodId",
                table: "Categories",
                column: "MethodId",
                principalTable: "Methods",
                principalColumn: "MethodId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
