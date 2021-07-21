namespace Adapter.Entities
{
    public class TanqueDeGuerraAdapter : IAcao
    {
        readonly TanqueDeGuerra tanqueDeGuerra;

        public TanqueDeGuerraAdapter(TanqueDeGuerra tanqueDeGuerra)
        {
            this.tanqueDeGuerra = tanqueDeGuerra;
        }

        public void Andar(string personagem)
        {
            tanqueDeGuerra.Dirigir(personagem);
        }

        public void Atirar()
        {
            tanqueDeGuerra.AtirarComTanque();
        }
    }
}
