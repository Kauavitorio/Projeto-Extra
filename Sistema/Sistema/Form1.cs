using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Sistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-I8J3S4E\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_redeextra");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;


        private void Form1_Load(object sender, EventArgs e)
        {
            txtlogin.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            logingerente logingerente = new logingerente();
            logingerente.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "" && txtsenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo login e senha !!", "Não a nada inserido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Focus();

            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_funcionario where login_func = ('" + txtlogin.Text + "') and senha_func = ('" + txtsenha.Text + "')";
                    cm.Connection = cn;
                    lerdados = cm.ExecuteReader();
                    if (lerdados.HasRows)
                    {
                        PaginaPrincipal pagina = new PaginaPrincipal();
                        pagina.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha invalidos!!\nTente novamente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtlogin.Clear();
                        txtsenha.Clear();
                        txtlogin.Focus();
                    }
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
