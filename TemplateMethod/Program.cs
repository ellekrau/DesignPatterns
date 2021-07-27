using System;
using TemplateMethod.Class;

namespace TemplateMethod
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine(" ### Escolha o modo de corrida ###\n");
            Console.WriteLine(" 1 - Facil | 2 - Normal | 3 - Dificil");

            Console.WriteLine(" Suas condicoes de jogo sao: ");
            Console.Write(" > ");
            var escolha = Console.ReadLine();
            Console.WriteLine();
            
            Jogo jogo = null;

            switch (escolha)
            {
                case "1":
                    jogo = new ModoFacil();
                    break;
                case "2":
                    jogo = new ModoNormal();
                    break;
                case "3":
                    jogo = new ModoDificil();
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
