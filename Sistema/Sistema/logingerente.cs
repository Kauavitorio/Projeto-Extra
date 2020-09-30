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
using System.Runtime.InteropServices;

namespace Sistema
{
    public partial class logingerente : Form
    {
        public logingerente()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-I8J3S4E\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_redeextra");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void nomegerente()
        {
            if (txtlogingerente.Text != "")
            {
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                txtnomegerente.Visible = true;
                txtcpfgerente.Visible = true;
                txtcargogerente.Visible = true;
                txtsenha.Location = new Point(136, 263);
                label2.Location = new Point(43, 270);
                txtcpfgerente.Location = new Point(136, 194);
                label5.Location = new Point(43, 201);
                txtcargogerente.Location = new Point(136, 230);
                label6.Location = new Point(43, 237);
                txtcpfgerente.ForeColor = Color.FromArgb(255, 255, 255);
                btnlogar.Location = new Point(46, 318);
                txtlogingerente.Focus();
            }
            else
            {
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                txtnomegerente.Visible = false;
                txtcpfgerente.Visible = false;
                txtcargogerente.Visible = false;
                txtsenha.Location = new Point(136, 156);
                label2.Location = new Point(43, 165);
                btnlogar.Location = new Point(43, 191);
            }

        }

        private void logingerente_Load(object sender, EventArgs e)
        {
            nomegerente();
        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {
            if (txtlogingerente.Text.Length >= 1)
            {
                try
                {
                    cn.Open();

                    string strsql = "select cd_gerente, nm_gerente, cpf_gerente,func_gerente from tbl_gerentes where cd_gerente = " + txtlogingerente.Text;
                    cm.Connection = cn;
                    cm.CommandText = strsql;
                    lerdados = cm.ExecuteReader();
                    if (!lerdados.HasRows)
                    {
                        MessageBox.Show("Este Gerente não esta cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtlogingerente.Clear();
                        txtlogingerente.Focus();
                        nomegerente();
                        cn.Close();
                    }
                    else
                    {
                        lerdados.Read();
                        txtcpfgerente.Text = lerdados["cpf_gerente"].ToString();
                        txtnomegerente.Text = lerdados["nm_gerente"].ToString();
                        txtcargogerente.Text = lerdados["func_gerente"].ToString();
                        txtsenha.Focus();
                        cn.Close();
                        nomegerente();
                    }

                    if (!lerdados.IsClosed) { lerdados.Close(); }
                    txtnomegerente.Text = txtnomegerente.Text;
                    txtcpfgerente.Text = txtcpfgerente.Text;
                    txtcargogerente.Text = txtcargogerente.Text;
                    nomegerente();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    nomegerente();
                }
            }
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            if (txtlogingerente.Text == "" && txtsenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo login e senha !!", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogingerente.Focus();

            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_gerentes where cd_gerente = ('" + txtlogingerente.Text + "') and senha_gerente = ('" + txtsenha.Text + "')";
                    cm.Connection = cn;
                    lerdados = cm.ExecuteReader();
                    if (lerdados.HasRows)
                    {
                        TelaGerente gerente = new TelaGerente();
                        gerente.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha invalidos!!\nTente novamente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtsenha.Clear();
                        txtnomegerente.Clear();
                        txtlogingerente.Clear();
                        txtcpfgerente.Clear();
                        txtcargogerente.Clear();
                        txtlogingerente.Focus();
                        nomegerente();
                    }
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void logingerente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            logindeveloper devlog = new logindeveloper();
            devlog.Show();
            this.Close();
        }
    }
}
