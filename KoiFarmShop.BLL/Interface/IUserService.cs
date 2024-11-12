using KoiFarmShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.BLL.Interface
{
    public interface IUserService
    {
        public void AddUser(User u);
        public void UpdateUser(User u);
        public void DeleteUser(User u);
        public User? GetUserByAccount(string email, string password);
        public List<User> GetAllUsers();
        public List<User> GetAllEmployee();
    }
}
