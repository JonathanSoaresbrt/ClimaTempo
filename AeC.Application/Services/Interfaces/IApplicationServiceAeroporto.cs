using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AeC.Domain.Models;

namespace AeC.Application.Services.Interfaces
{
    public interface IApplicationServiceAeroporto
    {
        Task<AeroportoClima> GravarClima(string icaoCodigo);
    }
}