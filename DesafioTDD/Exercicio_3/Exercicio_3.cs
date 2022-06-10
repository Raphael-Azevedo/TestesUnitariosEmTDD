using System;
using Exercicio_3.Models;

namespace Exercicio_3
{
    class Exercicio3
    {
        public void Main()
        {
            Mago mago1 = new Mago("Merlim", 20, 60, 234.2f, 35, 5, 6);
            Guerreiro guerreiro1 = new Guerreiro("Hercules", 60, 15, 341.2f, 3, 42, 8);

            mago1.AprenderMagia("Cura");
            mago1.AprenderMagia("Bola de fogo");

            guerreiro1.AprenderHabilidade("Furia");
            guerreiro1.AprenderHabilidade("Machados girantes");

            mago1.Attack();
            mago1.LvlUp();
            mago1.LvlUp();
            mago1.Attack();

            guerreiro1.Attack();
            guerreiro1.LvlUp();
            guerreiro1.LvlUp();
            guerreiro1.Attack();

        }
    }
}
