using System;

namespace FactoryMethod
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine(" Escolha um personagem: \n");
            Console.WriteLine("  1 Scorpion");
            Console.WriteLine("  2 Liu-Kang");
            Console.WriteLine("  3 Subzero");
            Console.WriteLine("  0 Sair");
            Console.Write("\n > ");

            _ = short.TryParse(Console.ReadLine().ToString(), out short escolha);

            if (escolha == 0)
            {
                Console.WriteLine("\n Bye!");
                Console.ReadKey();
                return;
            }                

            var personagem = PersonagemFactory.EscolherPersonagem(escolha);
            personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
