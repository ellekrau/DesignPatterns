using Composite.Entities;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : ComponenteFase
    {
        private readonly IList<ComponenteFase> fasesDoJogo = new List<ComponenteFase>();

        public Composite(string nome) : base(nome) { }

        public override void Adicionar(ComponenteFase componenteFase)
        {
            fasesDoJogo.Add(componenteFase);
        }

        public override void Mostrar(int profundidade)
        {
            System.Console.WriteLine($" {new string('-', profundidade)} {nome}");

            foreach (var fase in fasesDoJogo)
            {
                fase.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(ComponenteFase componenteFase)
        {
            fasesDoJogo.Remove(componenteFase);
        }
    }
}
