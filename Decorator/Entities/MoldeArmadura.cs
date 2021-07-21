namespace Decorator.Entities
{
    public class MoldeArmadura
    {
        private readonly string descricao = "Armadura do personagem - Abstrata";

        public virtual string Descricao => 
            descricao;
    }
}
