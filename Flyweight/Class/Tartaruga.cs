namespace Flyweight.Entities
{
    public abstract class Tartaruga
    {
        protected string Condicao;

        protected string Acao;

        public string Cor { get; set; }

        public void Mostra(string cor)
        {
            Cor = cor;
            System.Console.WriteLine($" {Condicao} {Acao} {cor.ToUpper()}");
        }
    }
}
