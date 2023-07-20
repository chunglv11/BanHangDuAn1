using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ISanPhamServices
    {
        string add(SanPhamViewModels Sp);
        string remove(SanPhamViewModels Sp);
        string update(SanPhamViewModels Sp);
        public Guid IdSanPham(NsxViewModels CL);
        List<SanPhamViewModels> getlsSpfromDB();
    }
}
