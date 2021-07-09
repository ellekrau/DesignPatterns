using Adapter.Entities;
using System;

namespace Adapter
{
    static class Program
    {
        static void Main()
        {
            var adrielle = new Personagem();
            var aviaoDeBatalha = new Aviao();
            var tanqueDeGuerra = new TanqueDeGuerra();

            var adaptadorAviao = new AviaoAdapter(aviaoDeBatalha);
            var adaptadorTanqueDeGuerra = new TanqueDeGuerraAdapter(tanqueDeGuerra);

            Console.WriteLine(" --- CAMINHANDO ---");
            adrielle.Andar("Adrielle");
            adrielle.Atirar();

            Console.WriteLine("\n --- PEGOU UM AVIAO NO JOGO ---");
            adaptadorAviao.Andar("Adrielle");
            adaptadorAviao.Atirar();

            Console.WriteLine("\n --- PEGOU UM TANQUE NO JOGO ---");
            adaptadorTanqueDeGuerra.Andar("Adrielle");
            adaptadorTanqueDeGuerra.Atirar();

            Console.ReadKey();
        }
    }
}
