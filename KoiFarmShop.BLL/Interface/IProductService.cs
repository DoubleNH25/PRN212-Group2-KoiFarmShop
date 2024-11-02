using KoiFarmShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.BLL.Interface
{
    public interface IProductService
    {
        public void DeleteProduct(Product p);
        public Product? GetProductById(int id);
        public List<Product> GetAllProducts();
        public void AddProduct(Product p);
        public void UpdateProduct(Product p);
    }
}
