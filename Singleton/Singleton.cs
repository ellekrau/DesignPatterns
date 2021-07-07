namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instancia = null;

        public static Singleton GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Singleton();
                System.Console.WriteLine(" Bola em jogo");
            }

            return instancia;
        }

        public void Mensagem(string mensagem)
        {
            System.Console.WriteLine(mensagem);
        }
    }
}
