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
    public partial class BaterPontoFunc : Form
    {
        public BaterPontoFunc()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
                if (panel2.Width >= 10)
                {
                    label1.Text = "Bem Vindo a tela de bater ponto.";
                }
                if (panel2.Width >= 20)
                {
                label1.Text = "Bem Vindo a tela de bater ponto..";
            }
                if (panel2.Width >= 30)
                {
                label1.Text = "Bem Vindo a tela de bater ponto...";
                }
                if (panel2.Width >= 40)
                {
                label1.Text = "Bem Vindo a tela de bater ponto.";
            }
            if (panel2.Width >= 50)
                {
                label1.Text = "Bem Vindo a tela de bater ponto..";
                }
            if (panel2.Width >= 60)
                {
                label1.Location = new Point(879,387);
                label1.Visible = false;
                timer1.Enabled = false;
                }
        }

        private void BaterPontoFunc_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(76, 175);
            label1.Visible = true;
            label1.Text = "Bem Vindo a tela de bater ponto";
            timer1.Enabled = true;
        }
    }
}
