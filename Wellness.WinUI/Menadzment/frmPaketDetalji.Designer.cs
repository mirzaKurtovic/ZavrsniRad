namespace Wellness.WinUI.Menadzment
{
    partial class frmPaketDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaketDetalji));
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cbPristupGrupnimTreninzima = new System.Windows.Forms.CheckBox();
            this.cbNeogranicenPristup = new System.Windows.Forms.CheckBox();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.clbPristupniDani = new System.Windows.Forms.CheckedListBox();
            this.btnDodajPaket = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PaketErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudCijena = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaketErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(70, 23);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(255, 20);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNaziv_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(70, 59);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(110, 20);
            this.txtCijena.TabIndex = 2;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCijena_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(70, 96);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(255, 94);
            this.txtOpis.TabIndex = 4;
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.TxtOpis_Validating);
            // 
            // cbPristupGrupnimTreninzima
            // 
            this.cbPristupGrupnimTreninzima.AutoSize = true;
            this.cbPristupGrupnimTreninzima.Location = new System.Drawing.Point(70, 196);
            this.cbPristupGrupnimTreninzima.Name = "cbPristupGrupnimTreninzima";
            this.cbPristupGrupnimTreninzima.Size = new System.Drawing.Size(148, 17);
            this.cbPristupGrupnimTreninzima.TabIndex = 6;
            this.cbPristupGrupnimTreninzima.Text = "Pristup grupnim treninzima";
            this.cbPristupGrupnimTreninzima.UseVisualStyleBackColor = true;
            // 
            // cbNeogranicenPristup
            // 
            this.cbNeogranicenPristup.AutoSize = true;
            this.cbNeogranicenPristup.Location = new System.Drawing.Point(70, 226);
            this.cbNeogranicenPristup.Name = "cbNeogranicenPristup";
            this.cbNeogranicenPristup.Size = new System.Drawing.Size(145, 17);
            this.cbNeogranicenPristup.TabIndex = 7;
            this.cbNeogranicenPristup.Text = "Neogranicen pristup(24h)";
            this.cbNeogranicenPristup.UseVisualStyleBackColor = true;
            this.cbNeogranicenPristup.CheckedChanged += new System.EventHandler(this.CbNeogranicenPristup_CheckedChanged);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.CustomFormat = "HH:mm";
            this.dtpDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumOd.Location = new System.Drawing.Point(94, 259);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.ShowUpDown = true;
            this.dtpDatumOd.Size = new System.Drawing.Size(54, 20);
            this.dtpDatumOd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Do";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.CustomFormat = "HH:mm";
            this.dtpDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumDo.Location = new System.Drawing.Point(186, 259);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.ShowUpDown = true;
            this.dtpDatumDo.Size = new System.Drawing.Size(54, 20);
            this.dtpDatumDo.TabIndex = 10;
            // 
            // clbPristupniDani
            // 
            this.clbPristupniDani.FormattingEnabled = true;
            this.clbPristupniDani.Location = new System.Drawing.Point(70, 310);
            this.clbPristupniDani.Name = "clbPristupniDani";
            this.clbPristupniDani.Size = new System.Drawing.Size(255, 124);
            this.clbPristupniDani.TabIndex = 12;
            // 
            // btnDodajPaket
            // 
            this.btnDodajPaket.Location = new System.Drawing.Point(70, 458);
            this.btnDodajPaket.Name = "btnDodajPaket";
            this.btnDodajPaket.Size = new System.Drawing.Size(255, 23);
            this.btnDodajPaket.TabIndex = 14;
            this.btnDodajPaket.Text = "Spasi";
            this.btnDodajPaket.UseVisualStyleBackColor = true;
            this.btnDodajPaket.Click += new System.EventHandler(this.BtnDodajPaket_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.Image = ((System.Drawing.Image)(resources.GetObject("pbSlika.Image")));
            this.pbSlika.Location = new System.Drawing.Point(369, 23);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(320, 180);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 15;
            this.pbSlika.TabStop = false;
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(369, 220);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.ReadOnly = true;
            this.txtSlika.Size = new System.Drawing.Size(239, 20);
            this.txtSlika.TabIndex = 16;
            this.txtSlika.TextChanged += new System.EventHandler(this.TxtSlika_TextChanged);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(614, 220);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 21);
            this.btnDodajSliku.TabIndex = 17;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.BtnDodajSliku_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Dani kada korisnik ima pristup";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PaketErrorProvider
            // 
            this.PaketErrorProvider.ContainerControl = this;
            // 
            // nudCijena
            // 
            this.nudCijena.DecimalPlaces = 2;
            this.nudCijena.Location = new System.Drawing.Point(205, 59);
            this.nudCijena.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudCijena.Name = "nudCijena";
            this.nudCijena.Size = new System.Drawing.Size(120, 20);
            this.nudCijena.TabIndex = 19;
            this.nudCijena.Validating += new System.ComponentModel.CancelEventHandler(this.NudCijena_Validating);
            // 
            // frmPaketDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 493);
            this.Controls.Add(this.nudCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnDodajPaket);
            this.Controls.Add(this.clbPristupniDani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.cbNeogranicenPristup);
            this.Controls.Add(this.cbPristupGrupnimTreninzima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmPaketDetalji";
            this.Text = "frmPaketDetalji";
            this.Load += new System.EventHandler(this.FrmPaketDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaketErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.CheckBox cbPristupGrupnimTreninzima;
        private System.Windows.Forms.CheckBox cbNeogranicenPristup;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.CheckedListBox clbPristupniDani;
        private System.Windows.Forms.Button btnDodajPaket;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider PaketErrorProvider;
        private System.Windows.Forms.NumericUpDown nudCijena;
    }
}