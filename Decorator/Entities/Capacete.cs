namespace Decorator.Entities
{
    public class Capacete : DecoratorArmadura
    {
        private readonly string descricao = "Capacete, ";
        private readonly MoldeArmadura moldeArmadura;

        public Capacete(MoldeArmadura moldeArmadura)
        {
            this.moldeArmadura = moldeArmadura;
        }

        public override string Descricao => 
            $"{moldeArmadura.Descricao} {descricao}";
    }
}
