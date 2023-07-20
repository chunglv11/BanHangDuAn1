using _1.DAL.Models;
<<<<<<< Updated upstream
=======
using _1.DAL.Repository;
>>>>>>> Stashed changes
using System;
using System.Collections.Generic;

namespace _1.DAL.IRepository
{
    public interface IKhachHangResponsitory
    {
        bool AddKhachHang(KhachHang obj);
<<<<<<< Updated upstream
        bool DeleteKhachHang(KhachHang obj); // Modify the parameter to Guid
        bool EditKhachHang(KhachHang obj);
        List<KhachHang> GetAllKhachHang();
=======
        bool DeleteKhachHang(KhachHang obj);

        bool EditKhachHang(KhachHang obj);
        List<KhachHang> GetAllKhachHang();
        //List<KhachHang> GetById(Guid id);
        

>>>>>>> Stashed changes
    }
}
