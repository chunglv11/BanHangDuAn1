using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IChiTietThanhToanResponsitory
    {
        public bool AddCTTTDb(ChiTietThanhToan obj);
        public bool UpdateCTTTDb(ChiTietThanhToan obj);
        public bool DeleteCTTTDb(ChiTietThanhToan obj);
        public List<ChiTietThanhToan> GetAllCTTDb();
    }
}
