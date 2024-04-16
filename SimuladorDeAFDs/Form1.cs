using SimuladorDeAFDs.Entities;

namespace SimuladorDeAFDs
{
    public partial class Form1 : Form
    {
        private List<Estado> _estados;
        private List<char> _alfabeto;
        public Form1()
        {
            _estados = new List<Estado>();
            _alfabeto = new List<char>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != string.Empty && !this._alfabeto.Contains(Convert.ToChar(this.textBox1.Text)))
            {
                this._alfabeto.Add(Convert.ToChar(this.textBox1.Text));
                this.listView1.Columns.Add(this.textBox1.Text);
            } else
            {
                MessageBox.Show("Digite um simbolo válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._estados.Add(new Estado());
            this.listView1.Items.Add(this._estados.Last().Nome);
        }
    }
}
