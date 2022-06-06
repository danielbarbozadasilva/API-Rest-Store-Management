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
                keyValue: "1d7ee868-035a-4222-8e87-44676bedf67a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc9dce5-be02-4243-ab7f-bc3317b3cbc1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "14d141a0-5756-4d9b-9187-e66d8297acd5", "4fa3ba9d-7378-43b1-a8f1-46928675dce4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1955bdee-c7a6-46fa-85d6-f40bfdccd3b4", "f57a8e76-bbc6-4af4-b2a9-82aad4c2f01e", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "1d7ee868-035a-4222-8e87-44676bedf67a", "c526c221-dcd1-4a34-8c8b-1c8ad131472e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbc9dce5-be02-4243-ab7f-bc3317b3cbc1", "4c6b1db3-6fed-4be6-875a-70e9d93d58e8", "User", "USER" });
        }
    }
}
