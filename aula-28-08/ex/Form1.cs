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

namespace ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gerarButton_Click(object sender, EventArgs e)
        {
            rickTexto.Clear();
            string linha = "";
            const string saltaLinha = "\n";
            linha = "R E C I B O" + saltaLinha;
            rickTexto.AppendText(linha);
            linha = "Eu, "+ recebedorBox.Text+ ", recebi a importância de "+valorBox.Text;
            linha += " (" + extensoBox.Text + "), de "+pagadorBox.Text+" referente a(o) "+ referenteCombo.Text+". "+saltaLinha;
            rickTexto.AppendText(linha);
            rickTexto.AppendText(saltaLinha);
            rickTexto.AppendText ("---------------------"+saltaLinha);
            rickTexto.AppendText(recebedorBox.Text);
            rickTexto.SelectionStart = 0;
            rickTexto.SelectionLength =  11;
            rickTexto.SelectionFont = new Font(rickTexto.SelectionFont,FontStyle.Bold);
        }

        private void txtButton_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Quer gravar em Txt?", "Salvar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
            {
                try
                {
                    //pega caminho da pasta meus documentos
                    string documentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


                    //caminho pra arquivo a ser salvo
                    string caminhoArquivo = Path.Combine(documentosPath, "recibo.txt");

                    //salva o recibo no arquivo
                    File.WriteAllText(caminhoArquivo, rickTexto.Text);
                    MessageBox.Show("Arquivo salvo em " + caminhoArquivo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (resposta == DialogResult.No)
                MessageBox.Show("O recibo não será gravado.", "Salvar",MessageBoxButtons.OK);
                
        }

        private void rtfButton_Click(object sender, EventArgs e)
        {
            try
            {
                //pega caminho da pasta meus documentos
                string documentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


                //caminho pra arquivo a ser salvo
                string caminhoArquivo = Path.Combine(documentosPath, "recibo.rtf");

                //salva o recibo no arquivo
                File.WriteAllText(caminhoArquivo, rickTexto.Rtf);
                MessageBox.Show("Arquivo salvo em " + caminhoArquivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ;
        }
    }
}
