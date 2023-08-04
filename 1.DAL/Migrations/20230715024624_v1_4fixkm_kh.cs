using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class v1_4fixkm_kh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChiTietPTTT",
                keyColumn: "ID",
                keyValue: new Guid("8d3181bc-a4d8-479c-829e-b5112d055ac0"));

            migrationBuilder.DeleteData(
                table: "ChiTietPTTT",
                keyColumn: "ID",
                keyValue: new Guid("bf9e5e61-087b-48cc-acfe-1b01bdca384c"));

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumn: "ID",
                keyValue: new Guid("5b8ccadb-02eb-4320-8497-8b559fe818e1"));

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumn: "ID",
                keyValue: new Guid("6ab334a4-637d-47c0-a1bb-103c2ed09e73"));

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumn: "ID",
                keyValue: new Guid("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"));

            migrationBuilder.DeleteData(
                table: "KhachHang",
                keyColumn: "ID",
                keyValue: new Guid("17253c77-e652-4051-a831-5d9c4d553d71"));

            migrationBuilder.DeleteData(
                table: "SanPhamChiTiet",
                keyColumn: "ID",
                keyValue: new Guid("bc2f5d6f-080a-4cf7-ada8-7e4e2ae9abcc"));

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "ID",
                keyValue: new Guid("5353eab4-77df-4201-85d6-709b3b65deda"));

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "ID",
                keyValue: new Guid("78f0dc70-1f8d-42c0-abcb-914c306ff39c"));

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "ID",
                keyValue: new Guid("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"));

            migrationBuilder.DeleteData(
                table: "SanPhamChiTiet",
                keyColumn: "ID",
                keyValue: new Guid("3b1fab5d-7bb7-4abf-a12b-f1ef9416f241"));

            migrationBuilder.DeleteData(
                table: "SanPhamChiTiet",
                keyColumn: "ID",
                keyValue: new Guid("a3459c51-54ec-485c-bece-fdc74871fd4b"));

            migrationBuilder.DeleteData(
                table: "KhachHang",
                keyColumn: "ID",
                keyValue: new Guid("851a51e1-c114-4347-b663-f68334ddae2c"));

            migrationBuilder.AlterColumn<float>(
                name: "SoTienGiam",
                table: "KhuyenMai",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "KhachHang",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "ID", "Diem", "HovaTen", "SDT", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("4dc2c304-df44-4acb-be45-9434d83e45cc"), 12, "lại nam1", "01234542121", 1 },
                    { new Guid("d1fbd855-8d98-4edd-98c9-c639a5d05e4c"), 15, "lại nam", "0123456890", 0 }
                });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"),
                columns: new[] { "NgayBatDau", "NgayKetThuc", "SoTienGiam" },
                values: new object[] { new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9914), new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9916), 1000f });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"),
                columns: new[] { "NgayBatDau", "NgayKetThuc", "SoTienGiam" },
                values: new object[] { new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9924), new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9925), 1000f });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KhachHang",
                keyColumn: "ID",
                keyValue: new Guid("4dc2c304-df44-4acb-be45-9434d83e45cc"));

            migrationBuilder.DeleteData(
                table: "KhachHang",
                keyColumn: "ID",
                keyValue: new Guid("d1fbd855-8d98-4edd-98c9-c639a5d05e4c"));

            migrationBuilder.AlterColumn<int>(
                name: "SoTienGiam",
                table: "KhuyenMai",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "KhachHang",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "ID", "Diem", "HovaTen", "SDT", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("17253c77-e652-4051-a831-5d9c4d553d71"), 12, "lại nam1", "01234542121", null },
                    { new Guid("851a51e1-c114-4347-b663-f68334ddae2c"), 15, "lại nam", "0123456890", null }
                });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"),
                columns: new[] { "NgayBatDau", "NgayKetThuc", "SoTienGiam" },
                values: new object[] { new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7032), new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7033), 1000 });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"),
                columns: new[] { "NgayBatDau", "NgayKetThuc", "SoTienGiam" },
                values: new object[] { new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7035), new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7035), 1000 });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("6716c72b-76d9-4626-a269-674aac3b1426"),
                column: "NgaySinh",
                value: new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"),
                column: "NgaySinh",
                value: new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.InsertData(
                table: "SanPhamChiTiet",
                columns: new[] { "ID", "GiaBan", "GiaNhap", "HinhAnh", "IDKC", "IDLOAI", "IDMS", "IDNSX", "IDSP", "Ma", "MoTa", "SoLuongTon", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("3b1fab5d-7bb7-4abf-a12b-f1ef9416f241"), 17000m, 150000m, "\"C:\\Users\\laich\\Downloads\\anh2.jpg\"", new Guid("5770d06e-b38f-4d87-b820-f708c04203ad"), new Guid("40d32121-ad17-4bd5-9e07-6db69572b50b"), new Guid("1b5acee0-34fc-4248-b6b0-f2d0920ed633"), new Guid("74cac681-11db-4764-bd2c-6486775d22da"), new Guid("7173cee4-5764-4da7-96a9-2fd45fef403f"), "SPCT2", "Sản phẩm mới 2", 4, 1 },
                    { new Guid("a3459c51-54ec-485c-bece-fdc74871fd4b"), 15000m, 140000m, "\"C:\\Users\\laich\\Downloads\\anh1.jpg\"", new Guid("5770d06e-b38f-4d87-b820-f708c04203ad"), new Guid("40d32121-ad17-4bd5-9e07-6db69572b50b"), new Guid("1b5acee0-34fc-4248-b6b0-f2d0920ed633"), new Guid("74cac681-11db-4764-bd2c-6486775d22da"), new Guid("3a1a4888-f7fd-46c5-808e-a42885ff4178"), "SPCT1", "Sản phẩm mới1", 3, 1 },
                    { new Guid("bc2f5d6f-080a-4cf7-ada8-7e4e2ae9abcc"), 20000m, 140000m, null, new Guid("6f7a120e-5651-4d46-baec-5ce340a5d84e"), new Guid("40d32121-ad17-4bd5-9e07-6db69572b50b"), new Guid("1b5acee0-34fc-4248-b6b0-f2d0920ed633"), new Guid("74cac681-11db-4764-bd2c-6486775d22da"), new Guid("3a1a4888-f7fd-46c5-808e-a42885ff4178"), "SPCT1", "Sản phẩm mới3", 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "HoaDon",
                columns: new[] { "ID", "DiaChi", "IDKH", "IDKM", "IDNV", "Ma", "NgayNhan", "NgayShip", "NgayTao", "NgayThanhToan", "SDT", "TenNguoiNhan", "TrangThai" },
                values: new object[] { new Guid("5353eab4-77df-4201-85d6-709b3b65deda"), null, new Guid("851a51e1-c114-4347-b663-f68334ddae2c"), new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"), new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"), "HD3", null, null, new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7078), new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7078), null, null, 1 });

            migrationBuilder.InsertData(
                table: "HoaDon",
                columns: new[] { "ID", "DiaChi", "IDKH", "IDKM", "IDNV", "Ma", "NgayNhan", "NgayShip", "NgayTao", "NgayThanhToan", "SDT", "TenNguoiNhan", "TrangThai" },
                values: new object[] { new Guid("78f0dc70-1f8d-42c0-abcb-914c306ff39c"), null, new Guid("851a51e1-c114-4347-b663-f68334ddae2c"), new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"), new Guid("6716c72b-76d9-4626-a269-674aac3b1426"), "HD1", null, null, new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7071), new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7071), null, null, 1 });

            migrationBuilder.InsertData(
                table: "HoaDon",
                columns: new[] { "ID", "DiaChi", "IDKH", "IDKM", "IDNV", "Ma", "NgayNhan", "NgayShip", "NgayTao", "NgayThanhToan", "SDT", "TenNguoiNhan", "TrangThai" },
                values: new object[] { new Guid("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"), null, new Guid("851a51e1-c114-4347-b663-f68334ddae2c"), new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"), new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"), "HD2", null, null, new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7075), new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7075), null, null, 1 });

            migrationBuilder.InsertData(
                table: "ChiTietPTTT",
                columns: new[] { "ID", "GhiChu", "IdHoaDon", "IdPhuongThucThanhToan", "SoTienThanhToan", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("8d3181bc-a4d8-479c-829e-b5112d055ac0"), "Thanh toán bằng tiền mặt 15k", new Guid("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"), new Guid("5160e76f-a21c-4716-bf8a-fda4e27479f8"), 15000m, 0 },
                    { new Guid("bf9e5e61-087b-48cc-acfe-1b01bdca384c"), null, new Guid("78f0dc70-1f8d-42c0-abcb-914c306ff39c"), new Guid("5160e76f-a21c-4716-bf8a-fda4e27479f8"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "HoaDonChiTiet",
                columns: new[] { "ID", "DonGia", "IDHD", "IDSPCT", "SoLuong" },
                values: new object[,]
                {
                    { new Guid("5b8ccadb-02eb-4320-8497-8b559fe818e1"), 140000m, new Guid("5353eab4-77df-4201-85d6-709b3b65deda"), new Guid("3b1fab5d-7bb7-4abf-a12b-f1ef9416f241"), 6 },
                    { new Guid("6ab334a4-637d-47c0-a1bb-103c2ed09e73"), 140000m, new Guid("78f0dc70-1f8d-42c0-abcb-914c306ff39c"), new Guid("a3459c51-54ec-485c-bece-fdc74871fd4b"), 5 },
                    { new Guid("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"), 140000m, new Guid("78f0dc70-1f8d-42c0-abcb-914c306ff39c"), new Guid("3b1fab5d-7bb7-4abf-a12b-f1ef9416f241"), 4 }
                });
        }
    }
}
