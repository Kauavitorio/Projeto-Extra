using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class CadastrodenovoGerente : Form
    {
        public CadastrodenovoGerente()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-I8J3S4E\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_redeextra");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;

        private void carregargerent()
        {
            try
            {
                cn.Open();

                cm.CommandText = "select * from tbl_gerentes";
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

        }

        private void comecarcadas()
        {
            txtidfuncionariogere.Enabled = true;
            txtcpfgere.Enabled = true;
            txtnomegere.Enabled = true;
            txtsenhagere.Enabled = true;
            btncadastrar.Visible = true;
            btniniciocadas.Visible = false;
            ckeckgeregeral.Enabled = true;
            ckeckgerecaixa.Enabled = true;
            btndeletar.Visible = false;
            txtidfuncionariogere.Focus();
        }

        private void limpatudo()
        {
            txtcpfgere.Clear();
            txtgambiara.Clear();
            txtidfuncionariogere.Clear();
            txtnomegere.Clear();
            txtsenhagere.Clear();
            ckeckgerecaixa.Checked = false;
            ckeckgeregeral.Checked = false;
            txtcpfgere.Enabled = false;
            txtgambiara.Enabled = false;
            txtidfuncionariogere.Enabled = false;
            txtsenhagere.Enabled = false;
            txtnomegere.Enabled = false;
            btncadastrar.Visible = false;
            btniniciocadas.Visible = true;
            btndeletar.Visible = true;
        }

        private void CadastrodenovoGerente_Load(object sender, EventArgs e)
        {
            carregargerent();
            carregarfunc();

            //Tabela Funcionarios

            dtgfunc.DefaultCellStyle.ForeColor = Color.White;
            dtgfunc.RowsDefaultCellStyle.BackColor = Color.Black;
            dtgfunc.BackgroundColor = Color.Black;
            dtgfunc.Columns[0].HeaderText = "CD";
            dtgfunc.Columns[1].HeaderText = "Nome";
            dtgfunc.Columns[2].HeaderText = "CPF";
            dtgfunc.Columns[3].HeaderText = "Idade";
            dtgfunc.Columns[4].HeaderText = "Nascimento";
            dtgfunc.Columns[5].HeaderText = "Contratação";
            dtgfunc.Columns[6].HeaderText = "login";
            dtgfunc.Columns[7].HeaderText = "Senha";

            //Tabela Gerentes

            dtg.DefaultCellStyle.ForeColor = Color.White;
            dtg.RowsDefaultCellStyle.BackColor = Color.Black;
            dtg.BackgroundColor = Color.Black;
            dtg.Columns[0].HeaderText = "CD";
            dtg.Columns[1].HeaderText = "Nome";
            dtg.Columns[2].HeaderText = "CPF";
            dtg.Columns[3].HeaderText = "Função";
            dtg.Columns[4].HeaderText = "Senha";
        }

        private void carregaLinha()
        {
            ckeckgeregeral.Enabled = true;
            ckeckgerecaixa.Enabled = true;
            txtidparadeletar.Text = dtg.SelectedRows[0].Cells[0].Value.ToString();
            txtnomegere.Text = dtg.SelectedRows[0].Cells[1].Value.ToString();
            txtcpfgere.Text = dtg.SelectedRows[0].Cells[2].Value.ToString();
            txtgambiara.Text = dtg.SelectedRows[0].Cells[3].Value.ToString();
            txtsenhagere.Text = dtg.SelectedRows[0].Cells[4].Value.ToString();
            if(txtgambiara.Text == "Gerente Geral")
            {
                ckeckgeregeral.Checked = true;
            }
            else if (txtgambiara.Text == "Gerente de Caixa")
            {
                ckeckgerecaixa.Checked = true;
            }
            if((txtgambiara.Text != "Gerente Geral") && (txtgambiara.Text != "Gerente de Caixa"))
            {
                MessageBox.Show("Esse é um cargo superior ao de gerente\nContate um desenvolvedor ou propriatario!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpatudo();
                return;
            }
        }

        private void txtidfuncionariogere_TextChanged(object sender, EventArgs e)
        {
            if (txtidfuncionariogere.Text.Length >= 1)
            {
                try
                {
                    cn.Open();

                    string strsql = "select nm_func,cpf_func from tbl_funcionario where cd_func = " + txtidfuncionariogere.Text;
                    cm.Connection = cn;
                    cm.CommandText = strsql;
                    lerdados = cm.ExecuteReader();
                    if (!lerdados.HasRows)
                    {
                        MessageBox.Show("Este Funcionario não esta cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtidfuncionariogere.Clear();
                        txtidfuncionariogere.Focus();
                        cn.Close();
                    }
                    else
                    {
                        lerdados.Read();
                        txtnomegere.Text = lerdados["nm_func"].ToString();
                        txtcpfgere.Text = lerdados["cpf_func"].ToString();
                        txtnomegere.Enabled = false;
                        txtcpfgere.Enabled = false;
                        ckeckgeregeral.Focus();
                        cn.Close();
                    }

                    if (!lerdados.IsClosed) { lerdados.Close(); }
                    txtnomegere.Text = txtnomegere.Text;
                    txtcpfgere.Text = txtcpfgere.Text;

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

        private void btniniciocadas_Click(object sender, EventArgs e)
        {
            comecarcadas();
        }

        private void ckeckgeregeral_CheckedChanged(object sender, EventArgs e)
        {
            if (ckeckgeregeral.Checked == true)
            {
                ckeckgerecaixa.Enabled = false;
                txtsenhagere.Focus();
                txtgambiara.Text = "Gerente Geral";
            }
            else
            {
                ckeckgerecaixa.Enabled = true;
                txtgambiara.Clear();
            }
        }

        private void ckeckgerecaixa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckeckgerecaixa.Checked == true)
            {
                ckeckgeregeral.Enabled = false;
                txtsenhagere.Focus();
                txtgambiara.Text = "Gerente de Caixa";
            }
            else
            {
                ckeckgeregeral.Enabled = true;
                txtgambiara.Clear();
            }
        }

        private void txtsenhagere_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (txtnomegere.Text == "")
            {
                MessageBox.Show("Obrigatorio inserir o código do funcionario ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtcpfgere.Text == "")
            {
                MessageBox.Show("Obrigatorio inserir o código do funcionario ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtgambiara.Text == "")
            {

                MessageBox.Show("Obrigatorio selecionar a função ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtsenhagere.Text == "")
            {
                MessageBox.Show("Obrigatorio informar a senha do novo gerente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "insert into tbl_gerentes(nm_gerente,cpf_gerente,func_gerente,senha_gerente)values('" + txtnomegere.Text + "','" + txtcpfgere.Text + "','" + txtgambiara.Text + "','" + txtsenhagere.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Novo produto cadastrado com sucesso!!!", "Gravação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    cn.Close();
                    carregargerent();
                    limpatudo();
                }
            }
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            limpatudo();
            carregaLinha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtidparadeletar.Text == "")
            {
                MessageBox.Show("Selecione um gerente para a exclusão", "Alteração de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtidparadeletar.Text != "")
            {
                DialogResult exclusao = MessageBox.Show("Deseja realmentente excluir este registro??", "Alteração de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        cn.Open();
                        cm.CommandText = "delete from tbl_gerentes  where cd_gerente = " + txtidparadeletar.Text;
                        cm.Connection = cn;
                        cm.ExecuteNonQuery();
                        limpatudo();
                        MessageBox.Show("Funcionario deletado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);

                    }

                    finally
                    {
                        cn.Close();
                        carregargerent();
                    }
                }
            }
            
        }
    }
}