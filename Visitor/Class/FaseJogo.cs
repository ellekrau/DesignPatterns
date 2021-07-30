namespace Visitor.Class
{
    public class FaseJogo : IJogo
    {
        public string NomeFase { get; set; }

        public void Visitante(IVisitor visitante)
        {
            visitante.Identificar(this);
        }
    }
}