using Flyweight.Entities;
using System;

namespace Flyweight
{
    static class Program
    {
        static void Main()
        {
            var flyweight = new Flyweight();
            var cor = string.Empty;

            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine(" Qual tartaruga enviar para a tela?");
                Console.Write(" > ");

                cor = Console.ReadLine();

                tartaruga = flyweight.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine("\n ------------------------ ");
            }
        }
    }
}
