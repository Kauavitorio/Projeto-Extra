namespace Sistema
{
    partial class CadastrodenovoGerente
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
            this.dtg = new System.Windows.Forms.DataGridView();
            this.txtcpfgere = new System.Windows.Forms.MaskedTextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btniniciocadas = new System.Windows.Forms.Button();
            this.txtsenhagere = new System.Windows.Forms.TextBox();
            this.txtnomegere = new System.Windows.Forms.TextBox();
            this.lblsenhagere = new System.Windows.Forms.Label();
            this.lblcpfgere = new System.Windows.Forms.Label();
            this.lblnomegere = new System.Windows.Forms.Label();
            this.lblfuncaogere = new System.Windows.Forms.Label();
            this.txtidfuncionariogere = new System.Windows.Forms.TextBox();
            this.lblfuncionariogere = new System.Windows.Forms.Label();
            this.ckeckgeregeral = new System.Windows.Forms.CheckBox();
            this.ckeckgerecaixa = new System.Windows.Forms.CheckBox();
            this.txtgambiara = new System.Windows.Forms.TextBox();
            this.dtgfunc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgfunc)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg
            // 
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Location = new System.Drawing.Point(486, 520);
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            this.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg.Size = new System.Drawing.Size(562, 213);
            this.dtg.TabIndex = 1;
            // 
            // txtcpfgere
            // 
            this.txtcpfgere.BackColor = System.Drawing.Color.Black;
            this.txtcpfgere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcpfgere.Enabled = false;
            this.txtcpfgere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpfgere.ForeColor = System.Drawing.Color.White;
            this.txtcpfgere.Location = new System.Drawing.Point(85, 67);
            this.txtcpfgere.Mask = "000.000.000-00";
            this.txtcpfgere.Name = "txtcpfgere";
            this.txtcpfgere.Size = new System.Drawing.Size(201, 21);
            this.txtcpfgere.TabIndex = 57;
            this.txtcpfgere.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btncadastrar.FlatAppearance.BorderSize = 0;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.Color.White;
            this.btncadastrar.Location = new System.Drawing.Point(12, 151);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(277, 41);
            this.btncadastrar.TabIndex = 56;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Visible = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btniniciocadas
            // 
            this.btniniciocadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btniniciocadas.FlatAppearance.BorderSize = 0;
            this.btniniciocadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciocadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciocadas.ForeColor = System.Drawing.Color.White;
            this.btniniciocadas.Location = new System.Drawing.Point(15, 151);
            this.btniniciocadas.Name = "btniniciocadas";
            this.btniniciocadas.Size = new System.Drawing.Size(271, 41);
            this.btniniciocadas.TabIndex = 42;
            this.btniniciocadas.Text = "Iniciar Cadastro";
            this.btniniciocadas.UseVisualStyleBackColor = false;
            this.btniniciocadas.Click += new System.EventHandler(this.btniniciocadas_Click);
            // 
            // txtsenhagere
            // 
            this.txtsenhagere.BackColor = System.Drawing.Color.Black;
            this.txtsenhagere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenhagere.Enabled = false;
            this.txtsenhagere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenhagere.ForeColor = System.Drawing.Color.White;
            this.txtsenhagere.Location = new System.Drawing.Point(85, 122);
            this.txtsenhagere.MaxLength = 20;
            this.txtsenhagere.Multiline = true;
            this.txtsenhagere.Name = "txtsenhagere";
            this.txtsenhagere.Size = new System.Drawing.Size(201, 23);
            this.txtsenhagere.TabIndex = 54;
            this.txtsenhagere.TextChanged += new System.EventHandler(this.txtsenhagere_TextChanged);
            // 
            // txtnomegere
            // 
            this.txtnomegere.BackColor = System.Drawing.Color.Black;
            this.txtnomegere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomegere.Enabled = false;
            this.txtnomegere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomegere.ForeColor = System.Drawing.Color.White;
            this.txtnomegere.Location = new System.Drawing.Point(85, 36);
            this.txtnomegere.MaxLength = 50;
            this.txtnomegere.Multiline = true;
            this.txtnomegere.Name = "txtnomegere";
            this.txtnomegere.Size = new System.Drawing.Size(201, 23);
            this.txtnomegere.TabIndex = 43;
            // 
            // lblsenhagere
            // 
            this.lblsenhagere.AutoSize = true;
            this.lblsenhagere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenhagere.ForeColor = System.Drawing.Color.White;
            this.lblsenhagere.Location = new System.Drawing.Point(9, 124);
            this.lblsenhagere.Name = "lblsenhagere";
            this.lblsenhagere.Size = new System.Drawing.Size(52, 15);
            this.lblsenhagere.TabIndex = 55;
            this.lblsenhagere.Text = "Senha:";
            // 
            // lblcpfgere
            // 
            this.lblcpfgere.AutoSize = true;
            this.lblcpfgere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpfgere.ForeColor = System.Drawing.Color.White;
            this.lblcpfgere.Location = new System.Drawing.Point(12, 67);
            this.lblcpfgere.Name = "lblcpfgere";
            this.lblcpfgere.Size = new System.Drawing.Size(37, 15);
            this.lblcpfgere.TabIndex = 45;
            this.lblcpfgere.Text = "CPF:";
            // 
            // lblnomegere
            // 
            this.lblnomegere.AutoSize = true;
            this.lblnomegere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomegere.ForeColor = System.Drawing.Color.White;
            this.lblnomegere.Location = new System.Drawing.Point(12, 44);
            this.lblnomegere.Name = "lblnomegere";
            this.lblnomegere.Size = new System.Drawing.Size(49, 15);
            this.lblnomegere.TabIndex = 44;
            this.lblnomegere.Text = "Nome:";
            // 
            // lblfuncaogere
            // 
            this.lblfuncaogere.AutoSize = true;
            this.lblfuncaogere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuncaogere.ForeColor = System.Drawing.Color.White;
            this.lblfuncaogere.Location = new System.Drawing.Point(9, 97);
            this.lblfuncaogere.Name = "lblfuncaogere";
            this.lblfuncaogere.Size = new System.Drawing.Size(58, 15);
            this.lblfuncaogere.TabIndex = 47;
            this.lblfuncaogere.Text = "Função:";
            // 
            // txtidfuncionariogere
            // 
            this.txtidfuncionariogere.BackColor = System.Drawing.Color.Black;
            this.txtidfuncionariogere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidfuncionariogere.Enabled = false;
            this.txtidfuncionariogere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidfuncionariogere.ForeColor = System.Drawing.Color.White;
            this.txtidfuncionariogere.Location = new System.Drawing.Point(139, 7);
            this.txtidfuncionariogere.MaxLength = 50;
            this.txtidfuncionariogere.Multiline = true;
            this.txtidfuncionariogere.Name = "txtidfuncionariogere";
            this.txtidfuncionariogere.Size = new System.Drawing.Size(147, 23);
            this.txtidfuncionariogere.TabIndex = 58;
            this.txtidfuncionariogere.TextChanged += new System.EventHandler(this.txtidfuncionariogere_TextChanged);
            // 
            // lblfuncionariogere
            // 
            this.lblfuncionariogere.AutoSize = true;
            this.lblfuncionariogere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuncionariogere.ForeColor = System.Drawing.Color.White;
            this.lblfuncionariogere.Location = new System.Drawing.Point(12, 9);
            this.lblfuncionariogere.Name = "lblfuncionariogere";
            this.lblfuncionariogere.Size = new System.Drawing.Size(121, 15);
            this.lblfuncionariogere.TabIndex = 59;
            this.lblfuncionariogere.Text = "ID de funcionario:";
            // 
            // ckeckgeregeral
            // 
            this.ckeckgeregeral.AutoSize = true;
            this.ckeckgeregeral.Enabled = false;
            this.ckeckgeregeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckeckgeregeral.ForeColor = System.Drawing.Color.White;
            this.ckeckgeregeral.Location = new System.Drawing.Point(85, 99);
            this.ckeckgeregeral.Name = "ckeckgeregeral";
            this.ckeckgeregeral.Size = new System.Drawing.Size(94, 16);
            this.ckeckgeregeral.TabIndex = 60;
            this.ckeckgeregeral.Text = "Gerente Geral";
            this.ckeckgeregeral.UseVisualStyleBackColor = true;
            this.ckeckgeregeral.CheckedChanged += new System.EventHandler(this.ckeckgeregeral_CheckedChanged);
            // 
            // ckeckgerecaixa
            // 
            this.ckeckgerecaixa.AutoSize = true;
            this.ckeckgerecaixa.Enabled = false;
            this.ckeckgerecaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckeckgerecaixa.ForeColor = System.Drawing.Color.White;
            this.ckeckgerecaixa.Location = new System.Drawing.Point(178, 99);
            this.ckeckgerecaixa.Name = "ckeckgerecaixa";
            this.ckeckgerecaixa.Size = new System.Drawing.Size(111, 16);
            this.ckeckgerecaixa.TabIndex = 61;
            this.ckeckgerecaixa.Text = "Gerente de Caixa";
            this.ckeckgerecaixa.UseVisualStyleBackColor = true;
            this.ckeckgerecaixa.CheckedChanged += new System.EventHandler(this.ckeckgerecaixa_CheckedChanged);
            // 
            // txtgambiara
            // 
            this.txtgambiara.BackColor = System.Drawing.Color.Black;
            this.txtgambiara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgambiara.Enabled = false;
            this.txtgambiara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgambiara.ForeColor = System.Drawing.Color.White;
            this.txtgambiara.Location = new System.Drawing.Point(12, 214);
            this.txtgambiara.MaxLength = 50;
            this.txtgambiara.Multiline = true;
            this.txtgambiara.Name = "txtgambiara";
            this.txtgambiara.Size = new System.Drawing.Size(147, 23);
            this.txtgambiara.TabIndex = 62;
            this.txtgambiara.Visible = false;
            // 
            // dtgfunc
            // 
            this.dtgfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgfunc.Location = new System.Drawing.Point(319, 12);
            this.dtgfunc.Name = "dtgfunc";
            this.dtgfunc.ReadOnly = true;
            this.dtgfunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgfunc.Size = new System.Drawing.Size(854, 484);
            this.dtgfunc.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(688, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tabela dos Gerentes";
            // 
            // CadastrodenovoGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgfunc);
            this.Controls.Add(this.txtgambiara);
            this.Controls.Add(this.ckeckgerecaixa);
            this.Controls.Add(this.ckeckgeregeral);
            this.Controls.Add(this.txtidfuncionariogere);
            this.Controls.Add(this.lblfuncionariogere);
            this.Controls.Add(this.txtcpfgere);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.btniniciocadas);
            this.Controls.Add(this.txtsenhagere);
            this.Controls.Add(this.txtnomegere);
            this.Controls.Add(this.lblsenhagere);
            this.Controls.Add(this.lblfuncaogere);
            this.Controls.Add(this.lblcpfgere);
            this.Controls.Add(this.lblnomegere);
            this.Controls.Add(this.dtg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrodenovoGerente";
            this.Text = "CadastrodenovoGerente";
            this.Load += new System.EventHandler(this.CadastrodenovoGerente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgfunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.MaskedTextBox txtcpfgere;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btniniciocadas;
        private System.Windows.Forms.TextBox txtsenhagere;
        private System.Windows.Forms.TextBox txtnomegere;
        private System.Windows.Forms.Label lblsenhagere;
        private System.Windows.Forms.Label lblcpfgere;
        private System.Windows.Forms.Label lblnomegere;
        private System.Windows.Forms.Label lblfuncaogere;
        private System.Windows.Forms.TextBox txtidfuncionariogere;
        private System.Windows.Forms.Label lblfuncionariogere;
        private System.Windows.Forms.CheckBox ckeckgeregeral;
        private System.Windows.Forms.CheckBox ckeckgerecaixa;
        private System.Windows.Forms.TextBox txtgambiara;
        private System.Windows.Forms.DataGridView dtgfunc;
        private System.Windows.Forms.Label label1;
    }
}