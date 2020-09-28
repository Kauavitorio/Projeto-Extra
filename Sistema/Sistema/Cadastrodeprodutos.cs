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
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtcadnome.Visible = false;
            txtcadqt.Visible = false;
            txtcadvl.Visible = false;
            txtcadvali.Visible = false;
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
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            btncadastrar.Visible = true;
            txtcadnome.Visible = true;
            txtcadqt.Visible = true;
            txtcadvali.Visible = true;
            txtcadvl.Visible = true;
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
            txtnomeprod.ReadOnly = false;
            txtcdprod.ReadOnly = false;
            txtqtprod.ReadOnly = false;
            txtvaliprod.ReadOnly = false;
            txtprecoprod.ReadOnly = false;
            btniniciarcadastro.Visible = false;
            btnconcluiralt.Visible = true;
        }
        private void desabilitarcampos()
        {
            txtnomeprod.ReadOnly = true;
            txtcdprod.ReadOnly = true;
            txtqtprod.ReadOnly = true;
            txtvaliprod.ReadOnly = true;
            txtprecoprod.ReadOnly = true;
            btniniciarcadastro.Visible = true;
            btnconcluiralt.Visible = false;
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
            MessageBox.Show("\nAgora os campos abaixo podem ser editados insira os novos dados\n" +
                "Apos alterar os dados clique em 'Concluir Alteração'\n",
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            habilitarcampos();
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
                    cm.CommandText = "update tbl_cliente set nm_cliente = @nmcli,rg_cliente = @rg,sx_cliente = @sx,no_cliente = @num,cep_cliente =@cep,endereço = @end,complemento = @comple,no_casa = @numcasa where rg_cliente = " + txtcdprod.Text;
                    cm.Parameters.Add("@nmcli", SqlDbType.VarChar).Value = txtnomeprod.Text;
                    cm.Parameters.Add("@rg", SqlDbType.VarChar).Value = txtqtprod.Text;
                    cm.Parameters.Add("@sx", SqlDbType.VarChar).Value = txtvaliprod.Text;
                    cm.Parameters.Add("@num", SqlDbType.VarChar).Value = txtprecoprod.Text;

                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Dados Alterados com sucesso !!!", "Alteração Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    desabilitarcampos();
                    cm.Parameters.Clear();
                    cn.Close();
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
