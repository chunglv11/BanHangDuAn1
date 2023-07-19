using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class ChucVuResponsitory : IChucVuResponsitory
    {
        ShopContext _shopContext;
        List<ChucVu> _lstchucvus;
        public ChucVuResponsitory()
        {
            _shopContext = new ShopContext();
            _lstchucvus = new List<ChucVu>();

        }


        public string add(ChucVu chucVu)
        {
            _shopContext.ChucVus.Add(chucVu);
            _shopContext.SaveChanges();

            return "Thêm dữ liệu thành công";
        }

        public string delete(ChucVu chucVu)
        {
            _shopContext.ChucVus.Remove(chucVu);
            _shopContext.SaveChanges();

            return "Xóa dữ liệu thành công";
        }

        public List<ChucVu> GetAll()
        {
            return _shopContext.ChucVus.ToList();
        }





        public string update(ChucVu chucvu)
        {
            _shopContext.ChucVus.Update(chucvu);
            _shopContext.SaveChanges();

            return "Cập nhật dữ liệu thành công";
        }

    }
}
