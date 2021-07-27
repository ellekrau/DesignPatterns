namespace TemplateMethod.Class
{
    public class ModoFacil : Jogo
    {
        private const string modoDeJogo = "FACIL";

        public ModoFacil() : base(modoDeJogo) {}

        public override void PrimeiraFase()
        {
            System.Console.WriteLine(" Combustivel para a corrida toda");
        }

        public override void SegundaFase()
        {
            System.Console.WriteLine(" Carros adversarios devem correr menos");
        }
    }
}
