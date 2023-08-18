using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeC.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        void Dispose();
    }
}