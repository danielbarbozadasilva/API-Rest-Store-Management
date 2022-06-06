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
                keyValue: "4f65a75d-806f-48df-b9bb-3fb1e3827040");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "828ea046-7b1b-4861-ba7c-1ca96d0b058f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77a025f6-ee80-4cc8-8058-d22745416d5c", "9ce38d13-c2ee-49b7-b496-e5b5c910b771", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd00ec86-9c77-4bcc-b3e3-000761627c31", "ecdafc6b-37c6-4e2f-a6fa-cf61dd481511", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77a025f6-ee80-4cc8-8058-d22745416d5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd00ec86-9c77-4bcc-b3e3-000761627c31");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f65a75d-806f-48df-b9bb-3fb1e3827040", "583dd0ff-2fc1-4b9f-9571-e8a2694835e1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "828ea046-7b1b-4861-ba7c-1ca96d0b058f", "74bfa47c-7e97-4d2f-9e85-505000f68a72", "Administrator", "ADMINISTRATOR" });
        }
    }
}
