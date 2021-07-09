using Prototype.Entities;
using System;

namespace Prototype
{
    static class Program
    {
        static void Main()
        {
            var gerenciadorNuvens = new GerenciadorNuvens();

            gerenciadorNuvens["padrão"] = new NuvemConcreta("branco", "azul");
            gerenciadorNuvens["personalizada"] = new NuvemConcreta("branco", "laranja");

            var nuvemUm = gerenciadorNuvens["padrão"].Clone();
            var nuvemDois = gerenciadorNuvens["padrão"].Clone();
            var nuvemTres = gerenciadorNuvens["personalizada"].Clone();

            Console.ReadKey();
        }
    }
}
