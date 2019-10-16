namespace Wellness.WinUI.Menadzment
{
    partial class frmTrenerSpecijalizacija
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
            this.cbTipTreninga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTrener = new System.Windows.Forms.ComboBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.dgvTrenerSpecijalizacija = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipTreninga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.objectExtensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenerSpecijalizacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectExtensionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipTreninga
            // 
            this.cbTipTreninga.FormattingEnabled = true;
            this.cbTipTreninga.Location = new System.Drawing.Point(29, 41);
            this.cbTipTreninga.Name = "cbTipTreninga";
            this.cbTipTreninga.Size = new System.Drawing.Size(121, 21);
            this.cbTipTreninga.TabIndex = 0;
            this.cbTipTreninga.SelectedIndexChanged += new System.EventHandler(this.CbTipTreninga_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tip treninga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trener";
            // 
            // cbTrener
            // 
            this.cbTrener.FormattingEnabled = true;
            this.cbTrener.Location = new System.Drawing.Point(29, 82);
            this.cbTrener.Name = "cbTrener";
            this.cbTrener.Size = new System.Drawing.Size(121, 21);
            this.cbTrener.TabIndex = 2;
            this.cbTrener.SelectedIndexChanged += new System.EventHandler(this.CbTrener_SelectedIndexChanged);
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(29, 110);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(121, 23);
            this.btnSpasi.TabIndex = 4;
            this.btnSpasi.Text = "Dodjeli specijalizaciju";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.BtnSpasi_Click);
            // 
            // dgvTrenerSpecijalizacija
            // 
            this.dgvTrenerSpecijalizacija.AllowUserToAddRows = false;
            this.dgvTrenerSpecijalizacija.AllowUserToDeleteRows = false;
            this.dgvTrenerSpecijalizacija.AutoGenerateColumns = false;
            this.dgvTrenerSpecijalizacija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrenerSpecijalizacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrenerSpecijalizacija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Trener,
            this.TipTreninga,
            this.Ukloni});
            this.dgvTrenerSpecijalizacija.DataSource = this.objectExtensionBindingSource;
            this.dgvTrenerSpecijalizacija.Location = new System.Drawing.Point(29, 179);
            this.dgvTrenerSpecijalizacija.Name = "dgvTrenerSpecijalizacija";
            this.dgvTrenerSpecijalizacija.ReadOnly = true;
            this.dgvTrenerSpecijalizacija.Size = new System.Drawing.Size(389, 150);
            this.dgvTrenerSpecijalizacija.TabIndex = 5;
            this.dgvTrenerSpecijalizacija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTrenerSpecijalizacija_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Trener
            // 
            this.Trener.HeaderText = "Trener";
            this.Trener.Name = "Trener";
            this.Trener.ReadOnly = true;
            // 
            // TipTreninga
            // 
            this.TipTreninga.HeaderText = "Tip treninga";
            this.TipTreninga.Name = "TipTreninga";
            this.TipTreninga.ReadOnly = true;
            // 
            // Ukloni
            // 
            this.Ukloni.HeaderText = "Ukloni";
            this.Ukloni.Name = "Ukloni";
            this.Ukloni.ReadOnly = true;
            // 
            // objectExtensionBindingSource
            // 
            this.objectExtensionBindingSource.DataSource = typeof(Wellness.Model.ObjectExtension);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "________________________________________";
            // 
            // frmTrenerSpecijalizacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 384);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvTrenerSpecijalizacija);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTrener);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipTreninga);
            this.Name = "frmTrenerSpecijalizacija";
            this.Text = "frmTrenerSpecijalizacija";
            this.Load += new System.EventHandler(this.FrmTrenerSpecijalizacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenerSpecijalizacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectExtensionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipTreninga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTrener;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.DataGridView dgvTrenerSpecijalizacija;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource objectExtensionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trener;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipTreninga;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
    }
}