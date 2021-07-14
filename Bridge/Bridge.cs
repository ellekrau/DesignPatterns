using Bridge.Entities;
using System;

namespace Bridge
{
    public class Bridge
    {
        public IForma FormaSolicitada { get; set; }

        public void ExibeQualFormaEstaDescendoNaTela()
        {
            System.Console.WriteLine(FormaSolicitada.Descer());
        }

        public void CriarFormaComCor((IForma Forma, ICor Cor) formaCor)
        {
            FormaSolicitada = formaCor.Forma;
            FormaSolicitada.Cor = formaCor.Cor;
        }
    }
}
