using System;
using DesafioTDD.Troco.Models;

namespace DesafioTDD.Troco.Services
{
    public static class Troco
    {
        public static double ValorDeTroco(double totalDaCompra, double totalPago)
        {
            var troco = totalPago - totalDaCompra;
            troco = Math.Round( troco, 2);
            return troco;
        }
        public static Cedulas CedulasTroco(double troco)
        {
            Cedulas cedulas = new Cedulas();
            while (troco >= 1)
            {
                if (troco >= 100)
                {
                    troco -= 100.00;
                    cedulas.Cedula100 += 1;
                }
                if (troco < 100 && troco >= 50)
                {
                    troco -= 50.00;
                    cedulas.Cedula50 += 1;
                }
                if (troco < 50 && troco >= 20)
                {
                    troco -= 20.00;
                    cedulas.Cedula20 += 1;
                }
                if (troco < 20 && troco >= 10)
                {
                    troco -= 10.00;
                    cedulas.Cedula10 += 1;
                }
                if (troco < 10 && troco >= 1)
                {
                    troco -= 1.00;
                    cedulas.Cedula1 += 1;
                }

                troco = Math.Round( troco, 2);
            }
            cedulas.moedas = troco;
            return cedulas;
        }
        public static Moedas MoedasTroco(double troco)
        {
            Moedas moedas = new Moedas();
            while (troco >= 0.01)
            {
                if (troco >= 0.50)
                {
                    troco -= 0.50;
                    moedas.Moeda50 += 1;
                }
                if (troco < 0.50 && troco >= 0.10)
                {
                    troco -= 0.10;
                    moedas.Moeda10 += 1;
                }
                if (troco < 0.10 && troco >= 0.05)
                {
                    troco -= 0.05;
                    moedas.Moeda5 += 1;
                }
                if (troco < 0.05 && troco >= 0.01)
                {
                    troco -= 0.01;
                    moedas.Moeda1 += 1;
                }
                troco = Math.Round( troco, 2);
            }
            return moedas;
        }
        public static double ValidarEntrada()
        {
            Double x;
            var respost = Console.ReadLine();
            while (!double.TryParse(respost, out x))
            {
                Console.WriteLine("Valor invalido, insira um numero valido!");
                respost = Console.ReadLine();
            }
            return x;
        }
        public static double ValidaTroco()
        {
            Console.WriteLine("Seja bem vindo ao mercado Code!");
            Console.WriteLine("Digite o total da compra: ");
            var totalCompra = ValidarEntrada();
            Console.WriteLine("Digite o total pago:");
            var totalPago = ValidarEntrada();

            var troco = ValorDeTroco(totalCompra, totalPago);

            while (troco < 0)
            {
                Console.WriteLine("Valores incorretos, total do pagamento tem que ser maior que o valor de compra");
                Console.WriteLine("Digite o total da compra: ");
                totalCompra = ValidarEntrada();
                Console.WriteLine("Digite o total pago:");
                totalPago = ValidarEntrada();

                troco = ValorDeTroco(totalCompra, totalPago);
            }
            return troco;
        }
        public static void ResultadoCedula(Cedulas cedula, double troco)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"O Troco será de: {troco.ToString("C")}, favor devolver as cédulas:");
            Console.WriteLine("----------------------------------------------------------");
            if (cedula.Cedula100 > 0)
                Console.WriteLine($"CÉDULA DE R$ 100,00: {cedula.Cedula100.ToString()}");

            if (cedula.Cedula50 > 0)
                Console.WriteLine($"CÉDULA DE R$ 50,00: {cedula.Cedula50.ToString()}");

            if (cedula.Cedula20 > 0)
                Console.WriteLine($"CÉDULA DE R$ 20,00: {cedula.Cedula20.ToString()}");

            if (cedula.Cedula10 > 0)
                Console.WriteLine($"CÉDULA DE R$ 10,00: {cedula.Cedula10.ToString()}");

            if (cedula.Cedula1 > 0)
                Console.WriteLine($"CÉDULA DE R$ 1,00: {cedula.Cedula1.ToString()}");
        }
        public static void ResultadoMoeda(Moedas moeda, double troco)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"O Troco será de: {troco.ToString("C")}, favor devolver as moedas:");
            Console.WriteLine("----------------------------------------------------------");
            if (moeda.Moeda50 > 0)
                Console.WriteLine($"MOEDA DE R$ 0,50: {moeda.Moeda50.ToString()}");

            if (moeda.Moeda10 > 0)
                Console.WriteLine($"MOEDA DE R$ 0,10: {moeda.Moeda10.ToString()}");

            if (moeda.Moeda5 > 0)
                Console.WriteLine($"MOEDA DE R$ 0,05: {moeda.Moeda5.ToString()}");

            if (moeda.Moeda1 > 0)
                Console.WriteLine($"MOEDA DE R$ 0,01: {moeda.Moeda1.ToString()}");
        }
    }
}