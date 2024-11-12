using KoiFarmShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.BLL.Service
{
    public class CurrentUserService
    {
        private static CurrentUserService _instance;
        public User CurrentAccount { get; set; }
        private CurrentUserService() { }
        public static CurrentUserService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CurrentUserService();
                }
                return _instance;
            }
        }
    }
}
