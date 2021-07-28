using Interpreter.Class;
using Interpreter.Class.Armamento;
using System;

namespace Interpreter
{
    static class Program
    {
        static void Main()
        {
            var mochila = new Mochila(new Corda(), new Binoculos(), new ArcoFlecha());
            mochila.Interpretar(new Contexto());

            Console.ReadKey();
        }
    }
}
