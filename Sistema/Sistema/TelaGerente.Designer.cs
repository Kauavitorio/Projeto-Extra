namespace Sistema
{
    partial class TelaGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGerente));
            this.btnsair = new System.Windows.Forms.Button();
            this.painelsuperior = new System.Windows.Forms.Panel();
            this.btnmini = new System.Windows.Forms.Button();
            this.btnsai = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btntemaclaro = new System.Windows.Forms.Button();
            this.btncadastrarprod = new System.Windows.Forms.Button();
            this.btntemadark = new System.Windows.Forms.Button();
            this.painellateral = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.painelprincipal = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.painelsuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painellateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Transparent;
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.White;
            this.btnsair.Location = new System.Drawing.Point(1314, 0);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(49, 23);
            this.btnsair.TabIndex = 18;
            this.btnsair.Text = "X";
            this.btnsair.UseVisualStyleBackColor = false;
            // 
            // painelsuperior
            // 
            this.painelsuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.painelsuperior.Controls.Add(this.btnmini);
            this.painelsuperior.Controls.Add(this.btnsai);
            this.painelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelsuperior.Location = new System.Drawing.Point(0, 0);
            this.painelsuperior.Name = "painelsuperior";
            this.painelsuperior.Size = new System.Drawing.Size(1366, 25);
            this.painelsuperior.TabIndex = 0;
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
            this.btnmini.Location = new System.Drawing.Point(1271, -6);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(49, 31);
            this.btnmini.TabIndex = 11;
            this.btnmini.Text = "-";
            this.btnmini.UseVisualStyleBackColor = false;
            this.btnmini.Click += new System.EventHandler(this.button1_Click);
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
            this.btnsai.Location = new System.Drawing.Point(1326, -6);
            this.btnsai.Name = "btnsai";
            this.btnsai.Size = new System.Drawing.Size(49, 31);
            this.btnsai.TabIndex = 12;
            this.btnsai.Text = "X";
            this.btnsai.UseVisualStyleBackColor = false;
            this.btnsai.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btntemaclaro
            // 
            this.btntemaclaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btntemaclaro.FlatAppearance.BorderSize = 0;
            this.btntemaclaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntemaclaro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntemaclaro.ForeColor = System.Drawing.Color.White;
            this.btntemaclaro.Location = new System.Drawing.Point(3, 557);
            this.btntemaclaro.Name = "btntemaclaro";
            this.btntemaclaro.Size = new System.Drawing.Size(197, 42);
            this.btntemaclaro.TabIndex = 14;
            this.btntemaclaro.Text = "Tema Claro";
            this.btntemaclaro.UseVisualStyleBackColor = false;
            this.btntemaclaro.Click += new System.EventHandler(this.btntemaclaro_Click);
            // 
            // btncadastrarprod
            // 
            this.btncadastrarprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btncadastrarprod.FlatAppearance.BorderSize = 0;
            this.btncadastrarprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrarprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarprod.ForeColor = System.Drawing.Color.White;
            this.btncadastrarprod.Location = new System.Drawing.Point(0, 202);
            this.btncadastrarprod.Name = "btncadastrarprod";
            this.btncadastrarprod.Size = new System.Drawing.Size(200, 37);
            this.btncadastrarprod.TabIndex = 13;
            this.btncadastrarprod.Text = "Casdastrar Produto";
            this.btncadastrarprod.UseVisualStyleBackColor = false;
            this.btncadastrarprod.Click += new System.EventHandler(this.btncadastrarprod_Click);
            // 
            // btntemadark
            // 
            this.btntemadark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btntemadark.FlatAppearance.BorderSize = 0;
            this.btntemadark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntemadark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntemadark.ForeColor = System.Drawing.Color.Black;
            this.btntemadark.Location = new System.Drawing.Point(0, 557);
            this.btntemadark.Name = "btntemadark";
            this.btntemadark.Size = new System.Drawing.Size(200, 42);
            this.btntemadark.TabIndex = 16;
            this.btntemadark.Text = "Tema Dark";
            this.btntemadark.UseVisualStyleBackColor = false;
            this.btntemadark.Visible = false;
            this.btntemadark.Click += new System.EventHandler(this.btntemadark_Click);
            // 
            // painellateral
            // 
            this.painellateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.painellateral.Controls.Add(this.button4);
            this.painellateral.Controls.Add(this.button3);
            this.painellateral.Controls.Add(this.button2);
            this.painellateral.Controls.Add(this.button1);
            this.painellateral.Controls.Add(this.btntemadark);
            this.painellateral.Controls.Add(this.pictureBox1);
            this.painellateral.Controls.Add(this.btncadastrarprod);
            this.painellateral.Controls.Add(this.btnsair);
            this.painellateral.Controls.Add(this.btntemaclaro);
            this.painellateral.Controls.Add(this.btnminimizar);
            this.painellateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.painellateral.Location = new System.Drawing.Point(0, 25);
            this.painellateral.Name = "painellateral";
            this.painellateral.Size = new System.Drawing.Size(200, 743);
            this.painellateral.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 37);
            this.button3.TabIndex = 21;
            this.button3.Text = "Pontos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Funcionarios";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Vendas";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnminimizar
            // 
            this.btnminimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnminimizar.FlatAppearance.BorderSize = 0;
            this.btnminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimizar.ForeColor = System.Drawing.Color.White;
            this.btnminimizar.Location = new System.Drawing.Point(1262, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(49, 23);
            this.btnminimizar.TabIndex = 17;
            this.btnminimizar.Text = "-";
            this.btnminimizar.UseVisualStyleBackColor = false;
            // 
            // painelprincipal
            // 
            this.painelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelprincipal.Location = new System.Drawing.Point(200, 25);
            this.painelprincipal.Name = "painelprincipal";
            this.painelprincipal.Size = new System.Drawing.Size(1166, 743);
            this.painelprincipal.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 37);
            this.button4.TabIndex = 22;
            this.button4.Text = "Casdastrar Novo Gerente";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TelaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.painelprincipal);
            this.Controls.Add(this.painellateral);
            this.Controls.Add(this.painelsuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaGerente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.painelsuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painellateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Panel painelsuperior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btntemaclaro;
        private System.Windows.Forms.Button btncadastrarprod;
        private System.Windows.Forms.Button btntemadark;
        private System.Windows.Forms.Panel painellateral;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Button btnmini;
        private System.Windows.Forms.Button btnsai;
        private System.Windows.Forms.Panel painelprincipal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}