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

namespace exercicio_04_09_25
{
    public partial class Mini : Form
    {
        public Mini()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private int CalculatorYears()
        {
            int years = DateTime.Now.Year - monthCalendar1.SelectionStart.Year;
            return years;

        }

        private void btResumo_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            lstResultado.Items.Add("IDIOMAS");
            int cont = 0;
            foreach (var item in checkedListBox1.CheckedItems)
            {
                lstResultado.Items.Add(item.ToString());
                cont++;
            }
            if (cont == 0) lstResultado.Items.Add("Nenhum idioma selecionado");
            lstResultado.Items.Add("--------------");
            lstResultado.Items.Add("ESCOLARIDADE");
            if (cbxEscolaridade.Text == "") lstResultado.Items.Add("Nehum selecionado");
            else lstResultado.Items.Add(cbxEscolaridade.Text);
            lstResultado.Items.Add("--------------");
            lstResultado.Items.Add("NACIONALIDADE");
            if (radioBr.Checked) lstResultado.Items.Add("Brasileiro");
            else lstResultado.Items.Add("Estrangeiro");
            lstResultado.Items.Add("--------------");
            lstResultado.Items.Add("DATA DE NASCIMENTO");
            lstResultado.Items.Add(monthCalendar1.SelectionStart.ToShortDateString());
            lstResultado.Items.Add("Idade atual: "+ CalculatorYears());
            string documentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string caminhoArquivo = Path.Combine(documentosPath, "recibo.txt");
            //File.WriteAllText(caminhoArquivo, rickTexto.Text); erro aqui
            MessageBox.Show("Arquivo salvo em " + caminhoArquivo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void tbResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
