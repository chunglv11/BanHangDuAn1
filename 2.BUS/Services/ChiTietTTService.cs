using _1.DAL.IRepository;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChiTietTTService : IChiTietTTService
    {
        private IChiTietThanhToanResponsitory _iChiTietTT;
        public ChiTietTTService()
        {
            _iChiTietTT = new ChiTietTTResponsitory();
        }
        public bool AddCTTT(ChiTietThanhToan obj)
        {
            return _iChiTietTT.AddCTTTDb(obj);
        }

        public bool DeleteCTTT(ChiTietThanhToan obj)
        {
            return _iChiTietTT.DeleteCTTTDb(obj);
        }

        public List<ChiTietThanhToan> GetAllCTT()
        {
            return _iChiTietTT.GetAllCTTDb();
        }

        public bool UpdateCTTT(ChiTietThanhToan obj)
        {
            return _iChiTietTT.UpdateCTTTDb(obj);
        }
    }
}
