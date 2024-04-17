using SimuladorDeAFDs.Entities;
using System.Windows.Forms;

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
            this.tabelaTransicoes.Columns.Add("Estados");
        }

        private void Clear()
        {
            this.textoSimbolo.Clear(); this.textoSimbolo.Focus();
            this.selecionaSimbolo.Text = string.Empty;
            this.selecionaEstado.Text = string.Empty;
        }

        private void BotaoAdicionarS_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textoSimbolo.Text != string.Empty && !this._alfabeto.Contains(Convert.ToChar(this.textoSimbolo.Text)))
                {
                    this._alfabeto.Add(Convert.ToChar(this.textoSimbolo.Text));
                    this.tabelaTransicoes.Columns.Add(this.textoSimbolo.Text);
                    Atualiza(); Clear();
                } else
                {
                    throw new Exception("O simbolo não pode ser inserido");
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Atualiza()
        {
            try
            {
                this._estados.ForEach(x => x.AtualizaDicionario(this._alfabeto));
                selecionaEstado.Items.Clear(); selecionaSimbolo.Items.Clear();
                this._alfabeto.ForEach(x => this.selecionaSimbolo.Items.Add(x));
                this._estados.ForEach(x => this.selecionaEstado.Items.Add(x.Nome));
                for (int cont = 0; cont < this.tabelaTransicoes.Items.Count; cont++)
                {
                    foreach (char c in this._alfabeto)
                    {
                        this.tabelaTransicoes.Items[cont].SubItems.Add(this._estados.Last().Transicoes[c]);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoAdicionar_Click(object sender, EventArgs e)
        {
            this._estados.Add(new Estado());
            this.tabelaTransicoes.Items.Add(this._estados.Last().Nome);
            Atualiza(); Clear();
        }

        private void BotaoRemover_Click(object sender, EventArgs e)
        {
            try
            {
                string value = this.tabelaTransicoes.SelectedItems[0].Text;
                if (string.Compare(this.tabelaTransicoes.SelectedItems[0].Text, Estado.EstadoInicial?.Nome) == 0 && Estado.QuantReal != 1)
                    throw new Exception("O estado excluido não ser o inicial");
                this._estados.RemoveAt(this.tabelaTransicoes.SelectedIndices[0]);
                this.tabelaTransicoes.Items.RemoveAt(this.tabelaTransicoes.SelectedIndices[0]);
                foreach (char letra in _alfabeto)
                {
                    this._estados.ForEach(x =>
                    {
                        if (x.Transicoes[letra] == value)
                        {
                            x.Transicoes[letra] = "-";
                        }
                    }
                    );
                }
                Estado.QuantReal--;
                if (Estado.QuantReal == 0)
                    Estado.QuantEstados = 0;
                AtualizaPeloDicionario(); Atualiza(); Clear();
            } catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoFinal_Click(object sender, EventArgs e)
        {
            try
            {
                this._estados.ForEach(x =>
                {
                    if (x.Nome == this.tabelaTransicoes.SelectedItems[0].Text)
                    {
                        string valor = x.ViraFinal();
                        this._estados.ForEach(y => y.TrocaValor(valor, x.Nome, this._alfabeto));
                        for (int cont = 0; cont < this.tabelaTransicoes.Items.Count; cont++)
                        {
                            if (this.tabelaTransicoes.Items[cont].Text == valor)
                            {
                                this.tabelaTransicoes.Items[cont].Text = x.Nome;
                            }
                        }
                    }
                });
                AtualizaPeloDicionario(); Atualiza(); Clear();
            } catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionaTransicao_Click(object sender, EventArgs e)
        {
            try
            {
                this._estados.ForEach(x =>
                {
                    if (x.Nome == this.tabelaTransicoes.SelectedItems[0].Text)
                    {
                        this._alfabeto.ForEach(y =>
                        {
                            if (y == Convert.ToChar(this.selecionaSimbolo.Text))
                            {
                                x.Transicoes[y] = this.selecionaEstado.Text;
                                for (int cont = 0; cont < this.tabelaTransicoes.Items.Count; cont++)
                                {
                                    if (x.Nome == this.tabelaTransicoes.Items[cont].Text)
                                    {
                                        this.tabelaTransicoes.Items[cont].SubItems[this._alfabeto.IndexOf(y) + 1].Text = x.Transicoes[y];
                                    }
                                }
                            }
                        });
                    }
                });
                AtualizaPeloDicionario(); Atualiza(); Clear();
            } catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizaPeloDicionario()
        {
            for (int cont = 0; cont < tabelaTransicoes.Items.Count; cont++)
            {
                foreach (var simb in _alfabeto)
                {
                    this.tabelaTransicoes.Items[cont].SubItems[this._alfabeto.IndexOf(simb) + 1].Text = this._estados[cont].Transicoes[simb];
                }
            }
        }

        private void testarPalavra_Click(object sender, EventArgs e)
        {
            try
            {
                this.palavra.Focus();
                if(string.Compare(this.palavra.Text, string.Empty) == 0)
                {
                    throw new Exception("A palavra não ser vazia!");
                }
                Estado? estadoAtual = this._estados.First();
                foreach (var simb in this.palavra.Text.ToCharArray())
                {
                    if (estadoAtual.Transicoes.TryGetValue(simb, out string? value) && value != "-")
                    {
                        estadoAtual = this._estados.Find(x => x.Nome == value);
                    } else
                    {
                        this.palavraTestada.Text = $"O palavra {this.palavra.Text} foi recusada!";
                        this.palavraTestada.ForeColor = Color.Red; this.palavra.Text = string.Empty; return;
                    }
                }
                if (estadoAtual.EstadoFinal)
                {
                    this.palavraTestada.Text = $"O palavra {this.palavra.Text} foi aceita!";
                    this.palavraTestada.ForeColor = Color.Green;
                } else
                {
                    this.palavraTestada.Text = $"O palavra {this.palavra.Text} foi recusada!";
                    this.palavraTestada.ForeColor = Color.Red;
                }
                this.palavra.Text = string.Empty;
            } catch(Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
