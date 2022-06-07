using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Rest_Store_Management.Data.Migrations
{
    public partial class Fresition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a4a6a8-954c-4d90-a1c7-d08108840a9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8feeac0e-29dc-4907-ab27-bc1739f1a73e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67ead17c-4733-419c-8186-cdf9060ef788", "187a74e1-3c81-48e0-b52e-c482eb5cb54a", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "747afd85-7cca-4d2d-8f6f-4626e0d14c74", "9a77b25a-5b64-4de3-92fc-be46dabcf64b", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "68a4a6a8-954c-4d90-a1c7-d08108840a9e", "d8796038-6210-40ca-9f5e-c377f8588859", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8feeac0e-29dc-4907-ab27-bc1739f1a73e", "bc4f65df-7707-4119-9183-d7688bda134c", "User", "USER" });
        }
    }
}
