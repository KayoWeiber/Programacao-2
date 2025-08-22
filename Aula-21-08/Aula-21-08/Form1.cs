using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_21_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "sair";
            btn_saudacao.Text = "Hello World!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void HelloWorld(object sender, EventArgs e) 
        {
            Button mudatexto = (Button)sender;
            mudatexto.Text = "Hello Kayo";
            //MessageBox.Show("Olá Kayo");
            
        }
        private void NarcaVez_click(object sender, EventArgs e) 
        {
            Button vez = (Button)sender;
            vez.Text = lbl_vez.Text;
            TemVencedor();
            if (lbl_vez.Text == "X" || lbl_vez.Text == "x") lbl_vez.Text = "O"; else lbl_vez.Text = "X";
        }

        private void lbl_vez_Click(object sender, EventArgs e)
        {

        }
        private void TemVencedor()
        {
            if((button2 == button7) && (button7 == button10)&&(button7.Text!=""))
            {
                lbl_boasVindas.Text = button2.Text + " Ganhou";
            }
        }
    }
}
