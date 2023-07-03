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
    public class NhanVienConfigurations : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Username).HasColumnType("nvarchar(20)");
            builder.Property(x => x.MaNv).HasColumnType("nvarchar(20)");
            builder.Property(x => x.HoTen).HasColumnType("nvarchar(50)");
            builder.Property(x => x.TrangThai);
            builder.Property(x => x.MatKhau).HasColumnType("nvarchar(50)");
            builder.Property(x => x.GioiTinh);
            builder.Property(x => x.Email).HasColumnType("nvarchar(50)"); ;
            builder.Property(x => x.AnhNv).HasColumnType("nvarchar(MAX)"); ;
            builder.Property(x => x.NgaySinh);



            builder.HasOne(x => x.ChucVu).WithMany(x => x.nhanvien).HasForeignKey(x => x.IDCV);
        }
    }
}
