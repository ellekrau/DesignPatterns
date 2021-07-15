namespace FactoryMethod.Entities.Personagens
{
    public class Scorpion : IPersonagem
    {
        public void Escolhido()
        {
            System.Console.WriteLine("Você escolheu Scorpion");
        }
    }
}
