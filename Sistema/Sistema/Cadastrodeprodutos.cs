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
    }
}
