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
    public partial class Teladesplash : Form
    {
        public Teladesplash()
        {
            InitializeComponent();
        }

        private void Teladesplash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading();
        }
        private void loading()
        {
            panel2.Width += 2;
            if (panel2.Width >= 694)
            {
                timer1.Stop();
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            if (panel2.Width >= 62)
            {
                label2.Text = "Carregando banco de dados...";
            }
            if (panel2.Width >= 150)
            {
                label2.Text = "Sincronizando SqlServer...";

            }
            if (panel2.Width >= 300)
            {
                label2.Text = "Conectando a 'Rede Extra'";
            }

            if (panel2.Width >= 350)
            {

                label2.Text = "Autenticando assinatura..";
            }
            if (panel2.Width >= 450)
            {
                panel2.Width += 4;
                label2.Text = "Baixando novos dados...";
            }
            if (panel2.Width >= 550)
            {
                label2.Text = "Baixando informações do estabelecimento";
            }

            if (panel2.Width >= 50)
            {
                label4.Visible = true;
            }
            if (panel2.Width >= 100)
            {
                label4.Text = "Altenticando com os Dados do servidor...";
            }
            if (panel2.Width >= 150)
            {
                label4.Text = "Abrindo conexão...";
            }
            if (panel2.Width >= 200)
            {
                label4.Text = "Conectando com o Primeiro provedor...";
            }
            if (panel2.Width >= 250)
            {
                label4.Text = "Conectando com o Segundo provedor...";
            }
            if (panel2.Width >= 270)
            {
                label4.Text = "SqlServer.Data";
            }
            if (panel2.Width >= 290)
            {
                label4.Text = "SqlConnection";
            }

            if (panel2.Width >= 300)
            {
                label4.Text = "Conectado!!";
            }
            if (panel2.Width >= 310)
            {
                label4.Text = "Consultando tabelas de daods...";
            }
            if (panel2.Width >= 330)
            {
                label4.Text = "Daods recebidos...";
            }
            if (panel2.Width >= 350)
            {
                label4.Text = "Fechando conexão..";
            }
            if (panel2.Width >= 400)
            {
                label4.Text = "Abrindo conexão..";
            }
            if (panel2.Width >= 450)
            {
                label4.Text = "Conectado a Rede Extra...";
            }
            if (panel2.Width >= 650)
            {
                label2.Visible = false;
                label4.Visible = false;
                label3.Visible = true;
            }
        }
    }
}
