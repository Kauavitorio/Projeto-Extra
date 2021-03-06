﻿using System;
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
    public partial class TelaGerente : Form
    {
        public TelaGerente()
        {
            InitializeComponent();
        }

        private void temaclaro()
        {
            btntemadark.Visible = true;
            btntemaclaro.Visible = false;
            painellateral.BackColor = Color.FromArgb(218,218,218);
            painelprincipal.BackColor = Color.FromArgb(255,255,255);
            painelsuperior.BackColor = Color.FromArgb(218,218,218);
            btncadastrarprod.BackColor = Color.FromArgb(190,190,190);
            btncadastrarprod.ForeColor = Color.FromArgb(0, 0, 0);
            btnsai.ForeColor = Color.FromArgb(0, 0, 0);
            btnmini.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void temadark()
        {
            btntemadark.Visible = false;
            btntemaclaro.Visible = true;
            painelprincipal.BackColor = Color.FromArgb(0, 0, 0);
            painellateral.BackColor = Color.FromArgb(40,40,40);
            painelsuperior.BackColor = Color.FromArgb(40,40,40);
            btncadastrarprod.BackColor = Color.FromArgb(30,30,30);
            btncadastrarprod.ForeColor = Color.FromArgb(255, 255, 255);
            btnmini.ForeColor = Color.FromArgb(255, 255, 255);
            btnsai.ForeColor = Color.FromArgb(255, 255, 255);

        }

        private void abrirjanela(object formvenda)
        {
            if (this.painelprincipal.Controls.Count > 0)
                this.painelprincipal.Controls.RemoveAt(0);
            Form venda = formvenda as Form;
            venda.TopLevel = false;
            venda.Dock = DockStyle.Fill;
            this.painelprincipal.Controls.Add(venda);
            this.painelprincipal.Tag = venda;
            venda.Show();
        }

        private void btncadastrarprod_Click(object sender, EventArgs e)
        {
            abrirjanela(new Cadastrodeprodutos());
        }

        private void btntemaclaro_Click(object sender, EventArgs e)
        {
            temaclaro();
        }

        private void btntemadark_Click(object sender, EventArgs e)
        {
            temadark();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            abrirjanela(new Funcionarios());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BaterPontoGerente baterPontoGerente = new BaterPontoGerente();
            baterPontoGerente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirjanela(new CadastrodenovoGerente());
        }
    }
}
