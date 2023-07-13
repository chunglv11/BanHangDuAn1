using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKichThuocServices
    {
        string add(KichThuocViewModels size);
        string remove(KichThuocViewModels size);
        string update(KichThuocViewModels size);
        public Guid IdSize(KichThuocViewModels CL);
        List<KichThuocViewModels> GetSizeAo();
    }
}
