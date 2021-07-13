using Flyweight.Entities;
using System.Collections.Generic;

namespace Flyweight
{
    public class Flyweight
    {
        private readonly IDictionary<string, Tartaruga> listaDeTartarugas = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            if (listaDeTartarugas.ContainsKey(cor))
                return listaDeTartarugas[cor];

            var tartaruga = CriaInstanciaTartaruga(cor);
            listaDeTartarugas.Add(cor, tartaruga);

            return tartaruga;
        }

        private static Tartaruga CriaInstanciaTartaruga(string cor) =>
            cor switch
            {
                "azul" => new Azul(),
                "verde" => new Verde(),
                "laranja" => new Laranja(),
                _ => new Vermelha(),
            };
    }
}
