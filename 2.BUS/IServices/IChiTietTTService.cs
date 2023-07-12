using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChiTietTTService
    {
        public bool AddCTTT(ChiTietThanhToan obj);
        public bool UpdateCTTT(ChiTietThanhToan obj);
        public bool DeleteCTTT(ChiTietThanhToan obj);
        public List<ChiTietThanhToan> GetAllCTT();
    }
}
