using System;

namespace Exercicio_3.Models
{
    public class Personagem
    {
        public static int numeroDePersonagens;
        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            this.Nome = nome;
            this.Vida = vida;
            this.Mana = mana;
            this.Xp = xp;
            this.Inteligencia = inteligencia;
            this.Forca = forca;
            this.Level = level;
            Personagem.numeroDePersonagens++;
            Console.WriteLine($"Foi criado {numeroDePersonagens} personagens!.");
        }

        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public float Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }

        public virtual void LvlUp(){}
    }
}