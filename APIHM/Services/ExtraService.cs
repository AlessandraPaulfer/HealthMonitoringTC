using Common;
using Repository.Entities;
using Repository;
using Repository.Repositories;
using APIHM.Services.Interfaces;
using Repository.Repositories.Interfaces;

namespace APIHM.Services
{
    public class ExtraService : IExtraService
    {
        public readonly IExtraRepository extraRepository;

        public ExtraService(IExtraRepository extraRepository)
        {
            this.extraRepository = extraRepository;
        }
        public void AddExtra(ExtraModel model)
        {
            ExtraEntity entity = new ExtraEntity()
            {
                PersonId = model.PersonId,
                Date = DateTime.UtcNow,
                Descri = model.Descri,
                Quantity = model.Quantity
            };
            extraRepository.Add(entity);
        }
        public void UpdateExtra(ExtraModel model)
        {
            ExtraEntity entity = new ExtraEntity()
            {
                Id = model.Id,
                Descri = model.Descri,
                Quantity = model.Quantity
            };
            extraRepository.Update(entity);
        }
        public void DeleteExtra(int id)
        {
            extraRepository.Delete(id);
        }
        public List<ExtraEntity> GetFromPerson(int id)
        {
            return extraRepository.GetFromPerson(id);
        }
    }
}
