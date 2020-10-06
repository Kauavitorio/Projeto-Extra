namespace Sistema
{
    partial class BaterPontoGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaterPontoGerente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.lblfiltrocd = new System.Windows.Forms.Label();
            this.txtfiltrocd = new System.Windows.Forms.TextBox();
            this.lblfiltronome = new System.Windows.Forms.Label();
            this.txtfiltronome = new System.Windows.Forms.TextBox();
            this.lblfiltrodata = new System.Windows.Forms.Label();
            this.txtfiltrodata = new System.Windows.Forms.TextBox();
            this.lblcolocardata = new System.Windows.Forms.Label();
            this.lbltiradata = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbltiradata);
            this.panel1.Controls.Add(this.lblcolocardata);
            this.panel1.Controls.Add(this.lblfiltrodata);
            this.panel1.Controls.Add(this.txtfiltrodata);
            this.panel1.Controls.Add(this.lblfiltronome);
            this.panel1.Controls.Add(this.txtfiltronome);
            this.panel1.Controls.Add(this.lblfiltrocd);
            this.panel1.Controls.Add(this.txtfiltrocd);
            this.panel1.Controls.Add(this.dtg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 435);
            this.panel1.TabIndex = 0;
            // 
            // dtg
            // 
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Location = new System.Drawing.Point(254, 0);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(653, 435);
            this.dtg.TabIndex = 0;
            this.dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellContentClick);
            // 
            // lblfiltrocd
            // 
            this.lblfiltrocd.AutoSize = true;
            this.lblfiltrocd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltrocd.ForeColor = System.Drawing.Color.White;
            this.lblfiltrocd.Location = new System.Drawing.Point(3, 9);
            this.lblfiltrocd.Name = "lblfiltrocd";
            this.lblfiltrocd.Size = new System.Drawing.Size(138, 13);
            this.lblfiltrocd.TabIndex = 15;
            this.lblfiltrocd.Text = "Código do Funcionario:";
            // 
            // txtfiltrocd
            // 
            this.txtfiltrocd.BackColor = System.Drawing.Color.Black;
            this.txtfiltrocd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltrocd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltrocd.ForeColor = System.Drawing.Color.White;
            this.txtfiltrocd.Location = new System.Drawing.Point(147, 7);
            this.txtfiltrocd.Name = "txtfiltrocd";
            this.txtfiltrocd.Size = new System.Drawing.Size(100, 20);
            this.txtfiltrocd.TabIndex = 14;
            this.txtfiltrocd.TextChanged += new System.EventHandler(this.txtfiltrocd_TextChanged);
            // 
            // lblfiltronome
            // 
            this.lblfiltronome.AutoSize = true;
            this.lblfiltronome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltronome.ForeColor = System.Drawing.Color.White;
            this.lblfiltronome.Location = new System.Drawing.Point(3, 35);
            this.lblfiltronome.Name = "lblfiltronome";
            this.lblfiltronome.Size = new System.Drawing.Size(131, 13);
            this.lblfiltronome.TabIndex = 17;
            this.lblfiltronome.Text = "Nome do Funcionario:";
            // 
            // txtfiltronome
            // 
            this.txtfiltronome.BackColor = System.Drawing.Color.Black;
            this.txtfiltronome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltronome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltronome.ForeColor = System.Drawing.Color.White;
            this.txtfiltronome.Location = new System.Drawing.Point(147, 33);
            this.txtfiltronome.Name = "txtfiltronome";
            this.txtfiltronome.Size = new System.Drawing.Size(100, 20);
            this.txtfiltronome.TabIndex = 16;
            this.txtfiltronome.TextChanged += new System.EventHandler(this.txtfiltronome_TextChanged);
            // 
            // lblfiltrodata
            // 
            this.lblfiltrodata.AutoSize = true;
            this.lblfiltrodata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltrodata.ForeColor = System.Drawing.Color.White;
            this.lblfiltrodata.Location = new System.Drawing.Point(3, 61);
            this.lblfiltrodata.Name = "lblfiltrodata";
            this.lblfiltrodata.Size = new System.Drawing.Size(93, 13);
            this.lblfiltrodata.TabIndex = 19;
            this.lblfiltrodata.Text = "Data do Ponto:";
            // 
            // txtfiltrodata
            // 
            this.txtfiltrodata.BackColor = System.Drawing.Color.Black;
            this.txtfiltrodata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltrodata.Enabled = false;
            this.txtfiltrodata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltrodata.ForeColor = System.Drawing.Color.White;
            this.txtfiltrodata.Location = new System.Drawing.Point(147, 59);
            this.txtfiltrodata.Name = "txtfiltrodata";
            this.txtfiltrodata.Size = new System.Drawing.Size(100, 20);
            this.txtfiltrodata.TabIndex = 18;
            this.txtfiltrodata.TextChanged += new System.EventHandler(this.txtfiltrodata_TextChanged);
            // 
            // lblcolocardata
            // 
            this.lblcolocardata.AutoSize = true;
            this.lblcolocardata.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolocardata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblcolocardata.Location = new System.Drawing.Point(120, 82);
            this.lblcolocardata.Name = "lblcolocardata";
            this.lblcolocardata.Size = new System.Drawing.Size(128, 12);
            this.lblcolocardata.TabIndex = 20;
            this.lblcolocardata.Text = "*Aperte aqui para pegar a data";
            this.lblcolocardata.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbltiradata
            // 
            this.lbltiradata.AutoSize = true;
            this.lbltiradata.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiradata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbltiradata.Location = new System.Drawing.Point(145, 82);
            this.lbltiradata.Name = "lbltiradata";
            this.lbltiradata.Size = new System.Drawing.Size(57, 12);
            this.lbltiradata.TabIndex = 21;
            this.lbltiradata.Text = "*Limpar filtro";
            this.lbltiradata.Visible = false;
            this.lbltiradata.Click += new System.EventHandler(this.lbltiradata_Click);
            // 
            // BaterPontoGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 435);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(920, 474);
            this.MinimumSize = new System.Drawing.Size(920, 474);
            this.Name = "BaterPontoGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Pontos";
            this.Load += new System.EventHandler(this.BaterPontoGerente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Label lblcolocardata;
        private System.Windows.Forms.Label lblfiltrodata;
        private System.Windows.Forms.TextBox txtfiltrodata;
        private System.Windows.Forms.Label lblfiltronome;
        private System.Windows.Forms.TextBox txtfiltronome;
        private System.Windows.Forms.Label lblfiltrocd;
        private System.Windows.Forms.TextBox txtfiltrocd;
        private System.Windows.Forms.Label lbltiradata;
    }
}