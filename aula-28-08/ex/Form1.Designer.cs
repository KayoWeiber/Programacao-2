namespace ex
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pagadorBox = new System.Windows.Forms.TextBox();
            this.recebedorBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valorBox = new System.Windows.Forms.TextBox();
            this.extensoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.referenteCombo = new System.Windows.Forms.ComboBox();
            this.gerarButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rickTexto = new System.Windows.Forms.RichTextBox();
            this.txtButton = new System.Windows.Forms.Button();
            this.rtfButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gerarButton);
            this.panel1.Controls.Add(this.referenteCombo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.extensoBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.valorBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.recebedorBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pagadorBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 215);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pagadorBox
            // 
            this.pagadorBox.Location = new System.Drawing.Point(35, 31);
            this.pagadorBox.Name = "pagadorBox";
            this.pagadorBox.Size = new System.Drawing.Size(234, 20);
            this.pagadorBox.TabIndex = 1;
            // 
            // recebedorBox
            // 
            this.recebedorBox.Location = new System.Drawing.Point(35, 77);
            this.recebedorBox.Name = "recebedorBox";
            this.recebedorBox.Size = new System.Drawing.Size(234, 20);
            this.recebedorBox.TabIndex = 3;
            this.recebedorBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recebedor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // valorBox
            // 
            this.valorBox.Location = new System.Drawing.Point(38, 117);
            this.valorBox.Name = "valorBox";
            this.valorBox.Size = new System.Drawing.Size(100, 20);
            this.valorBox.TabIndex = 5;
            // 
            // extensoBox
            // 
            this.extensoBox.Location = new System.Drawing.Point(169, 117);
            this.extensoBox.Name = "extensoBox";
            this.extensoBox.Size = new System.Drawing.Size(100, 20);
            this.extensoBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Extenso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Referente";
            // 
            // referenteCombo
            // 
            this.referenteCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenteCombo.FormattingEnabled = true;
            this.referenteCombo.Items.AddRange(new object[] {
            "Serviços prestados em treinamento",
            "Suporte Técnico",
            "Desenvolvimento de sistema ",
            "Desenvolvimento de site ",
            "Formatação de computador"});
            this.referenteCombo.Location = new System.Drawing.Point(41, 158);
            this.referenteCombo.Name = "referenteCombo";
            this.referenteCombo.Size = new System.Drawing.Size(308, 24);
            this.referenteCombo.TabIndex = 10;
            // 
            // gerarButton
            // 
            this.gerarButton.Location = new System.Drawing.Point(274, 185);
            this.gerarButton.Name = "gerarButton";
            this.gerarButton.Size = new System.Drawing.Size(75, 23);
            this.gerarButton.TabIndex = 11;
            this.gerarButton.Text = "Gerar";
            this.gerarButton.UseVisualStyleBackColor = true;
            this.gerarButton.Click += new System.EventHandler(this.gerarButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtfButton);
            this.panel2.Controls.Add(this.txtButton);
            this.panel2.Controls.Add(this.rickTexto);
            this.panel2.Location = new System.Drawing.Point(12, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 204);
            this.panel2.TabIndex = 12;
            // 
            // rickTexto
            // 
            this.rickTexto.Location = new System.Drawing.Point(4, 4);
            this.rickTexto.Name = "rickTexto";
            this.rickTexto.Size = new System.Drawing.Size(363, 164);
            this.rickTexto.TabIndex = 0;
            this.rickTexto.Text = "";
            // 
            // txtButton
            // 
            this.txtButton.Location = new System.Drawing.Point(17, 174);
            this.txtButton.Name = "txtButton";
            this.txtButton.Size = new System.Drawing.Size(75, 23);
            this.txtButton.TabIndex = 1;
            this.txtButton.Text = "Gravar TXT";
            this.txtButton.UseVisualStyleBackColor = true;
            this.txtButton.Click += new System.EventHandler(this.txtButton_Click);
            // 
            // rtfButton
            // 
            this.rtfButton.Location = new System.Drawing.Point(252, 174);
            this.rtfButton.Name = "rtfButton";
            this.rtfButton.Size = new System.Drawing.Size(75, 23);
            this.rtfButton.TabIndex = 2;
            this.rtfButton.Text = "Gravar RTF";
            this.rtfButton.UseVisualStyleBackColor = true;
            this.rtfButton.Click += new System.EventHandler(this.rtfButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pagadorBox;
        private System.Windows.Forms.TextBox recebedorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valorBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox extensoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gerarButton;
        private System.Windows.Forms.ComboBox referenteCombo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rickTexto;
        private System.Windows.Forms.Button rtfButton;
        private System.Windows.Forms.Button txtButton;
    }
}

