using KoiFarmShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.DAL.Interface
{
    public interface ISupplierRepository
    {
        public void AddSupplier (Supplier s);
        public void UpdateSupplier (Supplier s);
        public void DeleteSupplier (Supplier s);
        public Supplier? GetSupplierById (int id);
        public List<Supplier> GetAllSupplier();
    }
}
