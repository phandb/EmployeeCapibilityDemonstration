using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class DeclareNullablePropertiesInEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "fb7455ba-d050-4734-b82a-0dbe4d5d0240");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "74fa3d20-3b78-4600-9498-0ea20d8ff1f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "b47c6091-5017-49cc-9f4d-1b630429035f", new DateTime(2022, 1, 6, 21, 57, 55, 285, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 1, 6, 21, 57, 55, 285, DateTimeKind.Local).AddTicks(8429), "AQAAAAEAACcQAAAAEDR0DShxQDpDrO9gLS80MIEyIfP53QtMSf7CU+PUZRMjLZipuOtDDsXfwOPZuCjAzg==", "015b6c61-eadb-4eae-a67a-60418694aef0", new DateTime(2022, 1, 6, 21, 57, 55, 285, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "e5548a45-e721-453b-b5e7-2aee245467b4", new DateTime(2022, 1, 6, 21, 57, 55, 280, DateTimeKind.Local).AddTicks(4467), new DateTime(2022, 1, 6, 21, 57, 55, 280, DateTimeKind.Local).AddTicks(4389), "AQAAAAEAACcQAAAAEGpVbNOzxKGy4hGZojsE/gtwskabCKc0Q6IK+SoWS702ex+P90jkvpa937+rPd44Gw==", "ccefe8c3-62b6-4861-8422-b6c6687b2e5f", new DateTime(2022, 1, 6, 21, 57, 55, 280, DateTimeKind.Local).AddTicks(4460) });
        }
    }
}
