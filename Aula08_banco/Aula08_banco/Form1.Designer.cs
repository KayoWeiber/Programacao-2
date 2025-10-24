namespace Aula08_banco
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
            this.components = new System.ComponentModel.Container();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.pnlBuscaNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.btnBuscaNome = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterioir = new System.Windows.Forms.Button();
            this.btnPrimieiro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlBuscarporNome = new System.Windows.Forms.Panel();
            this.dtgNomes = new System.Windows.Forms.DataGridView();
            this.btnCancelarBusca = new System.Windows.Forms.Button();
            this.btnConfirmarBusca = new System.Windows.Forms.Button();
            this.txtBuscarPorNome = new System.Windows.Forms.TextBox();
            this.pnlDados.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlBuscarporNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNomes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.btnCancelar);
            this.pnlDados.Controls.Add(this.btnConfirmar);
            this.pnlDados.Controls.Add(this.pnlBuscaNome);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.txtEmail);
            this.pnlDados.Controls.Add(this.lblId);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Enabled = false;
            this.pnlDados.Location = new System.Drawing.Point(12, 61);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(591, 246);
            this.pnlDados.TabIndex = 6;
            // 
            // pnlBuscaNome
            // 
            this.pnlBuscaNome.AutoSize = true;
            this.pnlBuscaNome.Location = new System.Drawing.Point(33, 68);
            this.pnlBuscaNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlBuscaNome.Name = "pnlBuscaNome";
            this.pnlBuscaNome.Size = new System.Drawing.Size(70, 29);
            this.pnlBuscaNome.TabIndex = 11;
            this.pnlBuscaNome.Text = "Nome:";
            this.pnlBuscaNome.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(37, 157);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(501, 35);
            this.txtEmail.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtEmail, "E-mail");
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(37, 36);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(91, 22);
            this.lblId.TabIndex = 8;
            this.toolTip1.SetToolTip(this.lblId, "Id do registro");
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(37, 93);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(501, 35);
            this.txtNome.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtNome, "Nome");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id:";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnBuscaNome);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnAdd);
            this.pnlBotoes.Controls.Add(this.btnBusca);
            this.pnlBotoes.Controls.Add(this.btnUltimo);
            this.pnlBotoes.Controls.Add(this.btnProximo);
            this.pnlBotoes.Controls.Add(this.btnAnterioir);
            this.pnlBotoes.Controls.Add(this.btnPrimieiro);
            this.pnlBotoes.Location = new System.Drawing.Point(12, 12);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(591, 43);
            this.pnlBotoes.TabIndex = 8;
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.btnSair);
            this.pnlRodape.Location = new System.Drawing.Point(12, 322);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(591, 53);
            this.pnlRodape.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Aula08_banco.Properties.Resources.exit;
            this.btnSair.Location = new System.Drawing.Point(491, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 47);
            this.btnSair.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnBuscaNome
            // 
            this.btnBuscaNome.Image = global::Aula08_banco.Properties.Resources.documento;
            this.btnBuscaNome.Location = new System.Drawing.Point(520, 3);
            this.btnBuscaNome.Name = "btnBuscaNome";
            this.btnBuscaNome.Size = new System.Drawing.Size(61, 37);
            this.btnBuscaNome.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnBuscaNome, "Buscar por nome");
            this.btnBuscaNome.UseVisualStyleBackColor = true;
            this.btnBuscaNome.Click += new System.EventHandler(this.btnBuscaNome_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::Aula08_banco.Properties.Resources.botao_de_deletar__1_;
            this.btnExcluir.Location = new System.Drawing.Point(455, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(61, 37);
            this.btnExcluir.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnExcluir, "excluir");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::Aula08_banco.Properties.Resources.pencil;
            this.btnAlterar.Location = new System.Drawing.Point(324, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(61, 37);
            this.btnAlterar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnAlterar, "Alterar Registro");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Aula08_banco.Properties.Resources.profile;
            this.btnAdd.Location = new System.Drawing.Point(261, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 37);
            this.btnAdd.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnAdd, "Adicionar nova entrada");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.Image = global::Aula08_banco.Properties.Resources.search;
            this.btnBusca.Location = new System.Drawing.Point(391, 3);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(61, 37);
            this.btnBusca.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnBusca, "Buscar");
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = global::Aula08_banco.Properties.Resources.next;
            this.btnUltimo.Location = new System.Drawing.Point(197, 3);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(61, 37);
            this.btnUltimo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnUltimo, "Último");
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = global::Aula08_banco.Properties.Resources.next_button;
            this.btnProximo.Location = new System.Drawing.Point(133, 3);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(61, 37);
            this.btnProximo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnProximo, "Próximo");
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterioir
            // 
            this.btnAnterioir.Image = global::Aula08_banco.Properties.Resources.previous__1_;
            this.btnAnterioir.Location = new System.Drawing.Point(67, 3);
            this.btnAnterioir.Name = "btnAnterioir";
            this.btnAnterioir.Size = new System.Drawing.Size(61, 37);
            this.btnAnterioir.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAnterioir, "Anterior");
            this.btnAnterioir.UseVisualStyleBackColor = true;
            this.btnAnterioir.Click += new System.EventHandler(this.btnAnterioir_Click);
            // 
            // btnPrimieiro
            // 
            this.btnPrimieiro.Image = global::Aula08_banco.Properties.Resources.previous;
            this.btnPrimieiro.Location = new System.Drawing.Point(3, 3);
            this.btnPrimieiro.Name = "btnPrimieiro";
            this.btnPrimieiro.Size = new System.Drawing.Size(61, 37);
            this.btnPrimieiro.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnPrimieiro, "Primeiro");
            this.btnPrimieiro.UseVisualStyleBackColor = true;
            this.btnPrimieiro.Click += new System.EventHandler(this.btnPrimieiro_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Aula08_banco.Properties.Resources.multiply;
            this.btnCancelar.Location = new System.Drawing.Point(338, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 47);
            this.btnCancelar.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::Aula08_banco.Properties.Resources.check;
            this.btnConfirmar.Location = new System.Drawing.Point(441, 191);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(97, 47);
            this.btnConfirmar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnConfirmar, "Confirmar");
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pnlBuscarporNome
            // 
            this.pnlBuscarporNome.Controls.Add(this.txtBuscarPorNome);
            this.pnlBuscarporNome.Controls.Add(this.btnCancelarBusca);
            this.pnlBuscarporNome.Controls.Add(this.btnConfirmarBusca);
            this.pnlBuscarporNome.Controls.Add(this.dtgNomes);
            this.pnlBuscarporNome.Location = new System.Drawing.Point(15, 12);
            this.pnlBuscarporNome.Name = "pnlBuscarporNome";
            this.pnlBuscarporNome.Size = new System.Drawing.Size(588, 304);
            this.pnlBuscarporNome.TabIndex = 9;
            this.pnlBuscarporNome.Visible = false;
            this.pnlBuscarporNome.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtgNomes
            // 
            this.dtgNomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNomes.Location = new System.Drawing.Point(4, 43);
            this.dtgNomes.Name = "dtgNomes";
            this.dtgNomes.RowHeadersWidth = 62;
            this.dtgNomes.RowTemplate.Height = 28;
            this.dtgNomes.Size = new System.Drawing.Size(581, 249);
            this.dtgNomes.TabIndex = 0;
            this.dtgNomes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNomes_CellContentClick);
            this.dtgNomes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fazBusca);
            // 
            // btnCancelarBusca
            // 
            this.btnCancelarBusca.Image = global::Aula08_banco.Properties.Resources.multiply;
            this.btnCancelarBusca.Location = new System.Drawing.Point(380, 3);
            this.btnCancelarBusca.Name = "btnCancelarBusca";
            this.btnCancelarBusca.Size = new System.Drawing.Size(97, 40);
            this.btnCancelarBusca.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnCancelarBusca, "Cancelar");
            this.btnCancelarBusca.UseVisualStyleBackColor = true;
            this.btnCancelarBusca.Click += new System.EventHandler(this.btnCancelarBusca_Click);
            // 
            // btnConfirmarBusca
            // 
            this.btnConfirmarBusca.Image = global::Aula08_banco.Properties.Resources.check;
            this.btnConfirmarBusca.Location = new System.Drawing.Point(483, 3);
            this.btnConfirmarBusca.Name = "btnConfirmarBusca";
            this.btnConfirmarBusca.Size = new System.Drawing.Size(97, 40);
            this.btnConfirmarBusca.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnConfirmarBusca, "Confirmar");
            this.btnConfirmarBusca.UseVisualStyleBackColor = true;
            this.btnConfirmarBusca.Click += new System.EventHandler(this.btnConfirmarBusca_Click);
            // 
            // txtBuscarPorNome
            // 
            this.txtBuscarPorNome.Location = new System.Drawing.Point(7, 5);
            this.txtBuscarPorNome.Name = "txtBuscarPorNome";
            this.txtBuscarPorNome.Size = new System.Drawing.Size(370, 35);
            this.txtBuscarPorNome.TabIndex = 16;
            this.txtBuscarPorNome.TextChanged += new System.EventHandler(this.txtBuscarPorNome_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 387);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBuscarporNome);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDados);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de e-mails";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.pnlBuscarporNome.ResumeLayout(false);
            this.pnlBuscarporNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNomes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Label pnlBuscaNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterioir;
        private System.Windows.Forms.Button btnPrimieiro;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscaNome;
        private System.Windows.Forms.Panel pnlBuscarporNome;
        private System.Windows.Forms.TextBox txtBuscarPorNome;
        private System.Windows.Forms.Button btnCancelarBusca;
        private System.Windows.Forms.Button btnConfirmarBusca;
        private System.Windows.Forms.DataGridView dtgNomes;
    }
}

