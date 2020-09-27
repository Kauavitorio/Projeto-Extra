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
            this.painelprincipal = new System.Windows.Forms.Panel();
            this.painelsuperior = new System.Windows.Forms.Panel();
            this.painellateral = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.painelprincipal.SuspendLayout();
            this.painelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelprincipal
            // 
            this.painelprincipal.Controls.Add(this.painellateral);
            this.painelprincipal.Controls.Add(this.painelsuperior);
            this.painelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelprincipal.Location = new System.Drawing.Point(0, 0);
            this.painelprincipal.Name = "painelprincipal";
            this.painelprincipal.Size = new System.Drawing.Size(1366, 768);
            this.painelprincipal.TabIndex = 0;
            // 
            // painelsuperior
            // 
            this.painelsuperior.Controls.Add(this.btnminimizar);
            this.painelsuperior.Controls.Add(this.btnsair);
            this.painelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelsuperior.Location = new System.Drawing.Point(0, 0);
            this.painelsuperior.Name = "painelsuperior";
            this.painelsuperior.Size = new System.Drawing.Size(1366, 23);
            this.painelsuperior.TabIndex = 0;
            // 
            // painellateral
            // 
            this.painellateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.painellateral.Location = new System.Drawing.Point(0, 23);
            this.painellateral.Name = "painellateral";
            this.painellateral.Size = new System.Drawing.Size(200, 745);
            this.painellateral.TabIndex = 1;
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
            this.btnminimizar.TabIndex = 11;
            this.btnminimizar.Text = "-";
            this.btnminimizar.UseVisualStyleBackColor = false;
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
            this.btnsair.TabIndex = 12;
            this.btnsair.Text = "X";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // TelaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.painelprincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaGerente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.painelprincipal.ResumeLayout(false);
            this.painelsuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelprincipal;
        private System.Windows.Forms.Panel painellateral;
        private System.Windows.Forms.Panel painelsuperior;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Button btnsair;
    }
}