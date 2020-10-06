using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema
{
    public partial class BaterPontoFunc : Form
    {
        public BaterPontoFunc()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-I8J3S4E\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_redeextra");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
                if (panel2.Width >= 10)
                {
                    label1.Text = "Bem Vindo a tela de bater ponto.";
                }
                if (panel2.Width >= 20)
                {
                label1.Text = "Bem Vindo a tela de bater ponto..";
            }
                if (panel2.Width >= 30)
                {
                label1.Text = "Bem Vindo a tela de bater ponto...";
                }
                if (panel2.Width >= 40)
                {
                label1.Text = "Bem Vindo a tela de bater ponto.";
            }
            if (panel2.Width >= 50)
                {
                label1.Text = "Bem Vindo a tela de bater ponto..";
                }
            if (panel2.Width >= 60)
                {
                label1.Location = new Point(879,387);
                label1.Visible = false;
                timer1.Enabled = false;
                panelprincipal.Visible = true;
                }
        }

        private void habilitarinicioponto()
        {
            lblcd.Visible = true;
            lbldata.Visible = true;
            lblhrentrada.Visible = true;
            lblhrsaida.Visible = true;
            lblnome.Visible = true;
            txtcd.Visible = true;
            txtdata.Visible = true;
            txthrentra.Visible = true;
            txtnome.Visible = true;
            txthrsaida.Visible = true;
            txtcd.Focus();
            btnabrirponto.Visible = false;
            txthrsaida.Enabled = false;
            txtdata.Enabled = false;
            txthrentra.Enabled = false;
            btnsalvarpontoinicio.Visible = true;
            txtnome.Enabled = false;
            btnfecharponto.Visible = false;
            txtdata.Text = DateTime.Now.ToShortDateString();
            txthrentra.Text = DateTime.Now.ToShortTimeString();
        }

        private void desabilitarnovoponto()
        {
            lblcd.Visible = false;
            lbldata.Visible = false;
            lblhrentrada.Visible = false;
            lblhrsaida.Visible = false;
            lblnome.Visible = false;
            txtcd.Visible = false;
            txtdata.Visible = false;
            txthrentra.Visible = false;
            txtnome.Visible = false;
            txthrsaida.Visible = false;
            btnabrirponto.Visible = true;
            btnsalvarpontoinicio.Visible = false;
            btnfecharponto.Visible = true;
        }

        private void comecarfechamento()
        {
            lblcd.Visible = true;
            lbldata.Visible = true;
            lblhrentrada.Visible = true;
            lblhrsaida.Visible = true;
            lblnome.Visible = true;
            txtcd.Visible = true;
            txtdata.Visible = true;
            txthrentra.Visible = true;
            txtnome.Visible = true;
            txthrsaida.Visible = true;
            txtcd.Enabled = false;
            btnabrirponto.Visible = false;
            txthrsaida.Enabled = false;
            txtdata.Enabled = false;
            txthrentra.Enabled = false;
            txtnome.Enabled = false;
            txtcdponto.Visible = true;
            lblcdponto.Visible = true;
            txtcdponto.Enabled = false;
            btnfecharponto.Visible = false;
            btnsalavarfechamento.Visible = true;
            lblfiltro.Visible = true;
            txtfiltro.Visible = true;
        }

        private void desabilitafechamento()
        {
            lblcd.Visible = false;
            lbldata.Visible = false;
            lblhrentrada.Visible = false;
            lblhrsaida.Visible = false;
            lblnome.Visible = false;
            txtcd.Visible = false;
            txtdata.Visible = false;
            txthrentra.Visible = false;
            txtnome.Visible = false;
            txthrsaida.Visible = false;
            btnabrirponto.Visible = true;
            btnsalvarpontoinicio.Visible = false;
            btnfecharponto.Visible = true;
            btnsalavarfechamento.Visible = false;
            lblcdponto.Visible = false;
            txtcdponto.Visible = false;
            lblfiltro.Visible = false;
            txtfiltro.Visible = false;
        }

        private void carregaLinha()
        {
            txtcd.Text = dtg.SelectedRows[0].Cells[0].Value.ToString();
            txtnome.Text = dtg.SelectedRows[0].Cells[1].Value.ToString();
            txtdata.Text = dtg.SelectedRows[0].Cells[2].Value.ToString();
            txthrentra.Text = dtg.SelectedRows[0].Cells[3].Value.ToString();
            txtcdponto.Text = dtg.SelectedRows[0].Cells[5].Value.ToString();
            txthrsaida.Text = DateTime.Now.ToLongTimeString();
        }

        private void carregarpontos()
        {
            try
            {
                cn.Open();

                cm.CommandText = "select * from tbl_baterponto";
                cm.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cm;
                da.Fill(dt);
                dtg.DataSource = dt;
                cn.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void BaterPontoFunc_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(76, 175);
            label1.Visible = true;
            label1.Text = "Bem Vindo a tela de bater ponto";
            timer1.Enabled = true;
        }

        private void panelprincipal_Paint(object sender, PaintEventArgs e)
        {
            carregarpontos();
            dtg.DefaultCellStyle.ForeColor =
                Color.White;

            dtg.RowsDefaultCellStyle.BackColor =

            Color.Black;

            dtg.BackgroundColor = Color.Black;

            dtg.Columns[0].HeaderText = "Código Funcionario";
            dtg.Columns[1].HeaderText = "Nome Funcionario";
            dtg.Columns[2].HeaderText = "Data do Ponto";
            dtg.Columns[3].HeaderText = "Horario de Entrada";
            dtg.Columns[4].HeaderText = "Horario de Saida";
            dtg.Columns[5].HeaderText = "Código do Ponto";
        }

        private void btnabrirponto_Click(object sender, EventArgs e)
        {
            habilitarinicioponto();
        }

        private void btnsalvarpontoinicio_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            if (txtcd.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'CODIGO' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtnome.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'NOME' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "insert into tbl_baterponto(cd_func,nm_func,dt_ponto,hr_entra,hr_saida)values('" + txtcd.Text + "','" + txtnome.Text + "','" + txtdata.Text + "','" + txthrentra.Text + "','" + txthrsaida.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show($"{nome} Seu ponto foi registrado com sucesso!!!", "Gravação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    cn.Close();
                    carregarpontos();
                    desabilitarnovoponto();
                }
            }
        }

        private void txtcd_TextChanged(object sender, EventArgs e)
        {
            if (txtcd.Text.Length >= 1)
            {
                try
                {
                    cn.Open();

                    string strsql = "select nm_func from tbl_funcionario where cd_func = " + txtcd.Text;
                    cm.Connection = cn;
                    cm.CommandText = strsql;
                    lerdados = cm.ExecuteReader();
                    if (!lerdados.HasRows)
                    {
                        MessageBox.Show("Este Funcionario não esta cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcd.Clear();
                        txtcd.Focus();
                        cn.Close();
                    }
                    else
                    {
                        lerdados.Read();
                        txtnome.Text = lerdados["nm_func"].ToString();
                        btnsalvarpontoinicio.Focus();
                        cn.Close();
                    }

                    if (!lerdados.IsClosed) { lerdados.Close(); }
                    txtnome.Text = txtnome.Text;

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnfecharponto_Click(object sender, EventArgs e)
        {
            if(txtcdponto.Text == "")
            {
                MessageBox.Show("Selecione na tabla o seu ponto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comecarfechamento();
            }
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(txtcdponto.Visible == false)
            {
                MessageBox.Show("É necessario iniciar o fechamento de ponto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                carregaLinha();
            }

        }

        private void btnsalavarfechamento_Click(object sender, EventArgs e)
        {
            if (txtcdponto.Text == "")
            {
                MessageBox.Show("Selecione o seu ponto para poder fechar ele", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtnome.Text == "")
            {
                MessageBox.Show("Selecione o seu ponto para poder fechar ele", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "update tbl_baterponto set cd_func = @cd_func,nm_func = @nm_func,dt_ponto = @dt_ponto,hr_entra = @hr_entra,hr_saida = @hr_saida where cd_ponto = " + txtcdponto.Text;
                    cm.Parameters.Add("@cd_func", SqlDbType.VarChar).Value = txtcd.Text;
                    cm.Parameters.Add("@nm_func", SqlDbType.VarChar).Value = txtnome.Text;
                    cm.Parameters.Add("@dt_ponto", SqlDbType.Date).Value = txtdata.Text;
                    cm.Parameters.Add("@hr_entra", SqlDbType.Time).Value = txthrentra.Text;
                    cm.Parameters.Add("@hr_saida", SqlDbType.Time).Value = txthrsaida.Text;

                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Dados Alterados com sucesso !!!", "Alteração Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cm.Parameters.Clear();
                    cn.Close();
                    carregarpontos();
                    desabilitafechamento();
                }


                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltro.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_baterponto where cd_func like ('%" + txtfiltro.Text + "%')";
                    cm.Connection = cn;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
                    da.Fill(dt);
                    dtg.DataSource = dt;
                    cn.Close();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
            else
            {
                carregarpontos();
            }
        }

        private void lblfiltro_Click(object sender, EventArgs e)
        {

        }
    }
}
