using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Rest_Store_Management.Data.Migrations
{
    public partial class AddedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a4e80a5-994f-4d83-981d-35903bbd75b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "904710a2-ac0a-4405-b5f7-aed5ee3892b5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7148859f-f6c3-4c75-a23f-fd6575c2b019", "9f3e8ade-a8ce-4e0c-870b-13c2ed9e7035", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "958468f2-2148-4ed8-ae6d-a0a0165bec85", "bf466fe1-5921-4962-b9d3-822a2b7fa5a4", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "5a4e80a5-994f-4d83-981d-35903bbd75b6", "96c93bd9-5e65-4f32-8d7d-f71857f07de7", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "904710a2-ac0a-4405-b5f7-aed5ee3892b5", "f27ec515-705d-4699-8d20-54e1f822d3e5", "User", "USER" });
        }
    }
}
