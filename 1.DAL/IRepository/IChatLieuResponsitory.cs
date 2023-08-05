using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IChatLieuResponsitory
    {
        public bool AddChatLieuFromDb(ChatLieu obj);
        public bool UpdateChatLieuFromDb(ChatLieu obj);
        public bool DeleteChatLieuFromDb(ChatLieu obj);
        public List<ChatLieu> GetAll();
        public ChatLieu Getbyid(Guid id);
    }
}
