using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INSXServices
    {
        string add(NsxViewModels NSX);
        string remove(NsxViewModels NSX);
        string update(NsxViewModels NSX);
        public Guid IdSize(NsxViewModels CL);
        List<NsxViewModels> GetNhasanxuat();
    }
}
