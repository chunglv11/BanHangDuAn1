﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Models;

#nullable disable

namespace _1.DAL.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1.DAL.Models.ChiTietThanhToan", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPhuongThucThanhToan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("SoTienThanhToan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IdHoaDon");

                    b.HasIndex("IdPhuongThucThanhToan");

                    b.ToTable("ChiTietPTTT", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.ChucVu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ChucVu", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("e36bbc87-d18b-4a9a-bc51-353e79e54586"),
                            Ma = "CV1",
                            Ten = "Quản lý",
                            TrangThai = 0
                        },
                        new
                        {
                            ID = new Guid("6459bdd4-3b16-45c3-9142-a8d3cc8bbfc1"),
                            Ma = "CV2",
                            Ten = "Nhân viên",
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("IDKH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDKM")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDNV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("NgayNhan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayShip")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TenNguoiNhan")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDKH");

                    b.HasIndex("IDKM");

                    b.HasIndex("IDNV");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("IDHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDHD");

                    b.HasIndex("IDSPCT");

                    b.ToTable("HoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.KhachHang", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Diem")
                        .HasColumnType("int");

                    b.Property<string>("HovaTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("KhachHang", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("d1fbd855-8d98-4edd-98c9-c639a5d05e4c"),
                            Diem = 15,
                            HovaTen = "lại nam",
                            SDT = "0123456890",
                            TrangThai = 0
                        },
                        new
                        {
                            ID = new Guid("4dc2c304-df44-4acb-be45-9434d83e45cc"),
                            Diem = 12,
                            HovaTen = "lại nam1",
                            SDT = "01234542121",
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.KhuyenMai", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PhanTramGiam")
                        .HasColumnType("int");

                    b.Property<float?>("SoTienGiam")
                        .HasColumnType("real");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("KhuyenMai", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("38dc8d59-1d19-4002-933e-3d09c77d8fb1"),
                            Ma = "KM1",
                            NgayBatDau = new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9914),
                            NgayKetThuc = new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9916),
                            PhanTramGiam = 7,
                            SoTienGiam = 1000f,
                            Ten = "Giảm 50%",
                            TrangThai = 1
                        },
                        new
                        {
                            ID = new Guid("8ee1a209-7ceb-471d-8452-b3c92408cabb"),
                            Ma = "KM2",
                            NgayBatDau = new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9924),
                            NgayKetThuc = new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9925),
                            PhanTramGiam = 5,
                            SoTienGiam = 1000f,
                            Ten = "Giảm 50%",
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.KichThuoc", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("KichCo", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("5770d06e-b38f-4d87-b820-f708c04203ad"),
                            Ma = "KT1",
                            Ten = "L",
                            TrangThai = 1
                        },
                        new
                        {
                            ID = new Guid("6f7a120e-5651-4d46-baec-5ce340a5d84e"),
                            Ma = "KT2",
                            Ten = "X",
                            TrangThai = 1
                        },
                        new
                        {
                            ID = new Guid("6194d5a3-e4c8-4065-8d97-d1a60eef1795"),
                            Ma = "KT3",
                            Ten = "S",
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.LoaiSanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("LoaiSanPham", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("9489d546-f9bf-4558-ade2-b120820212f0"),
                            Ma = "LSP1",
                            Ten = "Áo",
                            TrangThai = 1
                        },
                        new
                        {
                            ID = new Guid("40d32121-ad17-4bd5-9e07-6db69572b50b"),
                            Ma = "LSP2",
                            Ten = "Quần",
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.MauSac", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("MauSac", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("1b5acee0-34fc-4248-b6b0-f2d0920ed633"),
                            Ma = "MS1",
                            Ten = "Xanh",
                            TrangThai = 1
                        },
                        new
                        {
                            ID = new Guid("612089de-9442-4534-b16d-629bcd748dfa"),
                            Ma = "MS2",
                            Ten = "Đỏ",
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnhNv")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("IDCV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNv")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("IDCV");

                    b.ToTable("NhanVien", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("6716c72b-76d9-4626-a269-674aac3b1426"),
                            Email = "chunglvph20985@fpt.edu.vn",
                            GioiTinh = 0,
                            HoTen = "Phạm Gia Khánh",
                            IDCV = new Guid("e36bbc87-d18b-4a9a-bc51-353e79e54586"),
                            MaNv = "NV1",
                            MatKhau = "1",
                            NgaySinh = new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9620),
                            TrangThai = 1,
                            Username = "chunglv"
                        },
                        new
                        {
                            ID = new Guid("a6c0391b-59a9-48e5-aada-b684e80b1250"),
                            Email = "bena123@gmail.com",
                            GioiTinh = 0,
                            HoTen = "Lại Văn chung",
                            IDCV = new Guid("6459bdd4-3b16-45c3-9142-a8d3cc8bbfc1"),
                            MaNv = "NV2",
                            MatKhau = "1",
                            NgaySinh = new DateTime(2023, 7, 15, 9, 46, 23, 759, DateTimeKind.Local).AddTicks(9648),
                            TrangThai = 1,
                            Username = "bena"
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.NSX", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Nsx", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("37ab68dd-bbd9-47cf-bd15-48526a38c964"),
                            Ma = "NSX1",
                            Ten = "LV",
                            TrangThai = 1
                        },
                        new
                        {
                            ID = new Guid("74cac681-11db-4764-bd2c-6486775d22da"),
                            Ma = "NSX2",
                            Ten = "Guuchi",
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.PhuongThucThanhToan", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaPTThanhToan")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TenPTThanhToan")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PhuongThucThanhToan", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("5160e76f-a21c-4716-bf8a-fda4e27479f8"),
                            MaPTThanhToan = "PT1",
                            TenPTThanhToan = "Tiền mặt",
                            TrangThai = 1
                        },
                        new
                        {
                            ID = new Guid("cc628597-dcf8-4200-abc1-c6eff62b7b39"),
                            MaPTThanhToan = "PT2",
                            TenPTThanhToan = "Chuyển khoản",
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.SanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("SanPham", (string)null);

                    b.HasData(
                        new
                        {
                            ID = new Guid("3a1a4888-f7fd-46c5-808e-a42885ff4178"),
                            Ma = "SP1",
                            Ten = "Áo Len",
                            TrangThai = 1
                        },
                        new
                        {
                            ID = new Guid("7173cee4-5764-4da7-96a9-2fd45fef403f"),
                            Ma = "SP2",
                            Ten = "Áo Khoác",
                            TrangThai = 1
                        },
                        new
                        {
                            ID = new Guid("669bfd60-25cb-45e7-9585-14f45c4ea869"),
                            Ma = "SP3",
                            Ten = "Quần Đùi",
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.SanPhamChiTiet", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IDKC")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDLOAI")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDMS")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDNSX")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDKC");

                    b.HasIndex("IDLOAI");

                    b.HasIndex("IDMS");

                    b.HasIndex("IDNSX");

                    b.HasIndex("IDSP");

                    b.ToTable("SanPhamChiTiet", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Models.ChiTietThanhToan", b =>
                {
                    b.HasOne("_1.DAL.Models.HoaDon", "hoaDon")
                        .WithMany("ChiTietThanhToans")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.PhuongThucThanhToan", "phuongThucThanhToan")
                        .WithMany("ChiTietThanhToans")
                        .HasForeignKey("IdPhuongThucThanhToan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoaDon");

                    b.Navigation("phuongThucThanhToan");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.Models.KhachHang", "khachhang")
                        .WithMany("hoadon")
                        .HasForeignKey("IDKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.KhuyenMai", "KhuyenMai")
                        .WithMany("hoaDons")
                        .HasForeignKey("IDKM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.NhanVien", "nhanvien")
                        .WithMany("hoadon")
                        .HasForeignKey("IDNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhuyenMai");

                    b.Navigation("khachhang");

                    b.Navigation("nhanvien");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.HoaDon", "hoadon")
                        .WithMany("hoadonchitiet")
                        .HasForeignKey("IDHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.SanPhamChiTiet", "sanphamchitiet")
                        .WithMany("hoadonchitiet")
                        .HasForeignKey("IDSPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoadon");

                    b.Navigation("sanphamchitiet");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.Models.ChucVu", "ChucVu")
                        .WithMany("nhanvien")
                        .HasForeignKey("IDCV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.Models.SanPhamChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.KichThuoc", "size")
                        .WithMany("spct")
                        .HasForeignKey("IDKC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.LoaiSanPham", "loaiSanPham")
                        .WithMany("spct")
                        .HasForeignKey("IDLOAI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.MauSac", "mausac")
                        .WithMany("spct")
                        .HasForeignKey("IDMS")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.NSX", "nsx")
                        .WithMany("spct")
                        .HasForeignKey("IDNSX")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.SanPham", "sanpham")
                        .WithMany("spct")
                        .HasForeignKey("IDSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("loaiSanPham");

                    b.Navigation("mausac");

                    b.Navigation("nsx");

                    b.Navigation("sanpham");

                    b.Navigation("size");
                });

            modelBuilder.Entity("_1.DAL.Models.ChucVu", b =>
                {
                    b.Navigation("nhanvien");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.Navigation("ChiTietThanhToans");

                    b.Navigation("hoadonchitiet");
                });

            modelBuilder.Entity("_1.DAL.Models.KhachHang", b =>
                {
                    b.Navigation("hoadon");
                });

            modelBuilder.Entity("_1.DAL.Models.KhuyenMai", b =>
                {
                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("_1.DAL.Models.KichThuoc", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1.DAL.Models.LoaiSanPham", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1.DAL.Models.MauSac", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.Navigation("hoadon");
                });

            modelBuilder.Entity("_1.DAL.Models.NSX", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1.DAL.Models.PhuongThucThanhToan", b =>
                {
                    b.Navigation("ChiTietThanhToans");
                });

            modelBuilder.Entity("_1.DAL.Models.SanPham", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1.DAL.Models.SanPhamChiTiet", b =>
                {
                    b.Navigation("hoadonchitiet");
                });
#pragma warning restore 612, 618
        }
    }
}
