namespace Wellness.WinUI.Clanarina
{
    partial class frmClanarinaDetalji
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDatumUplate = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUplataZaGodinu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUplataZaMjesec = new System.Windows.Forms.TextBox();
            this.txtUplataZaGodinu = new System.Windows.Forms.TextBox();
            this.ClanarineErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbPaket = new System.Windows.Forms.ComboBox();
            this.cbClan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnZatvoriSkener = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOdaberiKameru = new System.Windows.Forms.Button();
            this.nudIznos = new System.Windows.Forms.NumericUpDown();
            this.gbQRKodSkener = new System.Windows.Forms.GroupBox();
            this.gbClanarina = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbQRKod = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClanarineErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).BeginInit();
            this.gbQRKodSkener.SuspendLayout();
            this.gbClanarina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRKod)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Clan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Paket";
            // 
            // dateDatumUplate
            // 
            this.dateDatumUplate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDatumUplate.Location = new System.Drawing.Point(33, 135);
            this.dateDatumUplate.Name = "dateDatumUplate";
            this.dateDatumUplate.Size = new System.Drawing.Size(219, 20);
            this.dateDatumUplate.TabIndex = 24;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(33, 306);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(219, 23);
            this.btnSacuvaj.TabIndex = 23;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Datum uplate";
            // 
            // lblUplataZaGodinu
            // 
            this.lblUplataZaGodinu.AutoSize = true;
            this.lblUplataZaGodinu.Location = new System.Drawing.Point(30, 71);
            this.lblUplataZaGodinu.Name = "lblUplataZaGodinu";
            this.lblUplataZaGodinu.Size = new System.Drawing.Size(87, 13);
            this.lblUplataZaGodinu.TabIndex = 18;
            this.lblUplataZaGodinu.Text = "Uplata za godinu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Uplata za mjesec";
            // 
            // txtUplataZaMjesec
            // 
            this.txtUplataZaMjesec.Location = new System.Drawing.Point(33, 43);
            this.txtUplataZaMjesec.Name = "txtUplataZaMjesec";
            this.txtUplataZaMjesec.Size = new System.Drawing.Size(219, 20);
            this.txtUplataZaMjesec.TabIndex = 30;
            this.txtUplataZaMjesec.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUplataZaMjesec_Validating);
            // 
            // txtUplataZaGodinu
            // 
            this.txtUplataZaGodinu.Location = new System.Drawing.Point(33, 87);
            this.txtUplataZaGodinu.Name = "txtUplataZaGodinu";
            this.txtUplataZaGodinu.Size = new System.Drawing.Size(219, 20);
            this.txtUplataZaGodinu.TabIndex = 31;
            this.txtUplataZaGodinu.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUplataZaGodinu_Validating);
            // 
            // ClanarineErrorProvider
            // 
            this.ClanarineErrorProvider.ContainerControl = this;
            // 
            // cbPaket
            // 
            this.cbPaket.FormattingEnabled = true;
            this.cbPaket.Location = new System.Drawing.Point(33, 223);
            this.cbPaket.Name = "cbPaket";
            this.cbPaket.Size = new System.Drawing.Size(219, 21);
            this.cbPaket.TabIndex = 33;
            this.cbPaket.SelectedIndexChanged += new System.EventHandler(this.CbPaket_SelectedIndexChanged);
            // 
            // cbClan
            // 
            this.cbClan.FormattingEnabled = true;
            this.cbClan.Location = new System.Drawing.Point(33, 268);
            this.cbClan.Name = "cbClan";
            this.cbClan.Size = new System.Drawing.Size(219, 21);
            this.cbClan.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Pronađi korisnika pomoću QR koda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnZatvoriSkener
            // 
            this.btnZatvoriSkener.Location = new System.Drawing.Point(6, 110);
            this.btnZatvoriSkener.Name = "btnZatvoriSkener";
            this.btnZatvoriSkener.Size = new System.Drawing.Size(121, 23);
            this.btnZatvoriSkener.TabIndex = 37;
            this.btnZatvoriSkener.Text = "Zatvori skener";
            this.btnZatvoriSkener.UseVisualStyleBackColor = true;
            this.btnZatvoriSkener.Click += new System.EventHandler(this.BtnZatvoriSkener_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Odaberite kameru";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnOdaberiKameru
            // 
            this.btnOdaberiKameru.Location = new System.Drawing.Point(6, 81);
            this.btnOdaberiKameru.Name = "btnOdaberiKameru";
            this.btnOdaberiKameru.Size = new System.Drawing.Size(121, 23);
            this.btnOdaberiKameru.TabIndex = 40;
            this.btnOdaberiKameru.Text = "Odaberi kameru";
            this.btnOdaberiKameru.UseVisualStyleBackColor = true;
            this.btnOdaberiKameru.Click += new System.EventHandler(this.BtnOdaberiKameru_Click);
            // 
            // nudIznos
            // 
            this.nudIznos.DecimalPlaces = 2;
            this.nudIznos.Location = new System.Drawing.Point(33, 179);
            this.nudIznos.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudIznos.Name = "nudIznos";
            this.nudIznos.Size = new System.Drawing.Size(219, 20);
            this.nudIznos.TabIndex = 41;
            // 
            // gbQRKodSkener
            // 
            this.gbQRKodSkener.Controls.Add(this.btnZatvoriSkener);
            this.gbQRKodSkener.Controls.Add(this.comboBox1);
            this.gbQRKodSkener.Controls.Add(this.btnOdaberiKameru);
            this.gbQRKodSkener.Controls.Add(this.label6);
            this.gbQRKodSkener.Location = new System.Drawing.Point(18, 400);
            this.gbQRKodSkener.Name = "gbQRKodSkener";
            this.gbQRKodSkener.Size = new System.Drawing.Size(135, 158);
            this.gbQRKodSkener.TabIndex = 42;
            this.gbQRKodSkener.TabStop = false;
            this.gbQRKodSkener.Text = "Postavke skenera";
            // 
            // gbClanarina
            // 
            this.gbClanarina.Controls.Add(this.pictureBox1);
            this.gbClanarina.Controls.Add(this.label1);
            this.gbClanarina.Controls.Add(this.lblUplataZaGodinu);
            this.gbClanarina.Controls.Add(this.nudIznos);
            this.gbClanarina.Controls.Add(this.label3);
            this.gbClanarina.Controls.Add(this.label2);
            this.gbClanarina.Controls.Add(this.button1);
            this.gbClanarina.Controls.Add(this.btnSacuvaj);
            this.gbClanarina.Controls.Add(this.cbClan);
            this.gbClanarina.Controls.Add(this.dateDatumUplate);
            this.gbClanarina.Controls.Add(this.cbPaket);
            this.gbClanarina.Controls.Add(this.label4);
            this.gbClanarina.Controls.Add(this.txtUplataZaGodinu);
            this.gbClanarina.Controls.Add(this.label5);
            this.gbClanarina.Controls.Add(this.txtUplataZaMjesec);
            this.gbClanarina.Location = new System.Drawing.Point(18, 12);
            this.gbClanarina.Name = "gbClanarina";
            this.gbClanarina.Size = new System.Drawing.Size(488, 367);
            this.gbClanarina.TabIndex = 43;
            this.gbClanarina.TabStop = false;
            this.gbClanarina.Text = "Clanarina ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wellness.WinUI.Properties.Resources.fees;
            this.pictureBox1.Location = new System.Drawing.Point(270, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pbQRKod
            // 
            this.pbQRKod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQRKod.Location = new System.Drawing.Point(168, 406);
            this.pbQRKod.Name = "pbQRKod";
            this.pbQRKod.Size = new System.Drawing.Size(238, 152);
            this.pbQRKod.TabIndex = 36;
            this.pbQRKod.TabStop = false;
            // 
            // frmClanarinaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 570);
            this.Controls.Add(this.gbClanarina);
            this.Controls.Add(this.gbQRKodSkener);
            this.Controls.Add(this.pbQRKod);
            this.Name = "frmClanarinaDetalji";
            this.Text = "Clanarina - detaljan prikaz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClanarinaDetalji_FormClosing);
            this.Load += new System.EventHandler(this.FrmClanarinaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClanarineErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIznos)).EndInit();
            this.gbQRKodSkener.ResumeLayout(false);
            this.gbQRKodSkener.PerformLayout();
            this.gbClanarina.ResumeLayout(false);
            this.gbClanarina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRKod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDatumUplate;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUplataZaGodinu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUplataZaMjesec;
        private System.Windows.Forms.TextBox txtUplataZaGodinu;
        private System.Windows.Forms.ErrorProvider ClanarineErrorProvider;
        private System.Windows.Forms.ComboBox cbClan;
        private System.Windows.Forms.ComboBox cbPaket;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbQRKod;
        private System.Windows.Forms.Button btnZatvoriSkener;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOdaberiKameru;
        private System.Windows.Forms.NumericUpDown nudIznos;
        private System.Windows.Forms.GroupBox gbQRKodSkener;
        private System.Windows.Forms.GroupBox gbClanarina;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}