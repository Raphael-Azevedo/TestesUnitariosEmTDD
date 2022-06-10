using System;
namespace Exercicio_7.Models
{
    public class Funcionario
    {
        public Funcionario(string Nome, int Idade, double Salario)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Salario = Salario;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public virtual double Bonificacao()
        {
            Console.WriteLine($"Nome: {this.Nome}, Idade: {this.Idade}, Cargo: Funcionario, Salario Total: {this.Salario.ToString("C")}");
            return this.Salario;
        }
    }
}