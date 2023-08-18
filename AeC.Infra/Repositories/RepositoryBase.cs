using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AeC.Domain.Interfaces.Repositories;
using AeC.Infra.Context;

namespace AeC.Infra.Repositories
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DbContextAec _dbContextAec;

        public RepositoryBase(DbContextAec context)
        {
            _dbContextAec = context;
        }
        public void Add(TEntity obj)
        {
            try
            {
                _dbContextAec.Set<TEntity>().Add(obj);
                _dbContextAec.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public TEntity GetById(int id)
        {
            return _dbContextAec.Set<TEntity>().Find(id);
        }

        public void Dispose()
        {
            _dbContextAec.Dispose();
        }
    }
}