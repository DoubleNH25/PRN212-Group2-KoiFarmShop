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
    public class KoiBreedService : IKoiBreedService
    {
        private IKoiBreedRepository repo = new KoiBreedRepository();

        public void AddBreed(KoiBreed k)
        {
            repo.AddBreed(k);
        }

        public void DeleteBreed(KoiBreed k)
        {
            repo.DeleteBreed(k);
        }

        public List<KoiBreed> GetAllKoiBreed()
        {
            return repo.GetAllKoiBreed();
        }

        public KoiBreed? GetBreedById(int id)
        {
            return repo.GetBreedById(id);
        }

        public void UpdateBreed(KoiBreed k)
        {
            repo.UpdateBreed(k);
        }
    }
}
