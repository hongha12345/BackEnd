using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class updatemi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e6b1f28-2779-4ec4-af67-232e5f0a5ef0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54c502a7-4394-480d-8d19-b748314cc3bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d53a236-87e7-4754-b49a-40e1a2f4fbf9");

            migrationBuilder.AddColumn<int>(
                name: "MaCN",
                table: "ThoCatToc",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "102bddc7-a610-4592-b42e-629c5c3ba841", "a8dc2f6e-d5e8-4928-9ee8-ef977aa3c823", "Admin", "ADMIN" },
                    { "ec99548d-7938-4189-bceb-78d4a9c95d8a", "736b06c4-b827-43ed-861f-3f7ede29d90e", "Manager", "MANAGER" },
                    { "efcbfefd-487e-462f-9892-598568e2e83d", "b2616936-f3af-4a6a-8767-e0eca14d2d48", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "102bddc7-a610-4592-b42e-629c5c3ba841");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec99548d-7938-4189-bceb-78d4a9c95d8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efcbfefd-487e-462f-9892-598568e2e83d");

            migrationBuilder.DropColumn(
                name: "MaCN",
                table: "ThoCatToc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e6b1f28-2779-4ec4-af67-232e5f0a5ef0", "443c9934-a854-4958-b047-6d29c7eab4c3", "User", "USER" },
                    { "54c502a7-4394-480d-8d19-b748314cc3bb", "684a91d7-a36a-4e32-80da-bbc16138cb0b", "Admin", "ADMIN" },
                    { "7d53a236-87e7-4754-b49a-40e1a2f4fbf9", "a75e4f71-3e62-4234-b91f-573b65860225", "Manager", "MANAGER" }
                });
        }
    }
}
