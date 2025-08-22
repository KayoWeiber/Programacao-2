namespace Aula_21_08
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_boasVindas = new System.Windows.Forms.Label();
            this.btn_saudacao = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.lbl_vez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_boasVindas
            // 
            this.lbl_boasVindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_boasVindas.Location = new System.Drawing.Point(18, 14);
            this.lbl_boasVindas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_boasVindas.Name = "lbl_boasVindas";
            this.lbl_boasVindas.Size = new System.Drawing.Size(210, 62);
            this.lbl_boasVindas.TabIndex = 1;
            this.lbl_boasVindas.Text = "Olá Kayo Weiber!!";
            this.lbl_boasVindas.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_saudacao
            // 
            this.btn_saudacao.Location = new System.Drawing.Point(23, 69);
            this.btn_saudacao.Name = "btn_saudacao";
            this.btn_saudacao.Size = new System.Drawing.Size(163, 39);
            this.btn_saudacao.TabIndex = 2;
            this.btn_saudacao.Text = "Saudacao";
            this.btn_saudacao.UseVisualStyleBackColor = true;
            this.btn_saudacao.Click += new System.EventHandler(this.HelloWorld);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 40);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NarcaVez_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 37);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NarcaVez_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(315, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 37);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NarcaVez_click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(426, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 37);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NarcaVez_click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(426, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 37);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NarcaVez_click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(426, 64);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 40);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NarcaVez_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(538, 153);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 37);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NarcaVez_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(538, 110);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(86, 37);
            this.button9.TabIndex = 10;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NarcaVez_click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(538, 64);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(86, 40);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NarcaVez_click);
            // 
            // lbl_vez
            // 
            this.lbl_vez.AutoSize = true;
            this.lbl_vez.Location = new System.Drawing.Point(407, 256);
            this.lbl_vez.Name = "lbl_vez";
            this.lbl_vez.Size = new System.Drawing.Size(16, 20);
            this.lbl_vez.TabIndex = 12;
            this.lbl_vez.Text = "x";
            this.lbl_vez.Visible = false;
            this.lbl_vez.Click += new System.EventHandler(this.lbl_vez_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 692);
            this.Controls.Add(this.lbl_vez);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_saudacao);
            this.Controls.Add(this.lbl_boasVindas);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Formulário teste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_boasVindas;
        private System.Windows.Forms.Button btn_saudacao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label lbl_vez;
    }
}

