using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class AddCategoryToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMethod_AspNetUsers_Id",
                table: "EmployeeMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeMethod",
                table: "EmployeeMethod");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Methods",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "EmployeeMethod",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeMethod",
                table: "EmployeeMethod",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "5f2a893e-2930-42b0-b4e4-b35d03b13089");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "e524b165-e9db-4cef-aee6-6c8003c5afa2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "0541e902-a9c6-4ec3-ba83-e011d1a4fa1e", new DateTime(2021, 12, 31, 15, 45, 4, 130, DateTimeKind.Local).AddTicks(4083), new DateTime(2021, 12, 31, 15, 45, 4, 130, DateTimeKind.Local).AddTicks(4065), "AQAAAAEAACcQAAAAEAngIydi8yK4Y3E2tJI+//OhWO9bcPcLXKON2vNuleIYgUw9R5d/aNS9QBmXth5c5g==", "d0d58eaf-8529-4e22-ac60-1737c53fc7f0", new DateTime(2021, 12, 31, 15, 45, 4, 130, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "500bf10a-48ad-402d-9e4d-73cabf8059b6", new DateTime(2021, 12, 31, 15, 45, 4, 127, DateTimeKind.Local).AddTicks(5646), new DateTime(2021, 12, 31, 15, 45, 4, 127, DateTimeKind.Local).AddTicks(5599), "AQAAAAEAACcQAAAAEAqBS82Oq29bwO6Ld8CLJZPeBu8mNh0DDzQQGAjFDnhcF2DSFNXck24l1AzK8G9lIw==", "ba2d391e-69f8-4312-b6a5-7e0412d743aa", new DateTime(2021, 12, 31, 15, 45, 4, 127, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.CreateIndex(
                name: "IX_Methods_EmployeeId",
                table: "Methods",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMethod_EmployeeId",
                table: "EmployeeMethod",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_EmployeeId",
                table: "Categories",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_EmployeeId",
                table: "Categories",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMethod_AspNetUsers_EmployeeId",
                table: "EmployeeMethod",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Methods_AspNetUsers_EmployeeId",
                table: "Methods",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_EmployeeId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMethod_AspNetUsers_EmployeeId",
                table: "EmployeeMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_Methods_AspNetUsers_EmployeeId",
                table: "Methods");

            migrationBuilder.DropIndex(
                name: "IX_Methods_EmployeeId",
                table: "Methods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeMethod",
                table: "EmployeeMethod");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeMethod_EmployeeId",
                table: "EmployeeMethod");

            migrationBuilder.DropIndex(
                name: "IX_Categories_EmployeeId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Methods");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeMethod");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeMethod",
                table: "EmployeeMethod",
                columns: new[] { "Id", "MethodId" });

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
                name: "FK_EmployeeMethod_AspNetUsers_Id",
                table: "EmployeeMethod",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
