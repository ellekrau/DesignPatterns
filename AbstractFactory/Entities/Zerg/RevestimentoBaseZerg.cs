namespace AbstractFactory.Entities.Zerg
{
    public class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            System.Console.WriteLine("Base revestida pela cor vermelha");
        }
    }
}
