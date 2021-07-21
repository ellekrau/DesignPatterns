using Adapter.Entities;

namespace Adapter
{
    public class AviaoAdapter : IAcao
    {
        readonly Aviao aviao;

        public AviaoAdapter(Aviao aviao)
        {
            this.aviao = aviao;
        }

        public void Andar(string personagem)
        {
            aviao.Voar("Adrielle");
        }

        public void Atirar()
        {
            aviao.SoltarMissil();
        }
    }
}
