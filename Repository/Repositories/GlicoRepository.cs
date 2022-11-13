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
    public class GlicoRepository : IGlicoRepository
    {
        protected EFContext _dataContext;

        public GlicoRepository(EFContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(GlicoEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public void Update(GlicoEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public GlicoEntity Get(int id)
        {
            return _dataContext.Glico.FirstOrDefault(o =>
                o.Id == id);
        }
        public void Delete(int id)
        {
            var entity = Get(id);
            _dataContext.Glico.Remove(entity);
            _dataContext.SaveChanges();

        }
        public List<GlicoEntity> GetFromPerson(int personId)
        {
            return _dataContext.Glico.Where(c => c.PersonId == personId).ToList();
        }
    }
}
