using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IMedRepository
    {
        void Add(MedEntity entity);
        void Update(MedEntity entity);
        List<MedEntity> GetFromPerson(int personId);
        MedEntity Get(int id);
        void Delete(int id);
    }
}
