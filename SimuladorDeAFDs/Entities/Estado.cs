namespace SimuladorDeAFDs.Entities
{
    public class Estado
    {
        public string Nome { get; private set; }
        public Dictionary<char, string> Transicoes { get; set; }
        public static int QuantEstados = 0, QuantReal = 0;
        public static Estado? EstadoInicial;
        public bool EstadoFinal { get; set; }
        public Estado()
        {
            this.Nome = "q" + (QuantEstados++).ToString(); QuantReal++;
            if (QuantReal == 1)
            {
                this.Nome += "(Inicial)";
                EstadoInicial = this;
            }
            this.Transicoes = new Dictionary<char, string>();
            this.EstadoFinal = false;
        }

        public void AtualizaDicionario(List<char> alfabeto)
        {
            foreach (char letras in alfabeto)
            {
                if (!this.Transicoes.ContainsKey(letras))
                {
                    this.Transicoes[letras] = "-";
                }
            }
        }

        public string ViraFinal()
        {
            this.EstadoFinal = true; string nome = this.Nome;
            if(EstadoInicial?.Nome == this.Nome)
            {
                this.Nome = this.Nome.Split(')')[0] + "/Final)";
            } else
            {
                this.Nome += "(Final)";
            }
            return nome;
        }

        public void TrocaValor(string antiga, string nova, List<char> alfabeto)
        {
            foreach (var simb in alfabeto)
            {
                if (this.Transicoes[simb] == antiga)
                {
                    this.Transicoes[simb] = nova;
                }
            }
        }
    }
}
