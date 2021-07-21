namespace AbstractFactory.Entities.Zerg
{
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composicao()
        {
            System.Console.WriteLine("Energia de sustentação da base pela terra");
        }
    }
}
