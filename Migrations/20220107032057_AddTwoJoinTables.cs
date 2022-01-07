using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class AddTwoJoinTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCategory_AspNetUsers_Id",
                table: "EmployeeCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCategory_Categories_CategoryId",
                table: "EmployeeCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMethod_AspNetUsers_Id",
                table: "EmployeeMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMethod_Methods_MethodId",
                table: "EmployeeMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeMethod",
                table: "EmployeeMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeCategory",
                table: "EmployeeCategory");

            migrationBuilder.RenameTable(
                name: "EmployeeMethod",
                newName: "EmployeeMethods");

            migrationBuilder.RenameTable(
                name: "EmployeeCategory",
                newName: "EmployeeCategories");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeMethod_MethodId",
                table: "EmployeeMethods",
                newName: "IX_EmployeeMethods_MethodId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeCategory_CategoryId",
                table: "EmployeeCategories",
                newName: "IX_EmployeeCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeMethods",
                table: "EmployeeMethods",
                columns: new[] { "Id", "MethodId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeCategories",
                table: "EmployeeCategories",
                columns: new[] { "Id", "CategoryId" });

            migrationBuilder.CreateTable(
                name: "EmployeeDetailsViewModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateHired = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeDetailsViewModelId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryVMCategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeDetailsViewModelId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                value: "83bd3f89-34ea-44d7-9450-661f88eee1dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "0a607fc2-dae2-49ea-86d3-1ecf1e65570a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "81e29387-2b27-4a3c-a358-f19cccddf3fa", new DateTime(2022, 1, 6, 21, 20, 56, 74, DateTimeKind.Local).AddTicks(3695), new DateTime(2022, 1, 6, 21, 20, 56, 74, DateTimeKind.Local).AddTicks(3574), "AQAAAAEAACcQAAAAEL+qL8YmmtDtRERfXZ3UPe/n0bZQHW/7wjRC624Ncqx2T7UCnL9tI26nPSasZq90wg==", "c2e05961-99e4-49b6-9f2d-e0fa7e09c271", new DateTime(2022, 1, 6, 21, 20, 56, 74, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "7a1f2d1e-e043-4708-8c32-bfb8c1b85aad", new DateTime(2022, 1, 6, 21, 20, 56, 68, DateTimeKind.Local).AddTicks(4936), new DateTime(2022, 1, 6, 21, 20, 56, 68, DateTimeKind.Local).AddTicks(4820), "AQAAAAEAACcQAAAAEKoPJnHnXvN5s8qWSosxPrJKJdggp85Z0kjy5yZQSQe4iUnhLGnkZ2vxfnCxOxoEzw==", "5af68680-784d-4e0d-a5c8-3fd4b7422ce3", new DateTime(2022, 1, 6, 21, 20, 56, 68, DateTimeKind.Local).AddTicks(4932) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCategories_AspNetUsers_Id",
                table: "EmployeeCategories",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCategories_Categories_CategoryId",
                table: "EmployeeCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMethods_AspNetUsers_Id",
                table: "EmployeeMethods",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMethods_Methods_MethodId",
                table: "EmployeeMethods",
                column: "MethodId",
                principalTable: "Methods",
                principalColumn: "MethodId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCategories_AspNetUsers_Id",
                table: "EmployeeCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCategories_Categories_CategoryId",
                table: "EmployeeCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMethods_AspNetUsers_Id",
                table: "EmployeeMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMethods_Methods_MethodId",
                table: "EmployeeMethods");

            migrationBuilder.DropTable(
                name: "MethodViewModel");

            migrationBuilder.DropTable(
                name: "CategoryViewModel");

            migrationBuilder.DropTable(
                name: "EmployeeDetailsViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeMethods",
                table: "EmployeeMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeCategories",
                table: "EmployeeCategories");

            migrationBuilder.RenameTable(
                name: "EmployeeMethods",
                newName: "EmployeeMethod");

            migrationBuilder.RenameTable(
                name: "EmployeeCategories",
                newName: "EmployeeCategory");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeMethods_MethodId",
                table: "EmployeeMethod",
                newName: "IX_EmployeeMethod_MethodId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeCategories_CategoryId",
                table: "EmployeeCategory",
                newName: "IX_EmployeeCategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeMethod",
                table: "EmployeeMethod",
                columns: new[] { "Id", "MethodId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeCategory",
                table: "EmployeeCategory",
                columns: new[] { "Id", "CategoryId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "f55d05a1-d181-40c6-a167-44d34e5f8485");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "4b98e45a-2a30-4b76-a5a5-04fff0ba2e23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "59475640-2928-40d2-9b16-3cdab51b120c", new DateTime(2022, 1, 3, 22, 1, 55, 447, DateTimeKind.Local).AddTicks(1649), new DateTime(2022, 1, 3, 22, 1, 55, 447, DateTimeKind.Local).AddTicks(1589), "AQAAAAEAACcQAAAAEBRtKtUzoV6gP8SkXqXypyWESr8HTIxlTlOpubsZGaJG9favNTvtQiUhHwmLdS+aRA==", "e857d31a-427c-48b7-97e9-2df559da936b", new DateTime(2022, 1, 3, 22, 1, 55, 447, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "06a9e48c-3899-4e41-86b5-2e2501734d3f", new DateTime(2022, 1, 3, 22, 1, 55, 442, DateTimeKind.Local).AddTicks(8583), new DateTime(2022, 1, 3, 22, 1, 55, 442, DateTimeKind.Local).AddTicks(8527), "AQAAAAEAACcQAAAAEPjz+Ev4t+mUpfOOVXEoXD1PtmRmRy61C6etLoaZdCifc9b/JQLR83hYg5tC7UIRgg==", "8ce7bc5e-b05d-4fb7-ae78-9476c9ea2667", new DateTime(2022, 1, 3, 22, 1, 55, 442, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCategory_AspNetUsers_Id",
                table: "EmployeeCategory",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCategory_Categories_CategoryId",
                table: "EmployeeCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMethod_AspNetUsers_Id",
                table: "EmployeeMethod",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMethod_Methods_MethodId",
                table: "EmployeeMethod",
                column: "MethodId",
                principalTable: "Methods",
                principalColumn: "MethodId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
