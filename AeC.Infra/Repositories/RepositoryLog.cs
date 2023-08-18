using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AeC.Domain.Interfaces.Repositories;
using AeC.Domain.Models;
using AeC.Infra.Context;

namespace AeC.Infra.Repositories
{
    public class RepositoryLog : RepositoryBase<Log>, IRepositoryLog
    {
        public RepositoryLog(DbContextAec context) : base(context)
        {
        }
    }
}