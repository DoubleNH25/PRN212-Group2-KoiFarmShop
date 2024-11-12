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
    public class KoiBreedRepository : IKoiBreedRepository
    {
        public void AddBreed(KoiBreed k)
        {
            try
            {
                using var context = new Fu2024koiFarmShopContext();
                context.KoiBreeds.Add(k);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteBreed(KoiBreed k)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                var breed = db.KoiBreeds.SingleOrDefault(b => b.BreedId == k.BreedId);
                if (breed != null)
                {
                    db.KoiBreeds.Remove(breed);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<KoiBreed> GetAllKoiBreed()
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                return db.KoiBreeds.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public KoiBreed? GetBreedById(int id)
        {
            try
            {
                using var db = new Fu2024koiFarmShopContext();
                return db.KoiBreeds.FirstOrDefault(b => b.BreedId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateBreed(KoiBreed k)
        {
            try
            {
                using var context = new Fu2024koiFarmShopContext();
                context.Entry<KoiBreed>(k).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
