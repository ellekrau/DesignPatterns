namespace TemplateMethod.Class
{
    public class ModoDificil : Jogo
    {
        private const string modoDeJogo = "DIFICIL";

        public ModoDificil() : base(modoDeJogo) { }

        public override void PrimeiraFase()
        {
            System.Console.WriteLine(" Adicionar obstaculos na pista");
        }

        public override void SegundaFase()
        {
            System.Console.WriteLine(" Carros adversarios devem correr mais");
        }
    }
}
