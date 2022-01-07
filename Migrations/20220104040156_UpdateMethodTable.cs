using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class UpdateMethodTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
