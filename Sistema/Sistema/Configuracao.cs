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
    public partial class Configuracao : Form
    {
        public Configuracao()
        {
            InitializeComponent();
        }

        private void Configuracao_Load(object sender, EventArgs e)
        {
            cmblingua.Items.AddRange(new object[]
            {
                "Portugues",
                "Ingles"
            });
            cmblingua.SelectedIndex = 0;
            //MessageBox.Show("Em desemvolvimento!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logindeveloper devlogin = new logindeveloper();
            devlogin.Show();
        }

        private void cmblingua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmblingua.SelectedIndex == 0)
            {
                label1.Text = "Você esta logado como:";
                label2.Location = new Point(118,436);
                cmblingua.Location = new Point(75, 21);
                button1.Location = new Point(167,379);
                label2.Text = "Funcionario";
                button1.Text = "Ativar";
                label3.Text = "Linguagem:";
                label4.Text = "Modo desenvolvedor:";
            }
            else
            {
                label2.Location = new Point(104,436);
                cmblingua.Location = new Point(72, 21);
                button1.Location = new Point(130, 379);
                label1.Text = "You are logged in as:";
                label2.Text = "Employee";
                button1.Text = "Turn on";
                label3.Text = "Language:";
                label4.Text = "Developer mode:";
            }
        }
    }
}