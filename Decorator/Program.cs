using Decorator.Entities;
using System;

namespace Decorator
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine(" ### Veste Armadura Padrao ###");

            MoldeArmadura armadura = new ArmaduraPadrao();

            Console.WriteLine($" Descricao: {armadura.Descricao.TrimEnd(' ', ',')}");

            Console.WriteLine();

            Console.WriteLine("     ### Incluir Novos itens na Armadura (Decorar) ###");
            
            armadura = new Capacete(armadura);
            armadura = new Espada(armadura);

            Console.WriteLine($" Descricao: {armadura.Descricao.TrimEnd(' ', ',')}");

            Console.ReadKey();
        }
    }
}
