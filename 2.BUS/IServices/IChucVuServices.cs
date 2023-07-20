using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChucVuServices 
    {
        List<ChucVu> GetAll();
       
        bool Xoa(ChucVu chucVu);
        
        bool Them(ChucVu chucVu);
        bool Sua (ChucVu chucVu);
       


        //List<ChucVuViewModels> TimKiem(string Ma);
    }
}
