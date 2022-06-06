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
                keyValue: "77a025f6-ee80-4cc8-8058-d22745416d5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd00ec86-9c77-4bcc-b3e3-000761627c31");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d7ee868-035a-4222-8e87-44676bedf67a", "c526c221-dcd1-4a34-8c8b-1c8ad131472e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbc9dce5-be02-4243-ab7f-bc3317b3cbc1", "4c6b1db3-6fed-4be6-875a-70e9d93d58e8", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "77a025f6-ee80-4cc8-8058-d22745416d5c", "9ce38d13-c2ee-49b7-b496-e5b5c910b771", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd00ec86-9c77-4bcc-b3e3-000761627c31", "ecdafc6b-37c6-4e2f-a6fa-cf61dd481511", "User", "USER" });
        }
    }
}
