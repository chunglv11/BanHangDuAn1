using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChucVuServices 
    {
     
       
        
        
        //public ChucVu GetById(Guid id);
        //public ChucVu GetByMa(string ma);
        //bool Sua(ChucVuViewModels obj);
        //string Xoa(Guid Id);
        //string Them(ChucVuViewModels chucVuViewModels);
        //List<ChucVuViewModels> Getlst();
        bool Add(ChucVu chucvu);
        bool Update(ChucVu chucvu);
        bool Delete(Guid Id);
        List<ChucVu> GetAll();
        ChucVu? GetByMa(string? ma);

        bool CheckMa(string ma);
        List<ChucVuViewModels> GetAllView();
        //bool Sua(ChucVu chucVu);






        //List<ChucVuViewModels> TimKiem(string Ma);
    }
}
