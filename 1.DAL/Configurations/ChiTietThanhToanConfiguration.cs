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
            builder.Property(x => x.IdPhuongThucThanhToan);
            builder.Property(x => x.IdHoaDon);
            builder.Property(x => x.GhiChu).HasColumnType("nvarchar(50)");
            builder.Property(x => x.SoTienThanhToan);
            builder.Property(x => x.TrangThai);
        }
    }
}
