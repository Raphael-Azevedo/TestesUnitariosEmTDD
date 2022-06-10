using Exercicio_7.Models;
using System;

namespace Exercicio_7
{
    class Exercicio7
    {
        public void Main()
        {
            var gerenteGeral = new Gerente("Raphael Azevedo", 24, 8000.50);
            var supervisorArea = new Supervisor("Larissa", 28, 5000);
            var vendedor1 = new Vendedor("Felipe", 24, 1300);

            gerenteGeral.Bonificacao();
            supervisorArea.Bonificacao();
            vendedor1.Bonificacao();
        }
    }
}
