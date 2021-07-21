namespace Decorator.Entities
{
    public class DecoratorArmadura : MoldeArmadura
    {
        private readonly string descricao = "Decorador abstrato de armadura do Personagem";

        public override string Descricao => 
            descricao;
    }
}
