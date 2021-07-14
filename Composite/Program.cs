using Composite.Entities;
using System;

namespace Composite
{
    static class Program
    {
        static void Main()
        {            
            var caverna1 = new Composite(" Caverna 1");
            caverna1.Adicionar(new FaseJogo(" Sub Fase 1"));
            caverna1.Adicionar(new FaseJogo(" Sub Fase 2"));
            caverna1.Adicionar(new FaseJogo(" Sub Fase 3"));

            var portaSecreta = new Composite(" Porta Secreta");
            portaSecreta.Adicionar(new FaseJogo(" Sub Fase Secreta X"));

            var caverna2 = new Composite(" Caverna 1");
            caverna2.Adicionar(new FaseJogo(" Sub Fase 4"));
            caverna2.Adicionar(new FaseJogo(" Sub Fase 5"));
            caverna2.Adicionar(portaSecreta);

            var mapa = new Composite(" MAPA DAS CAVERNAS");
            mapa.Adicionar(caverna1);
            mapa.Adicionar(caverna2);

            mapa.Mostrar(1);

            Console.ReadKey();
        }
    }
}
