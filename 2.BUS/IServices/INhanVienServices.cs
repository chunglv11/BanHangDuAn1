using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INhanVienServices
    {
        List<NhanVien> GetAll();

        bool Xoa(NhanVien nhanvien);
        
        bool Them(NhanVien nhanvien);
        bool Edit(NhanVien nhannien);
        

    }
}
