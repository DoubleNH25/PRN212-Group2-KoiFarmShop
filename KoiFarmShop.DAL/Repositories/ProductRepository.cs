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
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct (Product p)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var p1 = db.Products.SingleOrDefault(b => b.ProductId == p.ProductId);
                db.Products.Remove(p1);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Product? GetProductById(int id)
        {
            using var db = new Fu2024koiFarmShopContext();
            return db.Products.FirstOrDefault(b => b.ProductId.Equals(id));
        }
        public List<Product> GetAllProducts()
        {
            var listProducts = new List<Product>();
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                listProducts = db.Products
                    .Include(p => p.Supplier)
                    .Include(p => p.Breed).ToList();
            }
            catch (Exception ex) { }
            return listProducts;
        }
        public void AddProduct(Product p)
        {
            try
            {
                using var context = new Fu2024koiFarmShopContext();
                context.Products.Add(p);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateProduct(Product p)
        {
            try
            {
                using var context = new Fu2024koiFarmShopContext();
                context.Entry<Product>(p).State
                    = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
