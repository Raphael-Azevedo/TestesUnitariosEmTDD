using Xunit;
using Xunit.Abstractions;
using DesafioTDD.Troco.Services;
using DesafioTDD.Troco.Models;

namespace DesafioTDDTeste.TrocoTestes
{
    public class TrocoTeste
    {
        ITestOutputHelper _output;

        public TrocoTeste(ITestOutputHelper output)
        {
            _output = output;
        }
        [Theory]
        [Trait("Categoria", "Troco")]
        [InlineData(364.54, 500, 135.46)]
        [InlineData(5749.67, 6000, 250.33)]
        [InlineData(250, 250, 0)]
        public void DeveRetornarTroco(double totalDaCompra, double totalPago, double esperado)
        {
            // Arange
            var expectativa = esperado;
            // Act
            var resultado = Troco.ValorDeTroco(totalDaCompra, totalPago);
            // Assert
            _output.WriteLine($"Expectativa: {expectativa}, Resultado: {resultado}");
            Assert.Equal(resultado, expectativa);
        }
        [Theory]
        [Trait("Categoria", "Troco")]
        [InlineData(364.54, 3, 1, 0, 1, 4, 0.54)]
        [InlineData(1749.67, 17, 0, 2, 0, 9, 0.67)]
        [InlineData(250, 2, 1, 0, 0, 0, 0)]
        public void DeveRetornarQuantidadeDeCedulas(double troco, int cedula100, double cedula50, double cedula20, double cedula10, double cedula1, double moeda)
        {
            // Arange
            var esperadoNota100 = cedula100;
            var esperadoNota50 = cedula50;
            var esperadoNota20 = cedula20;
            var esperadoNota10 = cedula10;
            var esperadoNota1 = cedula1;
            var esperadoMoedas = moeda;
            // Act
            var resultado = Troco.CedulasTroco(troco);
            // Assert
            Assert.IsType<Cedulas>(resultado);
            Assert.Equal(resultado.Cedula100, esperadoNota100);
            Assert.Equal(resultado.Cedula50, esperadoNota50);
            Assert.Equal(resultado.Cedula20, esperadoNota20);
            Assert.Equal(resultado.Cedula10, esperadoNota10);
            Assert.Equal(resultado.Cedula1, esperadoNota1);
            Assert.Equal(resultado.moedas, esperadoMoedas);
        }
        [Theory]
        [Trait("Categoria", "Troco")]
        [InlineData(0.74, 1, 2, 0, 4)]
        [InlineData(0.67, 1, 1, 1, 2)]
        [InlineData(0, 0, 0, 0, 0)]
        public void DeveRetornarQuantidadeDeMoedas(double troco, double moeda50, double moeda10, double moeda05, double moeda01)
        {
            // Arange
            var esperadoMoeda50 = moeda50;
            var esperadoMoeda10 = moeda10;
            var esperadoMoeda05 = moeda05;
            var esperadoMoeda01 = moeda01;
            // Act
            var resultado = Troco.MoedasTroco(troco);
            // Assert
            Assert.IsType<Moedas>(resultado);
            Assert.Equal(resultado.Moeda50, esperadoMoeda50);
            Assert.Equal(resultado.Moeda10, esperadoMoeda10);
            Assert.Equal(resultado.Moeda5, esperadoMoeda05);
            Assert.Equal(resultado.Moeda1, esperadoMoeda01);
        }
    }
}