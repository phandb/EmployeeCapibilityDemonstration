using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e4583d62-6e7c-47a3-a303-33fds46b6edc", "fc6123b8-e660-47ea-abac-b25fbf8cc849", "User", "USER" },
                    { "e4583f62-6e7c-47f3-a203-33fdf46b6erc", "13db11a1-e6bb-477e-b347-79a3c683b57d", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ExpiredDate", "FirstName", "HiredDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TakenDate", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d5683f62-7f8c-47f3-a202-33fdf46b62fa", 0, "d7119cd9-3b99-4dd5-a87e-368df03912fb", "user@test.org", false, new DateTime(2021, 12, 14, 17, 5, 7, 287, DateTimeKind.Local).AddTicks(4689), "System", new DateTime(2021, 12, 14, 17, 5, 7, 287, DateTimeKind.Local).AddTicks(4682), "User", false, null, "USER@TEST.ORG", null, "AQAAAAEAACcQAAAAEDsmSLEMim3nLaQswIgoKEwkti7whJut17Y61yATb767E1E64A5MkkH/GFrZRiAN5g==", null, false, "bd9a93a6-9a0b-4911-8122-8e2fd93fc133", new DateTime(2021, 12, 14, 17, 5, 7, 287, DateTimeKind.Local).AddTicks(4687), false, null },
                    { "e4583f62-6e7b-47f3-a202-33fdf46b62fa", 0, "01af037a-db54-4058-8e50-ec7d70aa2d1b", "admin@test.org", false, new DateTime(2021, 12, 14, 17, 5, 7, 285, DateTimeKind.Local).AddTicks(1929), "System", new DateTime(2021, 12, 14, 17, 5, 7, 285, DateTimeKind.Local).AddTicks(1893), "Admin", false, null, "ADMIN@TEST.ORG", null, "AQAAAAEAACcQAAAAEELdH9UlEoCgKMuWCcpdzGqjer6sOQk8isoPxkbtdXFtDlF3prSo0gtZr1b9j++LeA==", null, false, "9212cdfd-ca8b-42aa-93d7-b55f1a25bd37", new DateTime(2021, 12, 14, 17, 5, 7, 285, DateTimeKind.Local).AddTicks(1927), false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e4583d62-6e7c-47a3-a303-33fds46b6edc", "d5683f62-7f8c-47f3-a202-33fdf46b62fa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e4583f62-6e7c-47f3-a203-33fdf46b6erc", "e4583f62-6e7b-47f3-a202-33fdf46b62fa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e4583d62-6e7c-47a3-a303-33fds46b6edc", "d5683f62-7f8c-47f3-a202-33fdf46b62fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e4583f62-6e7c-47f3-a203-33fdf46b6erc", "e4583f62-6e7b-47f3-a202-33fdf46b62fa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa");
        }
    }
}