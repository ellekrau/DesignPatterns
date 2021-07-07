namespace AbstractFactory.Entities.Protoss
{
    public class RevestimentoBaseProtoss : IRevestimento
    {
        public void Composicao()
        {
            System.Console.WriteLine("Base revestida pela cor amarela");
        }
    }
}
