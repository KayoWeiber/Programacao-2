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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnQuarto = new System.Windows.Forms.Button();
            this.btnTerceiro = new System.Windows.Forms.Button();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel1.Controls.Add(this.panel2);
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
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btnInserir);
            this.pnButton.Controls.Add(this.btnSearch);
            this.pnButton.Controls.Add(this.btnQuarto);
            this.pnButton.Controls.Add(this.btnTerceiro);
            this.pnButton.Controls.Add(this.btnSegundo);
            this.pnButton.Controls.Add(this.btnPrimeiro);
            this.pnButton.Location = new System.Drawing.Point(178, 73);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(588, 55);
            this.pnButton.TabIndex = 10;
            // 
            // btnQuarto
            // 
            this.btnQuarto.Location = new System.Drawing.Point(309, 13);
            this.btnQuarto.Name = "btnQuarto";
            this.btnQuarto.Size = new System.Drawing.Size(75, 39);
            this.btnQuarto.TabIndex = 3;
            this.btnQuarto.Text = ">>";
            this.toolTip1.SetToolTip(this.btnQuarto, "Ultimo");
            this.btnQuarto.UseVisualStyleBackColor = true;
            this.btnQuarto.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTerceiro
            // 
            this.btnTerceiro.Location = new System.Drawing.Point(219, 13);
            this.btnTerceiro.Name = "btnTerceiro";
            this.btnTerceiro.Size = new System.Drawing.Size(75, 39);
            this.btnTerceiro.TabIndex = 2;
            this.btnTerceiro.Text = ">";
            this.toolTip1.SetToolTip(this.btnTerceiro, "depois");
            this.btnTerceiro.UseVisualStyleBackColor = true;
            this.btnTerceiro.Click += new System.EventHandler(this.btnTerceiro_Click);
            // 
            // btnSegundo
            // 
            this.btnSegundo.Location = new System.Drawing.Point(99, 13);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(75, 39);
            this.btnSegundo.TabIndex = 1;
            this.btnSegundo.Text = "<";
            this.toolTip1.SetToolTip(this.btnSegundo, "antes");
            this.btnSegundo.UseVisualStyleBackColor = true;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(18, 13);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 39);
            this.btnPrimeiro.TabIndex = 0;
            this.btnPrimeiro.Text = "<<";
            this.toolTip1.SetToolTip(this.btnPrimeiro, "primeiro");
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(219, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Location = new System.Drawing.Point(240, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 100);
            this.panel3.TabIndex = 11;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::aula_02_10.Properties.Resources.sair;
            this.btnFechar.Location = new System.Drawing.Point(298, 22);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(137, 62);
            this.btnFechar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnFechar, "Sair");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Image = global::aula_02_10.Properties.Resources.user_interface;
            this.btnInserir.Location = new System.Drawing.Point(407, 13);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 39);
            this.btnInserir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnInserir, "Inserir");
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::aula_02_10.Properties.Resources.lupa;
            this.btnSearch.Location = new System.Drawing.Point(488, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 39);
            this.btnSearch.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnSearch, "Pesquisar");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 652);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cadastro de e-mails";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

