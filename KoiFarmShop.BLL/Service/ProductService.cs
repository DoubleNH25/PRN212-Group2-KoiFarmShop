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
    public class ProductService : IProductService
    {
        private IProductRepository repo = new ProductRepository();
        public void AddProduct(Product p)
        {
            repo.AddProduct(p);
        }

        public void DeleteProduct(Product p)
        {
            repo.DeleteProduct(p);
        }

        public List<Product> GetAllProducts()
        {
            return repo.GetAllProducts();
        }

        public Product? GetProductById(int id)
        {
            return repo.GetProductById(id);
        }

        public void UpdateProduct(Product p)
        {
            repo.UpdateProduct(p);
        }
    }
}
