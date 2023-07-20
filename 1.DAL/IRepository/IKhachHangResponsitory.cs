using _1.DAL.Models;

using _1.DAL.Repository;

using System;
using System.Collections.Generic;

namespace _1.DAL.IRepository
{
    public interface IKhachHangResponsitory
    {
        bool AddKhachHang(KhachHang obj);
        bool DeleteKhachHang(KhachHang obj); // Modify the parameter to Guid
        bool EditKhachHang(KhachHang obj);
        List<KhachHang> GetAllKhachHang();

    }
}
