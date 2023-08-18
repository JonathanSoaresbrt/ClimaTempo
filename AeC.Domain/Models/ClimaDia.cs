using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AeC.Domain.Models
{
    public class ClimaDia
    {
        public int Id { get; private set; }
        public string Data { get; private set; }
        public string Condicao { get; private set; }
        public int Min { get; private set; }
        public int Max { get; private set; }
        public int IndiceUV { get; private set; }
        public string CondicaoDescricao { get; private set; }
        public int CidadeClimaId { get; private set; }
        public CidadeClima CidadeClima { get; private set; }
    }
}