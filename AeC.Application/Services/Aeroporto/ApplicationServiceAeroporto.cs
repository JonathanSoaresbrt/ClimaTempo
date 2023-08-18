using AeC.Application.Services.Interfaces;
using AeC.Domain.Interfaces.Repositories;
using AeC.Domain.Models;
using AeC.Services.interfaces.BrasilApi;
using AutoMapper;

namespace AeC.Application.Services.Aeroporto
{
    public class ApplicationServiceAeroporto : IApplicationServiceAeroporto
    {
        private readonly IRepositoryAeroporto _repositoryAeroporto;
        private readonly IApiExternaClima _apiExternaClima;
        private readonly IRepositoryLog _repositoryLog;

        private readonly IMapper _mapper;

        public ApplicationServiceAeroporto(IRepositoryAeroporto repositoryAeroporto, IApiExternaClima apiExternaClima, IMapper mapper, IRepositoryLog repositoryLog)
        {
            _repositoryAeroporto = repositoryAeroporto;
            _apiExternaClima = apiExternaClima;
            _repositoryLog = repositoryLog;
            _mapper = mapper;
        }

        public async Task<AeroportoClima> GravarClima(string icaoCodigo)
        {
            try
            {
                var aeroportoClimaDto = await _apiExternaClima.GetClimaAeroporto(icaoCodigo);

                var aeroportoClima = _mapper.Map<AeroportoClima>(aeroportoClimaDto);

                _repositoryAeroporto.Add(aeroportoClima);

                return _repositoryAeroporto.GetById(aeroportoClima.Id);
            }
            catch (Exception ex)
            {
                _repositoryLog.Add(Log.GerarExcecao(ex));

                throw new Exception("Ocorreu um erro na gravação no Clima do Aeroporto!}");
            }
        }
    }
}