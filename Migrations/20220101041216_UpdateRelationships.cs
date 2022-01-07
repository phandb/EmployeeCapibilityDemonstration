using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class UpdateRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "CategoryMethod");

            migrationBuilder.DropIndex(
                name: "IX_Methods_EmployeeId",
                table: "Methods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeMethod",
                table: "EmployeeMethod");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeMethod_EmployeeId",
                table: "EmployeeMethod");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Methods");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeMethod");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Categories",
                newName: "MethodId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_EmployeeId",
                table: "Categories",
                newName: "IX_Categories_MethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeMethod",
                table: "EmployeeMethod",
                columns: new[] { "Id", "MethodId" });

            migrationBuilder.CreateTable(
                name: "EmployeeCategory",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCategory", x => new { x.Id, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_EmployeeCategory_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "c3efeb22-04c0-486d-abb0-0f8df7c3f6c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "cbfa0684-593f-4f1e-ace1-8acfce9c41e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "b986583e-9745-41a7-bd1c-76df2bd8900b", new DateTime(2021, 12, 31, 22, 12, 15, 321, DateTimeKind.Local).AddTicks(3304), new DateTime(2021, 12, 31, 22, 12, 15, 321, DateTimeKind.Local).AddTicks(3231), "AQAAAAEAACcQAAAAEPg/yCWD7T30GFsjmnx47GvtYeAKz3LFIS7W7MhMnyozZExC6y97CvzdNKIcrtLWpA==", "557cd431-2f32-43fc-bc47-d7832f46d34b", new DateTime(2021, 12, 31, 22, 12, 15, 321, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "22a4ead9-067d-46d3-9693-28dd31f3084b", new DateTime(2021, 12, 31, 22, 12, 15, 316, DateTimeKind.Local).AddTicks(4060), new DateTime(2021, 12, 31, 22, 12, 15, 316, DateTimeKind.Local).AddTicks(4002), "AQAAAAEAACcQAAAAEEdO7/r1kfKr/fT2QC95ra+lnAbRZYkLiHs89T4kFQrvlgtM7fOlpYGzF9QAATcBqQ==", "3260c925-8eb8-4882-8690-3ce6838bb5c7", new DateTime(2021, 12, 31, 22, 12, 15, 316, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCategory_CategoryId",
                table: "EmployeeCategory",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Methods_MethodId",
                table: "Categories",
                column: "MethodId",
                principalTable: "Methods",
                principalColumn: "MethodId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMethod_AspNetUsers_Id",
                table: "EmployeeMethod",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Methods_MethodId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMethod_AspNetUsers_Id",
                table: "EmployeeMethod");

            migrationBuilder.DropTable(
                name: "EmployeeCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeMethod",
                table: "EmployeeMethod");

            migrationBuilder.RenameColumn(
                name: "MethodId",
                table: "Categories",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_MethodId",
                table: "Categories",
                newName: "IX_Categories_EmployeeId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeMethod",
                table: "EmployeeMethod",
                column: "Id");

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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoryMethod_Methods_MethodId",
                        column: x => x.MethodId,
                        principalTable: "Methods",
                        principalColumn: "MethodId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_CategoryMethod_MethodId",
                table: "CategoryMethod",
                column: "MethodId");

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
    }
}
