using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AeC.Domain.Dto
{
    public record ClimaDiaDto
    {
        public string Data { get; init; }
        public string Condicao { get; init; }
        public int Min { get; init; }
        public int Max { get; init; }
        public int IndiceUV { get; init; }

        [JsonProperty("condicao_desc")]
        public string CondicaoDescricao { get; init; }
    }
}