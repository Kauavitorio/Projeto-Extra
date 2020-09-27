using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class PaginaPrincipal : Form
    {

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            imgcode();
            txtidprod.Focus();
        }

        public PaginaPrincipal()
        {
            InitializeComponent();
        }
        private void btntema_Click(object sender, EventArgs e)
        {
            temaclaro();
        }

        private void btntema2_Click_1(object sender, EventArgs e)
        {
            temadark();
        }

        private void btnajuda_Click(object sender, EventArgs e)
        {
            alertzinho.Visible = true;
            btnajuda.Visible = false;
            btndesligaluz.Visible = true;
        }

        private void btndesligaluz_Click(object sender, EventArgs e)
        {
            btndesligaluz.Visible = false;
            btnajuda.Visible = true;
            alertzinho.Visible = false;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnitens_Click(object sender, EventArgs e)
        {
            paneldositens.Visible = true;
        }
            
        private void temaclaro()
        {
            PainelPrincipal.BackColor = Color.FromArgb(255, 255, 255);
            painellateral.BackColor = Color.FromArgb(218, 218, 218);
            painelsuperior.BackColor = Color.FromArgb(218, 218, 218);
            btntema.Visible = false;
            btntema2.Visible = true;
            btnsair.ForeColor = Color.FromArgb(0, 0, 0);
            btnminimizar.ForeColor = Color.FromArgb(0, 0, 0);
            btnajuda.BackColor = Color.FromArgb(190, 190, 190);
            btnajuda.ForeColor = Color.FromArgb(0, 0, 0);
            btntrocarconta.BackColor = Color.FromArgb(190, 190, 190);
            btntrocarconta.ForeColor = Color.FromArgb(0, 0, 0);
            paneldositens.BackColor = Color.FromArgb(190, 190, 190);
            btncodigos.BackColor = Color.FromArgb(150, 150, 150);
            btncodigos.ForeColor = Color.FromArgb(0, 0, 0);
            btnitens.BackColor = Color.FromArgb(190, 190, 190);
            btnitens.ForeColor = Color.FromArgb(0, 0, 0);
            btndesligaluz.BackColor = Color.FromArgb(190, 190, 190);
            btndesligaluz.ForeColor = Color.FromArgb(0, 0, 0);
            btnajuda.ForeColor = Color.FromArgb(0, 0, 0);
            btnajuda.BackColor = Color.FromArgb(190, 190, 190);
            btndesligaluz.ForeColor = Color.FromArgb(0, 0, 0);
            btndesligaluz.BackColor = Color.FromArgb(190, 190, 190);
            label1.ForeColor = Color.FromArgb(0,0,0);
            label2.ForeColor = Color.FromArgb(0,0,0);
            label3.ForeColor = Color.FromArgb(0,0,0);
            txtidprod.BackColor = Color.FromArgb(230, 230, 230);
            txtqtprod.BackColor = Color.FromArgb(230, 230, 230);
            txtnomeprod.BackColor = Color.FromArgb(230, 230, 230);
            btnfinalizarcompra.BackColor = Color.FromArgb(230, 230, 230);
            btnfinalizarcompra.ForeColor = Color.FromArgb(0,0,0);
        }

        private void temadark()
        {
            btntema.Visible = true;
            btntema2.Visible = false;
            painellateral.BackColor = Color.FromArgb(40, 40, 40);
            painelsuperior.BackColor = Color.FromArgb(40, 40, 40);
            paneldositens.BackColor = Color.FromArgb(55, 55, 55);
            PainelPrincipal.BackColor = Color.FromArgb(0, 0, 0);
            btnsair.ForeColor = Color.FromArgb(255, 255, 255);
            btnminimizar.ForeColor = Color.FromArgb(255, 255, 255);
            btnitens.ForeColor = Color.FromArgb(255, 255, 255);
            btnitens.BackColor = Color.FromArgb(30, 30, 30);
            btncodigos.BackColor = Color.FromArgb(30, 30, 30);
            btncodigos.ForeColor = Color.FromArgb(255, 255, 255);
            btntrocarconta.ForeColor = Color.FromArgb(255, 255, 255);
            btntrocarconta.BackColor = Color.FromArgb(30, 30, 30);
            btnajuda.BackColor = Color.FromArgb(30, 30, 30);
            btnajuda.ForeColor = Color.FromArgb(255, 255, 255);
            btndesligaluz.ForeColor = Color.FromArgb(255, 255, 255);
            btndesligaluz.BackColor = Color.FromArgb(30, 30, 30);
            label1.ForeColor = Color.FromArgb(255, 255, 255);
            label2.ForeColor = Color.FromArgb(255, 255, 255);
            label3.ForeColor = Color.FromArgb(255, 255, 255);
            txtidprod.BackColor = Color.FromArgb(0,0,0);
            txtqtprod.BackColor = Color.FromArgb(0,0,0);
            txtnomeprod.BackColor = Color.FromArgb(0,0,0);
            btnfinalizarcompra.BackColor = Color.FromArgb(15, 15, 15);
            btnfinalizarcompra.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btncodigos_Click(object sender, EventArgs e)
        {
            paneldositens.Visible = false;
        }

        private void txtidprod_TextChanged(object sender, EventArgs e)
        {
            imgcode();
        }
        public void imgcode()
        {
            if (txtidprod.Text == "")
            {
                imginsiraocode.Visible = true;
            }
            else
            {
                imginsiraocode.Visible = false;
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btntrocarconta_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Gostaria realmente alterar sua conta?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                return;
            }
        }
    }
}
