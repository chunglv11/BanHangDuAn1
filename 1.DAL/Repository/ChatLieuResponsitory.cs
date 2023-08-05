using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class ChatLieuResponsitory : IChatLieuResponsitory
    {
        private ShopContext _shopContext;
        public ChatLieuResponsitory()
        {
            _shopContext = new ShopContext();
        }
        public bool AddChatLieuFromDb(ChatLieu obj)
        {
            try
            {
                _shopContext.ChatLieus.Add(obj);
                _shopContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteChatLieuFromDb(ChatLieu obj)
        {
            try
            {
                if (obj == null) return false;
                var temsize = _shopContext.ChatLieus.FirstOrDefault(p => p.ID == obj.ID);
                _shopContext.ChatLieus.Remove(temsize);
                _shopContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ChatLieu> GetAll()
        {
            return _shopContext.ChatLieus.ToList();
        }

        public ChatLieu Getbyid(Guid id)
        {
            return _shopContext.ChatLieus.FirstOrDefault(c => c.ID == id);
        }

        public bool UpdateChatLieuFromDb(ChatLieu obj)
        {
            if (obj == null) return false;
            var temsize = _shopContext.ChatLieus.FirstOrDefault(p => p.ID == obj.ID);
            temsize.Ma = obj.Ma;
            temsize.Ten = obj.Ten;
            temsize.TrangThai = obj.TrangThai;
            _shopContext.ChatLieus.Update(temsize);
            _shopContext.SaveChanges();
            return true;
        }
    }
}
