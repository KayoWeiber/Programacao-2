namespace trabalho_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.dtgfilmes = new System.Windows.Forms.DataGridView();
            this.lblDuracao = new System.Windows.Forms.TextBox();
            this.btnDuracao = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClassificacao = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlBuscaTitulo = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgfilmes)).BeginInit();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnDelete);
            this.pnlBotoes.Controls.Add(this.button2);
            this.pnlBotoes.Controls.Add(this.btnAdd);
            this.pnlBotoes.Controls.Add(this.button1);
            this.pnlBotoes.Controls.Add(this.btnAnterior);
            this.pnlBotoes.Controls.Add(this.btnProximo);
            this.pnlBotoes.Location = new System.Drawing.Point(0, 4);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(722, 76);
            this.pnlBotoes.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::trabalho_2.Properties.Resources.excluir;
            this.btnDelete.Location = new System.Drawing.Point(623, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 46);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::trabalho_2.Properties.Resources.big_search_len;
            this.button2.Location = new System.Drawing.Point(542, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::trabalho_2.Properties.Resources.adicionar__1_;
            this.btnAdd.Location = new System.Drawing.Point(380, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Image = global::trabalho_2.Properties.Resources.pencil;
            this.button1.Location = new System.Drawing.Point(461, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::trabalho_2.Properties.Resources.previous;
            this.btnAnterior.Location = new System.Drawing.Point(26, 8);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 46);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Image = global::trabalho_2.Properties.Resources.next;
            this.btnProximo.Location = new System.Drawing.Point(107, 8);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 46);
            this.btnProximo.TabIndex = 0;
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.dtgfilmes);
            this.pnlDados.Controls.Add(this.lblDuracao);
            this.pnlDados.Controls.Add(this.btnDuracao);
            this.pnlDados.Controls.Add(this.cbGenero);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.cbClassificacao);
            this.pnlDados.Controls.Add(this.btnCancelar);
            this.pnlDados.Controls.Add(this.btnConfirmar);
            this.pnlDados.Controls.Add(this.pnlBuscaTitulo);
            this.pnlDados.Controls.Add(this.lblClassificacao);
            this.pnlDados.Controls.Add(this.lblId);
            this.pnlDados.Controls.Add(this.txtTitulo);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Enabled = false;
            this.pnlDados.Location = new System.Drawing.Point(0, 102);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(732, 292);
            this.pnlDados.TabIndex = 10;
            this.pnlDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDados_Paint);
            // 
            // dtgfilmes
            // 
            this.dtgfilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgfilmes.Location = new System.Drawing.Point(0, 0);
            this.dtgfilmes.Name = "dtgfilmes";
            this.dtgfilmes.RowHeadersWidth = 62;
            this.dtgfilmes.RowTemplate.Height = 28;
            this.dtgfilmes.Size = new System.Drawing.Size(726, 289);
            this.dtgfilmes.TabIndex = 20;
            this.dtgfilmes.Visible = false;
            // 
            // lblDuracao
            // 
            this.lblDuracao.Location = new System.Drawing.Point(392, 158);
            this.lblDuracao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(189, 26);
            this.lblDuracao.TabIndex = 18;
            // 
            // btnDuracao
            // 
            this.btnDuracao.AutoSize = true;
            this.btnDuracao.Location = new System.Drawing.Point(388, 132);
            this.btnDuracao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnDuracao.Name = "btnDuracao";
            this.btnDuracao.Size = new System.Drawing.Size(144, 20);
            this.btnDuracao.TabIndex = 17;
            this.btnDuracao.Text = "Duração (minutos):";
            this.btnDuracao.Visible = false;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "",
            "Comédia",
            "",
            "Drama",
            "",
            "Romance",
            "",
            "Terror",
            "",
            "Ficção científica",
            "",
            "Fantasia",
            "Suspense",
            "",
            "Policial",
            "",
            "Animação",
            "",
            "Musical",
            "",
            "Documentário"});
            this.cbGenero.Location = new System.Drawing.Point(392, 80);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(189, 28);
            this.cbGenero.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Genero:";
            this.label2.Visible = false;
            // 
            // cbClassificacao
            // 
            this.cbClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassificacao.FormattingEnabled = true;
            this.cbClassificacao.Items.AddRange(new object[] {
            "Livre",
            "10+",
            "12+",
            "14+",
            "16+",
            "18+"});
            this.cbClassificacao.Location = new System.Drawing.Point(37, 156);
            this.cbClassificacao.Name = "cbClassificacao";
            this.cbClassificacao.Size = new System.Drawing.Size(189, 28);
            this.cbClassificacao.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::trabalho_2.Properties.Resources.multiply;
            this.btnCancelar.Location = new System.Drawing.Point(426, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 47);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::trabalho_2.Properties.Resources.check;
            this.btnConfirmar.Location = new System.Drawing.Point(542, 191);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(97, 47);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // pnlBuscaTitulo
            // 
            this.pnlBuscaTitulo.AutoSize = true;
            this.pnlBuscaTitulo.Location = new System.Drawing.Point(33, 68);
            this.pnlBuscaTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlBuscaTitulo.Name = "pnlBuscaTitulo";
            this.pnlBuscaTitulo.Size = new System.Drawing.Size(47, 20);
            this.pnlBuscaTitulo.TabIndex = 11;
            this.pnlBuscaTitulo.Text = "Titulo";
            this.pnlBuscaTitulo.Visible = false;
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Location = new System.Drawing.Point(33, 132);
            this.lblClassificacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(106, 20);
            this.lblClassificacao.TabIndex = 10;
            this.lblClassificacao.Text = "Classificação:";
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(37, 36);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(91, 22);
            this.lblId.TabIndex = 8;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(37, 93);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(189, 26);
            this.txtTitulo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id:";
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.btnComprar);
            this.pnlRodape.Controls.Add(this.btnSair);
            this.pnlRodape.Location = new System.Drawing.Point(0, 400);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(722, 101);
            this.pnlRodape.TabIndex = 11;
            // 
            // btnComprar
            // 
            this.btnComprar.Image = global::trabalho_2.Properties.Resources.compras_online;
            this.btnComprar.Location = new System.Drawing.Point(516, 3);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(97, 47);
            this.btnComprar.TabIndex = 10;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::trabalho_2.Properties.Resources.exit;
            this.btnSair.Location = new System.Drawing.Point(619, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 47);
            this.btnSair.TabIndex = 9;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlBotoes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgfilmes)).EndInit();
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label pnlBuscaTitulo;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClassificacao;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblDuracao;
        private System.Windows.Forms.Label btnDuracao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.DataGridView dtgfilmes;
    }
}

