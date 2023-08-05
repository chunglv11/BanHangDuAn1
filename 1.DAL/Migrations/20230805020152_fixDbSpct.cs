using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class fixDbSpct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IDCL",
                table: "SanPhamChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ChatLieu",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieu", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "ChatLieu",
                columns: new[] { "ID", "Ma", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("2ab9d74b-b4db-4a42-896e-c43ca8276b81"), "CL3", "cotton", 1 },
                    { new Guid("bfcc93fd-2382-4bca-ad75-70dda2e3d1da"), "CL2", "Vải thô", 1 },
                    { new Guid("cb4eaedb-a21a-4560-a069-35f580dae332"), "CL1", "Vải", 1 }
                });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 8, 5, 9, 1, 51, 805, DateTimeKind.Local).AddTicks(7478), new DateTime(2023, 8, 5, 9, 1, 51, 805, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 8, 5, 9, 1, 51, 805, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 8, 5, 9, 1, 51, 805, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("6716c72b-76d9-4626-a269-674aac3b1426"),
                column: "NgaySinh",
                value: new DateTime(2023, 8, 5, 9, 1, 51, 805, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"),
                column: "NgaySinh",
                value: new DateTime(2023, 8, 5, 9, 1, 51, 805, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IDCL",
                table: "SanPhamChiTiet",
                column: "IDCL");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhamChiTiet_ChatLieu_IDCL",
                table: "SanPhamChiTiet",
                column: "IDCL",
                principalTable: "ChatLieu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPhamChiTiet_ChatLieu_IDCL",
                table: "SanPhamChiTiet");

            migrationBuilder.DropTable(
                name: "ChatLieu");

            migrationBuilder.DropIndex(
                name: "IX_SanPhamChiTiet_IDCL",
                table: "SanPhamChiTiet");

            migrationBuilder.DropColumn(
                name: "IDCL",
                table: "SanPhamChiTiet");

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 7, 29, 8, 35, 25, 354, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 7, 29, 8, 35, 25, 354, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 7, 29, 8, 35, 25, 354, DateTimeKind.Local).AddTicks(6071), new DateTime(2023, 7, 29, 8, 35, 25, 354, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("6716c72b-76d9-4626-a269-674aac3b1426"),
                column: "NgaySinh",
                value: new DateTime(2023, 7, 29, 8, 35, 25, 354, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"),
                column: "NgaySinh",
                value: new DateTime(2023, 7, 29, 8, 35, 25, 354, DateTimeKind.Local).AddTicks(5990));
        }
    }
}
