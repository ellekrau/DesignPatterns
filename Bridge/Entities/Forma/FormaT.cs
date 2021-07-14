namespace Bridge.Entities
{
    public class FormaT : IForma
    {
        public ICor Cor { get; set; }

        public string Descer() =>
            $" T - {Cor.Cor()}";
        
    }
}
