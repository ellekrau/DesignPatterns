namespace TemplateMethod.Class
{
    public class ModoNormal : Jogo
    {
        private const string modoDeJogo = "MEDIO";

        public ModoNormal() : base(modoDeJogo) {}

        public override void PrimeiraFase()
        {
            System.Console.WriteLine(" O carro precisa abastecer uma vez");
        }

        public override void SegundaFase()
        {
            System.Console.WriteLine(" Os carros devem correr na mesma velocidade");
        }
    }
}
