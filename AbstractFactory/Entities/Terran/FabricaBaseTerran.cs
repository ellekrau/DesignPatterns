namespace AbstractFactory.Entities.Terran
{
    public class FabricaBaseTerran : IFabricaBases
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            System.Console.WriteLine("Base Terran criada com sucesso");

            var revestimentoBaseTerran = new RevestimentoBaseTerran();
            revestimentoBaseTerran.Composicao();

            var energiaBaseTerran = new EnergiaBaseTerran();
            energiaBaseTerran.Composicao();
        }
    }
}
