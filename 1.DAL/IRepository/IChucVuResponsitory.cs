using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IChucVuResponsitory
    {
        bool add(ChucVu chucVu);
        bool update(ChucVu chucVu);
        bool delete(ChucVu chucVu);
        public List<ChucVu> GetAll();
        public ChucVu GetById(Guid id);
        public ChucVu GetByMa(string ma);

    }
}

