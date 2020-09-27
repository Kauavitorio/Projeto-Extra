using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            PaginaPrincipal pagina = new PaginaPrincipal();
            pagina.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
