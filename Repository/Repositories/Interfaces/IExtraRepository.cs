using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IExtraRepository
    {
        void Add(ExtraEntity entity);
        void Update(ExtraEntity entity);
        List<ExtraEntity> GetFromPerson(int personId);
        ExtraEntity Get(int id);
        void Delete(int id);
    }
}
