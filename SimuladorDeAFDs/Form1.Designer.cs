namespace SimuladorDeAFDs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BotaoAdicionarS = new Button();
            tabelaTransicoes = new ListView();
            textoSimbolo = new TextBox();
            BotaoAdicionar = new Button();
            BotaoRemover = new Button();
            selecionaEstado = new DomainUpDown();
            AdicionaTransicao = new Button();
            selecionaSimbolo = new DomainUpDown();
            BotaoFinal = new Button();
            palavra = new TextBox();
            testarPalavra = new Button();
            palavraTestada = new Label();
            SuspendLayout();
            // 
            // BotaoAdicionarS
            // 
            BotaoAdicionarS.Location = new Point(545, 50);
            BotaoAdicionarS.Name = "BotaoAdicionarS";
            BotaoAdicionarS.Size = new Size(134, 23);
            BotaoAdicionarS.TabIndex = 1;
            BotaoAdicionarS.Text = "Adicionar Simbolo";
            BotaoAdicionarS.UseVisualStyleBackColor = true;
            BotaoAdicionarS.Click += BotaoAdicionarS_Click;
            // 
            // tabelaTransicoes
            // 
            tabelaTransicoes.FullRowSelect = true;
            tabelaTransicoes.Location = new Point(12, 12);
            tabelaTransicoes.Name = "tabelaTransicoes";
            tabelaTransicoes.Size = new Size(509, 276);
            tabelaTransicoes.TabIndex = 2;
            tabelaTransicoes.UseCompatibleStateImageBehavior = false;
            tabelaTransicoes.View = View.Details;
            // 
            // textoSimbolo
            // 
            textoSimbolo.Location = new Point(545, 21);
            textoSimbolo.MaxLength = 1;
            textoSimbolo.Name = "textoSimbolo";
            textoSimbolo.PlaceholderText = "Insira o simbolo aqui";
            textoSimbolo.Size = new Size(134, 23);
            textoSimbolo.TabIndex = 3;
            // 
            // BotaoAdicionar
            // 
            BotaoAdicionar.Location = new Point(545, 79);
            BotaoAdicionar.Name = "BotaoAdicionar";
            BotaoAdicionar.Size = new Size(134, 23);
            BotaoAdicionar.TabIndex = 4;
            BotaoAdicionar.Text = "Adicionar Estado";
            BotaoAdicionar.UseVisualStyleBackColor = true;
            BotaoAdicionar.Click += BotaoAdicionar_Click;
            // 
            // BotaoRemover
            // 
            BotaoRemover.Location = new Point(545, 108);
            BotaoRemover.Name = "BotaoRemover";
            BotaoRemover.Size = new Size(134, 23);
            BotaoRemover.TabIndex = 5;
            BotaoRemover.Text = "Remover Estado";
            BotaoRemover.UseVisualStyleBackColor = true;
            BotaoRemover.Click += BotaoRemover_Click;
            // 
            // selecionaEstado
            // 
            selecionaEstado.Location = new Point(545, 137);
            selecionaEstado.Name = "selecionaEstado";
            selecionaEstado.Size = new Size(134, 23);
            selecionaEstado.TabIndex = 6;
            // 
            // AdicionaTransicao
            // 
            AdicionaTransicao.Location = new Point(545, 195);
            AdicionaTransicao.Name = "AdicionaTransicao";
            AdicionaTransicao.Size = new Size(134, 23);
            AdicionaTransicao.TabIndex = 7;
            AdicionaTransicao.Text = "Adicionar Transição";
            AdicionaTransicao.UseVisualStyleBackColor = true;
            AdicionaTransicao.Click += AdicionaTransicao_Click;
            // 
            // selecionaSimbolo
            // 
            selecionaSimbolo.Location = new Point(545, 166);
            selecionaSimbolo.Name = "selecionaSimbolo";
            selecionaSimbolo.Size = new Size(134, 23);
            selecionaSimbolo.TabIndex = 8;
            // 
            // BotaoFinal
            // 
            BotaoFinal.Location = new Point(545, 224);
            BotaoFinal.Name = "BotaoFinal";
            BotaoFinal.Size = new Size(134, 23);
            BotaoFinal.TabIndex = 9;
            BotaoFinal.Text = "Adicionar Estado Final";
            BotaoFinal.UseVisualStyleBackColor = true;
            BotaoFinal.Click += BotaoFinal_Click;
            // 
            // palavra
            // 
            palavra.Location = new Point(545, 253);
            palavra.Name = "palavra";
            palavra.Size = new Size(134, 23);
            palavra.TabIndex = 10;
            // 
            // testarPalavra
            // 
            testarPalavra.Location = new Point(545, 282);
            testarPalavra.Name = "testarPalavra";
            testarPalavra.Size = new Size(134, 23);
            testarPalavra.TabIndex = 11;
            testarPalavra.Text = "Testar Palavra";
            testarPalavra.UseVisualStyleBackColor = true;
            testarPalavra.Click += testarPalavra_Click;
            // 
            // palavraTestada
            // 
            palavraTestada.AutoSize = true;
            palavraTestada.Location = new Point(545, 308);
            palavraTestada.Name = "palavraTestada";
            palavraTestada.Size = new Size(0, 15);
            palavraTestada.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(palavraTestada);
            Controls.Add(testarPalavra);
            Controls.Add(palavra);
            Controls.Add(BotaoFinal);
            Controls.Add(selecionaSimbolo);
            Controls.Add(AdicionaTransicao);
            Controls.Add(selecionaEstado);
            Controls.Add(BotaoRemover);
            Controls.Add(BotaoAdicionar);
            Controls.Add(textoSimbolo);
            Controls.Add(tabelaTransicoes);
            Controls.Add(BotaoAdicionarS);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BotaoAdicionarS;
        private ListView tabelaTransicoes;
        private TextBox textoSimbolo;
        private Button BotaoAdicionar;
        private Button BotaoRemover;
        private DomainUpDown selecionaEstado;
        private Button AdicionaTransicao;
        private DomainUpDown selecionaSimbolo;
        private Button BotaoFinal;
        private TextBox palavra;
        private Button testarPalavra;
        private Label palavraTestada;
    }
}
