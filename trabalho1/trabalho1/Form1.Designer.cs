namespace trabalho1
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
            this.lblName = new System.Windows.Forms.Label();
            this.tboxNome = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDisciplinas = new System.Windows.Forms.ComboBox();
            this.clbDisciplinas = new System.Windows.Forms.CheckedListBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnVisu = new System.Windows.Forms.Button();
            this.btnSalv = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblListaAlunos = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // tboxNome
            // 
            this.tboxNome.Location = new System.Drawing.Point(90, 36);
            this.tboxNome.Name = "tboxNome";
            this.tboxNome.Size = new System.Drawing.Size(270, 26);
            this.tboxNome.TabIndex = 1;
            this.tboxNome.TextChanged += new System.EventHandler(this.tboxNome_TextChanged);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(379, 39);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(158, 20);
            this.lblDataNasc.TabIndex = 2;
            this.lblDataNasc.Text = "Data de Nascimento:";
            this.lblDataNasc.Click += new System.EventHandler(this.lblDataNasc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdFem);
            this.groupBox1.Controls.Add(this.rbMasc);
            this.groupBox1.Controls.Add(this.lblGenero);
            this.groupBox1.Location = new System.Drawing.Point(22, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdFem
            // 
            this.rdFem.AutoSize = true;
            this.rdFem.Location = new System.Drawing.Point(79, 47);
            this.rdFem.Name = "rdFem";
            this.rdFem.Size = new System.Drawing.Size(99, 24);
            this.rdFem.TabIndex = 9;
            this.rdFem.TabStop = true;
            this.rdFem.Text = "Feminino";
            this.rdFem.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(79, 17);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(105, 24);
            this.rbMasc.TabIndex = 8;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            this.rbMasc.CheckedChanged += new System.EventHandler(this.rbMasc_CheckedChanged);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(5, 17);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(67, 20);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Genero:";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(386, 86);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(88, 20);
            this.lblDisciplina.TabIndex = 5;
            this.lblDisciplina.Text = "Disciplinas:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(34, 160);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(55, 20);
            this.lblCurso.TabIndex = 6;
            this.lblCurso.Text = "Curso:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDisciplinas);
            this.groupBox2.Location = new System.Drawing.Point(90, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 53);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // cbDisciplinas
            // 
            this.cbDisciplinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisciplinas.FormattingEnabled = true;
            this.cbDisciplinas.Items.AddRange(new object[] {
            "Sistemas de Informação",
            "Administração"});
            this.cbDisciplinas.Location = new System.Drawing.Point(7, 12);
            this.cbDisciplinas.Name = "cbDisciplinas";
            this.cbDisciplinas.Size = new System.Drawing.Size(222, 28);
            this.cbDisciplinas.TabIndex = 0;
            // 
            // clbDisciplinas
            // 
            this.clbDisciplinas.FormattingEnabled = true;
            this.clbDisciplinas.Items.AddRange(new object[] {
            "Programação 1",
            "Programação 2",
            "Administração de empresas",
            "Administração de pessoas"});
            this.clbDisciplinas.Location = new System.Drawing.Point(481, 90);
            this.clbDisciplinas.Name = "clbDisciplinas";
            this.clbDisciplinas.Size = new System.Drawing.Size(231, 96);
            this.clbDisciplinas.TabIndex = 8;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(533, 36);
            this.dtpDataNasc.MaxDate = new System.DateTime(2150, 12, 25, 0, 0, 0, 0);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(246, 26);
            this.dtpDataNasc.TabIndex = 9;
            this.dtpDataNasc.Value = new System.DateTime(2025, 9, 18, 0, 0, 0, 0);
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dtpDataNasc_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(12, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 10);
            this.panel1.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(32, 230);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(88, 43);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnVisu
            // 
            this.btnVisu.Location = new System.Drawing.Point(130, 230);
            this.btnVisu.Name = "btnVisu";
            this.btnVisu.Size = new System.Drawing.Size(88, 43);
            this.btnVisu.TabIndex = 12;
            this.btnVisu.Text = "Visualizar";
            this.btnVisu.UseVisualStyleBackColor = true;
            this.btnVisu.Click += new System.EventHandler(this.btnVisu_Click);
            // 
            // btnSalv
            // 
            this.btnSalv.Location = new System.Drawing.Point(227, 228);
            this.btnSalv.Name = "btnSalv";
            this.btnSalv.Size = new System.Drawing.Size(88, 43);
            this.btnSalv.TabIndex = 13;
            this.btnSalv.Text = "Salvar";
            this.btnSalv.UseVisualStyleBackColor = true;
            this.btnSalv.Click += new System.EventHandler(this.btnSalv_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(322, 230);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(88, 43);
            this.btnAbrir.TabIndex = 14;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblListaAlunos
            // 
            this.lblListaAlunos.AutoSize = true;
            this.lblListaAlunos.Location = new System.Drawing.Point(481, 230);
            this.lblListaAlunos.Name = "lblListaAlunos";
            this.lblListaAlunos.Size = new System.Drawing.Size(122, 20);
            this.lblListaAlunos.TabIndex = 15;
            this.lblListaAlunos.Text = "Lista de Alunos:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(485, 253);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(303, 240);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Location = new System.Drawing.Point(38, 280);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(77, 20);
            this.lblDetalhes.TabIndex = 17;
            this.lblDetalhes.Text = "Detalhes:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(42, 304);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(420, 240);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(501, 501);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(171, 43);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lblDetalhes);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblListaAlunos);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnSalv);
            this.Controls.Add(this.btnVisu);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.clbDisciplinas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.tboxNome);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Cadastro Aluno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tboxNome;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox clbDisciplinas;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnVisu;
        private System.Windows.Forms.Button btnSalv;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblListaAlunos;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox cbDisciplinas;
        private System.Windows.Forms.Button btnSair;
    }
}

