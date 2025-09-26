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

namespace aulaPart2_25_09
{
    public partial class frmPrincipal : Form
    {
        private int contador = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filho = new frmDocumento();
            filho.MdiParent = this;
            filho.Text = "Documento " + (++contador);
            filho.Show();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ladoaladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void organizarIconesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void fecharTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }


        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ativo = this.ActiveMdiChild as frmDocumento;
            if (ativo == null)
            {
                MessageBox.Show("Nenhum documento ativo", "Salvar", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                return;
            }
            var sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo de Texto|*.txt|Todos arquivos|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, ativo.conteudo);
                MessageBox.Show("Arquivo salvo com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}