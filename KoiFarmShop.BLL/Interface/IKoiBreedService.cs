using KoiFarmShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiFarmShop.BLL.Interface
{
    public interface IKoiBreedService
    {
        public void AddBreed(KoiBreed k);
        public void UpdateBreed(KoiBreed k);
        public void DeleteBreed(KoiBreed k);
        public KoiBreed? GetBreedById(int id);
        public List<KoiBreed> GetAllKoiBreed();
    }
}
