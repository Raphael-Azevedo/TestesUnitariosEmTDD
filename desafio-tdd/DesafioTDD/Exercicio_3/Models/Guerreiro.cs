using System;
using System.Collections.Generic;

namespace Exercicio_3.Models
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            this.Habilidade = new List<string>();
        }

        public List<string> Habilidade { get; private set; }

        public override void LvlUp()
        {
            this.Level++;
            this.Vida += 30;
            this.Forca += 10;
            Console.WriteLine($"Parabéns você subiu de Nível, agora você é Nível {this.Level}, + 30 de vida e + 10 de força, quantidade total de vida {this.Vida}, quantidade total de força {this.Forca}.");
        }

        public int Attack()
        {
            var rand = new Random();
            var dano = (this.Forca * this.Level) + rand.Next(0, 300);
            Console.WriteLine($"{this.Nome} atacou, total do dano: {dano}.");
            return dano;
        }
        public void AprenderHabilidade(string habilidade)
        {
            Habilidade.Add(habilidade);
            Console.WriteLine($"Parabéns você aprendeu a habilidade: {habilidade}.");
        }
    }
}