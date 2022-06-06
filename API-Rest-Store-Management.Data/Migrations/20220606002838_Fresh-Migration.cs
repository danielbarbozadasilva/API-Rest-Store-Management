using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Rest_Store_Management.Data.Migrations
{
    public partial class FreshMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14d141a0-5756-4d9b-9187-e66d8297acd5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1955bdee-c7a6-46fa-85d6-f40bfdccd3b4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f9ffae5-3410-4a63-b6eb-b33fd74d1970", "e1bf12b4-c185-4fdf-b978-be65ad28dd98", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5268555-7004-45b1-a587-8f76f454fd23", "49fa5caa-4e6a-4848-8d59-399f323b5bda", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f9ffae5-3410-4a63-b6eb-b33fd74d1970");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5268555-7004-45b1-a587-8f76f454fd23");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "14d141a0-5756-4d9b-9187-e66d8297acd5", "4fa3ba9d-7378-43b1-a8f1-46928675dce4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1955bdee-c7a6-46fa-85d6-f40bfdccd3b4", "f57a8e76-bbc6-4af4-b2a9-82aad4c2f01e", "Administrator", "ADMINISTRATOR" });
        }
    }
}
