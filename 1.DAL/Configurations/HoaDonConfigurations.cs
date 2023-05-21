using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    public class HoaDonConfigurations : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ma).HasColumnType("nvarchar(20)");
            builder.Property(x => x.NgayTao);
            builder.Property(x => x.NgayThanhToan);
            builder.Property(x => x.NgayShip);
            builder.Property(x => x.NgayNhan);
            builder.Property(x => x.TenNguoiNhan).HasColumnType("nvarchar(50)");
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(200)");
            builder.Property(x => x.SDT).HasColumnType("nvarchar(20)");
            builder.Property(x => x.TrangThai);
            builder.HasOne(p => p.nhanvien).WithMany(q => q.hoadon).HasForeignKey(v => v.IDNV);
            builder.HasOne(p => p.khachhang).WithMany(q => q.hoadon).HasForeignKey(v => v.IDKH);
            builder.HasOne(p => p.KhuyenMai).WithMany(q => q.hoaDons).HasForeignKey(v => v.IDKM);
        }
    }
}
