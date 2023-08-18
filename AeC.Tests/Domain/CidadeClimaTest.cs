using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AeC.Domain.Models;
using AeC.Domain.ValueObjects;
using Xunit;

namespace AeC.Tests.Domain
{
    public class CidadeClimaTest
    {
        private readonly CidadeClima _cidadeClima;
        public CidadeClimaTest()
        {
            _cidadeClima = new CidadeClima(DateTime.Now,new List<ClimaDia>());
        }

        [Fact(DisplayName = "Quando inserir uma cidade clima com endereço inválido estado")]
        public void InserirCidadeClima_QuandoInserirUmaCidadeClimaComEnderecoInvalidoEstado_DeveRetornarException()
        {            // Arrange
            string cidade = "São Paulo";
            string estado = string.Empty;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _cidadeClima.VincularEnderecoCidadeClima(cidade, estado));
        }

        [Fact(DisplayName = "Quando inserir uma cidade clima com endereço inválido cidade")]
        public void InserirCidadeClima_QuandoInserirUmaCidadeClimaComEnderecoInvalidoCidade_DeveRetornarException()
        {
            // Arrange
            string cidade = string.Empty;
            string estado = "PR";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _cidadeClima.VincularEnderecoCidadeClima(cidade, estado));
        }

        [Fact(DisplayName = "Quando inserir uma cidade clima com endereço válido")]
        public void TestEnderecoCreation_ValidData()
        {
            // Arrange
            string cidade = "São Paulo";
            string estado = "SP";

            // Act
            var cidadeClima = _cidadeClima.VincularEnderecoCidadeClima(cidade,estado);

            // Assert
            Assert.Equal(cidade, cidadeClima.Endereco.Cidade);
            Assert.Equal(estado, cidadeClima.Endereco.Estado);
        }
    }
}