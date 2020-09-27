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
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg
            // 
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Location = new System.Drawing.Point(472, 29);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(565, 247);
            this.dtg.TabIndex = 0;
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
            this.btniniciarcadastro.Size = new System.Drawing.Size(215, 59);
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
            this.label1.Visible = false;
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
            this.label2.Visible = false;
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
            this.label3.Visible = false;
            // 
            // txtcadnome
            // 
            this.txtcadnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtcadnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadnome.ForeColor = System.Drawing.Color.White;
            this.txtcadnome.Location = new System.Drawing.Point(156, 99);
            this.txtcadnome.Multiline = true;
            this.txtcadnome.Name = "txtcadnome";
            this.txtcadnome.Size = new System.Drawing.Size(158, 24);
            this.txtcadnome.TabIndex = 5;
            this.txtcadnome.Visible = false;
            // 
            // txtcadqt
            // 
            this.txtcadqt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtcadqt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadqt.ForeColor = System.Drawing.Color.White;
            this.txtcadqt.Location = new System.Drawing.Point(156, 129);
            this.txtcadqt.Multiline = true;
            this.txtcadqt.Name = "txtcadqt";
            this.txtcadqt.Size = new System.Drawing.Size(158, 24);
            this.txtcadqt.TabIndex = 6;
            this.txtcadqt.Visible = false;
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
            this.txtcadvali.ForeColor = System.Drawing.Color.White;
            this.txtcadvali.Location = new System.Drawing.Point(156, 159);
            this.txtcadvali.Mask = "00/00/0000";
            this.txtcadvali.Name = "txtcadvali";
            this.txtcadvali.Size = new System.Drawing.Size(158, 20);
            this.txtcadvali.TabIndex = 9;
            this.txtcadvali.ValidatingType = typeof(System.DateTime);
            this.txtcadvali.Visible = false;
            // 
            // txtcadvl
            // 
            this.txtcadvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtcadvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcadvl.ForeColor = System.Drawing.Color.White;
            this.txtcadvl.Location = new System.Drawing.Point(156, 188);
            this.txtcadvl.Multiline = true;
            this.txtcadvl.Name = "txtcadvl";
            this.txtcadvl.Size = new System.Drawing.Size(158, 24);
            this.txtcadvl.TabIndex = 11;
            this.txtcadvl.Visible = false;
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
            this.label4.Visible = false;
            // 
            // Cadastrodeprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
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
    }
}