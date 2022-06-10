using System;
using Exercicio_1.Models;

namespace Exercicio_1
{
    class Exercicio1
    {
        public void Main()
        {
            var veiculo1 = new Veiculo("Chevrolet", "Corsa hatch 1.4", "ABC1234", "Branco", 73.8f, true, 0, 10, 45000.00);
            veiculo1.Acelerar();
            veiculo1.Abastecer(30);
            veiculo1.Abastecer(35);
            veiculo1.Abastecer(-20);
            veiculo1.Frear();
            veiculo1.Frear();
            veiculo1.Frear();
            veiculo1.Pintar("Azul");
            veiculo1.Pintar("Preto");
            veiculo1.Desligar();
            veiculo1.Desligar();
            veiculo1.Ligar();
            veiculo1.Ligar();
            veiculo1.Acelerar();
            veiculo1.Desligar();
        }
    }
}
