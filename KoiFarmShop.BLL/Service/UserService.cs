using KoiFarmShop.BLL.Interface;
using KoiFarmShop.DAL.Interface;
using KoiFarmShop.DAL.Models;
using KoiFarmShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.BLL.Service
{
    public class UserService : IUserService
    {
        private IUserRepository repo = new UserRepository();
        public void AddUser(User u)
        {
            repo.AddUser(u);
        }

        public void DeleteUser(User u)
        {
            repo.DeleteUser(u);
        }

        public List<User> GetAllEmployee()
        {
           return repo.GetAllEmployee();
        }

        public List<User> GetAllUsers()
        {
            return repo.GetAllUsers();
        }

        public User? GetUserByAccount(string email, string password)
        {
            return repo.GetUserByAccount(email, password);
        }

        public void UpdateUser(User u)
        {
            repo.UpdateUser(u);
        }
    }
}
