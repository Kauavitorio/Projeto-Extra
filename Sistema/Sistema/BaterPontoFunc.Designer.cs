namespace Sistema
{
    partial class BaterPontoFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaterPontoFunc));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.btnsalavarfechamento = new System.Windows.Forms.Button();
            this.txtcdponto = new System.Windows.Forms.TextBox();
            this.lblcdponto = new System.Windows.Forms.Label();
            this.btnfecharponto = new System.Windows.Forms.Button();
            this.btnsalvarpontoinicio = new System.Windows.Forms.Button();
            this.txthrsaida = new System.Windows.Forms.TextBox();
            this.txthrentra = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcd = new System.Windows.Forms.TextBox();
            this.lblhrsaida = new System.Windows.Forms.Label();
            this.lblhrentrada = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblcd = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.btnabrirponto = new System.Windows.Forms.Button();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.panelprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(879, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = ".";
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(707, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(707, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 20);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // panelprincipal
            // 
            this.panelprincipal.Controls.Add(this.lblfiltro);
            this.panelprincipal.Controls.Add(this.txtfiltro);
            this.panelprincipal.Controls.Add(this.btnsalavarfechamento);
            this.panelprincipal.Controls.Add(this.txtcdponto);
            this.panelprincipal.Controls.Add(this.lblcdponto);
            this.panelprincipal.Controls.Add(this.btnfecharponto);
            this.panelprincipal.Controls.Add(this.btnsalvarpontoinicio);
            this.panelprincipal.Controls.Add(this.txthrsaida);
            this.panelprincipal.Controls.Add(this.txthrentra);
            this.panelprincipal.Controls.Add(this.txtdata);
            this.panelprincipal.Controls.Add(this.txtnome);
            this.panelprincipal.Controls.Add(this.txtcd);
            this.panelprincipal.Controls.Add(this.lblhrsaida);
            this.panelprincipal.Controls.Add(this.lblhrentrada);
            this.panelprincipal.Controls.Add(this.lbldata);
            this.panelprincipal.Controls.Add(this.lblcd);
            this.panelprincipal.Controls.Add(this.lblnome);
            this.panelprincipal.Controls.Add(this.btnabrirponto);
            this.panelprincipal.Controls.Add(this.dtg);
            this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprincipal.Location = new System.Drawing.Point(0, 0);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(904, 435);
            this.panelprincipal.TabIndex = 2;
            this.panelprincipal.Visible = false;
            this.panelprincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelprincipal_Paint);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltro.ForeColor = System.Drawing.Color.White;
            this.lblfiltro.Location = new System.Drawing.Point(12, 225);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(108, 13);
            this.lblfiltro.TabIndex = 13;
            this.lblfiltro.Text = "Insira seu código:";
            this.lblfiltro.Visible = false;
            this.lblfiltro.Click += new System.EventHandler(this.lblfiltro_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.BackColor = System.Drawing.Color.Black;
            this.txtfiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltro.ForeColor = System.Drawing.Color.White;
            this.txtfiltro.Location = new System.Drawing.Point(126, 223);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(100, 20);
            this.txtfiltro.TabIndex = 12;
            this.txtfiltro.Visible = false;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // btnsalavarfechamento
            // 
            this.btnsalavarfechamento.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.btnsalavarfechamento.BackColor = System.Drawing.Color.Black;
            this.btnsalavarfechamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalavarfechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalavarfechamento.ForeColor = System.Drawing.Color.White;
            this.btnsalavarfechamento.Location = new System.Drawing.Point(8, 163);
            this.btnsalavarfechamento.Name = "btnsalavarfechamento";
            this.btnsalavarfechamento.Size = new System.Drawing.Size(242, 54);
            this.btnsalavarfechamento.TabIndex = 11;
            this.btnsalavarfechamento.Text = "Salvar Fechamento";
            this.btnsalavarfechamento.UseVisualStyleBackColor = false;
            this.btnsalavarfechamento.Visible = false;
            this.btnsalavarfechamento.Click += new System.EventHandler(this.btnsalavarfechamento_Click);
            // 
            // txtcdponto
            // 
            this.txtcdponto.BackColor = System.Drawing.Color.Black;
            this.txtcdponto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcdponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcdponto.ForeColor = System.Drawing.Color.White;
            this.txtcdponto.Location = new System.Drawing.Point(96, 137);
            this.txtcdponto.Name = "txtcdponto";
            this.txtcdponto.Size = new System.Drawing.Size(100, 20);
            this.txtcdponto.TabIndex = 9;
            this.txtcdponto.Visible = false;
            // 
            // lblcdponto
            // 
            this.lblcdponto.AutoSize = true;
            this.lblcdponto.ForeColor = System.Drawing.Color.White;
            this.lblcdponto.Location = new System.Drawing.Point(5, 139);
            this.lblcdponto.Name = "lblcdponto";
            this.lblcdponto.Size = new System.Drawing.Size(74, 13);
            this.lblcdponto.TabIndex = 10;
            this.lblcdponto.Text = "Codigo Ponto:";
            this.lblcdponto.Visible = false;
            // 
            // btnfecharponto
            // 
            this.btnfecharponto.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.btnfecharponto.BackColor = System.Drawing.Color.Black;
            this.btnfecharponto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfecharponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharponto.ForeColor = System.Drawing.Color.White;
            this.btnfecharponto.Location = new System.Drawing.Point(6, 66);
            this.btnfecharponto.Name = "btnfecharponto";
            this.btnfecharponto.Size = new System.Drawing.Size(242, 54);
            this.btnfecharponto.TabIndex = 8;
            this.btnfecharponto.Text = "Fechar Ponto";
            this.btnfecharponto.UseVisualStyleBackColor = false;
            this.btnfecharponto.Click += new System.EventHandler(this.btnfecharponto_Click);
            // 
            // btnsalvarpontoinicio
            // 
            this.btnsalvarpontoinicio.BackColor = System.Drawing.Color.Black;
            this.btnsalvarpontoinicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvarpontoinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvarpontoinicio.ForeColor = System.Drawing.Color.White;
            this.btnsalvarpontoinicio.Location = new System.Drawing.Point(6, 139);
            this.btnsalvarpontoinicio.Name = "btnsalvarpontoinicio";
            this.btnsalvarpontoinicio.Size = new System.Drawing.Size(242, 54);
            this.btnsalvarpontoinicio.TabIndex = 7;
            this.btnsalvarpontoinicio.Text = "Salvar Ponto";
            this.btnsalvarpontoinicio.UseVisualStyleBackColor = false;
            this.btnsalvarpontoinicio.Visible = false;
            this.btnsalvarpontoinicio.Click += new System.EventHandler(this.btnsalvarpontoinicio_Click);
            // 
            // txthrsaida
            // 
            this.txthrsaida.BackColor = System.Drawing.Color.Black;
            this.txthrsaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthrsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthrsaida.ForeColor = System.Drawing.Color.White;
            this.txthrsaida.Location = new System.Drawing.Point(96, 111);
            this.txthrsaida.Name = "txthrsaida";
            this.txthrsaida.Size = new System.Drawing.Size(100, 20);
            this.txthrsaida.TabIndex = 5;
            this.txthrsaida.Visible = false;
            // 
            // txthrentra
            // 
            this.txthrentra.BackColor = System.Drawing.Color.Black;
            this.txthrentra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthrentra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthrentra.ForeColor = System.Drawing.Color.White;
            this.txthrentra.Location = new System.Drawing.Point(96, 85);
            this.txthrentra.Name = "txthrentra";
            this.txthrentra.Size = new System.Drawing.Size(100, 20);
            this.txthrentra.TabIndex = 4;
            this.txthrentra.Visible = false;
            // 
            // txtdata
            // 
            this.txtdata.BackColor = System.Drawing.Color.Black;
            this.txtdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.ForeColor = System.Drawing.Color.White;
            this.txtdata.Location = new System.Drawing.Point(52, 59);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(144, 20);
            this.txtdata.TabIndex = 3;
            this.txtdata.Visible = false;
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.Black;
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(52, 33);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(167, 20);
            this.txtnome.TabIndex = 2;
            this.txtnome.Visible = false;
            // 
            // txtcd
            // 
            this.txtcd.BackColor = System.Drawing.Color.Black;
            this.txtcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcd.ForeColor = System.Drawing.Color.White;
            this.txtcd.Location = new System.Drawing.Point(52, 7);
            this.txtcd.Name = "txtcd";
            this.txtcd.Size = new System.Drawing.Size(100, 20);
            this.txtcd.TabIndex = 1;
            this.txtcd.Visible = false;
            this.txtcd.TextChanged += new System.EventHandler(this.txtcd_TextChanged);
            // 
            // lblhrsaida
            // 
            this.lblhrsaida.AutoSize = true;
            this.lblhrsaida.ForeColor = System.Drawing.Color.White;
            this.lblhrsaida.Location = new System.Drawing.Point(3, 113);
            this.lblhrsaida.Name = "lblhrsaida";
            this.lblhrsaida.Size = new System.Drawing.Size(76, 13);
            this.lblhrsaida.TabIndex = 6;
            this.lblhrsaida.Text = "Hora de saida:";
            this.lblhrsaida.Visible = false;
            // 
            // lblhrentrada
            // 
            this.lblhrentrada.AutoSize = true;
            this.lblhrentrada.ForeColor = System.Drawing.Color.White;
            this.lblhrentrada.Location = new System.Drawing.Point(3, 87);
            this.lblhrentrada.Name = "lblhrentrada";
            this.lblhrentrada.Size = new System.Drawing.Size(87, 13);
            this.lblhrentrada.TabIndex = 5;
            this.lblhrentrada.Text = "Hora de entrada:";
            this.lblhrentrada.Visible = false;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.ForeColor = System.Drawing.Color.White;
            this.lbldata.Location = new System.Drawing.Point(3, 61);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(33, 13);
            this.lbldata.TabIndex = 4;
            this.lbldata.Text = "Data:";
            this.lbldata.Visible = false;
            // 
            // lblcd
            // 
            this.lblcd.AutoSize = true;
            this.lblcd.ForeColor = System.Drawing.Color.White;
            this.lblcd.Location = new System.Drawing.Point(3, 9);
            this.lblcd.Name = "lblcd";
            this.lblcd.Size = new System.Drawing.Size(43, 13);
            this.lblcd.TabIndex = 3;
            this.lblcd.Text = "Codigo:";
            this.lblcd.Visible = false;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.ForeColor = System.Drawing.Color.White;
            this.lblnome.Location = new System.Drawing.Point(3, 35);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome:";
            this.lblnome.Visible = false;
            // 
            // btnabrirponto
            // 
            this.btnabrirponto.BackColor = System.Drawing.Color.Black;
            this.btnabrirponto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrirponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabrirponto.ForeColor = System.Drawing.Color.White;
            this.btnabrirponto.Location = new System.Drawing.Point(6, 3);
            this.btnabrirponto.Name = "btnabrirponto";
            this.btnabrirponto.Size = new System.Drawing.Size(242, 54);
            this.btnabrirponto.TabIndex = 1;
            this.btnabrirponto.Text = "Abrir Ponto";
            this.btnabrirponto.UseVisualStyleBackColor = false;
            this.btnabrirponto.Click += new System.EventHandler(this.btnabrirponto_Click);
            // 
            // dtg
            // 
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Location = new System.Drawing.Point(254, 0);
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            this.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg.Size = new System.Drawing.Size(653, 435);
            this.dtg.TabIndex = 0;
            this.dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellContentClick);
            // 
            // BaterPontoFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(904, 435);
            this.Controls.Add(this.panelprincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(920, 474);
            this.MinimumSize = new System.Drawing.Size(920, 474);
            this.Name = "BaterPontoFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bater Ponto";
            this.Load += new System.EventHandler(this.BaterPontoFunc_Load);
            this.panelprincipal.ResumeLayout(false);
            this.panelprincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Label lblhrsaida;
        private System.Windows.Forms.Label lblhrentrada;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblcd;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btnabrirponto;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcd;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.TextBox txthrentra;
        private System.Windows.Forms.TextBox txthrsaida;
        private System.Windows.Forms.Button btnsalvarpontoinicio;
        private System.Windows.Forms.Button btnfecharponto;
        private System.Windows.Forms.TextBox txtcdponto;
        private System.Windows.Forms.Label lblcdponto;
        private System.Windows.Forms.Button btnsalavarfechamento;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label lblfiltro;
    }
}