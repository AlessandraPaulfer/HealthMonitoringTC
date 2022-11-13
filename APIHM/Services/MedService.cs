using Common;
using Repository.Entities;
using Repository;
using Repository.Repositories;
using APIHM.Services.Interfaces;
using Repository.Repositories.Interfaces;

namespace APIHM.Services
{
    public class MedService : IMedService
    {
        public readonly IMedRepository medRepository;

        public MedService(IMedRepository medRepository)
        {
            this.medRepository = medRepository;
        }

        public void AddMed(MedModel model)
        {
            MedEntity entity = new MedEntity()
            {
                PersonId = model.PersonId,
                Date = DateTime.UtcNow,
                Descri = model.Descri,
                Quantity = model.Quantity,
                Type = model.Type,
            };
            medRepository.Add(entity);
        }
        public void UpdateMed(MedModel model)
        {
            MedEntity entity = new MedEntity()
            {
                Id = model.Id,
                Descri = model.Descri,
                Quantity = model.Quantity,
                Type = model.Type
            };
            medRepository.Update(entity);
        }
        public void DeleteMed(int id)
        {
            medRepository.Delete(id);
        }
        public List<MedEntity> GetFromPerson(int id)
        {
            return medRepository.GetFromPerson(id);
        }
    }
}
