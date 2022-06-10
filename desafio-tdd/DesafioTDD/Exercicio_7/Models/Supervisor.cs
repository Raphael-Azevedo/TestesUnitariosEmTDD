using System;

namespace Exercicio_7.Models
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string Nome, int Idade, double Salario) : base(Nome, Idade, Salario)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Salario = Salario;
        }

        public override double Bonificacao()
        {
            var bonificacaoTotal = 5000 + this.Salario;
            Console.WriteLine($"Nome: {this.Nome}, Idade: {this.Idade}, Cargo: Supervisor, Salario Total: {bonificacaoTotal.ToString("C")}");
            return bonificacaoTotal;
        }
    }
}