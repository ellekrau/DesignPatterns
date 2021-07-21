namespace AbstractFactory.Entities.Protoss
{
    public class FabricaBaseProtoss : IFabricaBases
    {
        public FabricaBaseProtoss()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            System.Console.WriteLine("Base Protoss criada com sucesso");

            var revestimentoBaseProtoss = new RevestimentoBaseProtoss();
            revestimentoBaseProtoss.Composicao();

            var energiaBaseProtoss = new EnergiaBaseProtoss();
            energiaBaseProtoss.Composicao();
        }
    }
}
