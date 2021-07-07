using Builder.Entities;
using System;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            var exercito = new Exercito();
            CriadorDeSoldado criadorDeSoldado;
            Soldado soldado;

            // Criando um soldado das forcas especiais
            criadorDeSoldado = new CriadorDeForcasEspeciais();
            exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();

            Console.WriteLine("Soldado com as caracteristicas: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);


            // Criando um soldado das forcas especiais
            criadorDeSoldado = new CriadorDeInfantariaLeve();
            exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();

            Console.WriteLine("Soldado com as caracteristicas: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);

            Console.ReadKey();
        }
    }
}
