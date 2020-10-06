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
    public partial class BaterPontoGerente : Form
    {
        public BaterPontoGerente()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-I8J3S4E\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_redeextra");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;
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

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse mecanicsmo esta em desenvolvimento\nCaso não tenha aparecido nada na tabela limpe o filtro e utiliza outro modo de busca","Ops...",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtfiltrodata.Text = DateTime.Now.ToShortDateString();
            if (txtfiltrodata.Text != "")
            {
                lblcolocardata.Visible = false;
                lbltiradata.Visible = true;
            }
            else
            {
                lbltiradata.Visible = true;
            }
        }

        private void txtfiltrodata_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltrodata.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_baterponto where dt_ponto like ('%" + txtfiltrodata.Text + "%')";
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

        private void BaterPontoGerente_Load(object sender, EventArgs e)
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

        private void lbltiradata_Click(object sender, EventArgs e)
        {
            txtfiltrodata.Text = "";
            lbltiradata.Visible = false;
            lblcolocardata.Visible = true;
            txtfiltrocd.Focus();
        }

        private void txtfiltrocd_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltrocd.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_baterponto where cd_func like ('%" + txtfiltrocd.Text + "%')";
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

        private void txtfiltronome_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltronome.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_baterponto where nm_func like ('%" + txtfiltronome.Text + "%')";
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
    }
}
