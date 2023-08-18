using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeC.Domain.Models
{
    public class Log
    {
        public int Id { get; private set; }
        public DateTime Data { get; private set; } = DateTime.Now;
        public string Erro { get; private set; }

        public Log() { }

        private Log(string exception)
        {
            Erro = exception;
        }

        public static Log GerarExcecao(Exception exception) => new(exception.ToString());

    }
}