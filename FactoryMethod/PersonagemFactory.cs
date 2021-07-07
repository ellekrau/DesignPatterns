using FactoryMethod.Entities;
using FactoryMethod.Entities.Personagens;

namespace FactoryMethod
{
    public static class PersonagemFactory
    {
        public static IPersonagem EscolherPersonagem(short codigoPersonagem)
        {
            return codigoPersonagem switch
            {
                0 => null,
                1 => new Scorpion(),
                2 => new LiuKang(),
                3 => new Subzero(),
                _ => null,
            };
        }
    }
}
