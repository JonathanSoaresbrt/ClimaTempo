using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AeC.Domain.Dto
{
    public record AeroportoClimaDto
    {
        [JsonProperty("codigo_icao")]
        public string CodigoIcao { get; init; }
        [JsonProperty("atualizado_em")]
        public DateTime AtualizadoEm { get; init; }
        [JsonProperty("pressao_atmosferica")]
        public string PressaoAtmosferica { get; init; }
        public string Visibilidade { get; init; }
        public int Vento { get; init; }
        [JsonProperty("direcao_vento")]
        public int DirecaoVento { get; init; }
        public int Umidade { get; init; }
        public string Condicao { get; init; }
        [JsonProperty("condicao_desc")]
        public string CondicaoDesc { get; init; }
        public int Temp { get; init; }
    }
}