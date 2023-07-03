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
    public class ChiTietThanhToanConfiguration : IEntityTypeConfiguration<ChiTietThanhToan>
    {
        public void Configure(EntityTypeBuilder<ChiTietThanhToan> builder)
        {
            builder.ToTable("ChiTietPTTT");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.GhiChu).HasColumnType("nvarchar(50)");
            builder.Property(x => x.SoTienThanhToan);
            builder.Property(x => x.TrangThai);
            builder.HasOne(c => c.hoaDon).WithMany(v => v.ChiTietThanhToans).HasForeignKey(p => p.IdHoaDon);
            builder.HasOne(c => c.phuongThucThanhToan).WithMany(v => v.ChiTietThanhToans).HasForeignKey(p => p.IdPhuongThucThanhToan);

        }
    }
}
