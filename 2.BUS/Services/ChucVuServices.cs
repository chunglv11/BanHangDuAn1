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
    public class ChucVuServices : IChucVuServices
    {
        private readonly IChucVuResponsitory ChucVuMoi;
        ShopContext context = new ShopContext();

        public ChucVuServices()
        {
            context = new ShopContext();
            ChucVuMoi = new ChucVuResponsitory();
        }

        public bool Xoa(ChucVu a)
        {

            try
            {

                ChucVuMoi.delete(a);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Sua(ChucVu a)
        {

            try
            {
                ChucVuMoi.update(a);
                context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }


        public bool Them(ChucVu a)
        {

            try
            {
                ChucVuMoi.add(a);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ChucVu> GetAll()
        {
            return ChucVuMoi.GetAll();
        }

        public ChucVu GetById(Guid id)
        {
            return GetAll().FirstOrDefault(c => c.ID == id);
        }



        public ChucVu GetByMa(string ma)
        {
            return GetAll().FirstOrDefault(c => c.Ma == ma);
        }


    }
}
