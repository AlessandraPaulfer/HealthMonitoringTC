using Common;
using Repository.Entities;
using Repository;
using Repository.Repositories;
using APIHM.Services.Interfaces;
using Repository.Repositories.Interfaces;

namespace APIHM.Services
{
    public class HiperService : IHiperService
    {
        public readonly IHiperRepository hiperRepository;

        public HiperService(IHiperRepository hiperRepository)
        {
            this.hiperRepository = hiperRepository;
        }

        public void AddHiper(HiperModel model)
        {
            HiperEntity entity = new HiperEntity()
            {
                PersonId = model.PersonId,
                Date = DateTime.UtcNow,
                Sistolica = model.Sistolica,
                Diastolica = model.Diastolica,
                Batimentos = model.Batimentos,
            };
            hiperRepository.Add(entity);
        }
        public void UpdateHiper(HiperModel model)
        {
            HiperEntity entity = new HiperEntity()
            {
                Id = model.Id,
                Sistolica = model.Sistolica,
                Diastolica = model.Diastolica,
                Batimentos = model.Batimentos,
            };
            hiperRepository.Update(entity);
        }
        public void DeleteHiper(int id)
        {
            hiperRepository.Delete(id);
        }
        public List<HiperEntity> GetFromPerson(int id)
        {
            return hiperRepository.GetFromPerson(id);
        }
        public List<HiperEntity> HiperPeriod(DataModel dataModel)
        {
            if (dataModel.Days == Days.Hoje)
            {
                return hiperRepository.GetToday(dataModel.PersonId).ToList();
            }
            else if (dataModel.Days == Days.Ontem)
            {
                return hiperRepository.GetYesterday(dataModel.PersonId).ToList();
            }
            else if (dataModel.Days == Days.UltimaSemana)
            {
                return hiperRepository.GetLastWeek(dataModel.PersonId).ToList();
            }
            else if (dataModel.Days == Days.UltimoMes)
            {
                return hiperRepository.GetLastMonth(dataModel.PersonId).ToList();
            }
            else
            {
                throw new Exception("Não existem dados para esse período");
            }
        }
    }
}
