using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ILoaiSanPhamServices
    {
         string add(PhanLoaiSpViewModels LSp);
        string remove(PhanLoaiSpViewModels LSp);
        string update(PhanLoaiSpViewModels LSp);
        public Guid IdSize(PhanLoaiSpViewModels CL);
        List<PhanLoaiSpViewModels> GetLoaiSP();
    }
}
