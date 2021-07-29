namespace Observer.Class
{
    public interface IPersonagem
    {
        void RegistrarObservador(IObservador observador);
        void NotificarPersonagens();
    }
}
