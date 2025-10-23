using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula08_banco
{
    public partial class frmbusca : Form
    {
        public frmbusca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrWhiteSpace(txtBusca.Text))
            if(txtBusca.Text.Trim() == "")  
            {
                MessageBox.Show("Por favor, informe um id para a busca.", "Busca de id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBusca.Focus();
                return;
            }
            // Verifica se o texto é um número inteiro
            /*if(!int.TryParse(txtBusca.Text, out int busca))
            {
                MessageBox.Show("Por favor, informe um id válido.", "Busca de id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBusca.Focus();
                return;
            }
            parametros.buscaId = busca;
            this.DialogResult = DialogResult.OK;
            this.Close();
            */
            try
            {
                int busca = Convert.ToInt32(txtBusca.Text.Trim());
                parametros.buscaId = busca;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o id: " + ex.Message, "Busca de id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBusca.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
