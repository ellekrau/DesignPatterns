using Flyweight.Entities;
using System;

namespace Flyweight
{
    static class Program
    {
        const string barra = "\n ----------------------------------------------- \n";
        static void Main()
        {
            var flyweight = new Flyweight();
            var cor = string.Empty;

            Tartaruga tartaruga;

            Console.WriteLine(barra);

            while (true)
            {
                Console.WriteLine(" Qual tartaruga enviar para a tela?");
                Console.Write(" > ");

                cor = Console.ReadLine();
                Console.WriteLine();

                tartaruga = flyweight.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine(barra);
            }
        }
    }
}
