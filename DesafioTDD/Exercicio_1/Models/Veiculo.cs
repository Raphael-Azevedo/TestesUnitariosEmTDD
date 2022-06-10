using System;

namespace Exercicio_1.Models
{
    public class Veiculo
    {
        public Veiculo(string marca, string modelo, string placa, string cor, float km, bool isLigado, int litrosCombustivel, int velocidade, double preco)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
            this.Km = km;
            this.IsLigado = isLigado;
            this.LitrosCombustivel = litrosCombustivel;
            this.Velocidade = velocidade;
            this.Preco = preco;
        }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public float Km { get; private set; }
        public bool IsLigado { get; private set; }
        public int LitrosCombustivel { get; private set; }
        public int Velocidade { get; private set; }
        public double Preco { get; private set; }

        public void Acelerar()
        {
            if (IsLigado)
            {
                this.Velocidade += +20;
                Console.WriteLine("Acelerando o veiculo... Velocidade após acelarar o veiculo: " + this.Velocidade + " km/h");
            }
            else
            {
                Console.WriteLine("Para acelerar, o carro tem que está ligado!");
            }

        }
        public void Abastecer(int combustivel)
        {
            var combustivelTotal = this.LitrosCombustivel + combustivel;

            if (combustivelTotal > 60)
            {
                this.LitrosCombustivel = 60;
                Console.WriteLine("Só foi possivel abastecer até 60 Litros, a quantidade desejada é superior ao limite do tanque!");
            }
            else if (combustivel > 0 && combustivel <= 60)
            {
                this.LitrosCombustivel = combustivelTotal;
                Console.WriteLine("Quantidade de combustivel após abastecimento: " + this.LitrosCombustivel + " Litros");
            }
            else
            {
                Console.WriteLine("Quantidade de combustivel inválida, favor verificar!");
            }
        }
        public void Frear()
        {
            if (this.Velocidade >= 20)
            {
                this.Velocidade -= 20;
                Console.WriteLine("Freiando... o veiculo desacelerou, Velocidade após frear o veiculo: " + this.Velocidade + " km/h");
            }

            else if (this.Velocidade < 20 && this.Velocidade > 0)
            {
                this.Velocidade = 0;
                Console.WriteLine("Freiando... o veiculo desacelerou, Velocidade após frear o veiculo: " + this.Velocidade + " km/h");
            }
            else if (this.Velocidade == 0)
            {
                Console.WriteLine("Veiculo já se encontra parado");
            }
        }
        public void Pintar(string cor)
        {
            this.Cor = cor;
            Console.WriteLine("A cor do veiculo após a pintura é " + this.Cor);
        }
        public void Ligar()
        {
            if (this.IsLigado)
            {
                Console.WriteLine("O veiculo já está ligado");
            }
            else
            {
                this.IsLigado = true;
                Console.WriteLine("O veiculo foi ligado");
            }
        }
        public void Desligar()
        {
            if (!this.IsLigado)
            {
                Console.WriteLine("O veiculo já está desligado");
            }
            else if (this.IsLigado && this.Velocidade == 0)
            {
                this.IsLigado = false;
                Console.WriteLine("O veiculo foi desligado");
            }
            else if (this.IsLigado && this.Velocidade > 0)
            {
                Console.WriteLine("O veiculo não pode ser desligado em movimento!");
            }
        }
    }

}