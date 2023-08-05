using _1.DAL.IRepository;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChatLieuService : IChatLieuService
    {
        private IChatLieuResponsitory _ChatLieu;
        private List<ChatLieuViewModels> lstChatlieu;
        public ChatLieuService()
        {
            _ChatLieu = new ChatLieuResponsitory();
            lstChatlieu = new List<ChatLieuViewModels>();
        }
        public string add(ChatLieuViewModels clp)
        {
            if (clp == null) return "Không Thành Công";
            var temp = _ChatLieu.Getbyid(clp.ID);
            ChatLieu x = new ChatLieu()
            {
                ID = clp.ID,
                Ma = clp.Ma,
                Ten = clp.Ten,
                TrangThai = clp.TrangThai
            };
            if (temp == null)
            {
                if (clp.Ma != "")
                {
                    if (_ChatLieu.AddChatLieuFromDb(x)) return "Thêm Thành Công";
                    return "Không Thành Công";
                }
                else return "Chưa nhập mã";
            }
            else { return "Trùng rồi"; }
        }

        public List<ChatLieuViewModels> GetChatLieu()
        {
            lstChatlieu = (from sz in _ChatLieu.GetAll()
                           select new ChatLieuViewModels
                           {
                               ID = sz.ID,
                               Ma = sz.Ma,
                               Ten = sz.Ten,
                               TrangThai = sz.TrangThai,
                           }).OrderBy(c => c.Ma).ToList();
            return lstChatlieu;
        }

        public Guid IdSize(ChatLieuViewModels CL)
        {
            ChatLieu x = new ChatLieu()
            {
                ID = CL.ID,
                Ma = CL.Ma,
                Ten = CL.Ten,
                TrangThai = CL.TrangThai
            };
            if (_ChatLieu.AddChatLieuFromDb(x)) return x.ID;
            else return Guid.Empty;
        }

        public string remove(ChatLieuViewModels clp)
        {
            if (clp == null) return "Không Thành Công";
            int a = 0;
            var x = new ChatLieu()
            {
                ID = clp.ID
            };
            var list = _ChatLieu.GetAll();
            foreach (var i in list)
            {
                if (clp.ID == i.ID) a++;
            }
            if (_ChatLieu.DeleteChatLieuFromDb(x)) return "Xóa Thành Công";
            return "Không Thành Công";
        }

        public string update(ChatLieuViewModels clp)
        {
            if (clp == null) return "Không Thành Công";
            var temp = _ChatLieu.GetAll().FirstOrDefault(c => c.ID == clp.ID);
            ChatLieu x = new ChatLieu()
            {
                ID = clp.ID,
                Ma = clp.Ma,
                Ten = clp.Ten,
                TrangThai = clp.TrangThai
            };
            if (clp.Ma != "")
            {
                if (temp == null)
                {
                    if (_ChatLieu.UpdateChatLieuFromDb(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else if (clp.ID == x.ID)
                {
                    if (_ChatLieu.UpdateChatLieuFromDb(x)) return "Sửa Thành Công";
                    return "Không Thành Công";
                }
                else { return "Trùng rồi"; }
            }
            else return "Nhập đủ thông tin";
        }
    }
}
