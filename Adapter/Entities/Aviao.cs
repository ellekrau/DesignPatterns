namespace Adapter.Entities
{
    public class Aviao
    {
        public void Voar(string personagem)
        {
            System.Console.WriteLine("{0} voou pra frente", personagem);
        }

        public void SoltarMissil()
        {
            System.Console.WriteLine("Soltou um missil no jogo!");
        }
    }
}
