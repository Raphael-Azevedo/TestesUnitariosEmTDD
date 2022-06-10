using System;
using Exercicio_2.Interfaces;

namespace Exercicio_2.Models
{
    public class VideoGame : Produto
    {
        public VideoGame() { }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.IsUsado = isUsado;
        }

        private string Marca { get; set; }
        public string Modelo { get; private set; }
        private bool IsUsado { get; set; }

        public double CalculaImposto()
        {
            if (this.IsUsado)
            {
                double imposto = 0.25 * this.Preco;
                Console.WriteLine($"Imposto {this.Nome} {this.Modelo} usado, R$ {imposto.ToString("C")}.");
                return imposto;
            }
            else
            {
                double imposto = 0.45 * this.Preco;
                Console.WriteLine($"Imposto {this.Nome} {this.Modelo} R$ {imposto.ToString("C")}.");
                return imposto;
            }
        }
    }
}