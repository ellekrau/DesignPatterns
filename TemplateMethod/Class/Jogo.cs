namespace TemplateMethod.Class
{
    public abstract class Jogo
    {
        public Jogo(string modoDeJogo)
        {
            System.Console.WriteLine($" ### {modoDeJogo} ###\n");
            TrilhaSonora();
            PrimeiraFase();
            SegundaFase();
        }

        public abstract void PrimeiraFase();
        public abstract void SegundaFase();

        private void TrilhaSonora()
        {
            System.Console.WriteLine(" Musica emocionante");
        }
    }
}
