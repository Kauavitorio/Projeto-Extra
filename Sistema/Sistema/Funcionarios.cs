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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-I8J3S4E\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_redeextra");
        SqlCommand cm = new SqlCommand();
        private void comecacadastro()
        {
            lbltitulocadas.Text = "Preencha os campos abaixo!!";
            txtcpffunc.Enabled = true;
            txtidadefunc.Enabled = true;
            txtloginfunc.Enabled = true;
            txtnascfunc.Enabled = true;
            txtnomefunc.Enabled = true;
            txtsenhafunc.Enabled = true;
            txtcontratofunc.Enabled = true;
            txtnomefunc.Focus();
            btniniciocadas.Visible = false;
            btncadastrar.Visible = true;
        }

        private void acabouocadastro()
        {
            lbltitulocadas.Text = "Cadastrar novo Funcionários";
            txtcpffunc.Enabled = false;
            txtidadefunc.Enabled = false;
            txtloginfunc.Enabled = false;
            txtnascfunc.Enabled = false;
            txtnomefunc.Enabled = false;
            txtsenhafunc.Enabled = false;
            txtcontratofunc.Enabled = false;
            btniniciocadas.Visible = true;
            btncadastrar.Visible = false;
        }

        private void limparcamposcadas()
        {
            txtcontratofunc.Clear();
            txtcpffunc.Clear();
            txtidadefunc.Clear();
            txtidadefunc.Clear();
            txtloginfunc.Clear();
            txtnascfunc.Clear();
            txtsenhafunc.Clear();
            txtnomefunc.Clear();
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
            lblavisoalter.Visible = false;
            lblnome.Visible = true;
            lblsenha.Visible = true;
            lblcd.Visible = true;
            btninicioalter.Visible = true;
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
            lblavisoalter.Visible = true;
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

        private void carregaLinha()
        {
            txtcd.Text = dtg.SelectedRows[0].Cells[0].Value.ToString();
            txtnome.Text = dtg.SelectedRows[0].Cells[1].Value.ToString();
            txtcpf.Text = dtg.SelectedRows[0].Cells[2].Value.ToString();
            txtidade.Text = dtg.SelectedRows[0].Cells[3].Value.ToString();
            txtnasc.Text = dtg.SelectedRows[0].Cells[4].Value.ToString();
            txtcontra.Text = dtg.SelectedRows[0].Cells[5].Value.ToString();
            txtlogin.Text = dtg.SelectedRows[0].Cells[6].Value.ToString();
            txtsenha.Text = dtg.SelectedRows[0].Cells[7].Value.ToString();
        }

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
                dtg.DataSource = dt;
                cn.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comecacadastro();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (txtnascfunc.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'NOME' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtcpffunc.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'CPF' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtidadefunc.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'IDADE' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtnascfunc.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'NASCIMENTO' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtcontratofunc.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'CONTRATAÇÃO' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtloginfunc.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'LOGIN' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtsenhafunc.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'SENHA' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nasc = txtnascfunc.Text;
                string contrato = txtcontratofunc.Text;
                string login = txtloginfunc.Text;
                string senha = txtsenhafunc.Text;
                try
                {
                    cn.Open();
                    cm.CommandText = "insert into tbl_funcionario(nm_func,cpf_func,idade_fnc,nasc_func,dtcontrat_func,login_func,senha_func)values('" + txtnomefunc.Text + "','" + txtcpffunc.Text + "','" + txtidadefunc.Text + "','" + nasc + "','" + contrato + "','" + login + "','" + senha + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Funcionario cadastrado com sucesso!!!", "Gravação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    cn.Close();
                    acabouocadastro();
                    limparcamposcadas();
                    carregarfunc();
                    
                }
            }
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitaredit();
            carregaLinha();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            carregarfunc();

            dtg.DefaultCellStyle.ForeColor =
                Color.White;

            dtg.RowsDefaultCellStyle.BackColor =

            Color.Black;

            dtg.BackgroundColor = Color.Black;

            dtg.Columns[0].HeaderText =

            "CD";



            dtg.Columns[1].HeaderText =

            "Nome";


            dtg.Columns[2].HeaderText =

            "CPF";



            dtg.Columns[3].HeaderText =

            "Idade";

            dtg.Columns[4].HeaderText =

            "Nascimento";

            dtg.Columns[5].HeaderText =

            "Contratação";

            dtg.Columns[6].HeaderText =

           "login";

            dtg.Columns[7].HeaderText =

           "Senha";
        }

        private void txtbuscarprod_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscarfunc.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_funcionario where nm_func like ('%" + txtbuscarfunc.Text + "%')";
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
                carregarfunc();
            }
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
