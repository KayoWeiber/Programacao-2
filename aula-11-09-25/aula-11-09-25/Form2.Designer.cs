namespace aula_11_09_25
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.Abrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.preferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarCorDoFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgFonte = new System.Windows.Forms.FontDialog();
            this.dlgCor = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.preferênciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "&Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sai&r";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // txtDoc
            // 
            this.txtDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDoc.Location = new System.Drawing.Point(0, 24);
            this.txtDoc.Multiline = true;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDoc.Size = new System.Drawing.Size(800, 426);
            this.txtDoc.TabIndex = 1;
            this.txtDoc.WordWrap = false;
            // 
            // Abrir
            // 
            this.Abrir.FileName = "openFileDialog1";
            // 
            // preferênciasToolStripMenuItem
            // 
            this.preferênciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarFonteToolStripMenuItem,
            this.configurarCorDoFundoToolStripMenuItem});
            this.preferênciasToolStripMenuItem.Name = "preferênciasToolStripMenuItem";
            this.preferênciasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.preferênciasToolStripMenuItem.Text = "Preferências";
            // 
            // configurarFonteToolStripMenuItem
            // 
            this.configurarFonteToolStripMenuItem.Name = "configurarFonteToolStripMenuItem";
            this.configurarFonteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.configurarFonteToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.configurarFonteToolStripMenuItem.Text = "Configurar &Fonte";
            this.configurarFonteToolStripMenuItem.Click += new System.EventHandler(this.configurarFonteToolStripMenuItem_Click);
            // 
            // configurarCorDoFundoToolStripMenuItem
            // 
            this.configurarCorDoFundoToolStripMenuItem.Name = "configurarCorDoFundoToolStripMenuItem";
            this.configurarCorDoFundoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.configurarCorDoFundoToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.configurarCorDoFundoToolStripMenuItem.Text = "Configurar cor do f&undo";
            this.configurarCorDoFundoToolStripMenuItem.Click += new System.EventHandler(this.configurarCorDoFundoToolStripMenuItem_Click);
            // 
            // dlgFonte
            // 
            this.dlgFonte.ShowColor = true;
            this.dlgFonte.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "KayoPad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.OpenFileDialog Abrir;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarCorDoFundoToolStripMenuItem;
        private System.Windows.Forms.FontDialog dlgFonte;
        private System.Windows.Forms.ColorDialog dlgCor;
    }
}