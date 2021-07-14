using Bridge.Entities;
using Bridge.Entities.Cor;
using System;

namespace Bridge
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine(" Pressione ENTER para enviar uma forma!");

            var input = Console.ReadKey();
            var bridge = new Bridge();

            while (input.Key == ConsoleKey.Enter)
            {
                bridge.CriarFormaComCor(Sortear());
                bridge.ExibeQualFormaEstaDescendoNaTela();

                input = Console.ReadKey();
            }
        }

        static (IForma, ICor) Sortear()
        {
            IForma forma;
            ICor cor;

            var random = new Random();
            var numeroSorteado = random.Next(1, 5);

            if (numeroSorteado == 1)
                forma = new FormaT();
            else
                forma = new FormaU();

            if (numeroSorteado == 1)
                cor = new Verde();
            else if (numeroSorteado == 2)
                cor = new Laranja();
            else if (numeroSorteado == 3)
                cor = new Rosa();
            else
                cor = new Azul();

            return (forma, cor);
        }
    }
}
