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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.Sifra = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisnicko ime";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(277, 37);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(277, 84);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(180, 20);
            this.txtSifra.TabIndex = 3;
            // 
            // Sifra
            // 
            this.Sifra.AutoSize = true;
            this.Sifra.Location = new System.Drawing.Point(274, 68);
            this.Sifra.Name = "Sifra";
            this.Sifra.Size = new System.Drawing.Size(28, 13);
            this.Sifra.TabIndex = 2;
            this.Sifra.Text = "Sifra";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(277, 129);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(180, 24);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(277, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(180, 237);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 459);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.Sifra);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label Sifra;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}