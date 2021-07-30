namespace Visitor.Class
{
    public interface IVisitor
    {
        void Identificar(Chefao chefao);
        void Identificar(FaseJogo faseJogo);
    }
}