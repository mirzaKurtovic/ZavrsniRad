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
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.gbPostavkeSkenera = new System.Windows.Forms.GroupBox();
            this.lblTrenutnaRadnja = new System.Windows.Forms.Label();
            this.btnSakriPostavke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPictureBox.SuspendLayout();
            this.gbPostavkeSkenera.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(18, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 447);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberite kameru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukupno slika";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(124, 59);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(196, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // txtPositive
            // 
            this.txtPositive.Location = new System.Drawing.Point(124, 98);
            this.txtPositive.Name = "txtPositive";
            this.txtPositive.Size = new System.Drawing.Size(196, 20);
            this.txtPositive.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pozitivnih rezultata";
            // 
            // txtNegative
            // 
            this.txtNegative.Location = new System.Drawing.Point(124, 134);
            this.txtNegative.Name = "txtNegative";
            this.txtNegative.Size = new System.Drawing.Size(196, 20);
            this.txtNegative.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Negativnih rezultata";
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(124, 170);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(196, 23);
            this.btnPokreni.TabIndex = 9;
            this.btnPokreni.Text = "Pokreni kameru";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.BtnPokreni_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Location = new System.Drawing.Point(124, 199);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(196, 23);
            this.btnZaustavi.TabIndex = 11;
            this.btnZaustavi.Text = "Zaustavi skeniranje";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            this.btnZaustavi.Click += new System.EventHandler(this.BtnZaustavi_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.Controls.Add(this.pictureBox1);
            this.panelPictureBox.Location = new System.Drawing.Point(12, 12);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Padding = new System.Windows.Forms.Padding(25);
            this.panelPictureBox.Size = new System.Drawing.Size(716, 480);
            this.panelPictureBox.TabIndex = 15;
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMain.Location = new System.Drawing.Point(41, 52);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(166, 77);
            this.lblMain.TabIndex = 16;
            this.lblMain.Text = "label5";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSide.Location = new System.Drawing.Point(50, 150);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(97, 45);
            this.lblSide.TabIndex = 18;
            this.lblSide.Text = "label5";
            // 
            // gbPostavkeSkenera
            // 
            this.gbPostavkeSkenera.Controls.Add(this.lblTrenutnaRadnja);
            this.gbPostavkeSkenera.Controls.Add(this.btnSakriPostavke);
            this.gbPostavkeSkenera.Controls.Add(this.btnZaustavi);
            this.gbPostavkeSkenera.Controls.Add(this.comboBox1);
            this.gbPostavkeSkenera.Controls.Add(this.label1);
            this.gbPostavkeSkenera.Controls.Add(this.label2);
            this.gbPostavkeSkenera.Controls.Add(this.txtTotal);
            this.gbPostavkeSkenera.Controls.Add(this.label3);
            this.gbPostavkeSkenera.Controls.Add(this.txtPositive);
            this.gbPostavkeSkenera.Controls.Add(this.btnPokreni);
            this.gbPostavkeSkenera.Controls.Add(this.label4);
            this.gbPostavkeSkenera.Controls.Add(this.txtNegative);
            this.gbPostavkeSkenera.Location = new System.Drawing.Point(752, 28);
            this.gbPostavkeSkenera.Name = "gbPostavkeSkenera";
            this.gbPostavkeSkenera.Size = new System.Drawing.Size(343, 356);
            this.gbPostavkeSkenera.TabIndex = 19;
            this.gbPostavkeSkenera.TabStop = false;
            this.gbPostavkeSkenera.Text = "Postavke skenera";
            // 
            // lblTrenutnaRadnja
            // 
            this.lblTrenutnaRadnja.AutoSize = true;
            this.lblTrenutnaRadnja.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutnaRadnja.Location = new System.Drawing.Point(14, 299);
            this.lblTrenutnaRadnja.Name = "lblTrenutnaRadnja";
            this.lblTrenutnaRadnja.Size = new System.Drawing.Size(232, 39);
            this.lblTrenutnaRadnja.TabIndex = 20;
            this.lblTrenutnaRadnja.Text = "Trenutna akcija";
            // 
            // btnSakriPostavke
            // 
            this.btnSakriPostavke.Location = new System.Drawing.Point(124, 228);
            this.btnSakriPostavke.Name = "btnSakriPostavke";
            this.btnSakriPostavke.Size = new System.Drawing.Size(196, 23);
            this.btnSakriPostavke.TabIndex = 12;
            this.btnSakriPostavke.Text = "Sakri postavke";
            this.btnSakriPostavke.UseVisualStyleBackColor = true;
            this.btnSakriPostavke.Click += new System.EventHandler(this.BtnSakriPostavke_Click);
            // 
            // frmCameraQRDecoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 632);
            this.Controls.Add(this.gbPostavkeSkenera);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.panelPictureBox);
            this.Name = "frmCameraQRDecoder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCameraQRDecoder_FormClosing);
            this.Load += new System.EventHandler(this.FrmCameraQRDecoder_Load);
            this.SizeChanged += new System.EventHandler(this.FrmCameraQRDecoder_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPictureBox.ResumeLayout(false);
            this.gbPostavkeSkenera.ResumeLayout(false);
            this.gbPostavkeSkenera.PerformLayout();
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
        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.GroupBox gbPostavkeSkenera;
        private System.Windows.Forms.Button btnSakriPostavke;
        private System.Windows.Forms.Label lblTrenutnaRadnja;
    }
}