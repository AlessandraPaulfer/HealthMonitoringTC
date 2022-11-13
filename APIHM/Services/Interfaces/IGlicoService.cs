using Common;
using Repository.Entities;

namespace APIHM.Services.Interfaces
{
    public interface IGlicoService
    {
        void AddGlico(GlicoModel model);
        void UpdateGlico(GlicoModel model);
        public void DeleteGlico(int id);
        List<GlicoEntity> GetFromPerson(int id);
    }
}
