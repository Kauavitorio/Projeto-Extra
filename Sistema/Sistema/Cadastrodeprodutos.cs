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
using System.Runtime.CompilerServices;

namespace Sistema
{
    public partial class Cadastrodeprodutos : Form
    {
        public Cadastrodeprodutos()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-I8J3S4E\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_redeextra");
        SqlCommand cm = new SqlCommand();

        private void carregarprod()
        {
            try
            {
                cn.Open();

                cm.CommandText = "select * from tbl_produtos";
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

        private void escondercadastro()
        {
            txtcadnome.Enabled = false;
            txtcadqt.Enabled = false;
            txtcadvl.Enabled = false;
            txtcadvali.Enabled = false;
            btniniciarcadastro.Visible = true;
            btncadastrar.Visible = false;
        }


        private void Cadastrodeprodutos_Load(object sender, EventArgs e)
        {
            carregarprod();

            dtg.DefaultCellStyle.ForeColor =
                Color.White;

            dtg.RowsDefaultCellStyle.BackColor =

            Color.Black;

            dtg.BackgroundColor = Color.Black;

            dtg.Columns[0].HeaderText =

            "Código Produto";



            dtg.Columns[1].HeaderText =

            "Nome do produto";



            dtg.Columns[2].HeaderText =

            "Estoque";



            dtg.Columns[3].HeaderText =

            "Validade";

            dtg.Columns[4].HeaderText =

            "Valor";

        }

        private void caregarcadastro()
        {
            btniniciarcadastro.Visible = false;
            btncadastrar.Visible = true;
            txtcadnome.Enabled = true;
            txtcadqt.Enabled = true;
            txtcadvali.Enabled = true;
            txtcadvl.Enabled = true;
        }
        private void carregaLinha()
        {
            txtcdprod.Text = dtg.SelectedRows[0].Cells[0].Value.ToString();
            txtnomeprod.Text = dtg.SelectedRows[0].Cells[1].Value.ToString();
            txtqtprod.Text = dtg.SelectedRows[0].Cells[2].Value.ToString();
            txtvaliprod.Text = dtg.SelectedRows[0].Cells[3].Value.ToString();
            txtprecoprod.Text = dtg.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void habilitarcampos()
        {
            txtnomeprod.Enabled = true;
            txtcdprod.Enabled = false;
            txtqtprod.Enabled = true;
            txtvaliprod.Enabled = true;
            txtprecoprod.Enabled = true;
            btniniciarcadastro.Visible = false;
            btnconcluiralt.Visible = true;
        }
        private void desabilitarcampos()
        {
            txtnomeprod.Enabled = false;
            txtcdprod.Enabled = false;
            txtqtprod.Enabled = false;
            txtvaliprod.Enabled = false;
            txtprecoprod.Enabled = false;
            btniniciarcadastro.Visible = true;
            btnconcluiralt.Visible = false;
        }

        private void limparcampos()
        {
            txtnomeprod.Clear();
            txtcdprod.Clear();
            txtqtprod.Clear();
            txtvaliprod.Clear();
            txtprecoprod.Clear();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (txtcadnome.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'NOME' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtcadqt.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'QUANTIDADE' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtcadvali.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'VALIDADE' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtcadvl.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'PREÇO' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int qtde = Convert.ToInt32(txtcadqt.Text);
                string validade = txtcadvali.Text;
                try
                {
                    cn.Open();
                    cm.CommandText = "insert into tbl_produtos(nm_prod,qtd_prod,dt_vali,vl_produto)values('" + txtcadnome.Text + "','" + qtde + "','" + validade + "','" + txtcadvl.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Novo produto cadastrado com sucesso!!!", "Gravação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    cn.Close();
                    carregarprod();
                    escondercadastro();
                }
            }
        }

        private void btniniciarcadastro_Click(object sender, EventArgs e)
        {
            caregarcadastro();
        }

        private void txtbuscarprod_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscarprod.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_produtos where nm_prod like ('%" + txtbuscarprod.Text + "%')";
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
                carregarprod();
            }
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaLinha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtcdprod.Text == "") {
                MessageBox.Show("É necessario selecionar um produto na lista!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("\nAgora os campos abaixo podem ser editados insira os novos dados\n" +
                "Apos alterar os dados clique em 'Concluir Alteração'\nSó não é possivel alterar o código do produto",
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                habilitarcampos();
            }
        }

        private void btnconcluiralt_Click(object sender, EventArgs e)
        {

            if (txtnomeprod.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'NOME'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnomeprod.Focus();
            }

            else if (txtqtprod.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'CEP'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtqtprod.Focus();
            }
            else if (txtvaliprod.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'NUMERO TELEFONE'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtvaliprod.Focus();
            }
            else if (txtprecoprod.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o campo 'NUMERO TELEFONE'", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtprecoprod.Focus();
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "update tbl_produtos set nm_prod = @nmprod,qtd_prod = @qtprod,dt_vali = @dtvaliprod,vl_produto = @vlprod where cd_prod = " + txtcdprod.Text;
                    cm.Parameters.Add("@nmprod", SqlDbType.VarChar).Value = txtnomeprod.Text;
                    cm.Parameters.Add("@qtprod", SqlDbType.Int).Value = txtqtprod.Text;
                    cm.Parameters.Add("@dtvaliprod", SqlDbType.Date).Value = txtvaliprod.Text;
                    cm.Parameters.Add("@vlprod", SqlDbType.Decimal).Value = txtprecoprod.Text;

                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Dados Alterados com sucesso !!!", "Alteração Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cm.Parameters.Clear();
                    cn.Close();
                    desabilitarcampos();
                    carregarprod();
                    limparcampos();
                }


                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;
            if (panel2.Width >= 1366)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel4.Width += 6;
            if (panel4.Width >= 1366)
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel6.Width += 2;
            if (panel6.Width >= 10)
            {
                label11.Text = "Bem Vindo ao cadastro de produtos!!";
            }
            if (panel6.Width >= 50)
            {
                label11.Text = "Banco de dados operendo corretamente!!";
            }
            if (panel6.Width >= 90)
            {
                label12.Location = new Point(12, 639);
                label11.Visible = false;
                label12.Visible = true;
            }
            if (panel6.Width >= 120)
            {
                label12.Text = "Banco de dados conecdado em 'Rede Extra'...";
            }
            if (panel6.Width >= 160)
            {
                label12.Text = "Todas as alteraçoes que serão salvas para a Rede Extra";
            }
            if (panel6.Width >= 200)
            {
                label12.Visible = false;
            }
        }
    }
}
