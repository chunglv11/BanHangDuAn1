using _1.DAL.IRepository;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class SanPhamCTResponsitory : ISanPhamCTResponsitory
    {
        private ShopContext _shopContext;
        public SanPhamCTResponsitory()
        {
            _shopContext = new ShopContext();
        }
        public bool AddSanPhamCTFromDb(SanPhamChiTiet obj)
        {

            try
            {
                _shopContext.SanPhamChiTiets.Add(obj);
                _shopContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteSanPhamCTFromDb(Guid id)
        {
            try
            {
                var deleteId = _shopContext.SanPhamChiTiets.SingleOrDefault(p => p.ID == id);
                _shopContext.SanPhamChiTiets.Remove(deleteId);
                _shopContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<SanPhamChiTiet> GetAllSanPhamCTFromDb()
        {
            return _shopContext.SanPhamChiTiets.ToList();
        }

        public SanPhamChiTiet GetSanPhamCTByidFromDb(Guid id)
        {
            return _shopContext.SanPhamChiTiets.FirstOrDefault(c => c.ID == id);
        }

        public bool UpdateSanPhamCTFromDb(SanPhamChiTiet obj)
        {
            try
            {
                if (obj == null) return false;
                var Spct = _shopContext.SanPhamChiTiets.FirstOrDefault(p => p.ID == obj.ID);
                Spct.IDSP = obj.IDSP;
                Spct.IDMS = obj.IDMS;
                Spct.IDNSX = obj.IDNSX;
                Spct.IDKC = obj.IDKC;
                Spct.IDLOAI = obj.IDLOAI;
                Spct.IDCL = obj.IDCL;
                Spct.Ma = obj.Ma;
                Spct.SoLuongTon = obj.SoLuongTon;
                Spct.GiaNhap = obj.GiaNhap;
                Spct.GiaBan = obj.GiaBan;
                Spct.HinhAnh = obj.HinhAnh;
                Spct.TrangThai = obj.TrangThai;
                Spct.MoTa = obj.MoTa;
                _shopContext.SanPhamChiTiets.Update(Spct);
                _shopContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
