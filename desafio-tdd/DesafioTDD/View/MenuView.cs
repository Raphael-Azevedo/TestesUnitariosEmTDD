using System;
using Exercicio_1;
using Exercicio_7;
using Exercicio_3;
using Exercicio_2;
using DesafioTDD.Troco;

namespace DesafioTDD.MenuView
{
    static class Menu
    {
        public static void MenuPrincipal()
        {
            Console.WriteLine();
            Console.Title = "Desafio TDD";
            string title = @"
$$$$$$$\ $$$$$$$$\ $$$$$$\  $$$$$$\ $$$$$$$$\$$$$$$\ $$$$$$\        $$$$$$$$\$$$$$$$\ $$$$$$$\  
$$  __$$\$$  _____$$  __$$\$$  __$$\$$  _____\_$$  _$$  __$$\       \__$$  __$$  __$$\$$  __$$\ 
$$ |  $$ $$ |     $$ /  \__$$ /  $$ $$ |       $$ | $$ /  $$ |         $$ |  $$ |  $$ $$ |  $$ |
$$ |  $$ $$$$$\   \$$$$$$\ $$$$$$$$ $$$$$\     $$ | $$ |  $$ |         $$ |  $$ |  $$ $$ |  $$ |
$$ |  $$ $$  __|   \____$$\$$  __$$ $$  __|    $$ | $$ |  $$ |         $$ |  $$ |  $$ $$ |  $$ |
$$ |  $$ $$ |     $$\   $$ $$ |  $$ $$ |       $$ | $$ |  $$ |         $$ |  $$ |  $$ $$ |  $$ |
$$$$$$$  $$$$$$$$\\$$$$$$  $$ |  $$ $$ |     $$$$$$\ $$$$$$  |         $$ |  $$$$$$$  $$$$$$$  |
\_______/\________|\______/\__|  \__\__|     \______|\______/          \__|  \_______/\_______/ ";

            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1 - Exercicio 1 de POO");
            Console.WriteLine("2 - Exercicio 2 de POO");
            Console.WriteLine("3 - Exercicio 3 de POO");
            Console.WriteLine("4 - Exercicio 7 de POO");
            Console.WriteLine("5 - Desafio dojopuzzles (Troco)");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Escolha uma opção: ");

            var res = ValidarEntrada();
            switch (res)
            {
                case 1: Exercicio1(); break;
                case 2: Exercicio2(); break;
                case 3: Exercicio3(); break;
                case 4: Exercicio7(); break;
                case 5: Troco(); break;
                case 6: System.Environment.Exit(0); break;
                default: MenuPrincipal(); break;
            }
            static void Exercicio1()
            {
                Console.Clear();
                Exercicio1 Ex1 = new Exercicio1();
                Ex1.Main();
                MenuPrincipal();
            }
            static void Exercicio2()
            {
                Console.Clear();
                Exercicio2 Ex2 = new Exercicio2();
                Ex2.Main();
                MenuPrincipal();
            }
            static void Exercicio3()
            {
                Console.Clear();
                Exercicio3 Ex3 = new Exercicio3();
                Ex3.Main();
                MenuPrincipal();
            }
            static void Exercicio7()
            {
                Console.Clear();
                Exercicio7 Ex7 = new Exercicio7();
                Ex7.Main();
                MenuPrincipal();
            }
            static void Troco()
            {
                Console.Clear();
                TrocoMain troco = new TrocoMain();
                troco.Main();
                MenuPrincipal();
            }
            static short ValidarEntrada()
            {
                short x;
                var respost = Console.ReadLine();
                while (!short.TryParse(respost, out x))
                {
                    Console.WriteLine("Valor invalido, insira um numero valido!");
                    respost = Console.ReadLine();
                }
                return x;
            }
        }
    }
}