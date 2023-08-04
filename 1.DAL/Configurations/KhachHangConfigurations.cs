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
    public class KhachHangConfigurations : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.HovaTen).HasColumnType("nvarchar(50)");
            builder.Property(x => x.Diem);
            builder.Property(x => x.SDT).HasColumnType("nvarchar(20)");
            builder.Property(x => x.TrangThai);
        }
    }
}
