using Facade.Class;

namespace Facade
{
    public class Facade
    {
        readonly SubsistemaUm subsistemaUm;
        readonly SubsistemaDois subsistemaDois;
        readonly SubsistemaTres subsistemaTres;

        public Facade()
        {
            subsistemaUm = new SubsistemaUm();
            subsistemaDois = new SubsistemaDois();
            subsistemaTres = new SubsistemaTres();
        }

        public void OperacaoA()
        {
            System.Console.WriteLine("\n Operacao A -------");
            subsistemaUm.Responsabilidade();
            subsistemaDois.Responsabilidade();
        }

        public void OperacaoB()
        {
            System.Console.WriteLine("\n Operacao B -------");
            subsistemaTres.Responsabilidade();
        }
    }
}
