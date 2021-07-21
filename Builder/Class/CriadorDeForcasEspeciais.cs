namespace Builder.Entities
{
    public class CriadorDeForcasEspeciais : CriadorDeSoldado
    {
        public CriadorDeForcasEspeciais()
        {
            soldado = new SoldadoDeForcasEspeciais();
        }

        public override void Arma()
        {
            soldado.EscolherArma("Fuzil");
        }

        public override void Foco()
        {
            soldado.DefinirFoco("Combate em solo");
        }

        public override void Transporte()
        {
            soldado.EscolherTransporte("Carro de operacoes especiais");
        }
    }
}
