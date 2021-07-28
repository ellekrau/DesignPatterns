namespace Interpreter.Class
{
    public class Bussula : IFerramenta
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0} ", " Bussola ");
        }
    }
}
