namespace Bridge.Entities
{
    public class FormaU : IForma
    {
        public ICor Cor { get; set; }

        public string Descer() =>
            $" U - {Cor.Cor()}";
    }
}
