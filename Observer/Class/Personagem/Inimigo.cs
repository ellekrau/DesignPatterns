namespace Observer.Class.Personagem
{
    public class Inimigo : IObservador
    {
        private readonly Principal personagemObservado;

        public Inimigo(Principal pesonagemPrincipal)
        {
            this.personagemObservado = pesonagemPrincipal;
            personagemObservado.RegistrarObservador(this);
        }

        public void Avisar(IPersonagem personagem)
        {
            if (personagem != personagemObservado)
                return;

            System.Console.WriteLine("\n + Personagem principal foi acertado com um golpe.");
            System.Console.WriteLine($" + Vida do personagem principal: {personagemObservado.GetVida()}");
        }
    }
}
