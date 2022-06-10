using System;
using Xunit;
using Exercicio_2.Models;
using System.Collections.Generic;
using Xunit.Abstractions;

namespace Exercicio_3Teste
{
    public class Exercicio2Teste
    {
        ITestOutputHelper _output;

        public Exercicio2Teste(ITestOutputHelper output)
        {
            _output = output;
        }
        [Theory]
        [Trait("Categoria", "Livro")]
        [InlineData("Clen Code", 120, 50, "Robert", "educativo", 300)]
        [InlineData("Java POO", 20, 50, "GFT", "educativo", 500)]
        public void LivroEducativoNaoDeveRetornaImposto(string nome, double preco, int qtd, string autor, string tema, int qtdpag)
        {
            //Arange
            Livro livro = new Livro(nome, preco, qtd, autor, tema, qtdpag);
            var expectativa = 0;
            //Act
            var resultado = livro.CalculaImposto();
            //Assert
            _output.WriteLine($"Expectativa: {expectativa}, Resultado: {resultado}");
            Assert.Equal(expectativa, resultado);
        }
        [Theory]
        [Trait("Categoria", "Livro")]
        [InlineData("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500)]
        [InlineData("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300)]
        public void LivroNaoEducativoDeveRetorna10PorcentoDeImposto(string nome, double preco, int qtd, string autor, string tema, int qtdpag)
        {
            //Arange
            Livro livro = new Livro(nome, preco, qtd, autor, tema, qtdpag);
            var expectativa = 0.1 * preco;
            //Act
            var resultado = livro.CalculaImposto();
            //Assert
            _output.WriteLine($"Expectativa: {expectativa}, Resultado: {resultado}");
            Assert.Equal(expectativa, resultado);
        }
        [Theory]
        [Trait("Categoria", "VideoGame")]
        [InlineData("PS4", 1000, 7, "Sony", "Slim", true)]
        [InlineData("PS3", 350, 5, "Sony", "Slim", true)]
        public void VideoGameUsadoDeveRetorna25PorcentoDeImposto(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
        {
            //Arange
            VideoGame videoGame = new VideoGame(nome, preco, qtd, marca, modelo, isUsado);
            var expectativa = 0.25 * preco;
            //Act
            var resultado = videoGame.CalculaImposto();
            //Assert
            _output.WriteLine($"Expectativa: {expectativa}, Resultado: {resultado}");
            Assert.Equal(expectativa, resultado);
        }
        [Theory]
        [Trait("Categoria", "VideoGame")]
        [InlineData("PS4", 1800, 100, "Sony", "Slim", false)]
        [InlineData("XBOX", 1500, 500, "Microsoft", "One", false)]
        public void VideoGameUsadoDeveRetorna45PorcentoDeImposto(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
        {
            //Arange
            VideoGame videoGame = new VideoGame(nome, preco, qtd, marca, modelo, isUsado);
            var expectativa = 0.45 * preco;
            //Act
            var resultado = videoGame.CalculaImposto();
            //Assert
            _output.WriteLine($"Expectativa: {expectativa}, Resultado: {resultado}");
            Assert.Equal(expectativa, resultado);
        }
        [Fact]
        [Trait("Categoria", "Loja")]
        public void DeveCalcularOPatrimonioDaLoja()
        {
            //Arange
            Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            var expectativa = 50 * 40 + 60 * 30 + 1800 * 100;
            Loja americanas = new Loja("Americanas", "12345678", livros, games);
            //Act
            var resultado = americanas.CalculaPatrimonio();
            //Assert
            _output.WriteLine($"Expectativa: {expectativa}, Resultado: {resultado}");
            Assert.Equal(expectativa, resultado);
        }
    }
}
