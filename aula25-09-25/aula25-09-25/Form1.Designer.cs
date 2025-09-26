namespace aula25_09_25
{
    partial class frmPrincipal
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
            this.btnJanela = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnDialogo = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoJanelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoModalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoDialogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJanela
            // 
            this.btnJanela.Location = new System.Drawing.Point(77, 184);
            this.btnJanela.Name = "btnJanela";
            this.btnJanela.Size = new System.Drawing.Size(144, 78);
            this.btnJanela.TabIndex = 0;
            this.btnJanela.Text = "abrir modo Janela";
            this.btnJanela.UseVisualStyleBackColor = true;
            this.btnJanela.Click += new System.EventHandler(this.btnJanela_Click);
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(281, 184);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(144, 78);
            this.btnModal.TabIndex = 1;
            this.btnModal.Text = "abrir modo Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnDialogo
            // 
            this.btnDialogo.Location = new System.Drawing.Point(548, 184);
            this.btnDialogo.Name = "btnDialogo";
            this.btnDialogo.Size = new System.Drawing.Size(144, 78);
            this.btnDialogo.TabIndex = 2;
            this.btnDialogo.Text = "Abrir modo dialogo";
            this.btnDialogo.UseVisualStyleBackColor = true;
            this.btnDialogo.Click += new System.EventHandler(this.btnDialogo_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(347, 361);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 37);
            this.lblResposta.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.janelaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoJanelaToolStripMenuItem,
            this.modoModalToolStripMenuItem,
            this.modoDialogoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.arquivoToolStripMenuItem.Text = "arquivo";
            // 
            // modoJanelaToolStripMenuItem
            // 
            this.modoJanelaToolStripMenuItem.Name = "modoJanelaToolStripMenuItem";
            this.modoJanelaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modoJanelaToolStripMenuItem.Text = "Modo Janela";
            this.modoJanelaToolStripMenuItem.Click += new System.EventHandler(this.btnJanela_Click);
            // 
            // modoModalToolStripMenuItem
            // 
            this.modoModalToolStripMenuItem.Name = "modoModalToolStripMenuItem";
            this.modoModalToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modoModalToolStripMenuItem.Text = "Modo Modal";
            this.modoModalToolStripMenuItem.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // modoDialogoToolStripMenuItem
            // 
            this.modoDialogoToolStripMenuItem.Name = "modoDialogoToolStripMenuItem";
            this.modoDialogoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modoDialogoToolStripMenuItem.Text = "Modo dialogo";
            this.modoDialogoToolStripMenuItem.Click += new System.EventHandler(this.btnDialogo_Click);
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.janelaToolStripMenuItem.Text = "janela";
            this.janelaToolStripMenuItem.Click += new System.EventHandler(this.janelaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnDialogo);
            this.Controls.Add(this.btnModal);
            this.Controls.Add(this.btnJanela);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Click += new System.EventHandler(this.btnJanela_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJanela;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnDialogo;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoJanelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoModalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoDialogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
    }
}

