using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChatLieuService
    {
        string add(ChatLieuViewModels clp);
        string remove(ChatLieuViewModels clp);
        string update(ChatLieuViewModels clp);
        public Guid IdSize(ChatLieuViewModels CL);
        List<ChatLieuViewModels> GetChatLieu();
    }
}
