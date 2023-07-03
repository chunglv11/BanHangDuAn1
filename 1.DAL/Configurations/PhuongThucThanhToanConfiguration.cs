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
    public class PhuongThucThanhToanConfiguration : IEntityTypeConfiguration<PhuongThucThanhToan>
    {
        public void Configure(EntityTypeBuilder<PhuongThucThanhToan> builder)
        {
            builder.ToTable("PhuongThucThanhToan");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.MaPTThanhToan).HasColumnType("nvarchar(20)");
            builder.Property(x => x.TenPTThanhToan).HasColumnType("nvarchar(50)");
            builder.Property(x => x.TrangThai);
        }
    }
}
