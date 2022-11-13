using Common;
using Repository.Entities;

namespace APIHM.Services.Interfaces
{
    public interface IMedService
    {
        void AddMed(MedModel model);
        void UpdateMed(MedModel model);
        public void DeleteMed(int id);
        List<MedEntity> GetFromPerson(int id);
    }
}
