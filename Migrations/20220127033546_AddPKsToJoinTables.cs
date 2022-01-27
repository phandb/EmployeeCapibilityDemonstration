using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    public partial class AddPKsToJoinTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MethodCategoryId",
                table: "MethodCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeMethodId",
                table: "EmployeeMethods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                column: "ConcurrencyStamp",
                value: "326c4362-de7c-495c-9d42-f20f31dba7b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                column: "ConcurrencyStamp",
                value: "65e7371b-8b6c-44ad-8548-ad0450ea6f0f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbc4d9ca-6224-448b-9085-c99feb4412a9", "AQAAAAEAACcQAAAAEPcFqeDQzyyZSVPN5GUPiG47ez8+wUPuPjZYD4ejYGApTPLRwW6AMAxGgUed+ZGN2w==", "94dbc63a-1008-4b79-b82e-2ca6d5d7f98d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0159906d-c93d-414f-98b9-17698ea12322", "AQAAAAEAACcQAAAAEDhq1J7TqzN5SKA49+6/flL25EablrZbb6DiCXhqLadwAsupacEk4j/JBiGg+kP1Zg==", "e2876f3f-2af8-427c-a24f-13053a717921" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MethodCategoryId",
                table: "MethodCategories");

            migrationBuilder.DropColumn(
                name: "EmployeeMethodId",
                table: "EmployeeMethods");

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
    }
}
