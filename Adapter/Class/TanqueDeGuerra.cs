namespace Adapter.Entities
{
    public class TanqueDeGuerra
    {
        public void Dirigir(string personagem)
        {
            System.Console.WriteLine("{0} esta dirigindo pra frente!", personagem);
        }

        public void AtirarComTanque()
        {
            System.Console.WriteLine("Deu um tiro com o tanque de guerra!");
        }
    }
}
