using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class RemoveInitializedDateTimeNow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "f7d7719a-1496-4047-8dcd-2531724b145d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "8a39b8dd-e2d0-47a9-9f04-1785a56cb1b2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "7a1bb97d-7b71-437f-a39d-58cb299df109", new DateTime(2022, 1, 17, 10, 17, 55, 305, DateTimeKind.Local).AddTicks(3780), new DateTime(2022, 1, 17, 10, 17, 55, 305, DateTimeKind.Local).AddTicks(3745), "AQAAAAEAACcQAAAAEI2cmtjDbDnWtjT/EzlaYKiYteO6Kn3wL/YNOaeYmeZWfFv5KcbV9Ccm087skKT2zg==", "0f5c8bfa-c3fb-4a18-a8e6-c2fadb7b5cb4", new DateTime(2022, 1, 17, 10, 17, 55, 305, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "ExpiredDate", "HiredDate", "PasswordHash", "SecurityStamp", "TakenDate" },
                values: new object[] { "bd923a37-3ed2-436e-a0d9-bb145ff4d1d1", new DateTime(2022, 1, 17, 10, 17, 55, 300, DateTimeKind.Local).AddTicks(8739), new DateTime(2022, 1, 17, 10, 17, 55, 300, DateTimeKind.Local).AddTicks(8665), "AQAAAAEAACcQAAAAEDLvK0xnbZeRyks/KmSjoAggvP/A5SL3/5vvX7Ww1EkltgSp+yE5dHG9S0IuNfYEPQ==", "0c93a6d6-7eae-4531-8c06-d2b6dbe45c1e", new DateTime(2022, 1, 17, 10, 17, 55, 300, DateTimeKind.Local).AddTicks(8735) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
