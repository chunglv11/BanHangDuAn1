using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface INhanVienResponsitory
    {
        string add(NhanVien nhanVien);
        string update(NhanVien nhanVien);
        string delete(NhanVien nhanVien);
        public List<NhanVien> GetAll();

    }
}
