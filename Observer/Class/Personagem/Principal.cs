using System.Collections.Generic;

namespace Observer.Class
{
    public class Principal : IPersonagem
    {
        private IList<IObservador> inimigos = new List<IObservador>();
        private int vida = 100;

        public void NotificarPersonagens()
        {
            foreach (var inimigo in inimigos)
            {
                inimigo.Avisar(this);
            }
        }

        public void RegistrarObservador(IObservador observador)
        {
            inimigos.Add(observador);
        }

        public void GolpeAcertado(bool golpe)
        {
            if (golpe)
            {
                vida -= 10;
                NotificarPersonagens();
            }
        }
        public int GetVida() =>
            vida;
    }
}
