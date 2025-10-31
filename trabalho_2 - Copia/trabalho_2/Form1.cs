using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace trabalho_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimpaDados()
        {
            lblId.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            cbClassificacao.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            lblDuracao.Text = string.Empty;
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
                MessageBox.Show(ex.Message, "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        
        private void CarregaDados(MySqlDataReader dr)
        {
            lblId.Text = dr["id"].ToString();
            txtTitulo.Text = dr["titulo"].ToString();

            if (cbGenero != null)
            {
                int idx = cbGenero.FindStringExact(dr["genero"]?.ToString() ?? "");
                cbGenero.SelectedIndex = idx;
            }

            if (cbClassificacao != null)
            {
                int idx = cbClassificacao.FindStringExact(dr["classificacao"]?.ToString() ?? "");
                cbClassificacao.SelectedIndex = idx;
            }

            lblDuracao.Text = dr["duracao"]?.ToString() ?? "";
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            btnPrimieiro_Click(sender, e);
            if (pnlBuscaTitulo != null)
                pnlBuscaTitulo.Location = new Point(12, 12);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            int idativo = int.Parse(lblId.Text);
            MySqlDataReader dr = CarregarRegistro("SELECT * FROM filmes WHERE id > " + idativo + " ORDER BY id ASC LIMIT 1");
            if (dr != null)
                CarregaDados(dr);
            else
            {
                MessageBox.Show("Último Registro", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterioir_Click(object sender, EventArgs e)
        {
            int idativo = int.Parse(lblId.Text);
            MySqlDataReader dr = CarregarRegistro("SELECT * FROM filmes WHERE id < " + idativo + " ORDER BY id DESC LIMIT 1");
            if (dr != null)
                CarregaDados(dr);
            else
            {
                MessageBox.Show("Primeiro Registro", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimieiro_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr = CarregarRegistro("SELECT * FROM filmes ORDER BY id ASC LIMIT 1");
            if (dr != null)
                CarregaDados(dr);
            else
            {
                LimpaDados();
                MessageBox.Show("O banco de dados está vazio!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr = CarregarRegistro("SELECT * FROM filmes ORDER BY id DESC LIMIT 1");
            if (dr != null)
                CarregaDados(dr);
            else
            {
                LimpaDados();
                MessageBox.Show("O banco de dados está vazio!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void buscaporId()
        {
            string id_busca = parametros.buscaId.ToString();
            string sql = "SELECT * FROM filmes WHERE id = " + id_busca;
            MySqlDataReader result = CarregarRegistro(sql);
            if (result != null)
            {
                CarregaDados(result);
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MudarEstado(false);
            parametros.buscaId = string.IsNullOrEmpty(lblId.Text) ? 0 : int.Parse(lblId.Text);
            LimpaDados();
            lblId.Text = "Agauradando";
            txtTitulo.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MudarEstado(false);
            parametros.buscaId = int.Parse(lblId.Text);
            txtTitulo.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = DBComun.Conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            try
            {
                cn.Open();

                string titulo = txtTitulo.Text.Trim();
                string genero = cbGenero?.SelectedItem?.ToString() ?? "";
                string classificacao = cbClassificacao?.SelectedItem?.ToString() ?? "";
                string duracao = lblDuracao.Text?.Trim() ?? "";

                if (lblId.Text != "Agauradando")
                {
                    cmd.CommandText = "UPDATE filmes SET titulo = @titulo, genero = @genero, classificacao = @classificacao, duracao = @duracao WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", int.Parse(lblId.Text));
                }
                else
                {
                    cmd.CommandText = "INSERT INTO filmes (titulo, genero, classificacao, duracao) VALUES (@titulo, @genero, @classificacao, @duracao)";
                }

                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@genero", genero);
                cmd.Parameters.AddWithValue("@classificacao", classificacao);
                cmd.Parameters.AddWithValue("@duracao", duracao);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                if (lblId.Text == "Agauradando")
                {
                    cmd.CommandText = "SELECT MAX(id) FROM filmes";
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
                MessageBox.Show(ex.Message, "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MudarEstado(true);
            CarregaDados(CarregarRegistro("SELECT * FROM filmes WHERE id = " + parametros.buscaId.ToString()));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Confirma a exclusão de " + txtTitulo.Text + "?", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                MySqlConnection cn = DBComun.Conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                try
                {
                    cn.Open();
                    cmd.CommandText = "DELETE FROM filmes WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", int.Parse(lblId.Text));
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    btnPrimieiro_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Filmes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void MudarEstado(bool estado)
        {
            pnlBotoes.Enabled = estado;
            pnlDados.Enabled = !estado;
            pnlRodape.Enabled = estado;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void carregaGrid()
        {
            string termoBusca = pnlBuscaTitulo?.Text?.Trim() ?? "";
            const string SQL = "SELECT id, titulo, genero, classificacao, duracao FROM filmes WHERE titulo LIKE @termo ORDER BY titulo";

            try
            {
                using (var cn = DBComun.Conectar())
                using (var cmd = new MySqlCommand(SQL, cn))
                {
                    if (termoBusca != "")
                        cmd.Parameters.AddWithValue("@termo", "%" + termoBusca + "%");
                    else
                        cmd.Parameters.AddWithValue("@termo", "%@@@@###"); // manter grid vazio quando sem termo

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        cn.Open();
                        da.Fill(dt);
                        dtgfilmes.DataSource = dt;
                        configurarColunasdoGrid();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Busca por título", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void configurarColunasdoGrid()
        {
            if (dtgfilmes.Columns.Count > 0)
            {
                if (dtgfilmes.Columns.Contains("id"))
                {
                    dtgfilmes.Columns["id"].HeaderText = "ID";
                    dtgfilmes.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                if (dtgfilmes.Columns.Contains("titulo"))
                {
                    dtgfilmes.Columns["titulo"].HeaderText = "Título";
                }
                if (dtgfilmes.Columns.Contains("genero"))
                {
                    dtgfilmes.Columns["genero"].HeaderText = "Gênero";
                }
                if (dtgfilmes.Columns.Contains("classificacao"))
                {
                    dtgfilmes.Columns["classificacao"].HeaderText = "Classificação";
                }
                if (dtgfilmes.Columns.Contains("duracao"))
                {
                    dtgfilmes.Columns["duracao"].HeaderText = "Duração";
                }

                dtgfilmes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgfilmes.MultiSelect = false;
                dtgfilmes.ReadOnly = true;
                dtgfilmes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgfilmes.AllowUserToAddRows = false;
            }
        }

        private void btnConfirmarBusca_Click(object sender, EventArgs e)
        {
            fazBusca();
        }

        private void btnCancelarBusca_Click(object sender, EventArgs e)
        {
            pnlBuscaTitulo.Visible = false;
        }

        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {
            pnlBuscaTitulo.Visible = true;
            configurarColunasdoGrid();
        }

        private void dtgfilmes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fazBusca();
        }

        private void fazBusca()
        {
            if (dtgfilmes.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dtgfilmes.SelectedRows[0];
                int idSelecionado = int.Parse(linhaSelecionada.Cells["id"].Value.ToString());
                if (idSelecionado != 0)
                {
                    parametros.buscaId = idSelecionado;
                    pnlBuscaTitulo.Visible = false;
                    buscaporId();
                }
                else
                {
                    MessageBox.Show("Nenhum registro selecionado!", "Busca por título", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!", "Busca por título", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Compras frm = new Compras();
            frm.Show();
        }
    }
}
