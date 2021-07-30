using System;
using System.Collections.Generic;
using Visitor.Class;

namespace Visitor
{
    static class Program
    {
        static void Main()
        {
            var jogo = new List<IJogo>();

            jogo.Add(new FaseJogo() { NomeFase = "Floresta" });
            jogo.Add(new FaseJogo() { NomeFase = "Caverna" });
            jogo.Add(new Chefao() { NomeChefao = "Boss 1", PontosVida = 30 });
            jogo.Add(new Chefao() { NomeChefao = "Boss 2", PontosVida = 50 });

            var niveis = new NivelVisitor();

            foreach (var etapa in jogo)
            {
                etapa.Visitante(niveis);
            }

            Console.ReadLine();
        }
    }
}
