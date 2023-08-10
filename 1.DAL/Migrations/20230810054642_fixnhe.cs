using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class fixnhe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ChucVu",
                keyColumn: "ID",
                keyValue: new Guid("e36bbc87-d18b-4a9a-bc51-353e79e54586"),
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "ID",
                keyValue: new Guid("4dc2c304-df44-4acb-be45-9434d83e45cc"),
                columns: new[] { "Diem", "HovaTen", "SDT" },
                values: new object[] { 10000, "Lại Văn Chung", "" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "ID",
                keyValue: new Guid("d1fbd855-8d98-4edd-98c9-c639a5d05e4c"),
                columns: new[] { "Diem", "HovaTen", "SDT" },
                values: new object[] { 0, "Khách vãng lai", "0" });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"),
                columns: new[] { "NgayBatDau", "NgayKetThuc", "PhanTramGiam" },
                values: new object[] { new DateTime(2023, 8, 10, 12, 46, 42, 109, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 8, 10, 12, 46, 42, 109, DateTimeKind.Local).AddTicks(6885), 0 });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"),
                columns: new[] { "NgayBatDau", "NgayKetThuc", "PhanTramGiam", "SoTienGiam" },
                values: new object[] { new DateTime(2023, 8, 10, 12, 46, 42, 109, DateTimeKind.Local).AddTicks(6889), new DateTime(2023, 8, 10, 12, 46, 42, 109, DateTimeKind.Local).AddTicks(6889), 50, 0f });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("6716c72b-76d9-4626-a269-674aac3b1426"),
                column: "NgaySinh",
                value: new DateTime(2023, 8, 10, 12, 46, 42, 109, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"),
                column: "NgaySinh",
                value: new DateTime(2023, 8, 10, 12, 46, 42, 109, DateTimeKind.Local).AddTicks(6775));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ChucVu",
                keyColumn: "ID",
                keyValue: new Guid("e36bbc87-d18b-4a9a-bc51-353e79e54586"),
                column: "TrangThai",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "ID",
                keyValue: new Guid("4dc2c304-df44-4acb-be45-9434d83e45cc"),
                columns: new[] { "Diem", "HovaTen", "SDT" },
                values: new object[] { 12, "lại nam1", "01234542121" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "ID",
                keyValue: new Guid("d1fbd855-8d98-4edd-98c9-c639a5d05e4c"),
                columns: new[] { "Diem", "HovaTen", "SDT" },
                values: new object[] { 15, "lại nam", "0123456890" });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"),
                columns: new[] { "NgayBatDau", "NgayKetThuc", "PhanTramGiam" },
                values: new object[] { new DateTime(2023, 8, 5, 9, 1, 51, 805, DateTimeKind.Local).AddTicks(7478), new DateTime(2023, 8, 5, 9, 1, 51, 805, DateTimeKind.Local).AddTicks(7478), 7 });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"),
                columns: new[] { "NgayBatDau", "NgayKetThuc", "PhanTramGiam", "SoTienGiam" },
                values: new object[] { new DateTime(2023, 8, 5, 9, 1, 51, 805, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 8, 5, 9, 1, 51, 805, DateTimeKind.Local).AddTicks(7482), 5, 1000f });

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
        }
    }
}
