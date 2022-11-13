using Common;
using Repository.Entities;
using Repository;
using Repository.Repositories;
using APIHM.Services.Interfaces;
using Repository.Repositories.Interfaces;

namespace APIHM.Services
{
    public class GlicoService : IGlicoService
    {
        public readonly IGlicoRepository glicoRepository;

        public GlicoService(IGlicoRepository glicoRepository)
        {
            this.glicoRepository = glicoRepository;
        }
        public void AddGlico(GlicoModel model)
        {
            GlicoEntity entity = new GlicoEntity()
            {
                PersonId = model.PersonId,
                Date = DateTime.UtcNow,
                Value = model.Value,
                Batimentos = model.Batimentos,
                Categoria = model.Categoria
            };
            glicoRepository.Add(entity);
        }
        public void UpdateGlico(GlicoModel model)
        {
            GlicoEntity entity = new GlicoEntity()
            {
                Id = model.Id,
                Value = model.Value,
                Batimentos = model.Batimentos,
                Categoria = model.Categoria
            };
            glicoRepository.Update(entity);
        }
        public void DeleteGlico(int id)
        {
            glicoRepository.Delete(id);
        }
        public List<GlicoEntity> GetFromPerson(int id)
        {
            return glicoRepository.GetFromPerson(id);
        }
    }
}
