namespace Sistema
{
    partial class TelaDevs
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
            this.btnmini = new System.Windows.Forms.Button();
            this.btnsai = new System.Windows.Forms.Button();
            this.dtgfunc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnatualizatbls = new System.Windows.Forms.Button();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.btnalter = new System.Windows.Forms.Button();
            this.txtcd = new System.Windows.Forms.TextBox();
            this.lblcd = new System.Windows.Forms.Label();
            this.btninicioalter = new System.Windows.Forms.Button();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.MaskedTextBox();
            this.txtnasc = new System.Windows.Forms.MaskedTextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblcontra = new System.Windows.Forms.Label();
            this.lblnasc = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgfunc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmini
            // 
            this.btnmini.BackColor = System.Drawing.Color.Transparent;
            this.btnmini.FlatAppearance.BorderSize = 0;
            this.btnmini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnmini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnmini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmini.ForeColor = System.Drawing.Color.White;
            this.btnmini.Location = new System.Drawing.Point(1275, -2);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(49, 31);
            this.btnmini.TabIndex = 13;
            this.btnmini.Text = "-";
            this.btnmini.UseVisualStyleBackColor = false;
            // 
            // btnsai
            // 
            this.btnsai.BackColor = System.Drawing.Color.Transparent;
            this.btnsai.FlatAppearance.BorderSize = 0;
            this.btnsai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnsai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnsai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsai.ForeColor = System.Drawing.Color.White;
            this.btnsai.Location = new System.Drawing.Point(1325, -2);
            this.btnsai.Name = "btnsai";
            this.btnsai.Size = new System.Drawing.Size(49, 31);
            this.btnsai.TabIndex = 14;
            this.btnsai.Text = "X";
            this.btnsai.UseVisualStyleBackColor = false;
            this.btnsai.Click += new System.EventHandler(this.btnsai_Click);
            // 
            // dtgfunc
            // 
            this.dtgfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgfunc.Location = new System.Drawing.Point(12, 49);
            this.dtgfunc.Name = "dtgfunc";
            this.dtgfunc.ReadOnly = true;
            this.dtgfunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgfunc.Size = new System.Drawing.Size(843, 396);
            this.dtgfunc.TabIndex = 15;
            this.dtgfunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgfunc_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tabela dos funcionarios";
            // 
            // btnatualizatbls
            // 
            this.btnatualizatbls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btnatualizatbls.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnatualizatbls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnatualizatbls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnatualizatbls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatualizatbls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizatbls.ForeColor = System.Drawing.Color.White;
            this.btnatualizatbls.Location = new System.Drawing.Point(15, 451);
            this.btnatualizatbls.Name = "btnatualizatbls";
            this.btnatualizatbls.Size = new System.Drawing.Size(110, 46);
            this.btnatualizatbls.TabIndex = 17;
            this.btnatualizatbls.Text = "Atualizar Tabela";
            this.btnatualizatbls.UseVisualStyleBackColor = false;
            this.btnatualizatbls.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.BackColor = System.Drawing.Color.Black;
            this.txtcpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcpf.Enabled = false;
            this.txtcpf.ForeColor = System.Drawing.Color.White;
            this.txtcpf.Location = new System.Drawing.Point(201, 564);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(201, 20);
            this.txtcpf.TabIndex = 58;
            this.txtcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtcpf.Visible = false;
            // 
            // btnalter
            // 
            this.btnalter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnalter.FlatAppearance.BorderSize = 0;
            this.btnalter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalter.ForeColor = System.Drawing.Color.White;
            this.btnalter.Location = new System.Drawing.Point(131, 451);
            this.btnalter.Name = "btnalter";
            this.btnalter.Size = new System.Drawing.Size(271, 41);
            this.btnalter.TabIndex = 57;
            this.btnalter.Text = "Alterar";
            this.btnalter.UseVisualStyleBackColor = false;
            this.btnalter.Visible = false;
            this.btnalter.Click += new System.EventHandler(this.btnalter_Click);
            // 
            // txtcd
            // 
            this.txtcd.BackColor = System.Drawing.Color.Black;
            this.txtcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcd.Enabled = false;
            this.txtcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcd.ForeColor = System.Drawing.Color.White;
            this.txtcd.Location = new System.Drawing.Point(201, 501);
            this.txtcd.MaxLength = 50;
            this.txtcd.Multiline = true;
            this.txtcd.Name = "txtcd";
            this.txtcd.Size = new System.Drawing.Size(201, 23);
            this.txtcd.TabIndex = 55;
            this.txtcd.Visible = false;
            // 
            // lblcd
            // 
            this.lblcd.AutoSize = true;
            this.lblcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcd.ForeColor = System.Drawing.Color.White;
            this.lblcd.Location = new System.Drawing.Point(128, 509);
            this.lblcd.Name = "lblcd";
            this.lblcd.Size = new System.Drawing.Size(30, 15);
            this.lblcd.TabIndex = 56;
            this.lblcd.Text = "CD:";
            this.lblcd.Visible = false;
            // 
            // btninicioalter
            // 
            this.btninicioalter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btninicioalter.FlatAppearance.BorderSize = 0;
            this.btninicioalter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicioalter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicioalter.ForeColor = System.Drawing.Color.White;
            this.btninicioalter.Location = new System.Drawing.Point(131, 451);
            this.btninicioalter.Name = "btninicioalter";
            this.btninicioalter.Size = new System.Drawing.Size(271, 41);
            this.btninicioalter.TabIndex = 54;
            this.btninicioalter.Text = "Iniciar Alteração";
            this.btninicioalter.UseVisualStyleBackColor = false;
            this.btninicioalter.Visible = false;
            this.btninicioalter.Click += new System.EventHandler(this.btninicioalter_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.Color.Black;
            this.txtsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenha.Enabled = false;
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.ForeColor = System.Drawing.Color.White;
            this.txtsenha.Location = new System.Drawing.Point(218, 704);
            this.txtsenha.MaxLength = 20;
            this.txtsenha.Multiline = true;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(184, 23);
            this.txtsenha.TabIndex = 52;
            this.txtsenha.Visible = false;
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.Black;
            this.txtlogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlogin.Enabled = false;
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.ForeColor = System.Drawing.Color.White;
            this.txtlogin.Location = new System.Drawing.Point(218, 675);
            this.txtlogin.MaxLength = 20;
            this.txtlogin.Multiline = true;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(184, 23);
            this.txtlogin.TabIndex = 50;
            this.txtlogin.Visible = false;
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.Black;
            this.txtcontra.Enabled = false;
            this.txtcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontra.ForeColor = System.Drawing.Color.White;
            this.txtcontra.Location = new System.Drawing.Point(218, 647);
            this.txtcontra.Mask = "00/00/0000";
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(184, 22);
            this.txtcontra.TabIndex = 48;
            this.txtcontra.ValidatingType = typeof(System.DateTime);
            this.txtcontra.Visible = false;
            // 
            // txtnasc
            // 
            this.txtnasc.BackColor = System.Drawing.Color.Black;
            this.txtnasc.Enabled = false;
            this.txtnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnasc.ForeColor = System.Drawing.Color.White;
            this.txtnasc.Location = new System.Drawing.Point(218, 619);
            this.txtnasc.Mask = "00/00/0000";
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.Size = new System.Drawing.Size(184, 22);
            this.txtnasc.TabIndex = 46;
            this.txtnasc.ValidatingType = typeof(System.DateTime);
            this.txtnasc.Visible = false;
            // 
            // txtidade
            // 
            this.txtidade.BackColor = System.Drawing.Color.Black;
            this.txtidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidade.Enabled = false;
            this.txtidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidade.ForeColor = System.Drawing.Color.White;
            this.txtidade.Location = new System.Drawing.Point(201, 590);
            this.txtidade.MaxLength = 3;
            this.txtidade.Multiline = true;
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(201, 23);
            this.txtidade.TabIndex = 44;
            this.txtidade.Visible = false;
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.Black;
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnome.Enabled = false;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(201, 533);
            this.txtnome.MaxLength = 50;
            this.txtnome.Multiline = true;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(201, 23);
            this.txtnome.TabIndex = 41;
            this.txtnome.Visible = false;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.White;
            this.lblsenha.Location = new System.Drawing.Point(125, 706);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(52, 15);
            this.lblsenha.TabIndex = 53;
            this.lblsenha.Text = "Senha:";
            this.lblsenha.Visible = false;
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.White;
            this.lbllogin.Location = new System.Drawing.Point(125, 677);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(47, 15);
            this.lbllogin.TabIndex = 51;
            this.lbllogin.Text = "Login:";
            this.lbllogin.Visible = false;
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontra.ForeColor = System.Drawing.Color.White;
            this.lblcontra.Location = new System.Drawing.Point(125, 650);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(88, 15);
            this.lblcontra.TabIndex = 49;
            this.lblcontra.Text = "Contratação:";
            this.lblcontra.Visible = false;
            // 
            // lblnasc
            // 
            this.lblnasc.AutoSize = true;
            this.lblnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnasc.ForeColor = System.Drawing.Color.White;
            this.lblnasc.Location = new System.Drawing.Point(125, 622);
            this.lblnasc.Name = "lblnasc";
            this.lblnasc.Size = new System.Drawing.Size(87, 15);
            this.lblnasc.TabIndex = 47;
            this.lblnasc.Text = "Nascimento:";
            this.lblnasc.Visible = false;
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidade.ForeColor = System.Drawing.Color.White;
            this.lblidade.Location = new System.Drawing.Point(128, 590);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(47, 15);
            this.lblidade.TabIndex = 45;
            this.lblidade.Text = "Idade:";
            this.lblidade.Visible = false;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.ForeColor = System.Drawing.Color.White;
            this.lblcpf.Location = new System.Drawing.Point(128, 564);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(37, 15);
            this.lblcpf.TabIndex = 43;
            this.lblcpf.Text = "CPF:";
            this.lblcpf.Visible = false;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.White;
            this.lblnome.Location = new System.Drawing.Point(128, 541);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(49, 15);
            this.lblnome.TabIndex = 42;
            this.lblnome.Text = "Nome:";
            this.lblnome.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 59;
            this.button1.Text = "Deletar Funcionario";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TelaDevs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.btnalter);
            this.Controls.Add(this.txtcd);
            this.Controls.Add(this.lblcd);
            this.Controls.Add(this.btninicioalter);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtnasc);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lblnasc);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btnatualizatbls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgfunc);
            this.Controls.Add(this.btnmini);
            this.Controls.Add(this.btnsai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaDevs";
            this.Text = "TelaDevs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaDevs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgfunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmini;
        private System.Windows.Forms.Button btnsai;
        private System.Windows.Forms.DataGridView dtgfunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnatualizatbls;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Button btnalter;
        private System.Windows.Forms.TextBox txtcd;
        private System.Windows.Forms.Label lblcd;
        private System.Windows.Forms.Button btninicioalter;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.MaskedTextBox txtcontra;
        private System.Windows.Forms.MaskedTextBox txtnasc;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.Label lblnasc;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button button1;
    }
}