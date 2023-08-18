using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AeC.Domain.Interfaces.Repositories;
using AeC.Domain.Models;
using AeC.Infra.Context;

namespace AeC.Infra.Repositories
{
    public class RepositoryAeroporto : RepositoryBase<AeroportoClima>, IRepositoryAeroporto
    {
        public RepositoryAeroporto(DbContextAec context) : base(context)
        {
        }
    }

}
