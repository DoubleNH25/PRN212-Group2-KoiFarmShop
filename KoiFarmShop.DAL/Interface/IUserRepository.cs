using KoiFarmShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.DAL.Interface
{
    public interface IUserRepository
    {
        public void AddUser(User u);
        public List<User> GetAllEmployee();
        public void UpdateUser(User u);
        public void DeleteUser(User u);
        public User? GetUserByAccount(string email, string password);
        public List<User> GetAllUsers();
    }
}
