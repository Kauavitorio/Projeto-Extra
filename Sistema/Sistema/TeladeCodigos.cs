using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sistema
{
    public partial class TeladeCodigos : Form
    {
        public TeladeCodigos()
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void TeladeCodigos_Load(object sender, EventArgs e)
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

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            txtbuscarprod.Focus();
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbuscarprod.Focus();
        }
    }
}
