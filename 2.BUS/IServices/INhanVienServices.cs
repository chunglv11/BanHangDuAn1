using _1.DAL.Models;
using _2.BUS.ViewModels;
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

        string Xoa(Guid Id);

        string Them(NhanVienViewModels NhanVienViewModels);
        string Sua(NhanVienViewModels NhanVienViewModels);
        public NhanVien GetByMa(string ma);
        public NhanVien GetById(Guid id);
        

    }
}
