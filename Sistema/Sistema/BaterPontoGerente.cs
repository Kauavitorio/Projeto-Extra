using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;                           //  Copyright (c) 2020 Kauã Vitório
using System.Linq;                              //  GitHub repositorio: https://github.com/Kauavitorio/Projeto-Extra
using System.Text;                              //  Não esqueça de preencher as informaçoes do seu banco de dados nas conexões
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema
{
    public partial class BaterPontoGerente : Form
    {
        public BaterPontoGerente()
        {
            InitializeComponent();
        }

        //  Iniciando conexao com o banco de dados

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-I8J3S4E\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_redeextra");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;
        private void carregarpontos()
        {
            try
            {
                cn.Open();

                cm.CommandText = "select * from tbl_baterponto";
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

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //  Aqui estou declarando que quando eu clicar sobre a label1 ela ira exibir uma mensagem de aviso de desenvolvimento
        //  Após enviar a mensagem ele coloca a data atual na textbox
        //  E logo após ele ira verificar se a textbox filtro de data esta com algo escrito nela
        //  Caso ela não esteja vazia ele ira tornar visivel a label tirar a data e deixar invisivel a tabel de colocar a data
        //  Se estiver vazia ele ira deixar a label de tirar a data visivel
        

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse mecanicsmo esta em desenvolvimento\nCaso não tenha aparecido nada na tabela limpe o filtro e utiliza outro modo de busca","Ops...",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtfiltrodata.Text = DateTime.Now.ToShortDateString();
            if (txtfiltrodata.Text != "")
            {
                lblcolocardata.Visible = false;
                lbltiradata.Visible = true;
            }
            else
            {
                lbltiradata.Visible = true;
            }
        }

        //  Aqui estou declarando que quando haver a mudança dem texto da textbox do filtro da data ele ira executar alguns comandos
        //  Se a textbox não estiver vazio ela ira tentar abrir a conexao com o banco de dados e ira selecionar todos os dados que seja relacionado a data do ponto 
        //  Se a textbox estiver vazia ele ira atulizar a tabela

        private void txtfiltrodata_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltrodata.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_baterponto where dt_ponto like ('%" + txtfiltrodata.Text + "%')";
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
                carregarpontos();
            }
        }

        //  Aqui estou mandando que ao carregar o from ele ira executar alguns comandos
        //  Ira carregar a tabela 
        //  Ira definir o texto,background das linhas e backgroud geral como black
        //  Ira definir o nome de cada coluno com o nome correspondente definido a baixo

        private void BaterPontoGerente_Load(object sender, EventArgs e)
        {
            carregarpontos();
            dtg.DefaultCellStyle.ForeColor =
                Color.White;

            dtg.RowsDefaultCellStyle.BackColor =

            Color.Black;

            dtg.BackgroundColor = Color.Black;

            dtg.Columns[0].HeaderText = "Código Funcionario";
            dtg.Columns[1].HeaderText = "Nome Funcionario";
            dtg.Columns[2].HeaderText = "Data do Ponto";
            dtg.Columns[3].HeaderText = "Horario de Entrada";
            dtg.Columns[4].HeaderText = "Horario de Saida";
            dtg.Columns[5].HeaderText = "Código do Ponto";
        }

        //  Aqui estou definindo que quando clicar na label de retirar senha ele ira executar alguns comandos
        //  Ele ira limpar a textbox filtro da data,deixar a label de tirar a data invisivel, torna visivel a label de colocar data e focar na textboxfiltro de codigo

        private void lbltiradata_Click(object sender, EventArgs e)
        {
            txtfiltrodata.Text = "";
            lbltiradata.Visible = false;
            lblcolocardata.Visible = true;
            txtfiltrocd.Focus();
        }

        //  Aqui estou definindo que quando haver mudança no texto da textbox filtro de codigo ele ira realizar alguns comandos
        //  Ele ira verificar se a textbox esta vazia
        //  Se ela não estiver vazia ela ira tentar abrir a conexao com o banco de dados e selecionar na tabela de bater ponto tudo relacionado com a textbox
        //  Se estiver vazia ele ira atualizar a tabela

        private void txtfiltrocd_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltrocd.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_baterponto where cd_func like ('%" + txtfiltrocd.Text + "%')";
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
                carregarpontos();
            }
        }

        //  Aqui estou definindo que quando haver mudança no texto da textbox filtro de nome ele ira realizar alguns comandos
        //  Ele ira verificar se a textbox esta vazia
        //  Se ela não estiver vazia ela ira tentar abrir a conexao com o banco de dados e selecionar na tabela de bater ponto tudo relacionado com a textbox
        //  Se estiver vazia ele ira atualizar a tabela

        private void txtfiltronome_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltronome.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_baterponto where nm_func like ('%" + txtfiltronome.Text + "%')";
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
                carregarpontos();
            }
        }
    }
}


        //  Copyright (c) 2020 Kauã Vitório
        //  GitHub repositorio: https://github.com/Kauavitorio/Projeto-Extra
        //  Não esqueça de preencher as informaçoes do seu banco de dados nas conexões