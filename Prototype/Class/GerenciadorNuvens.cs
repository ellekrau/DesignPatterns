using System.Collections.Generic;

namespace Prototype.Entities
{
    public class GerenciadorNuvens
    {
        private readonly IDictionary<string, NuvemMolde> nuvens = new Dictionary<string, NuvemMolde>();

        public NuvemMolde this[string key]
        {
            get { return nuvens[key];  }
            set { nuvens.Add(key, value);  }
        }
    }
}
