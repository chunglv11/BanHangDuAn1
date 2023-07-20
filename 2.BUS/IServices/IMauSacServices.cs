using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IMauSacServices
    {
          string add(MauSacViewModels mauSac);
        string remove(MauSacViewModels mauSac);
        string update(MauSacViewModels mauSac);
        public Guid IdmauSac(MauSacViewModels CL);
        List<MauSacViewModels> GetMauSac();
    }
}
