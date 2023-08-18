using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AeC.Domain.Dto;

namespace AeC.Services.interfaces.BrasilApi
{
    public interface IApiExternaClima
    {
        Task<ClimaInfoDto> GetClimaCidade(int codigoCidade);
        Task<AeroportoClimaDto> GetClimaAeroporto(string icaoCodigo);
    }
}