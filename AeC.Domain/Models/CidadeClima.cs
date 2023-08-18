using System.ComponentModel.DataAnnotations.Schema;
using AeC.Domain.ValueObjects;

namespace AeC.Domain.Models
{
    public class CidadeClima
    {
        public int Id { get; private set; }
        public Endereco Endereco { get; private set; }
        public DateTime AtualizadoEm { get; private set; }
        public List<ClimaDia> Clima { get; private set; }

        private CidadeClima()
        {
            
        }
        public CidadeClima(DateTime atualizadoEm, List<ClimaDia> clima)
        {
            AtualizadoEm = atualizadoEm;
            Clima = clima;
        }
        public CidadeClima VincularEnderecoCidadeClima(string cidade, string estado)
        {
            var endereco = new Endereco(cidade, estado);

            Endereco = endereco;

            return this;
        }
    }
}