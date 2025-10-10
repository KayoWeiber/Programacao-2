using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_02_10
{
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtBusca.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, digite o id", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBusca.Focus();
                return;
            }
            try
            {
                int busca = Convert.ToInt32(txtBusca.Text.Trim());
                parametro.buscaId = busca;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, digite um número válido"+ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBusca.Focus();
                return;
            }
                this.DialogResult = DialogResult.OK;
        }
    }
}
