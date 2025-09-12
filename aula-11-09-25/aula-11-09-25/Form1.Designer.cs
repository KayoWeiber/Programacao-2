namespace aula_11_09_25
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
            this.btn2 = new System.Windows.Forms.Button();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dlgFonte = new System.Windows.Forms.FontDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(270, 135);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "&Abrir";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            this.dlgAbrir.Filter = "Arquivo de texto (*.txt)|*.txt";
            this.dlgAbrir.Multiselect = true;
            this.dlgAbrir.Title = "Arquivo de cliente";
            this.dlgAbrir.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgAbrir_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dlgSalvar
            // 
            this.dlgSalvar.Filter = "Arquivo C#(*cs)|(*.cs)";
            this.dlgSalvar.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgSalvar_FileOk);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.DarkRed;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(336, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "&Fonte";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dlgFonte
            // 
            this.dlgFonte.Color = System.Drawing.Color.Pink;
            this.dlgFonte.ShowColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(270, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Form&2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FontDialog dlgFonte;
        private System.Windows.Forms.Button button5;
    }
}

