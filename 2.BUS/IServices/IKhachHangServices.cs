using _1.DAL.Models;
using System;
using System.Collections.Generic;

namespace _2.BUS.IServices
{
    public interface IKhachHangServices
    {
        bool AddKhachHang(KhachHang obj);

        bool DeleteKhachHang(KhachHang obj); // Sửa đổi kiểu dữ liệu của tham số thành Guid
        bool EditKhachHang(KhachHang obj);
        List<KhachHang> GetAllKhachHang();

    }
}
