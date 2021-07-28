using Interpreter.Class.Armamento;

namespace Interpreter.Class
{
    public class Mochila : IExpressao
    {
        private readonly IFerramenta ferramentaPrincipal;
        private readonly IFerramenta ferramentaSecundaria;
        private readonly IArmamento armamento;

        public Mochila(IFerramenta ferramentaPrincipal, IFerramenta ferramentaSecundaria, IArmamento armamento)
        {
            this.ferramentaPrincipal = ferramentaPrincipal;
            this.ferramentaSecundaria = ferramentaSecundaria;
            this.armamento = armamento;
        }

        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += " Abrindo a mochila... \n";

            contexto.Conteudo += "\n - Armamento:";
            armamento.Interpretar(contexto);

            contexto.Conteudo += "\n - 1º Ferramenta:";
            ferramentaPrincipal.Interpretar(contexto);

            contexto.Conteudo += "\n - 2º Ferramenta:";
            ferramentaSecundaria.Interpretar(contexto);

            contexto.Conteudo += "\n\n ...Fechando a mochila ";

            System.Console.WriteLine(contexto.Conteudo);
        }
    }
}
