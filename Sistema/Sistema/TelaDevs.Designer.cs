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
            // TelaDevs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnmini);
            this.Controls.Add(this.btnsai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaDevs";
            this.Text = "TelaDevs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmini;
        private System.Windows.Forms.Button btnsai;
    }
}