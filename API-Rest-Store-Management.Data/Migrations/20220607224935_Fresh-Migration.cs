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
                keyValue: "67ead17c-4733-419c-8186-cdf9060ef788");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "747afd85-7cca-4d2d-8f6f-4626e0d14c74");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81035880-7062-44bf-aff5-f07a604a5191", "b28096a8-2102-430b-a1c8-22ab9ee1a191", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5ad504a-81c8-4d28-b2cf-570857fab1fb", "c95cc3d4-7b0b-479d-912c-28ec98c2db92", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81035880-7062-44bf-aff5-f07a604a5191");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5ad504a-81c8-4d28-b2cf-570857fab1fb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67ead17c-4733-419c-8186-cdf9060ef788", "187a74e1-3c81-48e0-b52e-c482eb5cb54a", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "747afd85-7cca-4d2d-8f6f-4626e0d14c74", "9a77b25a-5b64-4de3-92fc-be46dabcf64b", "User", "USER" });
        }
    }
}
