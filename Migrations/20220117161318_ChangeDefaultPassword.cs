using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class ChangeDefaultPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MethodViewModel");

            migrationBuilder.DropTable(
                name: "CategoryViewModel");

            migrationBuilder.DropTable(
                name: "EmployeeDetailsViewModel");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "18fd2682-1ee0-476d-b6a4-1686c0407742");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "d2b905fb-7962-4726-ad5b-8c95c1ef1907");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "4f574cd4-87e6-43f6-9d98-67d85444dd06", new DateTime(2022, 1, 17, 10, 13, 17, 267, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 1, 17, 10, 13, 17, 267, DateTimeKind.Local).AddTicks(5370), "AQAAAAEAACcQAAAAEJ9sd5gmBnC6GelHXQUcJhZosbKgGe4t5eFnhNMz02sQ3zBT6PBCXdiQkwI4OxFf5Q==", "1b89200f-c357-453c-8a3f-b294821fda21", new DateTime(2022, 1, 17, 10, 13, 17, 267, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "258a77aa-1c24-424c-b42f-f52bbf8bfd61", new DateTime(2022, 1, 17, 10, 13, 17, 263, DateTimeKind.Local).AddTicks(1548), new DateTime(2022, 1, 17, 10, 13, 17, 263, DateTimeKind.Local).AddTicks(1472), "AQAAAAEAACcQAAAAEL6zZrPd6SbZ3tsEil3b4riQedZAqJdwpHbKIHtzMmEf7/f0xaZfikiIJauM6CQLIw==", "43491c0e-04dd-4972-be04-b32c68a27712", new DateTime(2022, 1, 17, 10, 13, 17, 263, DateTimeKind.Local).AddTicks(1543) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeDetailsViewModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateHired = table.Column<DateTime>(type: "datetime2", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetailsViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryViewModel",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeDetailsViewModelId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryViewModel", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_CategoryViewModel_EmployeeDetailsViewModel_EmployeeDetailsViewModelId",
                        column: x => x.EmployeeDetailsViewModelId,
                        principalTable: "EmployeeDetailsViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MethodViewModel",
                columns: table => new
                {
                    MethodId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryVMCategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeDetailsViewModelId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MethodViewModel", x => x.MethodId);
                    table.ForeignKey(
                        name: "FK_MethodViewModel_CategoryViewModel_CategoryVMCategoryId",
                        column: x => x.CategoryVMCategoryId,
                        principalTable: "CategoryViewModel",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MethodViewModel_EmployeeDetailsViewModel_EmployeeDetailsViewModelId",
                        column: x => x.EmployeeDetailsViewModelId,
                        principalTable: "EmployeeDetailsViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "41b6f1ff-b061-458b-be8f-4b67c63f1b82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "4ba1a782-5fdd-40e5-90fd-c314d4100795");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "03840c7d-7ab6-49ce-bb0f-d34610b49375", new DateTime(2022, 1, 16, 14, 49, 57, 348, DateTimeKind.Local).AddTicks(7041), new DateTime(2022, 1, 16, 14, 49, 57, 348, DateTimeKind.Local).AddTicks(7023), "AQAAAAEAACcQAAAAEDyl2NQjL7rlqtp0XfK3saYC0oGupbttGkzTpN5rVFFCAadwJ2SOOZftQC7SSW8CCA==", "6f203b14-364a-4364-b84f-fc825969b0c4", new DateTime(2022, 1, 16, 14, 49, 57, 348, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "953df117-84f4-4373-a388-8b2c2a34776c", new DateTime(2022, 1, 16, 14, 49, 57, 345, DateTimeKind.Local).AddTicks(5527), new DateTime(2022, 1, 16, 14, 49, 57, 345, DateTimeKind.Local).AddTicks(5478), "AQAAAAEAACcQAAAAEE6TzahYbpDOV/1c8a75xC1MWr34iUX0qVK1zU17D5kinsdEvtN0kKLCtM1NopePLA==", "4dce2657-d351-4c2e-a2b9-f72cb46d1663", new DateTime(2022, 1, 16, 14, 49, 57, 345, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryViewModel_EmployeeDetailsViewModelId",
                table: "CategoryViewModel",
                column: "EmployeeDetailsViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MethodViewModel_CategoryVMCategoryId",
                table: "MethodViewModel",
                column: "CategoryVMCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MethodViewModel_EmployeeDetailsViewModelId",
                table: "MethodViewModel",
                column: "EmployeeDetailsViewModelId");
        }
    }
}
