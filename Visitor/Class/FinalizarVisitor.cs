namespace Visitor.Class
{
    public class FinalizarVisitor : IVisitor
    {
        public void Identificar(Chefao chefao)
        {
            System.Console.WriteLine($" O chefao {chefao.NomeChefao} perdeu todos os pontos de vida e foi derrotado!");
        }

        public void Identificar(FaseJogo faseJogo)
        {
            System.Console.WriteLine($" A fase {faseJogo.NomeFase} terminou!");
        }
    }
}
