namespace Adapter.Entities
{
    public class Personagem : IAcao
    {
        public void Andar(string personagem)
        {
            System.Console.WriteLine("{0} andou para frente!", personagem);
        }

        public void Atirar()
        {
            System.Console.WriteLine("Atirou no jogo!");
        }
    }
}
