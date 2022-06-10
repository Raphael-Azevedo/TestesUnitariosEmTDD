using System;
using System.Collections.Generic;

namespace Exercicio_3.Models
{
    public class Mago : Personagem
    {
        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            this.Magia = new List<string>();
        }

        public List<string> Magia { get; private set; }

        public override void LvlUp()
        {
            this.Level++;
            this.Mana += 30;
            this.Inteligencia += 10;
            Console.WriteLine($"Parabéns você subiu de Nível, agora você é Nível {this.Level}, + 30 de mana e + 10 de inteligencia, quantidade total de mana {this.Mana}, quantidade total de inteligencia {this.Inteligencia}.");
        }

        public int Attack()
        {
            var rand = new Random();
            var dano = (this.Inteligencia * this.Level) + rand.Next(0, 300);
            Console.WriteLine($"{this.Nome} atacou lançando um feitiço, total do dano: {dano}.");
            return dano;
        }
        public void AprenderMagia(string magia)
        {
            Magia.Add(magia);
            Console.WriteLine($"Parabéns você aprendeu a magia: {magia}.");
        }
    }
}