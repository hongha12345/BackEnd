using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class updatemigra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "NgayHen",
                table: "LichHen");

            migrationBuilder.DropColumn(
                name: "ThoiGianBD",
                table: "LichHen");

            migrationBuilder.DropColumn(
                name: "ThoiGianKT",
                table: "LichHen");

            migrationBuilder.RenameColumn(
                name: "MALH",
                table: "LichHen",
                newName: "MaLH");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "LichHen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "LichHen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaCN",
                table: "LichHen",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaTCT",
                table: "LichHen",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "LichHen",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "LichHen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "LichHen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "customer_number",
                table: "LichHen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChiNhanh",
                columns: table => new
                {
                    MaCN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiNhanh", x => x.MaCN);
                });

            migrationBuilder.CreateTable(
                name: "ThoCatToc",
                columns: table => new
                {
                    MaTCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTCT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoCatToc", x => x.MaTCT);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e6b1f28-2779-4ec4-af67-232e5f0a5ef0", "443c9934-a854-4958-b047-6d29c7eab4c3", "User", "USER" },
                    { "54c502a7-4394-480d-8d19-b748314cc3bb", "684a91d7-a36a-4e32-80da-bbc16138cb0b", "Admin", "ADMIN" },
                    { "7d53a236-87e7-4754-b49a-40e1a2f4fbf9", "a75e4f71-3e62-4234-b91f-573b65860225", "Manager", "MANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LichHen_MaCN",
                table: "LichHen",
                column: "MaCN");

            migrationBuilder.CreateIndex(
                name: "IX_LichHen_MaTCT",
                table: "LichHen",
                column: "MaTCT");

            migrationBuilder.AddForeignKey(
                name: "FK_LichHen_ChiNhanh_MaCN",
                table: "LichHen",
                column: "MaCN",
                principalTable: "ChiNhanh",
                principalColumn: "MaCN");

            migrationBuilder.AddForeignKey(
                name: "FK_LichHen_ThoCatToc_MaTCT",
                table: "LichHen",
                column: "MaTCT",
                principalTable: "ThoCatToc",
                principalColumn: "MaTCT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LichHen_ChiNhanh_MaCN",
                table: "LichHen");

            migrationBuilder.DropForeignKey(
                name: "FK_LichHen_ThoCatToc_MaTCT",
                table: "LichHen");

            migrationBuilder.DropTable(
                name: "ChiNhanh");

            migrationBuilder.DropTable(
                name: "ThoCatToc");

            migrationBuilder.DropIndex(
                name: "IX_LichHen_MaCN",
                table: "LichHen");

            migrationBuilder.DropIndex(
                name: "IX_LichHen_MaTCT",
                table: "LichHen");

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

            migrationBuilder.DropColumn(
                name: "Date",
                table: "LichHen");

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "LichHen");

            migrationBuilder.DropColumn(
                name: "MaCN",
                table: "LichHen");

            migrationBuilder.DropColumn(
                name: "MaTCT",
                table: "LichHen");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "LichHen");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "LichHen");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "LichHen");

            migrationBuilder.DropColumn(
                name: "customer_number",
                table: "LichHen");

            migrationBuilder.RenameColumn(
                name: "MaLH",
                table: "LichHen",
                newName: "MALH");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayHen",
                table: "LichHen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiGianBD",
                table: "LichHen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiGianKT",
                table: "LichHen",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
