using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Rest_Store_Management.Data.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7148859f-f6c3-4c75-a23f-fd6575c2b019");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "958468f2-2148-4ed8-ae6d-a0a0165bec85");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68a4a6a8-954c-4d90-a1c7-d08108840a9e", "d8796038-6210-40ca-9f5e-c377f8588859", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8feeac0e-29dc-4907-ab27-bc1739f1a73e", "bc4f65df-7707-4119-9183-d7688bda134c", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7148859f-f6c3-4c75-a23f-fd6575c2b019", "9f3e8ade-a8ce-4e0c-870b-13c2ed9e7035", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "958468f2-2148-4ed8-ae6d-a0a0165bec85", "bf466fe1-5921-4962-b9d3-822a2b7fa5a4", "User", "USER" });
        }
    }
}
