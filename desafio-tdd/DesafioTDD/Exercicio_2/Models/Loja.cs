using System;
using System.Collections.Generic;

namespace Exercicio_2.Models
{
    public class Loja
    {
        public Loja() { }

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Livros = livros;
            this.VideoGames = videoGames;
        }

        private string Nome { get; set; }
        private string Cnpj { get; set; }
        private List<Livro> Livros { get; set; }
        private List<VideoGame> VideoGames { get; set; }

        public void ListaLivros()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"A loja {this.Nome} possui estes livros para venda:");
            foreach (var livro in this.Livros)
            {
                Console.WriteLine($"Titulo: {livro.Nome} , preço: {livro.Preco.ToString("C")} , quantidade: {livro.Qtd} em estoque.");
            }
        }
        public void ListaVideoGames()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"A loja {this.Nome} possui estes video-games para venda:");
            foreach (var videoGame in this.VideoGames)
            {
                Console.WriteLine($"Video-game: {videoGame.Modelo} , preço: {videoGame.Preco.ToString("C")} , quantidade: {videoGame.Qtd} em estoque.");
            }
        }
        public double CalculaPatrimonio()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            double preco = 0;
            foreach (var livro in this.Livros)
            {
                preco += (livro.Preco * livro.Qtd);
            }
            foreach (var videoGame in this.VideoGames)
            {
                preco += (videoGame.Preco * videoGame.Qtd);
            }
            Console.WriteLine($"O patrimonio da loja: {this.Nome} é de R$ {preco.ToString("C")}");
            return preco;
        }
    }
}