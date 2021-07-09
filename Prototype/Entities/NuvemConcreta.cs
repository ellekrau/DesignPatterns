namespace Prototype.Entities
{
    public class NuvemConcreta : NuvemMolde
    {
        private readonly string corPreenchimento;
        private readonly string corContorno;

        public NuvemConcreta(string corPreenchimento, string corContorno)
        {
            this.corPreenchimento = corPreenchimento;
            this.corContorno = corContorno;
        }

        public override NuvemMolde Clone()
        {
            System.Console.WriteLine("A nuvem clonada tem contorno {0} e preenchimento {1}", corContorno, corPreenchimento);
            return MemberwiseClone() as NuvemMolde;
        }
    }
}
