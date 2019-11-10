namespace Wellness.WinUI
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.Sifra = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisnicko ime";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(140, 94);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(140, 141);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(180, 20);
            this.txtSifra.TabIndex = 3;
            // 
            // Sifra
            // 
            this.Sifra.AutoSize = true;
            this.Sifra.Location = new System.Drawing.Point(137, 125);
            this.Sifra.Name = "Sifra";
            this.Sifra.Size = new System.Drawing.Size(28, 13);
            this.Sifra.TabIndex = 2;
            this.Sifra.Text = "Sifra";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(140, 176);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(180, 24);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wellness.WinUI.Properties.Resources.bac88503_eee6_4e9c_9af3_b77895cf3606_200x200;
            this.pictureBox1.Location = new System.Drawing.Point(140, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 232);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.Sifra);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label Sifra;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}