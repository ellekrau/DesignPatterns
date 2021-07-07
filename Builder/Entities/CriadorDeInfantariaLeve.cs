namespace Builder.Entities
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            soldado = new SoldadoDeInfantariaLeve();
        }

        public override void Arma()
        {
            soldado.EscolherArma("Ataque aereo");
        }

        public override void Foco()
        {
            soldado.DefinirFoco("Resposta rapida aerea");
        }

        public override void Transporte()
        {
            soldado.EscolherTransporte("Helicoptero de ataque do exercito");
        }
    }
}
