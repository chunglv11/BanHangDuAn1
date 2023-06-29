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
    public class SanPhamChiTietConfigurations : IEntityTypeConfiguration<SanPhamChiTiet>
    {
        public void Configure(EntityTypeBuilder<SanPhamChiTiet> builder)
        {
            builder.ToTable("SanPhamChiTiet");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ma).HasColumnType("nvarchar(10)"); ;
            builder.Property(x => x.GiaNhap);
            builder.Property(x => x.GiaBan);
            builder.Property(x => x.TrangThai);
            builder.Property(x => x.HinhAnh);
            builder.Property(x => x.SoLuongTon);
            builder.Property(x => x.MoTa).HasColumnType("nvarchar(50)");
            builder.HasOne(c => c.sanpham).WithMany(v => v.spct).HasForeignKey(p => p.IDSP);
            builder.HasOne(c => c.loaiSanPham).WithMany(v => v.spct).HasForeignKey(p => p.IDLOAI);
            builder.HasOne(c => c.mausac).WithMany(v => v.spct).HasForeignKey(p => p.IDMS);
            builder.HasOne(c => c.nsx).WithMany(v => v.spct).HasForeignKey(p => p.IDNSX);
            builder.HasOne(c => c.size).WithMany(v => v.spct).HasForeignKey(p => p.IDKC);
        }
    }
}
