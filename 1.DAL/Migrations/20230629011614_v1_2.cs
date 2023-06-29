using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class v1_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HovaTen = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Diem = table.Column<int>(type: "int", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    PhanTramGiam = table.Column<int>(type: "int", nullable: true),
                    SoTienGiam = table.Column<int>(type: "int", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KichCo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KichCo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Nsx",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nsx", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AnhNv = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IDCV",
                        column: x => x.IDCV,
                        principalTable: "ChucVu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamChiTiet",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKC = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDLOAI = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDNSX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDMS = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamChiTiet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_KichCo_IDKC",
                        column: x => x.IDKC,
                        principalTable: "KichCo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_LoaiSanPham_IDLOAI",
                        column: x => x.IDLOAI,
                        principalTable: "LoaiSanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_MauSac_IDMS",
                        column: x => x.IDMS,
                        principalTable: "MauSac",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_Nsx_IDNSX",
                        column: x => x.IDNSX,
                        principalTable: "Nsx",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_SanPham_IDSP",
                        column: x => x.IDSP,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKM = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayShip = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayNhan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IDKH",
                        column: x => x.IDKH,
                        principalTable: "KhachHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhuyenMai_IDKM",
                        column: x => x.IDKM,
                        principalTable: "KhuyenMai",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IDNV",
                        column: x => x.IDNV,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IDHD",
                        column: x => x.IDHD,
                        principalTable: "HoaDon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_SanPhamChiTiet_IDSPCT",
                        column: x => x.IDSPCT,
                        principalTable: "SanPhamChiTiet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "ID", "Ma", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("6459bdd4-3b16-45c3-9142-a8d3cc8bbfc1"), "CV2", "Nhân viên", 1 },
                    { new Guid("e36bbc87-d18b-4a9a-bc51-353e79e54586"), "CV1", "Quản lý", 0 }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "ID", "Diem", "HovaTen", "SDT", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("17253c77-e652-4051-a831-5d9c4d553d71"), 12, "lại nam1", "01234542121", null },
                    { new Guid("851a51e1-c114-4347-b663-f68334ddae2c"), 15, "lại nam", "0123456890", null }
                });

            migrationBuilder.InsertData(
                table: "KhuyenMai",
                columns: new[] { "ID", "Ma", "NgayBatDau", "NgayKetThuc", "PhanTramGiam", "SoTienGiam", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"), "KM1", new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2310), 7, 1000, "Giảm 50%", 1 },
                    { new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"), "KM2", new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2313), 5, 1000, "Giảm 50%", 1 }
                });

            migrationBuilder.InsertData(
                table: "KichCo",
                columns: new[] { "ID", "Ma", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("5770d06e-b38f-4d87-b820-f708c04203ad"), "KT1", "L", 1 },
                    { new Guid("6194d5a3-e4c8-4065-8d97-d1a60eef1795"), "KT3", "S", 1 },
                    { new Guid("6f7a120e-5651-4d46-baec-5ce340a5d84e"), "KT2", "X", 1 }
                });

            migrationBuilder.InsertData(
                table: "LoaiSanPham",
                columns: new[] { "ID", "Ma", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("40d32121-ad17-4bd5-9e07-6db69572b50b"), "LSP2", "Quần", 1 },
                    { new Guid("9489d546-f9bf-4558-ade2-b120820212f0"), "LSP1", "Áo", 1 }
                });

            migrationBuilder.InsertData(
                table: "MauSac",
                columns: new[] { "ID", "Ma", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1b5acee0-34fc-4248-b6b0-f2d0920ed633"), "MS1", "Xanh", 1 },
                    { new Guid("612089de-9442-4534-b16d-629bcd748dfa"), "MS2", "Đỏ", 1 }
                });

            migrationBuilder.InsertData(
                table: "Nsx",
                columns: new[] { "ID", "Ma", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("37ab68dd-bbd9-47cf-bd15-48526a38c964"), "NSX1", "LV", 1 },
                    { new Guid("74cac681-11db-4764-bd2c-6486775d22da"), "NSX2", "Guuchi", 1 }
                });

            migrationBuilder.InsertData(
                table: "SanPham",
                columns: new[] { "ID", "Ma", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("3a1a4888-f7fd-46c5-808e-a42885ff4178"), "SP1", "Áo Len", 1 },
                    { new Guid("669bfd60-25cb-45e7-9585-14f45c4ea869"), "SP3", "Quần Đùi", 1 },
                    { new Guid("7173cee4-5764-4da7-96a9-2fd45fef403f"), "SP2", "Áo Khoác", 1 }
                });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "ID", "AnhNv", "CCCD", "DiaChi", "Email", "GioiTinh", "HoTen", "IDCV", "MatKhau", "NgaySinh", "SoDienThoai", "TrangThai", "Username" },
                values: new object[,]
                {
                    { new Guid("6716c72b-76d9-4626-a269-674aac3b1426"), null, "1342567778", "Ha Noi", "chunglvph20985@fpt.edu.vn", 0, "Phạm Gia Khánh", new Guid("e36bbc87-d18b-4a9a-bc51-353e79e54586"), "1", new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2204), "098652627222", 1, "chunglv" },
                    { new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"), null, "1342567778", "Ha Noi", "bena123@gmail.com", 0, "Phạm Gia Khánh", new Guid("6459bdd4-3b16-45c3-9142-a8d3cc8bbfc1"), "1", new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2217), "09865262713", 1, "bena" }
                });

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
                values: new object[] { new Guid("78f0dc70-1f8d-42c0-abcb-914c306ff39c"), null, new Guid("851a51e1-c114-4347-b663-f68334ddae2c"), new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"), new Guid("6716c72b-76d9-4626-a269-674aac3b1426"), "HD1", null, null, new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2341), null, null, 1 });

            migrationBuilder.InsertData(
                table: "HoaDon",
                columns: new[] { "ID", "DiaChi", "IDKH", "IDKM", "IDNV", "Ma", "NgayNhan", "NgayShip", "NgayTao", "NgayThanhToan", "SDT", "TenNguoiNhan", "TrangThai" },
                values: new object[] { new Guid("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"), null, new Guid("851a51e1-c114-4347-b663-f68334ddae2c"), new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"), new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"), "HD2", null, null, new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2344), new DateTime(2023, 6, 29, 8, 16, 14, 603, DateTimeKind.Local).AddTicks(2344), null, null, 1 });

            migrationBuilder.InsertData(
                table: "HoaDonChiTiet",
                columns: new[] { "ID", "DonGia", "IDHD", "IDSPCT", "SoLuong" },
                values: new object[] { new Guid("6ab334a4-637d-47c0-a1bb-103c2ed09e73"), 140000m, new Guid("78f0dc70-1f8d-42c0-abcb-914c306ff39c"), new Guid("a3459c51-54ec-485c-bece-fdc74871fd4b"), 5 });

            migrationBuilder.InsertData(
                table: "HoaDonChiTiet",
                columns: new[] { "ID", "DonGia", "IDHD", "IDSPCT", "SoLuong" },
                values: new object[] { new Guid("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"), 140000m, new Guid("78f0dc70-1f8d-42c0-abcb-914c306ff39c"), new Guid("3b1fab5d-7bb7-4abf-a12b-f1ef9416f241"), 4 });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IDKH",
                table: "HoaDon",
                column: "IDKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IDKM",
                table: "HoaDon",
                column: "IDKM");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IDNV",
                table: "HoaDon",
                column: "IDNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IDHD",
                table: "HoaDonChiTiet",
                column: "IDHD");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IDSPCT",
                table: "HoaDonChiTiet",
                column: "IDSPCT");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IDCV",
                table: "NhanVien",
                column: "IDCV");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IDKC",
                table: "SanPhamChiTiet",
                column: "IDKC");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IDLOAI",
                table: "SanPhamChiTiet",
                column: "IDLOAI");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IDMS",
                table: "SanPhamChiTiet",
                column: "IDMS");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IDNSX",
                table: "SanPhamChiTiet",
                column: "IDNSX");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IDSP",
                table: "SanPhamChiTiet",
                column: "IDSP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPhamChiTiet");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "KichCo");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "Nsx");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
