using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_11_09_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlgAbrir.FileName = "";
            dlgAbrir.ShowDialog();
            MessageBox.Show(dlgAbrir.FileNames[2]);
            

            // MessageBox.Show("Mensagem","titulo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            //DialogResult resposta;
            //resposta = MessageBox.Show("Quer sair o programa?", "aula04", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            //if(resposta == DialogResult.Abort)
            //{
            //    MessageBox.Show("Abortou a operação");
            //}else if(resposta == DialogResult.Retry)
            //{
            //    MessageBox.Show("Repetir a operação");
            //}
            //else
            //{
            //    MessageBox.Show("Ignorou a operação");
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer sair o programa?", "aula04", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();

        }

        private void dlgAbrir_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dlgSalvar.FileName = "";
            dlgSalvar.ShowDialog();
            MessageBox.Show(dlgSalvar.FileName);
        }

        private void dlgSalvar_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color.Red;
            colorDialog1.ShowDialog();
            //button3.ForeColor = colorDialog1.Color;
            //button3.BackColor = colorDialog1.Color;
            this.BackColor = colorDialog1.Color;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dlgFonte.ShowDialog();
            MessageBox.Show(dlgFonte.Font.ToString());
            MessageBox.Show(dlgFonte.Color.ToString());
        }
    }
}
