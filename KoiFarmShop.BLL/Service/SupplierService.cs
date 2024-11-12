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
    public class SupplierService : ISupplierService
    {
        private ISupplierRepository repo = new SupplierRepository();
        public void AddSupplier(Supplier s)
        {
            repo.AddSupplier(s);
        }

        public void DeleteSupplier(Supplier s)
        {
            repo.DeleteSupplier(s);
        }

        public List<Supplier> GetAllSupplier()
        {
            return repo.GetAllSupplier();
        }

        public Supplier? GetSupplierById(int id)
        {
            return repo.GetSupplierById(id);
        }

        public void UpdateSupplier(Supplier s)
        {
            repo.UpdateSupplier(s);
        }
    }
}
