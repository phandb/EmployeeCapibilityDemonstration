using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Data.Migrations
{
    public partial class UpdatedDefaultUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "9e5650d7-d9e4-45ae-bf68-bb7f643ee31b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "debbc1ff-0b6d-41c8-89b7-6e4ae4802e4d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "ExpiredDate", "HiredDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "TakenDate", "UserName" },
                values: new object[] { "034dd254-3690-416c-9648-c11388201700", true, new DateTime(2021, 12, 14, 17, 20, 22, 186, DateTimeKind.Local).AddTicks(2189), new DateTime(2021, 12, 14, 17, 20, 22, 186, DateTimeKind.Local).AddTicks(2166), "USER@TEST.ORG", "AQAAAAEAACcQAAAAEGsRgfe18KkDNUYxwqvAWQBoSJG4YheOegxCXbCTbCaj0Tqm3fqL59+Nxqj4GU6Qcw==", "bc7be69c-7194-4737-a4cf-b1cb4b72a742", new DateTime(2021, 12, 14, 17, 20, 22, 186, DateTimeKind.Local).AddTicks(2186), "user@test.org" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "ExpiredDate", "HiredDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "TakenDate", "UserName" },
                values: new object[] { "52e4ca2f-32b8-4727-8812-cab3cd187056", true, new DateTime(2021, 12, 14, 17, 20, 22, 183, DateTimeKind.Local).AddTicks(4971), new DateTime(2021, 12, 14, 17, 20, 22, 183, DateTimeKind.Local).AddTicks(4928), "ADMIN@TEST.ORG", "AQAAAAEAACcQAAAAEDEh9ID7MGxR3KN75D4GXRJBPd5tVVjig6OgBkyh6q/S4J7f4q0guthgCd70nTcf1g==", "33dbe3af-97d9-4d68-bfd6-fde4883c4393", new DateTime(2021, 12, 14, 17, 20, 22, 183, DateTimeKind.Local).AddTicks(4969), "admin@test.org" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "fc6123b8-e660-47ea-abac-b25fbf8cc849");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "13db11a1-e6bb-477e-b347-79a3c683b57d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "ExpiredDate", "HiredDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "TakenDate", "UserName" },
                values: new object[] { "d7119cd9-3b99-4dd5-a87e-368df03912fb", false, new DateTime(2021, 12, 14, 17, 5, 7, 287, DateTimeKind.Local).AddTicks(4689), new DateTime(2021, 12, 14, 17, 5, 7, 287, DateTimeKind.Local).AddTicks(4682), null, "AQAAAAEAACcQAAAAEDsmSLEMim3nLaQswIgoKEwkti7whJut17Y61yATb767E1E64A5MkkH/GFrZRiAN5g==", "bd9a93a6-9a0b-4911-8122-8e2fd93fc133", new DateTime(2021, 12, 14, 17, 5, 7, 287, DateTimeKind.Local).AddTicks(4687), null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "ExpiredDate", "HiredDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "TakenDate", "UserName" },
                values: new object[] { "01af037a-db54-4058-8e50-ec7d70aa2d1b", false, new DateTime(2021, 12, 14, 17, 5, 7, 285, DateTimeKind.Local).AddTicks(1929), new DateTime(2021, 12, 14, 17, 5, 7, 285, DateTimeKind.Local).AddTicks(1893), null, "AQAAAAEAACcQAAAAEELdH9UlEoCgKMuWCcpdzGqjer6sOQk8isoPxkbtdXFtDlF3prSo0gtZr1b9j++LeA==", "9212cdfd-ca8b-42aa-93d7-b55f1a25bd37", new DateTime(2021, 12, 14, 17, 5, 7, 285, DateTimeKind.Local).AddTicks(1927), null });
        }
    }
}
