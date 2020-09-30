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
    public partial class logindeveloper : Form
    {
        public logindeveloper()
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
            this.Close();
        }

        private void habilitacampos()
        {
            lblcd.Visible = true;
            lblcpf.Visible = true;
            lblserial.Visible = true;
            lblnome.Visible = true;
            txtcd.Visible = true;
            txtcpf.Visible = true;
            txtserial.Visible = true;
            txtnome.Visible = true;
            btnreset.Visible = true;
            button3.Location = new Point(143,228);
            txtserial.Location = new Point(235,134);
            lblserial.Location = new Point(142,145);
            txtcpf.Location = new Point(235,170);
            lblcpf.Location = new Point(140,174);
            lblcd.Location = new Point(140, 204);
            txtcd.Location = new Point(235, 193);
            txtnome.Location = new Point(235, 34);
            lblnome.Location = new Point(140, 45);
        }

        private void voltatudoaonormal()
        {
            txtlogin.Clear();
            txtsenha.Clear();
            button3.Location = new Point(143, 139);
            btnreset.Visible = false;
            lblcd.Visible = false;
            lblcpf.Visible = false;
            lblserial.Visible = false;
            lblnome.Visible = false;
            txtcd.Visible = false;
            txtcpf.Visible = false;
            txtserial.Visible = false;
            txtnome.Visible = false;
            txtcd.Clear();
            txtcpf.Clear();
            txtserial.Clear();
            txtnome.Clear();
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
                    cm.CommandText = "select * from tbl_devs where cpf_dev = ('" + txtlogin.Text + "') and senha_dev = ('" + txtsenha.Text + "')";
                    cm.Connection = cn;
                    lerdados = cm.ExecuteReader();
                    if (lerdados.HasRows)
                    {
                        TelaDevs tldevs = new TelaDevs();
                        tldevs.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha invalidos!!\nTente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {
            if (txtlogin.Text.Length >= 11)
            {
                try
                {
                    cn.Open();

                    string strsql = "select cd_dev, nm_dev, serial_dev,cpf_dev,senha_dev from tbl_devs where cpf_dev = " + txtlogin.Text;
                    cm.Connection = cn;
                    cm.CommandText = strsql;
                    lerdados = cm.ExecuteReader();
                    if (!lerdados.HasRows)
                    {
                        MessageBox.Show("Este Dev não esta cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtlogin.Clear();
                        txtlogin.Focus();
                        cn.Close();
                    }
                    else
                    {
                        lerdados.Read();
                        txtcd.Text = lerdados["cd_dev"].ToString();
                        txtnome.Text = lerdados["nm_dev"].ToString();
                        txtserial.Text = lerdados["serial_dev"].ToString();
                        txtcpf.Text = lerdados["cpf_dev"].ToString();
                        txtsenha.Focus();
                        cn.Close();
                        habilitacampos();
                    }

                    if (!lerdados.IsClosed) { lerdados.Close(); }
                    txtnome.Text = txtnome.Text;
                    txtcpf.Text = txtcpf.Text;
                    txtcd.Text = txtcd.Text;
                    txtserial.Text = txtserial.Text;

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtlogin.Focus();
            voltatudoaonormal();
            if(txtserial.Text == "")
            {
                timer1.Enabled = false;
                panel3.Size = new Size(19, 17);
                lblserialaviso.Visible = false;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtserial_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblserialaviso.Visible = true;
            lblserialaviso.Text = "Serial identificado com sucesso!!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 2;
            if (panel3.Width >= 80)
            {
                txtserial.PasswordChar = '•';
                lblserialaviso.Visible = false;
            }
            if (panel3.Width >= 90)
            {
                txtserial.PasswordChar = '@';
            }
            if (panel3.Width >= 93)
            {
                txtserial.PasswordChar = '$';
            }
            if (panel3.Width >= 96)
            {
                txtserial.PasswordChar = 'º';
            }
            if (panel3.Width >= 99)
            {
                txtserial.PasswordChar = 'X';
            }
            if (panel3.Width >= 102)
            {
                txtserial.PasswordChar = '@';
            }
            if (panel3.Width >= 105)
            {
                txtserial.PasswordChar = '$';
            }
            if (panel3.Width >= 108)
            {
                txtserial.PasswordChar = 'º';
            }
            if (panel3.Width >= 111)
            {
                txtserial.PasswordChar = 'X';
            }
            if (panel3.Width >= 114)
            {
                txtserial.PasswordChar = '@';
            }
            if (panel3.Width >= 117)
            {
                txtserial.PasswordChar = '$';
            }
            if (panel3.Width >= 120)
            {
                txtserial.PasswordChar = 'º';
            }
            if (panel3.Width >= 123)
            {
                txtserial.PasswordChar = '•';
                timer1.Enabled = false;
            }
        }
    }
}
