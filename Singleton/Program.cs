using System;

namespace Singleton
{
    static class Program
    {
        static void Main()
        {
            var jogador1 = Singleton.GetInstancia();
            jogador1.Mensagem(" Jogador 1: A bola está comigo e esta no meio do campo");

            var jogador2 = Singleton.GetInstancia();
            jogador2.Mensagem(" Jogador 2: Recebeu a bola");

            var jogador3 = Singleton.GetInstancia();
            jogador3.Mensagem(" Jogador 3: Recebeu o lancamento na linha de fundo");

            Console.ReadKey();
        }
    }
}
