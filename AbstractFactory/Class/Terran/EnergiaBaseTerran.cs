namespace AbstractFactory.Entities.Terran
{
    public class EnergiaBaseTerran : IEnergia
    {
        public void Composicao()
        {
            System.Console.WriteLine("Energia de sustentação da base mecânica");
        }
    }
}
