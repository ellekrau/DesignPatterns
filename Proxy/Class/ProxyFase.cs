namespace Proxy.Class
{
    public class ProxyFase : IFase
    {
        FaseJogo faseJogo;
        const string password = "123";

        public string Jogar()
        {
            if (faseJogo != null)
                return faseJogo.Jogar();

            return " Informe o PASSWORD correto para abrir a fase do jogo!";
        }

        public string InformarPassword(string codigo)
        {
            if (codigo == password)
            {
                faseJogo = new FaseJogo();
                return " Password correto!";
            }

            return " Password incorreto!";
        }
    }
}
