namespace Decorator.Entities
{
    public class ArmaduraPadrao : MoldeArmadura
    {
        private readonly string descricao = "Proteção simples";

        public override string Descricao 
            => descricao;
    }
}
