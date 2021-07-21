namespace AbstractFactory.Entities.Zerg
{
    public class FabricaBaseZerg : IFabricaBases
    {
        public FabricaBaseZerg()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            System.Console.WriteLine("Base Protoss criada com sucesso");

            var revestimentoBaseZerg = new RevestimentoBaseZerg();
            revestimentoBaseZerg.Composicao();

            var energiaBaseZerg = new EnergiaBaseZerg();
            energiaBaseZerg.Composicao();
        }
    }
}
