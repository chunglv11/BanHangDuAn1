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
    public class ChucVuConfigurations : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.ToTable("ChucVu");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ma).HasColumnType("nvarchar(20)");
            builder.Property(x => x.Ten).HasColumnType("nvarchar(20)");
            builder.Property(x => x.TrangThai);

        }
    }
}
