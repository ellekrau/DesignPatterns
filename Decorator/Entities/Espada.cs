namespace Decorator.Entities
{
    public class Espada : DecoratorArmadura
    {
        private readonly string descricao = "Espada Ultra Forte, ";
        private readonly MoldeArmadura moldeArmadura;

        public Espada(MoldeArmadura moldeArmadura)
        {
            this.moldeArmadura = moldeArmadura;
        }

        public override string Descricao =>
            $"{moldeArmadura.Descricao} {descricao}";
    }
}
