using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace aula_11_09_25
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDoc.Clear();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir.Filter = "Arquivos de texto (*.txt)|*.txt|Arquivos de PHP(*.php)|*.php";
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                txtDoc.Text = File.ReadAllText(Abrir.FileName);
                this.Text = "KayoPad -"+Abrir.FileName;
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgSalvar.Filter = "Arquivos de texto (*.txt)|*.txt|Arquivos de PHP(*.php)|*.php";
            if (this.Text == "KayoPad")
                dlgSalvar.FileName = "";
            else {
                string nome = this.Text;
                dlgSalvar.FileName = Path.GetFileName(nome);
            }
            
            if (dlgSalvar.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlgSalvar.FileName, txtDoc.Text);
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void configurarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgFonte.Font = txtDoc.Font;
            if(dlgFonte.ShowDialog() == DialogResult.OK)
            {
                txtDoc.Font = dlgFonte.Font;
                txtDoc.ForeColor = dlgFonte.Color;
            }
        }

        private void configurarCorDoFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgCor.Color = txtDoc.BackColor;
            if(dlgCor.ShowDialog() == DialogResult.OK)
            {
                txtDoc.BackColor = dlgCor.Color;
            }
        }
    }
}
