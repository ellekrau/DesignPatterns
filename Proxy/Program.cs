using Proxy.Class;
using System;

namespace Proxy
{
    static class Program
    {
        static void Main()
        {
            SemProxy();
            ComProxySemPassWord();
            ComProxyComPasswordIncorreto();
            ComProxyComPasswordCorreto();

            Console.ReadKey();
        }

        static void SemProxy()
        {
            Console.WriteLine(" #### Acessando a Fase do Jogo sem o Proxy ###");

            var faseJogo = new FaseJogo();
            Console.WriteLine(faseJogo.Jogar());
        }

        static void ComProxySemPassWord()
        {
            Console.WriteLine("\n #### Usando o Proxy para controlar o acesso a fase do jogo ####");

            var proxy = new ProxyFase();
            Console.WriteLine(proxy.Jogar());
        }

        static void ComProxyComPasswordIncorreto()
        {
            Console.WriteLine("\n #### Tentando acessar a fase do jogo com Password Incorreto ####");

            var proxy = new ProxyFase();

            Console.WriteLine(proxy.InformarPassword("465"));
            Console.WriteLine(proxy.Jogar());
        }

        static void ComProxyComPasswordCorreto()
        {
            Console.WriteLine("\n #### Tentando acessar a fase do jogo com Password Incorreto ####");

            var proxy = new ProxyFase();

            Console.WriteLine(proxy.InformarPassword("123"));
            Console.WriteLine(proxy.Jogar());
        }
    }
}
