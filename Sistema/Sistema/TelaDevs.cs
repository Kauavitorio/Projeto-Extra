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
    public partial class TelaDevs : Form
    {
        public TelaDevs()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-I8J3S4E\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_redeextra");
        SqlCommand cm = new SqlCommand();

        private void carregarfunc()
        {
            try
            {
                cn.Open();

                cm.CommandText = "select * from tbl_funcionario";
                cm.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cm;
                da.Fill(dt);
                dtgfunc.DataSource = dt;
                cn.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            dtgfunc.DefaultCellStyle.ForeColor =
                Color.White;

            dtgfunc.RowsDefaultCellStyle.BackColor =

            Color.Black;

            dtgfunc.BackgroundColor = Color.Black;

        }

        private void comecareit()
        {
            txtnome.Enabled = true;
            txtcpf.Enabled = true;
            txtidade.Enabled = true;
            txtnasc.Enabled = true;
            txtcontra.Enabled = true;
            txtlogin.Enabled = true;
            txtsenha.Enabled = true;
            btninicioalter.Visible = false;
            btnalter.Visible = true;
        }
        private void finalizaralter()
        {
            txtcd.Visible = false;
            txtcd.Enabled = false;
            txtnome.Enabled = false;
            txtcpf.Enabled = false;
            txtidade.Enabled = false;
            txtnasc.Enabled = false;
            txtcontra.Enabled = false;
            txtlogin.Enabled = false;
            txtsenha.Enabled = false;
            txtnome.Visible = false;
            txtcpf.Visible = false;
            txtidade.Visible = false;
            txtnasc.Visible = false;
            txtcontra.Visible = false;
            txtlogin.Visible = false;
            txtsenha.Visible = false;
            lblcd.Visible = false;
            lblcontra.Visible = false;
            lblcpf.Visible = false;
            lblidade.Visible = false;
            lbllogin.Visible = false;
            lblnasc.Visible = false;
            lblnome.Visible = false;
            lblsenha.Visible = false;
            btnalter.Visible = false;
            txtnome.Clear();
            txtcpf.Clear();
            txtidade.Clear();
            txtnasc.Clear();
            txtcontra.Clear();
            txtlogin.Clear();
            txtsenha.Clear();
        }
        private void habilitaredit()
        {
            txtnome.Visible = true;
            txtcpf.Visible = true;
            txtidade.Visible = true;
            txtnasc.Visible = true;
            txtcontra.Visible = true;
            txtcd.Visible = true;
            txtlogin.Visible = true;
            txtsenha.Visible = true;
            lblcontra.Visible = true;
            lblcpf.Visible = true;
            lblidade.Visible = true;
            lbllogin.Visible = true;
            lblnasc.Visible = true;
            lblnome.Visible = true;
            lblsenha.Visible = true;
            lblcd.Visible = true;
            btninicioalter.Visible = true;
        }
        private void carregaLinha()
        {
            txtcd.Text = dtgfunc.SelectedRows[0].Cells[0].Value.ToString();
            txtnome.Text = dtgfunc.SelectedRows[0].Cells[1].Value.ToString();
            txtcpf.Text = dtgfunc.SelectedRows[0].Cells[2].Value.ToString();
            txtidade.Text = dtgfunc.SelectedRows[0].Cells[3].Value.ToString();
            txtnasc.Text = dtgfunc.SelectedRows[0].Cells[4].Value.ToString();
            txtcontra.Text = dtgfunc.SelectedRows[0].Cells[5].Value.ToString();
            txtlogin.Text = dtgfunc.SelectedRows[0].Cells[6].Value.ToString();
            txtsenha.Text = dtgfunc.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnsai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtgfunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaLinha();
            habilitaredit();
        }

        private void TelaDevs_Load(object sender, EventArgs e)
        {
            carregarfunc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregarfunc();
        }

        private void btninicioalter_Click(object sender, EventArgs e)
        {
            comecareit();
        }

        private void btnalter_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'NOME'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnome.Focus();
            }

            else if (txtcpf.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'CPF'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcpf.Focus();
            }
            else if (txtidade.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'IDADE'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidade.Focus();
            }
            else if (txtnasc.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'NASCIMENTO'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnasc.Focus();
            }
            else if (txtcontra.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'CONTRATAÇÃO'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcontra.Focus();
            }
            else if (txtlogin.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'LOGIN'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Focus();
            }
            else if (txtsenha.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'SENHA'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "update tbl_funcionario set nm_func = @nmfunc,cpf_func = @cpf,idade_fnc = @idade,nasc_func = @nasc,dtcontrat_func = @contra,login_func = @login,senha_func = @senha where cd_func = " + txtcd.Text;
                    cm.Parameters.Add("@nmfunc", SqlDbType.VarChar).Value = txtnome.Text;
                    cm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtcpf.Text;
                    cm.Parameters.Add("@idade", SqlDbType.Int).Value = txtidade.Text;
                    cm.Parameters.Add("@nasc", SqlDbType.Date).Value = txtnasc.Text;
                    cm.Parameters.Add("@contra", SqlDbType.Date).Value = txtcontra.Text;
                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = txtlogin.Text;
                    cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtsenha.Text;

                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Dados Alterados com sucesso !!!", "Alteração Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cm.Parameters.Clear();
                    cn.Close();
                    carregarfunc();
                    finalizaralter();
                }


                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
        }
    }
}
