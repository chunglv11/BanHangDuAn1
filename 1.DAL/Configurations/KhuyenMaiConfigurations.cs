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
    public class KhuyenMaiConfigurations : IEntityTypeConfiguration<KhuyenMai>
    {
        public void Configure(EntityTypeBuilder<KhuyenMai> builder)
        {
            builder.ToTable("KhuyenMai");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ma).HasColumnType("nvarchar(20)");
            builder.Property(x => x.Ten).HasColumnType("nvarchar(100)");
            builder.Property(x => x.PhanTramGiam);
            builder.Property(x => x.SoTienGiam);
            builder.Property(x => x.TrangThai);
            builder.Property(x => x.NgayBatDau);
            builder.Property(x => x.NgayKetThuc);

        }
    }
}
