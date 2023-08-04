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
        bool add(NhanVien nhanvien);
        bool update(NhanVien nhanvien);
        bool delete(Guid Id);
        public List<NhanVien> GetAll();
        public NhanVien GetById(Guid id);
        public NhanVien GetByMa(string ma);

    }
}
