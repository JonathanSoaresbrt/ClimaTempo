using System.Text.Json;
using AeC.Application.Services.Interfaces;
using AeC.Domain.Interfaces.Repositories;
using AeC.Domain.Models;
using AeC.Domain.ValueObjects;
using AeC.Services.interfaces.BrasilApi;
using AutoMapper;

namespace AeC.Application.Services.Cidade
{
    public class ApplicationServiceCidade : IApplicationServiceCidade
    {
        private readonly IRepositoryCidade _repositoryCidade;
        private readonly IApiExternaClima _apiExternaClima;
        private readonly IRepositoryLog _repositoryLog;
        private readonly IMapper _mapper;

        public ApplicationServiceCidade(IRepositoryCidade repositoryCidade, IApiExternaClima apiExternaClima, IMapper mapper, IRepositoryLog repositoryLog)
        {
            _repositoryCidade = repositoryCidade;
            _apiExternaClima = apiExternaClima;
            _repositoryLog = repositoryLog;
            _mapper = mapper;
        }

        public async Task<CidadeClima> GravarCidade(int codigoCidade)
        {
            try
            {
                var cidadeClimaDto = await _apiExternaClima.GetClimaCidade(codigoCidade);

                var cidadeClima = _mapper.Map<CidadeClima>(cidadeClimaDto);

                cidadeClima.VincularEnderecoCidadeClima(cidadeClimaDto.Cidade, cidadeClimaDto.Estado);

                _repositoryCidade.Add(cidadeClima);

                return _repositoryCidade.GetById(cidadeClima.Id);
            }
            catch (Exception ex)
            {
                _repositoryLog.Add(Log.GerarExcecao(ex));

                throw new Exception("Ocorreu um erro na gravação no Clima da Cidade!}");
            }
        }
    }
}