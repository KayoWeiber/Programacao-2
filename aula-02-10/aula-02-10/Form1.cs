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

namespace aula_02_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
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
                    return (dr);
                }
                else
                {
                    return null;
                }
                cn.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }
        private void CarregaDados(MySqlDataReader dr)
        {
            lblId.Text = dr["id"].ToString();
            txtemail.Text = dr["nome"].ToString();
            txtNom.Text = dr["email"].ToString();

        }
        private void LimparDados()
        {
            lblId.Text = " ";
            txtemail.Text = " ";
            txtNom.Text = " ";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnPrimeiro_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idativo = int.Parse(lblId.Text);
            MySqlDataReader dr = CarregarRegistro("Select * from aula1 order by id desc limit 1;");
            if (dr != null)
                CarregaDados(dr);
            else
            {
                LimparDados();
                MessageBox.Show("O banco de dados não possui dados!", "Cadastro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTerceiro_Click(object sender, EventArgs e)
        {
            int idativo = int.Parse(lblId.Text);
            MySqlDataReader dr = CarregarRegistro("Select * from aula1 where id > " + idativo + " order by id asc limit 1;");
            if (dr != null)
                CarregaDados(dr);
            else
            {
                LimparDados();
                MessageBox.Show("O banco de dados não possui dados!", "Cadastro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            int idativo = int.Parse(lblId.Text);
            MySqlDataReader dr = CarregarRegistro("Select * from aula1 where id < " + idativo + " order by id desc limit 1");
            if (dr != null)
                CarregaDados(dr);
            else
            {
                LimparDados();
                MessageBox.Show("O banco de dados não possui dados!", "Cadastro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {

            MySqlDataReader dr = CarregarRegistro("Select * from aula1 order by id asc;");
            if (dr != null)
                CarregaDados(dr);
            else
            {
                MessageBox.Show("O banco de dados está vázio!", "Cadastro de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form form = new frmLista();
            DialogResult resp = form.ShowDialog();
            if (resp == DialogResult.OK)
            {
                string id_busca = parametro.buscaId.ToString();
                string sql = "Select * from aula1 where id= " + id_busca;
                MySqlDataReader dr = CarregarRegistro(sql);
                if (dr != null)
                    CarregaDados(dr);
                else
                {
                    
                    MessageBox.Show("O id " + id_busca + " não foi encontrado!", "Busca de id", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //MessageBox.Show("Busca cancelada!", "Busca de id", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
