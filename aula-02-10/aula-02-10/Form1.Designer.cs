namespace aula_02_10
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.btnTerceiro = new System.Windows.Forms.Button();
            this.btnQuarto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ld:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(62, 116);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(403, 35);
            this.txtNom.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(68, 34);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(203, 29);
            this.lblId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(64, 199);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(406, 35);
            this.txtemail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(178, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 298);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(710, 462);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(137, 62);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btnQuarto);
            this.pnButton.Controls.Add(this.btnTerceiro);
            this.pnButton.Controls.Add(this.btnSegundo);
            this.pnButton.Controls.Add(this.btnPrimeiro);
            this.pnButton.Location = new System.Drawing.Point(178, 73);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(588, 55);
            this.pnButton.TabIndex = 10;
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(18, 13);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 39);
            this.btnPrimeiro.TabIndex = 0;
            this.btnPrimeiro.Text = "<<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnSegundo
            // 
            this.btnSegundo.Location = new System.Drawing.Point(99, 13);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(75, 39);
            this.btnSegundo.TabIndex = 1;
            this.btnSegundo.Text = "<";
            this.btnSegundo.UseVisualStyleBackColor = true;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // btnTerceiro
            // 
            this.btnTerceiro.Location = new System.Drawing.Point(272, 12);
            this.btnTerceiro.Name = "btnTerceiro";
            this.btnTerceiro.Size = new System.Drawing.Size(75, 39);
            this.btnTerceiro.TabIndex = 2;
            this.btnTerceiro.Text = ">";
            this.btnTerceiro.UseVisualStyleBackColor = true;
            this.btnTerceiro.Click += new System.EventHandler(this.btnTerceiro_Click);
            // 
            // btnQuarto
            // 
            this.btnQuarto.Location = new System.Drawing.Point(353, 13);
            this.btnQuarto.Name = "btnQuarto";
            this.btnQuarto.Size = new System.Drawing.Size(75, 39);
            this.btnQuarto.TabIndex = 3;
            this.btnQuarto.Text = ">>";
            this.btnQuarto.UseVisualStyleBackColor = true;
            this.btnQuarto.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 652);
            this.ControlBox = false;
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cadastro de e-mails";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Button btnQuarto;
        private System.Windows.Forms.Button btnTerceiro;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Button btnPrimeiro;
    }
}

