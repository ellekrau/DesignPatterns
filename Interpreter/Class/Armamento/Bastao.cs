namespace Interpreter.Class.Armamento
{
    public class Bastao : IArmamento
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0} ", " Bastao ");
        }
    }
}
