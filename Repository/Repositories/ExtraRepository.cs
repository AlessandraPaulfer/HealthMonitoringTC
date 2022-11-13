﻿using Common;
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

        public void Add(HiperEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public void Update(HiperEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
    }
}
