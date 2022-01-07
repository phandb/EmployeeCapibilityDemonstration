using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class AddDateTimeFormatToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
