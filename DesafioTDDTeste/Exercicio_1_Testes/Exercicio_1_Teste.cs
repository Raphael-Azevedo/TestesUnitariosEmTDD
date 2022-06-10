using System;
using Xunit;
using Exercicio_1.Models;
using Xunit.Abstractions;

namespace Exercicio_1Teste
{
    public class Exercicio1Teste
    {
        ITestOutputHelper _output;

        public Exercicio1Teste(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        [Trait("Categoria", "Acelerar")]
        public void AcelerarAumenta20KmVelocidade()
        {
            // Arange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, true, 0, 10, 45000.00);
            var esperado = 30;
            // Act
            veiculo1.Acelerar();
            var resultado = veiculo1.Velocidade;
            // Assert
            _output.WriteLine($"Expectativa: {esperado}, Resultado: {resultado}");
            Assert.Equal(resultado, esperado);
        }
        [Fact]
        [Trait("Categoria", "Acelerar")]
        public void NaoAcelerarComCarroDesligado()
        {
            // Arange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, false, 0, 0, 45000.00);
            var esperado = 0;
            // Act
            veiculo1.Acelerar();
            var resultado = veiculo1.Velocidade;
            // Assert
            _output.WriteLine($"Expectativa: {esperado}, Resultado: {resultado}");
            Assert.Equal(resultado, esperado);
        }
        [Fact]
        [Trait("Categoria", "Abastecer")]
        public void AbastecerCombustivelComTanqueAbaixoDoLimite()
        {
            // Arrange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, true, 0, 10, 45000.00);
            var esperado = 30;
            // Act
            var combustivel = 30;
            veiculo1.Abastecer(combustivel);
            var resultado = veiculo1.LitrosCombustivel;
            // Assert
            _output.WriteLine($"Expectativa: {esperado}, Resultado: {resultado}");
            Assert.Equal(resultado, esperado);
        }
        [Fact]
        [Trait("Categoria", "Abastecer")]
        public void NaoDeveAbastecerMaisQueOLimiteDoTanque()
        {
            // Arrange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, true, 0, 10, 45000.00);
            var esperado = 60;
            // Act
            var combustivel = 120;
            veiculo1.Abastecer(combustivel);
            var resultado = veiculo1.LitrosCombustivel;
            // Assert
            _output.WriteLine($"Expectativa: {esperado}, Resultado: {resultado}");
            Assert.Equal(resultado, esperado);
        }
        [Fact]
        [Trait("Categoria", "Abastecer")]
        public void NaoDeveAbastecerValorNegativo()
        {
            // Arrange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, true, 10, 10, 45000.00);
            var esperado = 10;
            // Act
            var combustivel = -20;
            veiculo1.Abastecer(combustivel);
            var resultado = veiculo1.LitrosCombustivel;
            // Assert
            _output.WriteLine($"Expectativa: {esperado}, Resultado: {resultado}");
            Assert.Equal(resultado, esperado);
        }
        [Theory]
        [Trait("Categoria", "Frear")]
        [InlineData(70, 50)]
        [InlineData(50, 30)]
        [InlineData(30, 10)]
        public void FrearDeveDiminuirVelocidadeEm20Km(int velocidade, int esperado)
        {
            // Arange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, true, 0, velocidade, 45000.00);
            // Act
            veiculo1.Frear();
            var resultado = veiculo1.Velocidade;
            // Assert
            _output.WriteLine($"Expectativa: {esperado}, Resultado: {resultado}");
            Assert.Equal(resultado, esperado);
        }
        [Theory]
        [Trait("Categoria", "Frear")]
        [InlineData(15, 0)]
        [InlineData(10, 0)]
        [InlineData(0, 0)]
        public void FrearComMenosDe20KmDeveZerarVelocidade(int velocidade, int esperado)
        {
            // Arange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, true, 0, velocidade, 45000.00);
            // Act
            veiculo1.Frear();
            var resultado = veiculo1.Velocidade;
            // Assert
            _output.WriteLine($"Expectativa: {esperado}, Resultado: {resultado}");
            Assert.Equal(resultado, esperado);
        }
        [Theory]
        [Trait("Categoria", "Pintar")]
        [InlineData("Azul")]
        [InlineData("Verde")]
        [InlineData("Amarelo")]
        public void PintarDeveTrocarCorDoCarro(string cor)
        {
            // Arange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, true, 0, 0, 45000.00);
            // Act
            veiculo1.Pintar(cor);
            var resultado = veiculo1.Cor;
            // Assert
            _output.WriteLine($"Expectativa: {cor}, Resultado: {resultado}");
            Assert.Contains(cor, resultado);
        }
        [Fact]
        [Trait("Categoria", "Ligar")]
        public void DeveLigarCarro()
        {
            // Arange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, false, 0, 10, 45000.00);
            // Act
            veiculo1.Ligar();
            var resultado = veiculo1.IsLigado;
            // Assert
            _output.WriteLine($"Expectativa: True, Resultado: {resultado}");
            Assert.True(resultado);
        }
        [Fact]
        public void CarroLigadoNaoDeveAlterarEstado()
        {
            // Arange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, true, 0, 10, 45000.00);
            // Act
            veiculo1.Ligar();
            var resultado = veiculo1.IsLigado;
            // Assert
            _output.WriteLine($"Expectativa: True, Resultado: {resultado}");
            Assert.True(resultado);
        }
        [Fact]
        [Trait("Categoria", "Desligar")]
        public void DeveDesligarCarroComVelocidade0()
        {
            // Arange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, true, 0, 0, 45000.00);
            // Act
            veiculo1.Desligar();
            var resultado = veiculo1.IsLigado;
            // Assert
            _output.WriteLine($"Expectativa: False, Resultado: {resultado}");
            Assert.False(resultado);
        }
        [Fact]
        [Trait("Categoria", "Desligar")]
        public void NaoDeveDesligarCarroEmMovimento()
        {
            // Arange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, true, 0, 60, 45000.00);
            // Act
            veiculo1.Desligar();
            var resultado = veiculo1.IsLigado;
            // Assert
            _output.WriteLine($"Expectativa: True, Resultado: {resultado}");
            Assert.True(resultado);
        }
        [Fact]
        [Trait("Categoria", "Desligar")]
        public void CarroDesligadoNaoDeveAlterarEstado()
        {
            // Arange
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, false, 0, 10, 45000.00);
            // Act
            veiculo1.Desligar();
            var resultado = veiculo1.IsLigado;
            // Assert
            _output.WriteLine($"Expectativa: False, Resultado: {resultado}");
            Assert.False(resultado);
        }
    }
}
