﻿using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>().HasData(
                new ChucVu() { ID = Guid.Parse("e36bbc87-d18b-4a9a-bc51-353e79e54586"), Ma = "CV1", Ten = "Quản lý", TrangThai = 0 },
                new ChucVu() { ID = Guid.Parse("6459bdd4-3b16-45c3-9142-a8d3cc8bbfc1"), Ma = "CV2", Ten = "Nhân viên", TrangThai = 1 }
                );
            modelBuilder.Entity<NhanVien>().HasData(
                new NhanVien() { ID = Guid.Parse("6716c72b-76d9-4626-a269-674aac3b1426"), HoTen = "Phạm Gia Khánh", GioiTinh = 0, NgaySinh = DateTime.Now, CCCD = "1342567778", DiaChi = "Ha Noi", Email = "chunglvph20985@fpt.edu.vn", SoDienThoai = "098652627222", Username = "chunglv", MatKhau = "1", IDCV = Guid.Parse("e36bbc87-d18b-4a9a-bc51-353e79e54586"), TrangThai = 1 },
                new NhanVien() { ID = Guid.Parse("a6c0391b-59a9-48e5-aada-b684e80b1250"), HoTen = "Phạm Gia Khánh", GioiTinh = 0, NgaySinh = DateTime.Now, CCCD = "1342567778", DiaChi = "Ha Noi", Email = "bena123@gmail.com", SoDienThoai = "09865262713", Username = "bena", MatKhau = "1", IDCV = Guid.Parse("6459bdd4-3b16-45c3-9142-a8d3cc8bbfc1"), TrangThai = 1 }
                );
            modelBuilder.Entity<SanPham>().HasData(
                new SanPham() { ID = Guid.Parse("3a1a4888-f7fd-46c5-808e-a42885ff4178"), Ma = "SP1", Ten = "Áo Len", TrangThai = 1 },
                new SanPham() { ID = Guid.Parse("7173cee4-5764-4da7-96a9-2fd45fef403f"), Ma = "SP2", Ten = "Áo Khoác", TrangThai = 1 },
                new SanPham() { ID = Guid.Parse("669bfd60-25cb-45e7-9585-14f45c4ea869"), Ma = "SP3", Ten = "Quần Đùi", TrangThai = 1 }
                );
            modelBuilder.Entity<MauSac>().HasData(
                new MauSac() { ID = Guid.Parse("1b5acee0-34fc-4248-b6b0-f2d0920ed633"), Ma = "MS1", Ten = "Xanh", TrangThai = 1 },
                new MauSac() { ID = Guid.Parse("612089de-9442-4534-b16d-629bcd748dfa"), Ma = "MS2", Ten = "Đỏ", TrangThai = 1 }
                );
            modelBuilder.Entity<KichThuoc>().HasData(
                new KichThuoc() { ID = Guid.Parse("5770d06e-b38f-4d87-b820-f708c04203ad"), Ma = "KT1", Ten = "L", TrangThai = 1 },
                new KichThuoc() { ID = Guid.Parse("6f7a120e-5651-4d46-baec-5ce340a5d84e"), Ma = "KT2", Ten = "X", TrangThai = 1 },
                new KichThuoc() { ID = Guid.Parse("6194d5a3-e4c8-4065-8d97-d1a60eef1795"), Ma = "KT3", Ten = "S", TrangThai = 1 }
                );
            modelBuilder.Entity<LoaiSanPham>().HasData(
                new LoaiSanPham() { ID = Guid.Parse("9489d546-f9bf-4558-ade2-b120820212f0"), Ma = "LSP1", Ten = "Áo", TrangThai = 1 },
                new LoaiSanPham() { ID = Guid.Parse("40d32121-ad17-4bd5-9e07-6db69572b50b"), Ma = "LSP2", Ten = "Quần", TrangThai = 1 }
                );
            modelBuilder.Entity<NSX>().HasData(
                new NSX() { ID = Guid.Parse("37ab68dd-bbd9-47cf-bd15-48526a38c964"), Ma = "NSX1", Ten = "LV", TrangThai = 1 },
                new NSX() { ID = Guid.Parse("74cac681-11db-4764-bd2c-6486775d22da"), Ma = "NSX2", Ten = "Guuchi", TrangThai = 1 }
                );
            modelBuilder.Entity<SanPhamChiTiet>().HasData(
                new SanPhamChiTiet() { ID = Guid.Parse("a3459c51-54ec-485c-bece-fdc74871fd4b"), IDSP = Guid.Parse("3a1a4888-f7fd-46c5-808e-a42885ff4178"), IDKC = Guid.Parse("5770d06e-b38f-4d87-b820-f708c04203ad"), IDLOAI = Guid.Parse("40d32121-ad17-4bd5-9e07-6db69572b50b"), IDMS = Guid.Parse("1b5acee0-34fc-4248-b6b0-f2d0920ed633"), IDNSX = Guid.Parse("74cac681-11db-4764-bd2c-6486775d22da"), Ma = "SPCT1", SoLuongTon = 3, DonGia = 140000, HinhAnh = "\"C:\\Users\\laich\\Downloads\\anh1.jpg\"", TrangThai = 1, MoTa = "Sản phẩm mới" },
                new SanPhamChiTiet() { ID = Guid.Parse("3b1fab5d-7bb7-4abf-a12b-f1ef9416f241"), IDSP = Guid.Parse("7173cee4-5764-4da7-96a9-2fd45fef403f"), IDKC = Guid.Parse("5770d06e-b38f-4d87-b820-f708c04203ad"), IDLOAI = Guid.Parse("40d32121-ad17-4bd5-9e07-6db69572b50b"), IDMS = Guid.Parse("1b5acee0-34fc-4248-b6b0-f2d0920ed633"), IDNSX = Guid.Parse("74cac681-11db-4764-bd2c-6486775d22da"), Ma = "SPCT2", SoLuongTon = 4, DonGia = 150000, HinhAnh = "\"C:\\Users\\laich\\Downloads\\anh2.jpg\"", TrangThai = 1, MoTa = "Sản phẩm mới 1" },
                new SanPhamChiTiet() { ID = Guid.Parse("bc2f5d6f-080a-4cf7-ada8-7e4e2ae9abcc"), IDSP = Guid.Parse("3a1a4888-f7fd-46c5-808e-a42885ff4178"), IDKC = Guid.Parse("6f7a120e-5651-4d46-baec-5ce340a5d84e"), IDLOAI = Guid.Parse("40d32121-ad17-4bd5-9e07-6db69572b50b"), IDMS = Guid.Parse("1b5acee0-34fc-4248-b6b0-f2d0920ed633"), IDNSX = Guid.Parse("74cac681-11db-4764-bd2c-6486775d22da"), Ma = "SPCT1", SoLuongTon = 3, DonGia = 140000, TrangThai = 1, MoTa = "Sản phẩm mới" }

                );
            modelBuilder.Entity<KhuyenMai>().HasData(
                new KhuyenMai() { ID = Guid.Parse("38dc8d59-1d19-4002-933e-3d09c77d8fb1"), Ma = "KM1", Ten = "Giảm 50%", NgayBatDau = DateTime.Now, NgayKetThuc = DateTime.Now, PhanTramGiam = 7, SoTienGiam = 1000, TrangThai = 1 },
                new KhuyenMai() { ID = Guid.Parse("8ee1a209-7ceb-471d-8452-b3c92408cabb"), Ma = "KM2", Ten = "Giảm 50%", NgayBatDau = DateTime.Now, NgayKetThuc = DateTime.Now, PhanTramGiam = 5, SoTienGiam = 1000, TrangThai = 1 }

                );
            modelBuilder.Entity<KhachHang>().HasData(
                new KhachHang() { ID = Guid.Parse("851a51e1-c114-4347-b663-f68334ddae2c"), HovaTen = "lại nam", SDT = "0123456890", Diem = 15, },
                new KhachHang() { ID = Guid.Parse("17253c77-e652-4051-a831-5d9c4d553d71"), HovaTen = "lại nam1", SDT = "01234542121", Diem = 12, }
                );
            modelBuilder.Entity<HoaDon>().HasData(
                new HoaDon() { ID = Guid.Parse("78f0dc70-1f8d-42c0-abcb-914c306ff39c"), IDKH = Guid.Parse("851a51e1-c114-4347-b663-f68334ddae2c"), IDKM = Guid.Parse("8ee1a209-7ceb-471d-8452-b3c92408cabb"), IDNV = Guid.Parse("6716c72b-76d9-4626-a269-674aac3b1426"), Ma = "HD1", NgayTao = DateTime.Now, NgayThanhToan = DateTime.Now, TrangThai = 1 },
                new HoaDon() { ID = Guid.Parse("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"), IDKH = Guid.Parse("851a51e1-c114-4347-b663-f68334ddae2c"), IDKM = Guid.Parse("8ee1a209-7ceb-471d-8452-b3c92408cabb"), IDNV = Guid.Parse("a6c0391b-59a9-48e5-aada-b684e80b1250"), Ma = "HD2", NgayTao = DateTime.Now, NgayThanhToan = DateTime.Now, TrangThai = 1 }
                );
            modelBuilder.Entity<HoaDonChiTiet>().HasData(
                new HoaDonChiTiet() { ID = Guid.Parse("6ab334a4-637d-47c0-a1bb-103c2ed09e73"), IDHD = Guid.Parse("78f0dc70-1f8d-42c0-abcb-914c306ff39c"), IDSPCT = Guid.Parse("a3459c51-54ec-485c-bece-fdc74871fd4b"), DonGia = 140000, SoLuong = 5 },
                new HoaDonChiTiet() { ID = Guid.Parse("854d3c4d-1571-419c-9a19-a2e0f3fbfa16"), IDHD = Guid.Parse("78f0dc70-1f8d-42c0-abcb-914c306ff39c"), IDSPCT = Guid.Parse("3b1fab5d-7bb7-4abf-a12b-f1ef9416f241"), DonGia = 140000, SoLuong = 4 }
                );
        }
    }
}
