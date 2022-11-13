using Common;
using Repository.Context;
using Repository.Entities;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class MedRepository : IMedRepository
    {
        protected EFContext _dataContext;

        public MedRepository(EFContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(MedEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public void Update(MedEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public MedEntity Get(int id)
        {
            return _dataContext.Med.FirstOrDefault(o =>
                o.Id == id);
        }
        public void Delete(int id)
        {
            var entity = Get(id);
            _dataContext.Med.Remove(entity);
            _dataContext.SaveChanges();

        }
        public List<MedEntity> GetFromPerson(int personId)
        {
            return _dataContext.Med.Where(c => c.PersonId == personId).ToList();
        }
    }
}
