using System.Text.Json;
using AeC.Domain.Dto;
using AeC.Services.interfaces.BrasilApi;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace AeC.Services.ExternalApis.BrasilApi
{
    public class ApiExternaClima : IApiExternaClima
    {
        private readonly IConfiguration _configuration;
        private string _apiUrl;

        public ApiExternaClima(IConfiguration configuration)
        {
            _configuration = configuration;
            _apiUrl = _configuration["ApiExternaBrasilApi:Url"];

        }

        public async Task<AeroportoClimaDto> GetClimaAeroporto(string icaoCodigo)
        {
            try
            {
                var url = $"{_apiUrl}/clima/aeroporto/{icaoCodigo}";

                HttpResponseMessage response = await HttpClientFactory.HttpClientFactory.FactoryHttpCliente().GetAsync(url);

                string responseBody = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<AeroportoClimaDto>(responseBody);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ClimaInfoDto> GetClimaCidade(int codigoCidade)
        {
            try
            {
                var url = $"{_apiUrl}/clima/previsao/{codigoCidade}";

                HttpResponseMessage response = await HttpClientFactory.HttpClientFactory.FactoryHttpCliente().GetAsync(url);

                string responseBody = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<ClimaInfoDto>(responseBody);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}