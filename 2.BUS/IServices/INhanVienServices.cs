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
        //bool Add(NhanVien obj);
        //bool Update(NhanVien obj);
        //bool Delete(NhanVien obj);
        //List<NhanVien> GetAll();
        //NhanVien? GetByMa(string? ma);

        //bool CheckMa(string ma);
        //List<NhanVienViewModels> GetAllView();



        //<<<<<<< Updated upstream
        bool Add(NhanVien nhanvien);
        bool Update(NhanVien nhanvien);
        bool Delete(Guid Id);
        List<NhanVien> GetAll();
        NhanVien? GetByMa(string? ma);

        bool CheckMa(string ma);
        public List<NhanVienViewModels> GetAllView();



        //=======
        //>>>>>>> Stashed changes

    }
}
