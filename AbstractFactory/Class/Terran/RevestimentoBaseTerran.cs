namespace AbstractFactory.Entities.Terran
{
    public class RevestimentoBaseTerran : IRevestimento
    {
        public void Composicao()
        {
            System.Console.WriteLine("Base revestida pela cor verde");
        }
    }
}
