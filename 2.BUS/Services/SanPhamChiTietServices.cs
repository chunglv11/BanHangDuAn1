using _1.DAL.IRepository;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class SanPhamChiTietServices : ISanPhamChiTietServices
    {
        ISanPhamCTResponsitory iSpCt;
        ISanPhamResponsitory iSp;
        IKichThuocResponsitory iSize;
        IMauSacResponsitory iMauSac;
        INXSResponsitory iNsx;
        ILoaiSanPhamResponsitory IloaiSp;
        private ISanPhamCTResponsitory _iSanPhamCTResponsitory;
        public SanPhamChiTietServices()
        {
            iSpCt = new SanPhamCTResponsitory();
            iSp = new SanPhamResponsitory();
            iSize = new KichThuocResponsitory();
            iMauSac = new MauSacResponsitory();
            iNsx = new NXSResponsitory();
            IloaiSp = new LoaiSanPhamResponsitory();
            _iSanPhamCTResponsitory = new SanPhamCTResponsitory();
        }
        public Guid IdSp(SanPhamViewModels Sp)
        {
            try
            {
                var sP = new SanPham();
                sP.Ten = Sp.Ten;
                sP.Ma = Sp.Ma;
                sP.TrangThai = Sp.TrangThai;
                iSp.AddSanPhamFromDb(sP);
                return sP.ID;
            }
            catch (Exception)
            {
                return Guid.Parse(null);
                throw;
            }
        }
        public bool AddSanPhamCT(SanPhamCTViewModels obj)
        {
            SanPhamChiTiet sanPhamChiTiet = new SanPhamChiTiet()
            {
                IDSP = (Guid)obj.IDSP,
                IDKC = (Guid)obj.IDKC,
                IDMS = (Guid)obj.IDMS,
                IDNSX = (Guid)obj.IDNSX,
                IDLOAI = (Guid)obj.IDLOAI,
                Ma = obj.Ma,
                SoLuongTon = obj.SoLuongTon,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                HinhAnh = obj.HinhAnh,
                TrangThai = obj.TrangThai,
                MoTa = obj.MoTa
            };
            if (iSpCt.AddSanPhamCTFromDb(sanPhamChiTiet))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteSanPhamCT(Guid id)
        {
            if (iSpCt.DeleteSanPhamCTFromDb(id)) return true;
            return false;
        }

        public List<SanPhamChiTiet> GetAllSanPhamCT()
        {
            return _iSanPhamCTResponsitory.GetAllSanPhamCTFromDb().ToList();
        }

        public SanPhamChiTiet GetSanPhamCTByid(Guid id)
        {
            return _iSanPhamCTResponsitory.GetSanPhamCTByidFromDb(id);
        }
        public List<SanPhamCTViewModels> GetsListCtSp()
        {
            return (from a in iSpCt.GetAllSanPhamCTFromDb()
                    join b in iSp.GetAll() on a.IDSP equals b.ID
                    join c in iMauSac.GetAll() on a.IDMS equals c.ID
                    join d in iNsx.GetAll() on a.IDNSX equals d.ID
                    join e in IloaiSp.GetAll() on a.IDLOAI equals e.ID
                    join f in iSize.GetAll() on a.IDKC equals f.ID
                    select new SanPhamCTViewModels
                    {
                        ID = a.ID,
                        IDSP = b.ID,
                        IDMS = c.ID,
                        IDNSX = d.ID,
                        IDLOAI = e.ID,
                        IDKC = f.ID,
                        Ma = a.Ma,
                        TenSp = b.Ten,
                        MauSac = c.Ten,
                        Nsx = b.Ten,
                        LoaiSp = e.Ten,
                        Size = f.Ten,
                        HinhAnh = a.HinhAnh,
                        MoTa = a.MoTa,
                        SoLuongTon = a.SoLuongTon,
                        GiaBan = a.GiaBan,
                        GiaNhap = a.GiaNhap,
                        TrangThai = a.TrangThai
                    }).ToList();
        }
        public bool UpdateSanPhamCT(SanPhamCTViewModels obj)
        {
            try
            {
                SanPhamChiTiet spCt = iSpCt.GetSanPhamCTByidFromDb(obj.ID);
                spCt.IDSP = (Guid)obj.IDSP;
                spCt.IDKC = (Guid)obj.IDKC;
                spCt.IDMS = (Guid)obj.IDMS;
                spCt.IDNSX = (Guid)obj.IDNSX;
                spCt.IDLOAI = (Guid)obj.IDLOAI;
                spCt.Ma = obj.Ma;
                spCt.SoLuongTon = obj.SoLuongTon;
                spCt.GiaNhap = obj.GiaNhap;
                spCt.GiaBan = obj.GiaBan;
                spCt.HinhAnh = obj.HinhAnh;
                spCt.TrangThai = obj.TrangThai;
                spCt.MoTa = obj.MoTa;
                spCt.MoTa = obj.MoTa;
                iSpCt.UpdateSanPhamCTFromDb(spCt);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
