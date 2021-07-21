using Builder.Entities;

namespace Builder
{
    public abstract class CriadorDeSoldado
    {
        protected Soldado soldado;

        public Soldado ObterSoldado() =>
            soldado;

        public abstract void Arma();
        public abstract void Transporte();
        public abstract void Foco();
    }
}
