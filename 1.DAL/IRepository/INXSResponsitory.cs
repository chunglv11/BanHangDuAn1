using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface INXSResponsitory
    {
        public bool AddNsxFromDb(NSX obj);
        public bool UpdateNsxFromDb(NSX obj);
        public bool DeleteNsxFromDb(NSX obj);
        public List<NSX> GetAll();
        public NSX Getbyid(Guid id);
    }
}
