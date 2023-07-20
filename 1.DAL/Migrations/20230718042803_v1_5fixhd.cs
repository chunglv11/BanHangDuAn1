using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class v1_5fixhd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhuyenMai_IDKM",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonChiTiet_IDHD",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "HoaDonChiTiet");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhToan",
                table: "HoaDon",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "IDKM",
                table: "HoaDon",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet",
                columns: new[] { "IDHD", "IDSPCT" });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 28, 2, 983, DateTimeKind.Local).AddTicks(1994), new DateTime(2023, 7, 18, 11, 28, 2, 983, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 28, 2, 983, DateTimeKind.Local).AddTicks(1997), new DateTime(2023, 7, 18, 11, 28, 2, 983, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("6716c72b-76d9-4626-a269-674aac3b1426"),
                column: "NgaySinh",
                value: new DateTime(2023, 7, 18, 11, 28, 2, 983, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"),
                column: "NgaySinh",
                value: new DateTime(2023, 7, 18, 11, 28, 2, 983, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhuyenMai_IDKM",
                table: "HoaDon",
                column: "IDKM",
                principalTable: "KhuyenMai",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhuyenMai_IDKM",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet");

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "HoaDonChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhToan",
                table: "HoaDon",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IDKM",
                table: "HoaDon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9914), new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9924), new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("6716c72b-76d9-4626-a269-674aac3b1426"),
                column: "NgaySinh",
                value: new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"),
                column: "NgaySinh",
                value: new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IDHD",
                table: "HoaDonChiTiet",
                column: "IDHD");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhuyenMai_IDKM",
                table: "HoaDon",
                column: "IDKM",
                principalTable: "KhuyenMai",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
