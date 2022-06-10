using System;
using Xunit;
using Exercicio_3.Models;
using System.Collections.Generic;
using Xunit.Abstractions;

namespace Exercicio_3Teste
{
    public class Exercicio3Teste
    {
        ITestOutputHelper _output;

        public Exercicio3Teste(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact(Skip = " Teste Ainda não implementado.")]
        public void DeveContarQuantidadePersonagemCriado()
        {
            // Teste vai ser implementado na próxima atualização
        }
        [Fact]
        [Trait("Categoria", "Mago")]
        public void DeveAumentarOsStatusDoMagoAoPassarDeLevel()
        {
            //Arange
            Mago mago1 = new Mago("Merlim", 20, 60, 234.2f, 35, 5, 6);
            var levelEsperado = 7;
            var manaEsperada = 90;
            var inteligenciaEsperada = 45;
            //Act
            mago1.LvlUp();
            //Assert
            Assert.Equal(levelEsperado, mago1.Level);
            Assert.Equal(manaEsperada, mago1.Mana);
            Assert.Equal(inteligenciaEsperada, mago1.Inteligencia);
        }
        [Fact]
        [Trait("Categoria", "Guerreiro")]
        public void DeveAumentarOsStatusDoGuerreiroAoPassarDeLevel()
        {
            //Arange
            Guerreiro guerreiro1 = new Guerreiro("Hercules", 60, 15, 341.2f, 3, 42, 8);
            var levelEsperado = 9;
            var vidaEsperada = 90;
            var forcaEsperada = 52;
            //Act
            guerreiro1.LvlUp();
            //Assert
            Assert.Equal(levelEsperado, guerreiro1.Level);
            Assert.Equal(vidaEsperada, guerreiro1.Vida);
            Assert.Equal(forcaEsperada, guerreiro1.Forca);
        }
        [Fact]
        [Trait("Categoria", "Guerreiro")]
        public void AtaqueDoGuerreiroDeveRetornarDano()
        {
            //Arange
            Guerreiro guerreiro1 = new Guerreiro("Hercules", 60, 15, 341.2f, 3, 42, 8);
            //Act
            var dano = guerreiro1.Attack();
            //Assert
            Assert.NotEmpty(dano.ToString());
        }
        [Fact]
        [Trait("Categoria", "Mago")]
        public void AtaqueDoMagoDeveRetornarDano()
        {
            //Arange
            Mago mago1 = new Mago("Merlim", 20, 60, 234.2f, 35, 5, 6);
            //Act
            var dano = mago1.Attack();
            //Assert
            Assert.NotEmpty(dano.ToString());
        }
        [Theory]
        [Trait("Categoria", "Guerreiro")]
        [InlineData("Lançar Machado")]
        [InlineData("Furia")]
        [InlineData("Frenesis")]
        public void AprenderHabilidadeDeveGravarHabilidade(string habilidade)
        {
            //Arange
            Guerreiro guerreiro1 = new Guerreiro("Hercules", 60, 15, 341.2f, 3, 42, 8);
            //Act
            guerreiro1.AprenderHabilidade(habilidade);
            //Assert
            _output.WriteLine($"Expectativa: {habilidade}, Resultado deve conter na lista: {guerreiro1.Habilidade}");
            Assert.Contains(habilidade, guerreiro1.Habilidade);
        }
        [Theory]
        [Trait("Categoria", "Mago")]
        [InlineData("Cura")]
        [InlineData("Bola de fogo")]
        [InlineData("Barreira")]
        public void AprenderMagiaDeveGravarMagia(string magia)
        {
            //Arange
            Mago mago1 = new Mago("Merlim", 20, 60, 234.2f, 35, 5, 6);
            //Act
            mago1.AprenderMagia(magia);
            //Assert
            _output.WriteLine($"Expectativa: {magia}, Resultado deve conter na lista: {mago1.Magia}");
            Assert.Contains(magia, mago1.Magia);
        }
    }
}
