namespace exercicio_04_09_25
{
    partial class Mini
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
            this.IdiomasGroup = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.gpNacionalidade = new System.Windows.Forms.GroupBox();
            this.radioBr = new System.Windows.Forms.RadioButton();
            this.rdEstrangeiro = new System.Windows.Forms.RadioButton();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.gbEscolaridade = new System.Windows.Forms.GroupBox();
            this.cbxEscolaridade = new System.Windows.Forms.ComboBox();
            this.gbDataNascimento = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btResumo = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.IdiomasGroup.SuspendLayout();
            this.gpNacionalidade.SuspendLayout();
            this.gbResultado.SuspendLayout();
            this.gbEscolaridade.SuspendLayout();
            this.gbDataNascimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdiomasGroup
            // 
            this.IdiomasGroup.Controls.Add(this.checkedListBox1);
            this.IdiomasGroup.Location = new System.Drawing.Point(13, 63);
            this.IdiomasGroup.Name = "IdiomasGroup";
            this.IdiomasGroup.Size = new System.Drawing.Size(152, 81);
            this.IdiomasGroup.TabIndex = 0;
            this.IdiomasGroup.TabStop = false;
            this.IdiomasGroup.Text = "Idiomas";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Alemão",
            "Espanhol",
            "Inglês"});
            this.checkedListBox1.Location = new System.Drawing.Point(7, 20);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 49);
            this.checkedListBox1.TabIndex = 0;
            // 
            // gpNacionalidade
            // 
            this.gpNacionalidade.Controls.Add(this.rdEstrangeiro);
            this.gpNacionalidade.Controls.Add(this.radioBr);
            this.gpNacionalidade.Location = new System.Drawing.Point(13, 151);
            this.gpNacionalidade.Name = "gpNacionalidade";
            this.gpNacionalidade.Size = new System.Drawing.Size(152, 76);
            this.gpNacionalidade.TabIndex = 1;
            this.gpNacionalidade.TabStop = false;
            this.gpNacionalidade.Text = "Nacionalidade";
            // 
            // radioBr
            // 
            this.radioBr.AutoSize = true;
            this.radioBr.Checked = true;
            this.radioBr.Location = new System.Drawing.Point(7, 30);
            this.radioBr.Name = "radioBr";
            this.radioBr.Size = new System.Drawing.Size(67, 17);
            this.radioBr.TabIndex = 0;
            this.radioBr.TabStop = true;
            this.radioBr.Text = "Brasileiro";
            this.radioBr.UseVisualStyleBackColor = true;
            // 
            // rdEstrangeiro
            // 
            this.rdEstrangeiro.AutoSize = true;
            this.rdEstrangeiro.Location = new System.Drawing.Point(7, 53);
            this.rdEstrangeiro.Name = "rdEstrangeiro";
            this.rdEstrangeiro.Size = new System.Drawing.Size(78, 17);
            this.rdEstrangeiro.TabIndex = 1;
            this.rdEstrangeiro.TabStop = true;
            this.rdEstrangeiro.Text = "Estrangeiro";
            this.rdEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.lstResultado);
            this.gbResultado.Location = new System.Drawing.Point(13, 231);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(152, 176);
            this.gbResultado.TabIndex = 2;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "resultado";
            // 
            // gbEscolaridade
            // 
            this.gbEscolaridade.Controls.Add(this.cbxEscolaridade);
            this.gbEscolaridade.Location = new System.Drawing.Point(196, 63);
            this.gbEscolaridade.Name = "gbEscolaridade";
            this.gbEscolaridade.Size = new System.Drawing.Size(178, 100);
            this.gbEscolaridade.TabIndex = 3;
            this.gbEscolaridade.TabStop = false;
            this.gbEscolaridade.Text = "Escolaridade";
            // 
            // cbxEscolaridade
            // 
            this.cbxEscolaridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEscolaridade.FormattingEnabled = true;
            this.cbxEscolaridade.Items.AddRange(new object[] {
            "medio",
            "fundamental",
            "superior",
            "ensino fundamental incompleto"});
            this.cbxEscolaridade.Location = new System.Drawing.Point(7, 20);
            this.cbxEscolaridade.Name = "cbxEscolaridade";
            this.cbxEscolaridade.Size = new System.Drawing.Size(121, 21);
            this.cbxEscolaridade.TabIndex = 0;
            // 
            // gbDataNascimento
            // 
            this.gbDataNascimento.Controls.Add(this.monthCalendar1);
            this.gbDataNascimento.Location = new System.Drawing.Point(196, 170);
            this.gbDataNascimento.Name = "gbDataNascimento";
            this.gbDataNascimento.Size = new System.Drawing.Size(247, 192);
            this.gbDataNascimento.TabIndex = 4;
            this.gbDataNascimento.TabStop = false;
            this.gbDataNascimento.Text = "Data de Nascimento";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 20);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btResumo
            // 
            this.btResumo.Location = new System.Drawing.Point(218, 377);
            this.btResumo.Name = "btResumo";
            this.btResumo.Size = new System.Drawing.Size(88, 23);
            this.btResumo.TabIndex = 5;
            this.btResumo.Text = "Gerar Resumo";
            this.btResumo.UseVisualStyleBackColor = true;
            this.btResumo.Click += new System.EventHandler(this.btResumo_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(318, 377);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(88, 23);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(7, 19);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(145, 134);
            this.lstResultado.TabIndex = 0;
            // 
            // Mini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btResumo);
            this.Controls.Add(this.gbDataNascimento);
            this.Controls.Add(this.gbEscolaridade);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gpNacionalidade);
            this.Controls.Add(this.IdiomasGroup);
            this.Name = "Mini";
            this.Text = "Form1";
            this.IdiomasGroup.ResumeLayout(false);
            this.gpNacionalidade.ResumeLayout(false);
            this.gpNacionalidade.PerformLayout();
            this.gbResultado.ResumeLayout(false);
            this.gbEscolaridade.ResumeLayout(false);
            this.gbDataNascimento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox IdiomasGroup;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox gpNacionalidade;
        private System.Windows.Forms.RadioButton radioBr;
        private System.Windows.Forms.RadioButton rdEstrangeiro;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.GroupBox gbEscolaridade;
        private System.Windows.Forms.ComboBox cbxEscolaridade;
        private System.Windows.Forms.GroupBox gbDataNascimento;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btResumo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ListBox lstResultado;
    }
}

