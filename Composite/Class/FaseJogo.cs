namespace Composite.Entities
{
    public class FaseJogo : ComponenteFase
    {
        public FaseJogo(string nome) : base(nome)
        {
        }

        public override void Adicionar(ComponenteFase componenteFase)
        {
            System.Console.WriteLine(" Nao e possível adicionar a fase no jogo por aqui!");
        }

        public override void Mostrar(int profundidade)
        {
            System.Console.WriteLine($" {new string('-', profundidade)} {nome}");
        }

        public override void Remover(ComponenteFase componenteFase)
        {
            System.Console.WriteLine(" Nao e possível remover a fase do jogo por aqui!");
        }
    }
}
