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
    public class NhanVienServices : INhanVienServices
    {
        private readonly INhanVienResponsitory NhanVienMoi;
        ShopContext context = new ShopContext();

        public NhanVienServices()
        {
            context = new ShopContext();
            NhanVienMoi = new NhanVienResponsitory();
        }

        public bool Xoa(NhanVien a)
        {

            try
            {

                NhanVienMoi.delete(a);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Edit (NhanVien a)
        {

            try
            {
                NhanVienMoi.update(a);
                context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }






      



        public bool Them(NhanVien a)
        {

            try
            {
                NhanVienMoi.add(a);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
        }

        public NhanVien GetById(Guid Id)
        {
            return GetAll().FirstOrDefault(c => c.ID == Id);
        }

        public NhanVien GetByMa(string Ma)
        {
            return GetAll().FirstOrDefault(c => c.MaNv == Ma);
        }


    }
}
