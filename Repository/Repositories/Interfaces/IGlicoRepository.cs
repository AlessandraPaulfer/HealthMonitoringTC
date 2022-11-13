using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IGlicoRepository
    {
        void Add(GlicoEntity entity);
        void Update(GlicoEntity entity);
        List<GlicoEntity> GetFromPerson(int personId);
        GlicoEntity Get(int id);
        void Delete(int id);
    }
}
