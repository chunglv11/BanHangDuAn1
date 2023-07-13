using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IKichThuocResponsitory
    {
        public bool AddKichThuocFromDb(KichThuoc obj);
        public bool UpdateKichThuocFromDb(KichThuoc obj);
        public bool DeleteKichThuocFromDb(KichThuoc obj);
        public List<KichThuoc> GetAll();
        public KichThuoc Getbyid(Guid id);
    }
}
