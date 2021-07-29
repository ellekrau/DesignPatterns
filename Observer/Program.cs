using Observer.Class;
using Observer.Class.Personagem;

namespace Observer
{
    static class Program
    {
        static void Main()
        {
            var personagemPrincipal = new Principal();

            var inimigoUm = new Inimigo(personagemPrincipal);
            var inimigoDois = new Inimigo(personagemPrincipal);
            var inimigoTres = new Inimigo(personagemPrincipal);

            while (true)
            {
                System.Console.WriteLine(" Acertar personagem principal com um golpe? S/N");
                System.Console.Write(" > ");

                var escolha = System.Console.ReadKey();
                System.Console.WriteLine();

                if (escolha.Key == System.ConsoleKey.S)
                    personagemPrincipal.GolpeAcertado(true);
                else
                    System.Console.WriteLine(" Voce nao acertou o personagem principal\n");

                System.Console.WriteLine();
            }
        }
    }
}
