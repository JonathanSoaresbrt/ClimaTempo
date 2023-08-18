using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AeC.Domain.Dto
{
    public record ClimaInfoDto
    {
        public string Cidade { get; set; }
        public string Estado { get; set; }

        [JsonProperty("atualizado_em")]
        public string AtualizadoEm { get; set; }
        public List<ClimaDiaDto> Clima { get; set; }
    }
}