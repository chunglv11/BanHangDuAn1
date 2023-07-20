using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class ChiTietTTResponsitory : IChiTietThanhToanResponsitory
    {
        private ShopContext _shopContext;
        public ChiTietTTResponsitory()
        {
            _shopContext = new ShopContext();
        }
        public bool AddCTTTDb(ChiTietThanhToan obj)
        {
            _shopContext.ChiTietThanhToans.Add(obj);
            _shopContext.SaveChanges();
            return true;
        }

        public bool DeleteCTTTDb(ChiTietThanhToan obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _shopContext.ChiTietThanhToans.FirstOrDefault(c => c.ID == obj.ID);
            _shopContext.ChiTietThanhToans.Remove(temp);
            _shopContext.SaveChanges();
            return true;
        }

        public List<ChiTietThanhToan> GetAllCTTDb()
        {
            return _shopContext.ChiTietThanhToans.ToList();
        }

        public bool UpdateCTTTDb(ChiTietThanhToan obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _shopContext.ChiTietThanhToans.FirstOrDefault(c => c.ID == obj.ID);
            temp.IdHoaDon = obj.IdHoaDon;
            temp.IdPhuongThucThanhToan = obj.IdPhuongThucThanhToan;
            temp.SoTienThanhToan = obj.SoTienThanhToan;
            temp.GhiChu = obj.GhiChu;
            temp.TrangThai = obj.TrangThai;
            _shopContext.ChiTietThanhToans.Update(obj);
            _shopContext.SaveChanges();
            return true;
        }
    }
}
