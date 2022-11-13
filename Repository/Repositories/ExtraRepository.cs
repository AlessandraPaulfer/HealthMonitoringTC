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
    public class ExtraRepository : IExtraRepository
    {
        protected EFContext _dataContext;

        public ExtraRepository(EFContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(ExtraEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public void Update(ExtraEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public ExtraEntity Get(int id)
        {
            return _dataContext.Extra.FirstOrDefault(o =>
                o.Id == id);
        }
        public void Delete(int id)
        {
            var entity = Get(id);
            _dataContext.Extra.Remove(entity);
            _dataContext.SaveChanges();

        }
        public List<ExtraEntity> GetFromPerson(int personId)
        {
            return _dataContext.Extra.Where(c => c.PersonId == personId).ToList();
        }
    }
}
