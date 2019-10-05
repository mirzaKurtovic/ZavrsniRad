namespace Wellness.WinUI
{
    partial class frmIndex
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clanarinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaClanarinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeClanovimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledClanovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogClanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviTreningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menadzmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeZaposlenicimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isplataZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjePaketimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPaketaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviPaketToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeTipovimaTreningaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledTipovaTreningaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviTipTreningaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestavanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRKodSkenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokreniSkeniranjeQrKodovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clanarinaToolStripMenuItem,
            this.upravljanjeClanovimaToolStripMenuItem,
            this.treningToolStripMenuItem,
            this.menadzmentToolStripMenuItem,
            this.qRKodSkenerToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(802, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // clanarinaToolStripMenuItem
            // 
            this.clanarinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem,
            this.novaClanarinaToolStripMenuItem});
            this.clanarinaToolStripMenuItem.Name = "clanarinaToolStripMenuItem";
            this.clanarinaToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.clanarinaToolStripMenuItem.Text = "Upravljanje clanarinama";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.pregledToolStripMenuItem.Text = "Pregled clanarina";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.PregledToolStripMenuItem_Click);
            // 
            // novaClanarinaToolStripMenuItem
            // 
            this.novaClanarinaToolStripMenuItem.Name = "novaClanarinaToolStripMenuItem";
            this.novaClanarinaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.novaClanarinaToolStripMenuItem.Text = "dodaj novu clanarinu";
            this.novaClanarinaToolStripMenuItem.Click += new System.EventHandler(this.NovaClanarinaToolStripMenuItem_Click);
            // 
            // upravljanjeClanovimaToolStripMenuItem
            // 
            this.upravljanjeClanovimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledClanovaToolStripMenuItem,
            this.dodajNovogClanaToolStripMenuItem});
            this.upravljanjeClanovimaToolStripMenuItem.Name = "upravljanjeClanovimaToolStripMenuItem";
            this.upravljanjeClanovimaToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.upravljanjeClanovimaToolStripMenuItem.Text = "Upravljanje clanovima";
            // 
            // pregledClanovaToolStripMenuItem
            // 
            this.pregledClanovaToolStripMenuItem.Name = "pregledClanovaToolStripMenuItem";
            this.pregledClanovaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pregledClanovaToolStripMenuItem.Text = "Pregled clanova";
            // 
            // dodajNovogClanaToolStripMenuItem
            // 
            this.dodajNovogClanaToolStripMenuItem.Name = "dodajNovogClanaToolStripMenuItem";
            this.dodajNovogClanaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.dodajNovogClanaToolStripMenuItem.Text = "Dodaj novog clana";
            // 
            // treningToolStripMenuItem
            // 
            this.treningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem1,
            this.noviTreningToolStripMenuItem});
            this.treningToolStripMenuItem.Name = "treningToolStripMenuItem";
            this.treningToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.treningToolStripMenuItem.Text = "Upravljanje treninzima";
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.pregledToolStripMenuItem1.Text = "Pregled treninga";
            this.pregledToolStripMenuItem1.Click += new System.EventHandler(this.PregledToolStripMenuItem1_Click);
            // 
            // noviTreningToolStripMenuItem
            // 
            this.noviTreningToolStripMenuItem.Name = "noviTreningToolStripMenuItem";
            this.noviTreningToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.noviTreningToolStripMenuItem.Text = "Dodaj novi trening";
            this.noviTreningToolStripMenuItem.Click += new System.EventHandler(this.NoviTreningToolStripMenuItem_Click);
            // 
            // menadzmentToolStripMenuItem
            // 
            this.menadzmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upravljanjeZaposlenicimaToolStripMenuItem,
            this.upravljanjePaketimaToolStripMenuItem,
            this.upravljanjeTipovimaTreningaToolStripMenuItem,
            this.izvjestavanjeToolStripMenuItem});
            this.menadzmentToolStripMenuItem.Name = "menadzmentToolStripMenuItem";
            this.menadzmentToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.menadzmentToolStripMenuItem.Text = "Menadzment";
            // 
            // upravljanjeZaposlenicimaToolStripMenuItem
            // 
            this.upravljanjeZaposlenicimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledZaposlenikaToolStripMenuItem,
            this.dodajNovogZaposlenikaToolStripMenuItem,
            this.isplataZaposlenikaToolStripMenuItem});
            this.upravljanjeZaposlenicimaToolStripMenuItem.Name = "upravljanjeZaposlenicimaToolStripMenuItem";
            this.upravljanjeZaposlenicimaToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.upravljanjeZaposlenicimaToolStripMenuItem.Text = "Upravljanje zaposlenicima";
            // 
            // pregledZaposlenikaToolStripMenuItem
            // 
            this.pregledZaposlenikaToolStripMenuItem.Name = "pregledZaposlenikaToolStripMenuItem";
            this.pregledZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.pregledZaposlenikaToolStripMenuItem.Text = "Pregled zaposlenika";
            this.pregledZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.PregledZaposlenikaToolStripMenuItem_Click);
            // 
            // dodajNovogZaposlenikaToolStripMenuItem
            // 
            this.dodajNovogZaposlenikaToolStripMenuItem.Name = "dodajNovogZaposlenikaToolStripMenuItem";
            this.dodajNovogZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.dodajNovogZaposlenikaToolStripMenuItem.Text = "Dodaj novog zaposlenika";
            this.dodajNovogZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.DodajNovogZaposlenikaToolStripMenuItem_Click);
            // 
            // isplataZaposlenikaToolStripMenuItem
            // 
            this.isplataZaposlenikaToolStripMenuItem.Name = "isplataZaposlenikaToolStripMenuItem";
            this.isplataZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.isplataZaposlenikaToolStripMenuItem.Text = "Isplata zaposlenika";
            this.isplataZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.IsplataZaposlenikaToolStripMenuItem_Click);
            // 
            // upravljanjePaketimaToolStripMenuItem
            // 
            this.upravljanjePaketimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledPaketaToolStripMenuItem,
            this.dodajNoviPaketToolStripMenuItem1});
            this.upravljanjePaketimaToolStripMenuItem.Name = "upravljanjePaketimaToolStripMenuItem";
            this.upravljanjePaketimaToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.upravljanjePaketimaToolStripMenuItem.Text = "Upravljanje paketima";
            // 
            // pregledPaketaToolStripMenuItem
            // 
            this.pregledPaketaToolStripMenuItem.Name = "pregledPaketaToolStripMenuItem";
            this.pregledPaketaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pregledPaketaToolStripMenuItem.Text = "Pregled paketa";
            this.pregledPaketaToolStripMenuItem.Click += new System.EventHandler(this.PregledPaketaToolStripMenuItem_Click);
            // 
            // dodajNoviPaketToolStripMenuItem1
            // 
            this.dodajNoviPaketToolStripMenuItem1.Name = "dodajNoviPaketToolStripMenuItem1";
            this.dodajNoviPaketToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.dodajNoviPaketToolStripMenuItem1.Text = "Dodaj novi paket";
            this.dodajNoviPaketToolStripMenuItem1.Click += new System.EventHandler(this.DodajNoviPaketToolStripMenuItem1_Click);
            // 
            // upravljanjeTipovimaTreningaToolStripMenuItem
            // 
            this.upravljanjeTipovimaTreningaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledTipovaTreningaToolStripMenuItem,
            this.dodajNoviTipTreningaToolStripMenuItem});
            this.upravljanjeTipovimaTreningaToolStripMenuItem.Name = "upravljanjeTipovimaTreningaToolStripMenuItem";
            this.upravljanjeTipovimaTreningaToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.upravljanjeTipovimaTreningaToolStripMenuItem.Text = "Upravljanje tipovima treninga";
            // 
            // pregledTipovaTreningaToolStripMenuItem
            // 
            this.pregledTipovaTreningaToolStripMenuItem.Name = "pregledTipovaTreningaToolStripMenuItem";
            this.pregledTipovaTreningaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pregledTipovaTreningaToolStripMenuItem.Text = "Pregled tipova treninga";
            this.pregledTipovaTreningaToolStripMenuItem.Click += new System.EventHandler(this.PregledTipovaTreningaToolStripMenuItem_Click);
            // 
            // dodajNoviTipTreningaToolStripMenuItem
            // 
            this.dodajNoviTipTreningaToolStripMenuItem.Name = "dodajNoviTipTreningaToolStripMenuItem";
            this.dodajNoviTipTreningaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.dodajNoviTipTreningaToolStripMenuItem.Text = "Dodaj novi tip treninga";
            this.dodajNoviTipTreningaToolStripMenuItem.Click += new System.EventHandler(this.DodajNoviTipTreningaToolStripMenuItem_Click);
            // 
            // izvjestavanjeToolStripMenuItem
            // 
            this.izvjestavanjeToolStripMenuItem.Name = "izvjestavanjeToolStripMenuItem";
            this.izvjestavanjeToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.izvjestavanjeToolStripMenuItem.Text = "Izvjestavanje";
            this.izvjestavanjeToolStripMenuItem.Click += new System.EventHandler(this.IzvjestavanjeToolStripMenuItem_Click);
            // 
            // qRKodSkenerToolStripMenuItem
            // 
            this.qRKodSkenerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokreniSkeniranjeQrKodovaToolStripMenuItem});
            this.qRKodSkenerToolStripMenuItem.Name = "qRKodSkenerToolStripMenuItem";
            this.qRKodSkenerToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.qRKodSkenerToolStripMenuItem.Text = "QR Kod Skener";
            // 
            // pokreniSkeniranjeQrKodovaToolStripMenuItem
            // 
            this.pokreniSkeniranjeQrKodovaToolStripMenuItem.Name = "pokreniSkeniranjeQrKodovaToolStripMenuItem";
            this.pokreniSkeniranjeQrKodovaToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.pokreniSkeniranjeQrKodovaToolStripMenuItem.Text = "Pokreni skeniranje qr kodova";
            this.pokreniSkeniranjeQrKodovaToolStripMenuItem.Click += new System.EventHandler(this.PokreniSkeniranjeQrKodovaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(802, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "Wellness centar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem clanarinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaClanarinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noviTreningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menadzmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestavanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qRKodSkenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokreniSkeniranjeQrKodovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjePaketimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPaketaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviPaketToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeZaposlenicimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isplataZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeClanovimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledClanovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogClanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeTipovimaTreningaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledTipovaTreningaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviTipTreningaToolStripMenuItem;
    }
}



