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
        string Sua(ChucVuViewModels chucVuViewModels);
        string Xoa(Guid Id);
        string Them(ChucVuViewModels chucVuViewModels);
        List<ChucVuViewModels> Getlst();






        //List<ChucVuViewModels> TimKiem(string Ma);
    }
}
