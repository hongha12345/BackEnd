using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class Addnohope : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71372e5e-0616-4f06-84b7-29e68bdcc700");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8726125d-1975-4edb-aa01-93dbdec39be2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95d2ec84-bb35-4f0c-9b16-9e4fc4c1c362");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8715583a-25e2-4a04-8ce8-743b1b2664cb", "52d49ee4-0aa9-41d2-adf0-08aedf475e42", "User", "USER" },
                    { "9fcc2d70-9ad4-45c5-b467-e6548d30c2f2", "3dd28820-8057-4021-aa12-89efd63bd2a1", "Admin", "ADMIN" },
                    { "d56ecf61-9710-4869-9cab-939b040a1bdb", "c99fbc1d-31b6-45b4-b885-5f0a9758ed2a", "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8715583a-25e2-4a04-8ce8-743b1b2664cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fcc2d70-9ad4-45c5-b467-e6548d30c2f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d56ecf61-9710-4869-9cab-939b040a1bdb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71372e5e-0616-4f06-84b7-29e68bdcc700", "a1252751-5666-463a-8b44-1700aa28eb2a", "Manager", "MANAGER" },
                    { "8726125d-1975-4edb-aa01-93dbdec39be2", "b02de70b-4fe2-4cac-83f7-ea1b5521801d", "Admin", "ADMIN" },
                    { "95d2ec84-bb35-4f0c-9b16-9e4fc4c1c362", "0abe25af-c4f5-4437-8f1f-97fa6785b6e4", "User", "USER" }
                });
        }
    }
}
