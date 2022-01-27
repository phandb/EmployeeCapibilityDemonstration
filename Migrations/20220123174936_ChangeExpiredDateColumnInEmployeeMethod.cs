using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class ChangeExpiredDateColumnInEmployeeMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiredDate",
                table: "EmployeeMethods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "868ed610-a4fa-478f-920d-e7f4a32c4813");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "d4970654-8150-4d3a-87b3-aa84693fa7d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4efb2c8-4e49-4cfb-aa71-b58587af1183", "AQAAAAEAACcQAAAAEP3X2yXuK8iaHHDd9Q/8+/Ctgxj3Hg8Hr/985lfGGaIMruMvbCwMOnj6DI4T8tvllg==", "74c41028-df8b-4c34-ba50-6f9a5231a284" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1386e01a-1632-465f-a2c7-3341d12ec6e0", "AQAAAAEAACcQAAAAELNUgc+GQZVfQGoeotF3E183DcH6Q/m+UQShuJTDAQKcfZMe3cGKBHdZzhU1IdSP6w==", "af5d6522-f2d6-4c52-aa08-e8d2f7967ddd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiredDate",
                table: "EmployeeMethods");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "78262c37-a4b4-4f52-a043-c145677949f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "a976761f-27a2-4284-9a94-eb8be05249f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ba5df1e-fe07-48e1-af11-315920ecbe0d", "AQAAAAEAACcQAAAAEJkMxjIIXAAFoicWav+giyLFa+SnqKFMmFsrnrqiVwjH2MayDucJW7DDtb2nVNPxUA==", "816fdd64-0ad4-46d5-95a8-94f98e88e72f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "376a9eb9-a365-4c60-9d72-db6830587383", "AQAAAAEAACcQAAAAELHbkXDjY/iteVlw/PPT+xrO34U7s9EZM4mzvxGP1BDKbjqluNrvN9evPhuIBHs66A==", "7dfea7e1-ea41-4a74-a3cf-5e836f3966e6" });
        }
    }
}
