using KoiFarmShop.DAL.Interface;
using KoiFarmShop.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User u)
        {
            try
            {
                using var context = new Fu2024koiFarmShopContext();
                u.CreatedDate = DateOnly.FromDateTime(DateTime.Now);
                context.Users.Add(u);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteUser(User u)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var user = db.Users.SingleOrDefault(b => b.UserId == u.UserId);
                if (user != null)
                {
                    user.Status = 0;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<User> GetAllUsers()
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                return db.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<User> GetAllEmployee()
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                return db.Users
                         .Where(u => u.Role == "Employee")
                         .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public User? GetUserByAccount(string email, string password)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                return db.Users.FirstOrDefault(b => b.Email == email 
                && b.Password == password);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error occurred while fetching user: {ex.Message}", ex);
            }
        }

        public void UpdateUser(User u)
        {
            try
            {
                using var context = new Fu2024koiFarmShopContext();
                context.Entry<User>(u).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
