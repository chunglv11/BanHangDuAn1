using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IMauSacResponsitory
    {
        public bool AddMauSacFromDb(MauSac obj);
        public bool UpdateMauSacFromDb(MauSac obj);
        public bool DeleteMauSacFromDb(MauSac obj);
        public List<MauSac> GetAll();
        public MauSac Getbyid(Guid id);
    }
}
