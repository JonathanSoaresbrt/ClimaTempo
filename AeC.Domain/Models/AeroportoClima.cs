using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeC.Domain.Models
{
    public class AeroportoClima
    {
        public int Id { get; private set; }
        public string CodigoIcao { get; private set; }
        public DateTime AtualizadoEm { get; private set; }
        public string PressaoAtmosferica { get; private set; }
        public string Visibilidade { get; private set; }
        public int Vento { get; private set; }
        public int DirecaoVento { get; private set; }
        public int Umidade { get; private set; }
        public string Condicao { get; private set; }
        public string CondicaoDesc { get; private set; }
        public int Temp { get; private set; }
    }
}