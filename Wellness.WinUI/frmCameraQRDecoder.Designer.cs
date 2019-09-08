namespace Wellness.WinUI
{
    partial class frmCameraQRDecoder
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPositive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNegative = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnTraziQR = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(787, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberite kameru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukupno slika";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(787, 56);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(196, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // txtPositive
            // 
            this.txtPositive.Location = new System.Drawing.Point(787, 95);
            this.txtPositive.Name = "txtPositive";
            this.txtPositive.Size = new System.Drawing.Size(196, 20);
            this.txtPositive.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pozitivnih rezultata";
            // 
            // txtNegative
            // 
            this.txtNegative.Location = new System.Drawing.Point(787, 131);
            this.txtNegative.Name = "txtNegative";
            this.txtNegative.Size = new System.Drawing.Size(196, 20);
            this.txtNegative.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Negativnih rezultata";
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(787, 167);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(196, 23);
            this.btnPokreni.TabIndex = 9;
            this.btnPokreni.Text = "Pokreni kameru";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.BtnPokreni_Click);
            // 
            // btnTraziQR
            // 
            this.btnTraziQR.Location = new System.Drawing.Point(787, 196);
            this.btnTraziQR.Name = "btnTraziQR";
            this.btnTraziQR.Size = new System.Drawing.Size(196, 23);
            this.btnTraziQR.TabIndex = 10;
            this.btnTraziQR.Text = "Trazi qr kod";
            this.btnTraziQR.UseVisualStyleBackColor = true;
            this.btnTraziQR.Click += new System.EventHandler(this.BtnTraziQR_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Location = new System.Drawing.Point(787, 225);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(196, 23);
            this.btnZaustavi.TabIndex = 11;
            this.btnZaustavi.Text = "Zaustavi kameru";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmCameraQRDecoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 387);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnTraziQR);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.txtNegative);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPositive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCameraQRDecoder";
            this.Text = "frmCameraQRDecoder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCameraQRDecoder_FormClosing);
            this.Load += new System.EventHandler(this.FrmCameraQRDecoder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPositive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNegative;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnTraziQR;
        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.Timer timer1;
    }
}