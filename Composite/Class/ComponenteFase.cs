namespace Composite.Entities
{
    public abstract class ComponenteFase
    {
        protected string nome;

        protected ComponenteFase(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(ComponenteFase componenteFase);

        public abstract void Remover(ComponenteFase componenteFase);

        public abstract void Mostrar(int profundidade);

    }
}
