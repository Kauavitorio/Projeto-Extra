using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;                        //  Copyright (c) 2020 Kauã Vitório
using System.Threading.Tasks;             //  GitHub repositorio: https://github.com/Kauavitorio/Projeto-Extra
using System.Windows.Forms;               //  Não esqueça de preencher as informaçoes do seu banco de dados nas conexões
using System.Data.SqlClient;

namespace Sistema
{
    public partial class BaterPontoFunc : Form
    {
        public BaterPontoFunc()
        {
            InitializeComponent();
        }

        //Abrindo a conexão com o banco de dados

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-I8J3S4E\SQLEXPRESS;integrated security=SSPI;initial Catalog=db_redeextra");
        SqlCommand cm = new SqlCommand();
        SqlDataReader lerdados;


      //  Timer 1 Esta sendo programado para mudar o texto da label1  constantemente até o panel2 chegar a 60 de largura
      //  O panelprincimal ira ficar visivel quando o panel2 chegar a 60 de largura
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
                panelprincipal.Visible = true;
                }
        }

        //  Esse metodo esta habilitando as opções para abrir um ponto
        //  Ela esta fazendo com que todas as label e textbox fiquem visivel
        //  Os boto~es de salvar o ponto ira ficar visivel e o botão de iniciar o ponto ira ficar invisivel
        //  A textbox da data e hora de entrada serão preenchida com a data e hora que foi acionado esse metodo 

        private void habilitarinicioponto()
        {
            lblcd.Visible = true;
            lbldata.Visible = true;
            lblhrentrada.Visible = true;
            lblhrsaida.Visible = true;
            lblnome.Visible = true;
            txtcd.Visible = true;
            txtdata.Visible = true;
            txthrentra.Visible = true;
            txtnome.Visible = true;
            txthrsaida.Visible = true;
            txtcd.Focus();
            btnabrirponto.Visible = false;
            txthrsaida.Enabled = false;
            txtdata.Enabled = false;
            txthrentra.Enabled = false;
            btnsalvarpontoinicio.Visible = true;
            txtnome.Enabled = false;
            btnfecharponto.Visible = false;
            txtdata.Text = DateTime.Now.ToShortDateString();
            txthrentra.Text = DateTime.Now.ToLongTimeString();
        }

        //  Esse metodo ao ser acionado ira deixar as label e textbox de pontos invisivel
        //  Ira deixar invisivel o botão de salvar o ponto e diexara novamente visivel o botão de iniciar o ponto
        //  Tambem ja deixara visivel o botão de fechar o ponto

        private void desabilitarnovoponto()
        {
            lblcd.Visible = false;
            lbldata.Visible = false;
            lblhrentrada.Visible = false;
            lblhrsaida.Visible = false;
            lblnome.Visible = false;
            txtcd.Visible = false;
            txtdata.Visible = false;
            txthrentra.Visible = false;
            txtnome.Visible = false;
            txthrsaida.Visible = false;
            btnabrirponto.Visible = true;
            btnsalvarpontoinicio.Visible = false;
            btnfecharponto.Visible = true;
        }

        //  Esse metodo ira habilitar e tonar visivel todas as label e textbox para fazer o fechamento do ponto
        //  Ira tambem deixar visivel o botão de confirmar o fechamento do ponto e deixando invisivel o botão de começar o fechamento de ponto
        //  Esse metodo tambem habilita a forma de filtra as informaçoes da tabala(dtg)

        private void comecarfechamento()
        {
            lblcd.Visible = true;
            lbldata.Visible = true;
            lblhrentrada.Visible = true;
            lblhrsaida.Visible = true;
            lblnome.Visible = true;
            txtcd.Visible = true;
            txtdata.Visible = true;
            txthrentra.Visible = true;
            txtnome.Visible = true;
            txthrsaida.Visible = true;
            txtcd.Enabled = false;
            btnabrirponto.Visible = false;
            txthrsaida.Enabled = false;
            txtdata.Enabled = false;
            txthrentra.Enabled = false;
            txtnome.Enabled = false;
            txtcdponto.Visible = true;
            lblcdponto.Visible = true;
            txtcdponto.Enabled = false;
            btnfecharponto.Visible = false;
            btnsalavarfechamento.Visible = true;
            lblfiltro.Visible = true;
            txtfiltro.Visible = true;
        }

        //  Esse metodo ira desabilitar todas as label e textbox de ponto
        //  Tambem ira desabilitar o mecanismo de filtragem da tabela(dtg)
        //  Esse metodo estara deixando o botão de abrir ponto e fechar ponto visivel e esta deixando os botões de salvar o fechamento e salvar a abertura de ponto

        private void desabilitafechamento()
        {
            lblcd.Visible = false;
            lbldata.Visible = false;
            lblhrentrada.Visible = false;
            lblhrsaida.Visible = false;
            lblnome.Visible = false;
            txtcd.Visible = false;
            txtdata.Visible = false;
            txthrentra.Visible = false;
            txtnome.Visible = false;
            txthrsaida.Visible = false;
            btnabrirponto.Visible = true;
            btnsalvarpontoinicio.Visible = false;
            btnfecharponto.Visible = true;
            btnsalavarfechamento.Visible = false;
            lblcdponto.Visible = false;
            txtcdponto.Visible = false;
            lblfiltro.Visible = false;
            txtfiltro.Visible = false;
        }

        //  Esse metodo carrega a linha selecionada na tabela(dtg) nas textbox a baixo
        //  Codigo, nome, data, hora de entrada, códgio do ponto
        //  E esse metodo tambem coloca a hora do acionamento do metodo na textbox = hora de saaida

        private void carregaLinha()
        {
            txtcd.Text = dtg.SelectedRows[0].Cells[0].Value.ToString();
            txtnome.Text = dtg.SelectedRows[0].Cells[1].Value.ToString();
            txtdata.Text = dtg.SelectedRows[0].Cells[2].Value.ToString();
            txthrentra.Text = dtg.SelectedRows[0].Cells[3].Value.ToString();
            txtcdponto.Text = dtg.SelectedRows[0].Cells[5].Value.ToString();
            txthrsaida.Text = DateTime.Now.ToLongTimeString();
        }

        //  Esse metodo carrega a tabela de pontos(Banco de dados) no dataGridView nomeado "dtg"
        //  No metodo ele seleciona no banco de dados a tabela de bater pontos e coloca no dtg

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

        //  Esse metodo limpa todo o conteudo dentro das textbox citadas a baixo
        //  TextBox: Codigo, Codigo do ponto, Data, filtro, hora de entrada, hora de saida e nome
        private void limparcampos()
        {
            txtcd.Clear();
            txtcdponto.Clear();
            txtdata.Clear();
            txtfiltro.Clear();
            txthrentra.Clear();
            txtnome.Clear();
            txthrsaida.Clear();
        }

        //  Aqui estou definindo que quando o form(BaterPontoFunc) carregar esse ira realizar alguns passos..
        //  Posicionar a label1 nas cordenadas definidas, deixar visivel a label1 definir o texto da label1 e ativar o timer1

        private void BaterPontoFunc_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(76, 175);
            label1.Visible = true;
            label1.Text = "Bem Vindo a tela de bater ponto";
            timer1.Enabled = true;
        }

        //  Aqui estou definindo alguns comandos que o panelprincipal devera realizar como:
        //  Executar o metodo "carregarpontos()"
        //  Definir o DataGridView(dtg) com a cor de fonte como "White", Definir o backgroud das linhas como "Black" e o backgroud com "Black"
        //  Definir que cada coluna numerada de 0 a 5 receberam o nome correspondete ao do banco de dados

        private void panelprincipal_Paint(object sender, PaintEventArgs e)
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

        //  Aqui apenas estou mandando que quando clicar no botão de inicar ponto ele ira executar o metodo "habilitarinicioponto()"
        //  

        private void btnabrirponto_Click(object sender, EventArgs e)
        {
            habilitarinicioponto();
        }

        //  Aqui estou definindo que qunado precionado o botão de salvar ponto ele executara os seguintes comandos:
        //  Ira checar se a textbox de codigo esta vazia e se estiver ira retornar uma mensagem
        //  Se a textbox codigo estiver preenchida ela ira checar a de nome e se não estiver preenchida ela ira retornar uma mensagem
        //  Se todas as textbox estiverem preenchidas ele ira tantar abrir a conexao com o banco de dados e inserir nas colunas determinadas os valores das textbox
        //  E finalmente fechar a conexao com  o banco de dados e executar alguns metodos: "carregarpontos()" para atualizar a tabela, "desabilitarnovoponto()" e "limparcampos()"


        private void btnsalvarpontoinicio_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            if (txtcd.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'CODIGO' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtnome.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher o campo 'NOME' ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "insert into tbl_baterponto(cd_func,nm_func,dt_ponto,hr_entra,hr_saida)values('" + txtcd.Text + "','" + txtnome.Text + "','" + txtdata.Text + "','" + txthrentra.Text + "','" + txthrsaida.Text + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show($"{nome} Seu ponto foi registrado com sucesso!!!", "Gravação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    cn.Close();
                    carregarpontos();
                    desabilitarnovoponto();
                    limparcampos();
                }
            }
        }

        private void txtcd_TextChanged(object sender, EventArgs e)
        {
            if (txtcd.Text.Length >= 1)
            {
                try
                {
                    cn.Open();

                    string strsql = "select nm_func from tbl_funcionario where cd_func = " + txtcd.Text;
                    cm.Connection = cn;
                    cm.CommandText = strsql;
                    lerdados = cm.ExecuteReader();
                    if (!lerdados.HasRows)
                    {
                        MessageBox.Show("Este Funcionario não esta cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcd.Clear();
                        txtcd.Focus();
                        cn.Close();
                    }
                    else
                    {
                        lerdados.Read();
                        txtnome.Text = lerdados["nm_func"].ToString();
                        btnsalvarpontoinicio.Focus();
                        cn.Close();
                    }

                    if (!lerdados.IsClosed) { lerdados.Close(); }
                    txtnome.Text = txtnome.Text;

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnfecharponto_Click(object sender, EventArgs e)
        {
            if(txtcdponto.Text == "")
            {
                MessageBox.Show("Selecione na tabla o seu ponto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comecarfechamento();
            }
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(txtcdponto.Visible == false)
            {
                MessageBox.Show("É necessario iniciar o fechamento de ponto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                carregaLinha();
            }

        }

        private void btnsalavarfechamento_Click(object sender, EventArgs e)
        {
            if (txtcdponto.Text == "")
            {
                MessageBox.Show("Selecione o seu ponto para poder fechar ele", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtnome.Text == "")
            {
                MessageBox.Show("Selecione o seu ponto para poder fechar ele", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "update tbl_baterponto set cd_func = @cd_func,nm_func = @nm_func,dt_ponto = @dt_ponto,hr_entra = @hr_entra,hr_saida = @hr_saida where cd_ponto = " + txtcdponto.Text;
                    cm.Parameters.Add("@cd_func", SqlDbType.VarChar).Value = txtcd.Text;
                    cm.Parameters.Add("@nm_func", SqlDbType.VarChar).Value = txtnome.Text;
                    cm.Parameters.Add("@dt_ponto", SqlDbType.Date).Value = txtdata.Text;
                    cm.Parameters.Add("@hr_entra", SqlDbType.Time).Value = txthrentra.Text;
                    cm.Parameters.Add("@hr_saida", SqlDbType.Time).Value = txthrsaida.Text;

                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Dados Alterados com sucesso !!!", "Alteração Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cm.Parameters.Clear();
                    cn.Close();
                    carregarpontos();
                    desabilitafechamento();
                    limparcampos();
                }


                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
        }

        //  Aqui ao inserir algo dentro da textbox do filtro ele ira tentar encontrar algo relacionado na tabela(dtg)
        //  Se a textbox filtro estiver sem nenhum texto ela recarregar a tabela

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltro.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_baterponto where cd_func like ('%" + txtfiltro.Text + "%')";
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