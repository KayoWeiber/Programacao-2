using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace trabalho1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<aluno> listaDeAlunos = new List<aluno>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblDataNasc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbMasc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVisu_Click(object sender, EventArgs e)
        {

            if (listaDeAlunos.Count == 0)
            {
                richTextBox2.Text = "Nenhum aluno foi cadastrado ainda.";
                return;
            }
            string textoFinal = "--- LISTA COMPLETA DE ALUNOS ---\n\n";
            foreach (var aluno in listaDeAlunos)
            {
                string disciplinas = aluno.matriculas.Count > 0
                    ? string.Join(", ", aluno.matriculas)
                    : "Nenhuma disciplina selecionada.";
                int idade = DateTime.Today.Year - aluno.dataNascimento.Year;
                if (aluno.dataNascimento.Date > DateTime.Today.AddYears(-idade))
                {
                    idade--;
                }
                textoFinal += $"Nome: {aluno.nome}\n";
                textoFinal += $"Data de Nascimento: {aluno.dataNascimento:dd/MM/yyyy}\n";
                textoFinal += $"Idade: {idade} anos\n";
                textoFinal += $"Gênero: {aluno.genero}\n";
                textoFinal += $"Disciplinas: {disciplinas}\n";
                textoFinal += "-----------------------------------\n";
            }

            richTextBox2.Text = textoFinal;
        }

        private void tboxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmar Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void alerta(string mensagem)
        {
            string titulo = "alerta";
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = tboxNome.Text;
            if (nome == "") alerta("Por favor, digite o nome");
            DateTime dataNascimento = dtpDataNasc.Value;
            if (!rbMasc.Checked && !rdFem.Checked)
            {
                alerta("Por favor, selecione o gênero");
                return; 
            }
            string genero = rbMasc.Checked ? "Masculino" : "Feminino";
            string curso = cbDisciplinas.Text;
            List<string> disciplinas = new List<string>();
            foreach (var disciplina in clbDisciplinas.CheckedItems)
            {
                disciplinas.Add(disciplina.ToString());
            }

            DateTime dataDoCadastro = DateTime.Now; 
            aluno novoAluno = new aluno(nome, dataNascimento, genero, disciplinas, dataDoCadastro);
            listaDeAlunos.Add(novoAluno);
            MessageBox.Show("Aluno adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            
            richTextBox1.AppendText(novoAluno.nome + "\n");


        }

        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void LimparCampos()
        {
            tboxNome.Clear();
            dtpDataNasc.Value = DateTime.Today;
            rbMasc.Checked = true; 
            for (int i = 0; i < clbDisciplinas.Items.Count; i++)
            {
                clbDisciplinas.SetItemChecked(i, false);
            }
        }

        private void btnSalv_Click(object sender, EventArgs e)
        {
            if (listaDeAlunos.Count == 0)
            {
                MessageBox.Show("Não há alunos para salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivo de Texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            saveDialog.Title = "Salvar Lista de Alunos";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        foreach (var aluno in listaDeAlunos)
                        {
                            string disciplinas = "";
                            for (int i = 0; i < aluno.matriculas.Count; i++)
                            {
                                disciplinas += aluno.matriculas[i];
                                if (i < aluno.matriculas.Count - 1)
                                {
                                    disciplinas += ",";
                                }
                            }

                            string dataNascimento = aluno.dataNascimento.ToString("dd/MM/yyyy");
                            string dataCadastro = aluno.DataCadastro.ToString("dd/MM/yyyy HH:mm:ss");
                            string linha = $"{aluno.nome}|{dataNascimento}|{aluno.genero}|{disciplinas}|{dataCadastro}";
                            
                            writer.WriteLine(linha);
                        }
                    }

                    MessageBox.Show("Alunos salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao salvar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAbrir_Click(object sender, EventArgs e)

        {

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Arquivo de Texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";

            openDialog.Title = "Abrir Lista de Alunos";
            if (openDialog.ShowDialog() == DialogResult.OK)

            {
                try

                {
                    List<aluno> alunosCarregados = new List<aluno>();

                    string[] linhasDoArquivo = File.ReadAllLines(openDialog.FileName);

                    foreach (var linha in linhasDoArquivo)

                    {
                        string[] campos = linha.Split('|');
                        if (campos.Length == 5)

                        {
                            string nome = campos[0];
                            DateTime dataNascimento = DateTime.ParseExact(campos[1], "dd/MM/yyyy", null);

                            string genero = campos[2];

                            List<string> disciplinas = new List<string>();

                            if (!string.IsNullOrEmpty(campos[3]))

                            {
                                disciplinas = campos[3].Split(',').ToList();
                            }
                            DateTime dataCadastro = DateTime.ParseExact(campos[4], "dd/MM/yyyy HH:mm:ss", null);
                            alunosCarregados.Add(new aluno(nome, dataNascimento, genero, disciplinas, dataCadastro));
                        }

                    }

                    listaDeAlunos = alunosCarregados;

                    AtualizarListaDeAlunosUI();



                    MessageBox.Show("Lista de alunos carregada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                catch (Exception ex)

                {

                    MessageBox.Show($"Ocorreu um erro ao abrir ou ler o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
        
        private void AtualizarListaDeAlunosUI()
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            foreach (var aluno in listaDeAlunos)
            {
                richTextBox1.AppendText(aluno.nome + "\n");
            }
        }
    }
}
