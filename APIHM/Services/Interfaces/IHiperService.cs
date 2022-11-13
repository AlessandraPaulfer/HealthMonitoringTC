using Common;
using Repository.Entities;

namespace APIHM.Services.Interfaces
{
    public interface IHiperService
    {
        void AddHiper(HiperModel model);
        void UpdateHiper(HiperModel model);
        public void DeleteHiper(int id);
        List<HiperEntity> HiperPeriod(DataModel dataModel);
        List<HiperEntity> GetFromPerson(int id);
    }
}
