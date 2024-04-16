namespace SimuladorDeAFDs.Entities
{
    public class Estado
    {
        public string Nome { get; private set; }
        public static int QuantEstados = 0;
        public Estado()
        {
            this.Nome = "q" + (QuantEstados++).ToString();
        }
    }
}
