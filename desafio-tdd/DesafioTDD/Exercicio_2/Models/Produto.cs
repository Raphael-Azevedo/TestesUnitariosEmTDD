

namespace Exercicio_2.Models

{
    public abstract class Produto
    {
        public Produto() { }

        public Produto(string nome, double preco, int qtd)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Qtd { get; private set; }

    }
}