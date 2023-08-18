using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AeC.Domain.ValueObjects
{

    public class Endereco
    {
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        
        private Endereco()
        {
            
        }
        
        public Endereco(string cidade, string estado)
        {
            if (string.IsNullOrEmpty(cidade))
                throw new ArgumentException("A cidade é obrigatória.", nameof(cidade));

            if (string.IsNullOrEmpty(estado))
                throw new ArgumentException("A rua é obrigatória.", nameof(estado));

            Cidade = cidade;
            Estado = estado;
        }
    }
}
