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
        string add(ChucVu chucVu);
        string update(ChucVu chucVu);
        string delete(ChucVu chucVu);
        public List<ChucVu> GetAll();


    }
}

