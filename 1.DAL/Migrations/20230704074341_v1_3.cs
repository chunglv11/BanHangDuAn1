using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class v1_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CCCD",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "SoDienThoai",
                table: "NhanVien");

            migrationBuilder.AddColumn<string>(
                name: "MaNv",
                table: "NhanVien",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PhuongThucThanhToan",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaPTThanhToan = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    TenPTThanhToan = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucThanhToan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPTTT",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhuongThucThanhToan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoTienThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPTTT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietPTTT_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPTTT_PhuongThucThanhToan_IdPhuongThucThanhToan",
                        column: x => x.IdPhuongThucThanhToan,
                        principalTable: "PhuongThucThanhToan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "ID",
                keyValue: new Guid("78f0dc70-1f8d-42c0-abcb-914c306ff39c"),
                columns: new[] { "NgayTao", "NgayThanhToan" },
                values: new object[] { new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7071), new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "ID",
                keyValue: new Guid("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"),
                columns: new[] { "NgayTao", "NgayThanhToan" },
                values: new object[] { new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7075), new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.InsertData(
                table: "HoaDon",
                columns: new[] { "ID", "DiaChi", "IDKH", "IDKM", "IDNV", "Ma", "NgayNhan", "NgayShip", "NgayTao", "NgayThanhToan", "SDT", "TenNguoiNhan", "TrangThai" },
                values: new object[] { new Guid("5353eab4-77df-4201-85d6-709b3b65deda"), null, new Guid("851a51e1-c114-4347-b663-f68334ddae2c"), new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"), new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"), "HD3", null, null, new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7078), new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7078), null, null, 1 });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7032), new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7035), new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("6716c72b-76d9-4626-a269-674aac3b1426"),
                columns: new[] { "MaNv", "NgaySinh" },
                values: new object[] { "NV1", new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"),
                columns: new[] { "HoTen", "MaNv", "NgaySinh" },
                values: new object[] { "Lại Văn chung", "NV2", new DateTime(2023, 7, 4, 14, 43, 40, 473, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.InsertData(
                table: "PhuongThucThanhToan",
                columns: new[] { "ID", "MaPTThanhToan", "TenPTThanhToan", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("5160e76f-a21c-4716-bf8a-fda4e27479f8"), "PT1", "Tiền mặt", 1 },
                    { new Guid("cc628597-dcf8-4200-abc1-c6eff62b7b39"), "PT2", "Chuyển khoản", 1 }
                });

            migrationBuilder.InsertData(
                table: "ChiTietPTTT",
                columns: new[] { "ID", "GhiChu", "IdHoaDon", "IdPhuongThucThanhToan", "SoTienThanhToan", "TrangThai" },
                values: new object[] { new Guid("8d3181bc-a4d8-479c-829e-b5112d055ac0"), "Thanh toán bằng tiền mặt 15k", new Guid("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"), new Guid("5160e76f-a21c-4716-bf8a-fda4e27479f8"), 15000m, 0 });

            migrationBuilder.InsertData(
                table: "ChiTietPTTT",
                columns: new[] { "ID", "GhiChu", "IdHoaDon", "IdPhuongThucThanhToan", "SoTienThanhToan", "TrangThai" },
                values: new object[] { new Guid("bf9e5e61-087b-48cc-acfe-1b01bdca384c"), null, new Guid("78f0dc70-1f8d-42c0-abcb-914c306ff39c"), new Guid("5160e76f-a21c-4716-bf8a-fda4e27479f8"), null, 0 });

            migrationBuilder.InsertData(
                table: "HoaDonChiTiet",
                columns: new[] { "ID", "DonGia", "IDHD", "IDSPCT", "SoLuong" },
                values: new object[] { new Guid("5b8ccadb-02eb-4320-8497-8b559fe818e1"), 140000m, new Guid("5353eab4-77df-4201-85d6-709b3b65deda"), new Guid("3b1fab5d-7bb7-4abf-a12b-f1ef9416f241"), 6 });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPTTT_IdHoaDon",
                table: "ChiTietPTTT",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPTTT_IdPhuongThucThanhToan",
                table: "ChiTietPTTT",
                column: "IdPhuongThucThanhToan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPTTT");

            migrationBuilder.DropTable(
                name: "PhuongThucThanhToan");

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumn: "ID",
                keyValue: new Guid("5b8ccadb-02eb-4320-8497-8b559fe818e1"));

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "ID",
                keyValue: new Guid("5353eab4-77df-4201-85d6-709b3b65deda"));

            migrationBuilder.DropColumn(
                name: "MaNv",
                table: "NhanVien");

            migrationBuilder.AddColumn<string>(
                name: "CCCD",
                table: "NhanVien",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "NhanVien",
                type: "nvarchar(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SoDienThoai",
                table: "NhanVien",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "ID",
                keyValue: new Guid("78f0dc70-1f8d-42c0-abcb-914c306ff39c"),
                columns: new[] { "NgayTao", "NgayThanhToan" },
                values: new object[] { new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "ID",
                keyValue: new Guid("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"),
                columns: new[] { "NgayTao", "NgayThanhToan" },
                values: new object[] { new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2344), new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "KhuyenMai",
                keyColumn: "ID",
                keyValue: new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("6716c72b-76d9-4626-a269-674aac3b1426"),
                columns: new[] { "CCCD", "DiaChi", "NgaySinh", "SoDienThoai" },
                values: new object[] { "1342567778", "Ha Noi", new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2204), "098652627222" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "ID",
                keyValue: new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"),
                columns: new[] { "CCCD", "DiaChi", "HoTen", "NgaySinh", "SoDienThoai" },
                values: new object[] { "1342567778", "Ha Noi", "Phạm Gia Khánh", new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2217), "09865262713" });
        }
    }
}
