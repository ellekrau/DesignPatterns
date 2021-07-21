namespace Facade
{
    static class Program
    {
        static void Main()
        {
            var facade = new Facade();
            facade.OperacaoA();
            facade.OperacaoB();

            System.Console.ReadKey();
        }
    }
}
