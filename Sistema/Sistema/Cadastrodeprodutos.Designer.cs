namespace Sistema
{
    partial class Cadastrodeprodutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.btniniciarcadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcadnome = new System.Windows.Forms.TextBox();
            this.txtcadqt = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtcadvali = new System.Windows.Forms.MaskedTextBox();
            this.txtcadvl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbuscarprod = new System.Windows.Forms.TextBox();
            this.btninicioalt = new System.Windows.Forms.Button();
            this.txtprecoprod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvaliprod = new System.Windows.Forms.MaskedTextBox();
            this.txtqtprod = new System.Windows.Forms.TextBox();
            this.txtnomeprod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcdprod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnconcluiralt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg
            // 
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Location = new System.Drawing.Point(570, 63);
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            this.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg.Size = new System.Drawing.Size(565, 484);
            this.dtg.TabIndex = 0;
            this.dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellContentClick);
            // 
            // btniniciarcadastro
            // 
            this.btniniciarcadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btniniciarcadastro.FlatAppearance.BorderSize = 0;
            this.btniniciarcadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btniniciarcadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciarcadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarcadastro.ForeColor = System.Drawing.Color.White;
            this.btniniciarcadastro.Location = new System.Drawing.Point(30, 29);
            this.btniniciarcadastro.Name = "btniniciarcadastro";
            this.btniniciarcadastro.Size = new System.Drawing.Size(284, 59);
            this.btniniciarcadastro.TabIndex = 1;
            this.btniniciarcadastro.Text = "Cadastrar Produtos";
            this.btniniciarcadastro.UseVisualStyleBackColor = false;
            this.btniniciarcadastro.Click += new System.EventHandler(this.btniniciarcadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Validade:";
            // 
            // txtcadnome
            // 
            this.txtcadnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtcadnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadnome.Enabled = false;
            this.txtcadnome.ForeColor = System.Drawing.Color.White;
            this.txtcadnome.Location = new System.Drawing.Point(156, 99);
            this.txtcadnome.Multiline = true;
            this.txtcadnome.Name = "txtcadnome";
            this.txtcadnome.Size = new System.Drawing.Size(158, 24);
            this.txtcadnome.TabIndex = 5;
            // 
            // txtcadqt
            // 
            this.txtcadqt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtcadqt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadqt.Enabled = false;
            this.txtcadqt.ForeColor = System.Drawing.Color.White;
            this.txtcadqt.Location = new System.Drawing.Point(156, 129);
            this.txtcadqt.Multiline = true;
            this.txtcadqt.Name = "txtcadqt";
            this.txtcadqt.Size = new System.Drawing.Size(158, 24);
            this.txtcadqt.TabIndex = 6;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btncadastrar.FlatAppearance.BorderSize = 0;
            this.btncadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.Color.White;
            this.btncadastrar.Location = new System.Drawing.Point(30, 227);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(284, 59);
            this.btncadastrar.TabIndex = 8;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Visible = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // txtcadvali
            // 
            this.txtcadvali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtcadvali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadvali.Enabled = false;
            this.txtcadvali.ForeColor = System.Drawing.Color.White;
            this.txtcadvali.Location = new System.Drawing.Point(156, 159);
            this.txtcadvali.Mask = "00/00/0000";
            this.txtcadvali.Name = "txtcadvali";
            this.txtcadvali.Size = new System.Drawing.Size(158, 20);
            this.txtcadvali.TabIndex = 9;
            this.txtcadvali.ValidatingType = typeof(System.DateTime);
            // 
            // txtcadvl
            // 
            this.txtcadvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtcadvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadvl.Enabled = false;
            this.txtcadvl.ForeColor = System.Drawing.Color.White;
            this.txtcadvl.Location = new System.Drawing.Point(156, 188);
            this.txtcadvl.Multiline = true;
            this.txtcadvl.Name = "txtcadvl";
            this.txtcadvl.Size = new System.Drawing.Size(158, 24);
            this.txtcadvl.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(567, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar um produto:";
            // 
            // txtbuscarprod
            // 
            this.txtbuscarprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtbuscarprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscarprod.ForeColor = System.Drawing.Color.White;
            this.txtbuscarprod.Location = new System.Drawing.Point(705, 29);
            this.txtbuscarprod.Multiline = true;
            this.txtbuscarprod.Name = "txtbuscarprod";
            this.txtbuscarprod.Size = new System.Drawing.Size(158, 24);
            this.txtbuscarprod.TabIndex = 13;
            this.txtbuscarprod.TextChanged += new System.EventHandler(this.txtbuscarprod_TextChanged);
            // 
            // btninicioalt
            // 
            this.btninicioalt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btninicioalt.FlatAppearance.BorderSize = 0;
            this.btninicioalt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btninicioalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicioalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicioalt.ForeColor = System.Drawing.Color.White;
            this.btninicioalt.Location = new System.Drawing.Point(30, 404);
            this.btninicioalt.Name = "btninicioalt";
            this.btninicioalt.Size = new System.Drawing.Size(284, 59);
            this.btninicioalt.TabIndex = 14;
            this.btninicioalt.Text = "Iniciar Alteração";
            this.btninicioalt.UseVisualStyleBackColor = false;
            this.btninicioalt.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtprecoprod
            // 
            this.txtprecoprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtprecoprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecoprod.Enabled = false;
            this.txtprecoprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecoprod.ForeColor = System.Drawing.Color.White;
            this.txtprecoprod.Location = new System.Drawing.Point(156, 612);
            this.txtprecoprod.Multiline = true;
            this.txtprecoprod.Name = "txtprecoprod";
            this.txtprecoprod.Size = new System.Drawing.Size(158, 24);
            this.txtprecoprod.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 612);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Preço:";
            // 
            // txtvaliprod
            // 
            this.txtvaliprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtvaliprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvaliprod.Enabled = false;
            this.txtvaliprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvaliprod.ForeColor = System.Drawing.Color.White;
            this.txtvaliprod.Location = new System.Drawing.Point(156, 583);
            this.txtvaliprod.Mask = "00/00/0000";
            this.txtvaliprod.Name = "txtvaliprod";
            this.txtvaliprod.Size = new System.Drawing.Size(158, 21);
            this.txtvaliprod.TabIndex = 20;
            this.txtvaliprod.ValidatingType = typeof(System.DateTime);
            // 
            // txtqtprod
            // 
            this.txtqtprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtqtprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqtprod.Enabled = false;
            this.txtqtprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtprod.ForeColor = System.Drawing.Color.White;
            this.txtqtprod.Location = new System.Drawing.Point(156, 553);
            this.txtqtprod.Multiline = true;
            this.txtqtprod.Name = "txtqtprod";
            this.txtqtprod.Size = new System.Drawing.Size(158, 24);
            this.txtqtprod.TabIndex = 19;
            // 
            // txtnomeprod
            // 
            this.txtnomeprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtnomeprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeprod.Enabled = false;
            this.txtnomeprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeprod.ForeColor = System.Drawing.Color.White;
            this.txtnomeprod.Location = new System.Drawing.Point(156, 513);
            this.txtnomeprod.Multiline = true;
            this.txtnomeprod.Name = "txtnomeprod";
            this.txtnomeprod.Size = new System.Drawing.Size(270, 34);
            this.txtnomeprod.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 583);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Validade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 514);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nome do Produto:";
            // 
            // txtcdprod
            // 
            this.txtcdprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtcdprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcdprod.Enabled = false;
            this.txtcdprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcdprod.ForeColor = System.Drawing.Color.White;
            this.txtcdprod.Location = new System.Drawing.Point(156, 481);
            this.txtcdprod.Multiline = true;
            this.txtcdprod.Name = "txtcdprod";
            this.txtcdprod.Size = new System.Drawing.Size(55, 24);
            this.txtcdprod.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Código do Produto:";
            // 
            // btnconcluiralt
            // 
            this.btnconcluiralt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnconcluiralt.FlatAppearance.BorderSize = 0;
            this.btnconcluiralt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnconcluiralt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconcluiralt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconcluiralt.ForeColor = System.Drawing.Color.White;
            this.btnconcluiralt.Location = new System.Drawing.Point(30, 404);
            this.btnconcluiralt.Name = "btnconcluiralt";
            this.btnconcluiralt.Size = new System.Drawing.Size(284, 59);
            this.btnconcluiralt.TabIndex = 25;
            this.btnconcluiralt.Text = "Concluir Alteração";
            this.btnconcluiralt.UseVisualStyleBackColor = false;
            this.btnconcluiralt.Visible = false;
            this.btnconcluiralt.Click += new System.EventHandler(this.btnconcluiralt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 8);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 8);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 760);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1366, 8);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 8);
            this.panel4.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(30, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(446, 16);
            this.panel5.TabIndex = 28;
            this.panel5.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(14, 16);
            this.panel6.TabIndex = 0;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 639);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(495, 31);
            this.label11.TabIndex = 29;
            this.label11.Text = "Bem Vindo ao cadastro de produtos!!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(14, 670);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(424, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Qualquer duvida consulte o desenvolvedor!!";
            this.label12.Visible = false;
            // 
            // Cadastrodeprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnconcluiralt);
            this.Controls.Add(this.txtcdprod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtprecoprod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtvaliprod);
            this.Controls.Add(this.txtqtprod);
            this.Controls.Add(this.txtnomeprod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btninicioalt);
            this.Controls.Add(this.txtbuscarprod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcadvl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcadvali);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtcadqt);
            this.Controls.Add(this.txtcadnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniniciarcadastro);
            this.Controls.Add(this.dtg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastrodeprodutos";
            this.Text = "Cadastrodeprodutos";
            this.Load += new System.EventHandler(this.Cadastrodeprodutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Button btniniciarcadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcadnome;
        private System.Windows.Forms.TextBox txtcadqt;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.MaskedTextBox txtcadvali;
        private System.Windows.Forms.TextBox txtcadvl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbuscarprod;
        private System.Windows.Forms.Button btninicioalt;
        private System.Windows.Forms.TextBox txtprecoprod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtvaliprod;
        private System.Windows.Forms.TextBox txtqtprod;
        private System.Windows.Forms.TextBox txtnomeprod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcdprod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnconcluiralt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}