using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aula08_banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private MySqlDataReader CarregarRegistro(string sql)
        {
            try
            {
                MySqlConnection cn = DBComun.Conectar();
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = sql;
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    return dr;
                }
                else
                {
                    return null;   
                }
                cn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return null;
        }

        private void LimpaDados()
        {
            lblId.Text = string.Empty;
            txtNome.Text = "";
            txtEmail.Text = "";
        }

        private void CarregaDados(MySqlDataReader dr)
        {
            lblId.Text = dr["id"].ToString();
            txtNome.Text = dr["nome"].ToString();
            txtEmail.Text = dr["email"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPrimieiro_Click(sender, e);
            pnlBuscarporNome.Location = new Point(12,12);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            int idativo = int.Parse(lblId.Text);
            MySqlDataReader dr = CarregarRegistro("Select * from aula1 where id > " + idativo + " order by id asc limit 1");
            if (dr != null)
                CarregaDados(dr);
            else
            {
               // LimpaDados();
                MessageBox.Show("Último Registro", "Cadasro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterioir_Click(object sender, EventArgs e)
        {
            int idativo = int.Parse(lblId.Text);
            MySqlDataReader dr = CarregarRegistro("Select * from aula1 where id < " + idativo + " order by id desc limit 1");
            if (dr != null)
                CarregaDados(dr);
            else
            {
                // LimpaDados();
                MessageBox.Show("Primeiro Registro", "Cadasro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimieiro_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr = CarregarRegistro("Select * from aula1 order by id asc limit 1");
            if (dr != null)
                CarregaDados(dr);
            else
            {
                LimpaDados();
                MessageBox.Show("O banco de dados está vazio!", "Cadasro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr = CarregarRegistro("Select * from aula1 order by id desc limit 1");
            if (dr != null)
                CarregaDados(dr);
            else
            {
                LimpaDados();
                MessageBox.Show("O banco de dados está vazio!", "Cadasro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            Form f = new frmbusca();
            DialogResult resp = f.ShowDialog();
            if (resp == DialogResult.OK)
            {
                buscaporId();
            }
            else
            {
                //MessageBox.Show("Busca cancelada");
            }
        }
        private void buscaporId()
        {
            string id_busca = parametros.buscaId.ToString();
            string sql = "Select * from aula1 where id = " + id_busca;
            MySqlDataReader result = CarregarRegistro(sql);
            if (result != null)
            {
                CarregaDados(result);
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "Cadasro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MudarEstado(false);
            parametros.buscaId = int.Parse(lblId.Text);
            LimpaDados();
            lblId.Text = "Agauradando";
            txtNome.Focus();
        }



        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MudarEstado(true);
            CarregaDados(CarregarRegistro("Select * from aula1 where id = " + parametros.buscaId.ToString()));
        }

        private void MudarEstado(bool estado)
        {
            pnlBotoes.Enabled = estado;
            pnlDados.Enabled = !estado;
            pnlRodape.Enabled = estado;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = DBComun.Conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            try
            {
                cn.Open();
                if (lblId.Text != "Agauradando")
                {
                    cmd.CommandText = "update aula1 set nome = @nome, email = @email where id = @id";
                    cmd.Parameters.AddWithValue("@id", int.Parse(lblId.Text));
                }
                else
                    cmd.CommandText = "insert into aula1 (nome, email) values (@nome, @email)";
                cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                if (lblId.Text == "Agauradando")
                {
                    cmd.CommandText = "Select max(id) from aula1";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    lblId.Text = dr[0].ToString();
                    dr.Close();
                }
                cn.Close();
                MudarEstado(true);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MudarEstado(false);
            parametros.buscaId = int.Parse(lblId.Text);
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Confirma a exclusão de"+txtNome.Text+"?", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                MySqlConnection cn = DBComun.Conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                try {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = "delete from aula1 where id = @id";
                    cmd.Parameters.AddWithValue("@id", int.Parse(lblId.Text));
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    btnPrimieiro_Click(sender, e);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cadastro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscaNome_Click(object sender, EventArgs e)
        {
            pnlBuscarporNome.Visible = true;
            configuraGrid();
        }

        private void btnCancelarBusca_Click(object sender, EventArgs e)
        {
            pnlBuscarporNome.Visible = false;
        }

        private void btnConfirmarBusca_Click(object sender, EventArgs e)
        {
            fazBusca();
        }

        private void txtBuscarPorNome_TextChanged(object sender, EventArgs e)
        {

                carregaGrid();

        }
        private void configuraGrid()
        {
            dtgNomes.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            dtgNomes.MultiSelect= false;
            dtgNomes.ReadOnly = true;
            dtgNomes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgNomes.AllowUserToAddRows= false;
        }
        private void carregaGrid()
        {
            string termoBusca = txtBuscarPorNome.Text.Trim();
            string SQL = "Select * from aula1 where nome like @termo order by nome";
            try
            {
                using (MySqlConnection cn = DBComun.Conectar())
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(SQL, cn))
                    {
                        if (termoBusca != "")
                        {
                            cmd.Parameters.AddWithValue("@termo", "%" + termoBusca + "%");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@termo", "%@@@@###");
                        }
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtgNomes.DataSource = dt;
                        configurarColunasdoGrid();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Busca por nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void configurarColunasdoGrid()
        {
            if (dtgNomes.Columns.Count > 0)
            {
                if (dtgNomes.Columns.Contains("email"))
                {
                    dtgNomes.Columns["email"].Visible = false;
                }
                if (dtgNomes.Columns.Contains("id"))
                {
                    dtgNomes.Columns["id"].HeaderText = "ID";
                    dtgNomes.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                if (dtgNomes.Columns.Contains("nome"))
                {
                    dtgNomes.Columns["nome"].HeaderText = "Nome";

                }
            }
        }
        private void fazBusca()
        {
            if (dtgNomes.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dtgNomes.SelectedRows[0];
                int idSelecionado = int.Parse(linhaSelecionada.Cells["id"].Value.ToString());
                if (idSelecionado !=null) 
                {
                    parametros.buscaId = idSelecionado;
                    pnlBuscarporNome.Visible = false;
                    buscaporId();

                }
                else
                {
                  MessageBox.Show("Nenhum registro selecionado!", "Busca por nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!", "Busca por nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dtgNomes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fazBusca(object sender, DataGridViewCellEventArgs e)
        {
            fazBusca();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }

}
