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
    public class SupplierRepository : ISupplierRepository
    {
        public void AddSupplier(Supplier s)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                db.Suppliers.Add(s);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteSupplier(Supplier s)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var s1 = db.Suppliers.SingleOrDefault(b => b.SupplierId == s.SupplierId);
                db.Suppliers.Remove(s1);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Supplier> GetAllSupplier()
        {
            var listSups = new List<Supplier>();
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                listSups = db.Suppliers.ToList();
            }
            catch (Exception ex) { }
            return listSups;
        }

        public Supplier? GetSupplierById(int id)
        {
            using var db = new Fu2024koiFarmShopContext();
            return db.Suppliers.FirstOrDefault(b => b.SupplierId.Equals(id));
        }

        public void UpdateSupplier(Supplier s)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                db.Entry<Supplier>(s).State
                    = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
