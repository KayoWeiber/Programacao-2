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
            else
            {
                //MessageBox.Show("Busca cancelada");
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
    }

}
