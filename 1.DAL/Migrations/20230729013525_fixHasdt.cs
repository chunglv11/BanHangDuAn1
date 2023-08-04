using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class fixHasdt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "PhuongThucThanhToan",
                keyColumn: "ID",
                keyValue: new Guid("5160e76f-a21c-4716-bf8a-fda4e27479f8"),
                column: "MaPTThanhToan",
                value: "Offline");

            migrationBuilder.UpdateData(
                table: "PhuongThucThanhToan",
                keyColumn: "ID",
                keyValue: new Guid("cc628597-dcf8-4200-abc1-c6eff62b7b39"),
                column: "MaPTThanhToan",
                value: "Online");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "PhuongThucThanhToan",
                keyColumn: "ID",
                keyValue: new Guid("5160e76f-a21c-4716-bf8a-fda4e27479f8"),
                column: "MaPTThanhToan",
                value: "PT1");

            migrationBuilder.UpdateData(
                table: "PhuongThucThanhToan",
                keyColumn: "ID",
                keyValue: new Guid("cc628597-dcf8-4200-abc1-c6eff62b7b39"),
                column: "MaPTThanhToan",
                value: "PT2");
        }
    }
}
