using AbstractFactory.Entities;
using AbstractFactory.Entities.Protoss;
using AbstractFactory.Entities.Terran;
using AbstractFactory.Entities.Zerg;
using System;

namespace AbstractFactory
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Escolha um personagem: \n");
            Console.WriteLine("  1 Protoss");
            Console.WriteLine("  2 Zerg");
            Console.WriteLine("  3 Terran");
            Console.WriteLine("  0 Sair");
            Console.Write("\n > ");

            _ = short.TryParse(Console.ReadLine().ToString(), out short escolha);

            if (escolha == 0)
            {
                Console.WriteLine("\n Bye!");
                Console.ReadKey();
                return;
            }

            var fabrica = EscolherPersonagem(escolha);

            Console.ReadKey();
        }

        static IFabricaBases EscolherPersonagem(short escolha)
        {
            return escolha switch
            {
                1 => new FabricaBaseProtoss(),
                2 => new FabricaBaseZerg(),
                3 => new FabricaBaseTerran(),
                _ => null,
            };
        }
    }
}
