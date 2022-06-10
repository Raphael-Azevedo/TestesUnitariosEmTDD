using System;
using Exercicio_2.Interfaces;

namespace Exercicio_2.Models
{
    public class Livro : Produto, IImposto
    {
        public Livro() { }

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            this.Autor = autor;
            this.Tema = tema;
            this.QtdPag = qtdPag;
        }

        private string Autor { get; set; }
        private string Tema { get; set; }
        private int QtdPag { get; set; }

        public double CalculaImposto()
        {
            if (this.Tema == "educativo")
            {
                Console.WriteLine($"Livro educativo não tem imposto: {this.Nome}.");
                return 0;
            }
            else
            {
                double imposto = 0.10 * this.Preco;
                Console.WriteLine($"R$ {imposto.ToString("C")} de impostos sobre o livro {this.Nome}.");
                return imposto;
            }
        }
    }
}