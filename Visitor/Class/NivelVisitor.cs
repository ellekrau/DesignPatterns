namespace Visitor.Class
{
    public class NivelVisitor : IVisitor
    {        
        public void Identificar(Chefao chefao)
        {
            var grauDificuldade = chefao.NomeChefao switch
            {
                "Boss 1" => 25,
                _ => 50,
            };

            System.Console.WriteLine(" O chefao {0} eh {1}% dificil e tem {2} pontos de vida", chefao.NomeChefao, grauDificuldade, chefao.PontosVida);
        }

        public void Identificar(FaseJogo faseJogo)
        {
            var grauDificuldade = faseJogo.NomeFase switch
            {
                "Floresta" => 70,
                _ => 30,
            };

            System.Console.WriteLine(" A fase {0} no jogo eh {1}% dificil", faseJogo.NomeFase, grauDificuldade);
        }
    }}
