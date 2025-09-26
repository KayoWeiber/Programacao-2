using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula25_09_25
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnJanela_Click(object sender, EventArgs e)
        {
            
            var janela = new frmJanela();
            janela.Show(); //MODO SDI
            //this.Hide();
            
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            var modal = new frmModal();
            modal.ShowDialog(); //MODO MODAL
        }

        private void btnDialogo_Click(object sender, EventArgs e)
        {
            var dialogo = new frmModal();
            dialogo.StartPosition = FormStartPosition.CenterScreen;
            dialogo.Text = "Caixa de Diálogo";
            var resultado = dialogo.ShowDialog();
            lblResposta.Text = resultado.ToString();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Usuário clicou em OK");
            }
            else
            {
                MessageBox.Show("Usuário clicou em Cancelar");
            }
        }

        private void janelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDialogo_Click(sender, e);
        }
    }
}
