namespace Wellness.WinUI.Menadzment
{
    partial class frmTipTreningaDetalji
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
            this.dgvTipTreninga = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipTreninga1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DodjeliTreneru = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tipTreningaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipTreninga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipTreningaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipTreninga
            // 
            this.dgvTipTreninga.AllowUserToAddRows = false;
            this.dgvTipTreninga.AllowUserToDeleteRows = false;
            this.dgvTipTreninga.AutoGenerateColumns = false;
            this.dgvTipTreninga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipTreninga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipTreninga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipTreninga1DataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.DodjeliTreneru});
            this.dgvTipTreninga.DataSource = this.tipTreningaBindingSource;
            this.dgvTipTreninga.Location = new System.Drawing.Point(40, 105);
            this.dgvTipTreninga.Name = "dgvTipTreninga";
            this.dgvTipTreninga.ReadOnly = true;
            this.dgvTipTreninga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipTreninga.Size = new System.Drawing.Size(271, 172);
            this.dgvTipTreninga.TabIndex = 0;
            this.dgvTipTreninga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipTreninga_CellContentClick);
            this.dgvTipTreninga.DoubleClick += new System.EventHandler(this.dgvTipTreninga_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipTreninga1DataGridViewTextBoxColumn
            // 
            this.tipTreninga1DataGridViewTextBoxColumn.DataPropertyName = "TipTreninga1";
            this.tipTreninga1DataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.tipTreninga1DataGridViewTextBoxColumn.Name = "tipTreninga1DataGridViewTextBoxColumn";
            this.tipTreninga1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisDataGridViewTextBoxColumn.Visible = false;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            this.imageDataGridViewImageColumn.Visible = false;
            // 
            // DodjeliTreneru
            // 
            this.DodjeliTreneru.HeaderText = "Dodjeli treneru";
            this.DodjeliTreneru.Name = "DodjeliTreneru";
            this.DodjeliTreneru.ReadOnly = true;
            this.DodjeliTreneru.Text = "Dodjeli treneru";
            // 
            // tipTreningaBindingSource
            // 
            this.tipTreningaBindingSource.DataSource = typeof(Wellness.Model.TipTreninga);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(40, 28);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(40, 54);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(100, 23);
            this.btnTrazi.TabIndex = 3;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.BtnTrazi_Click);
            // 
            // frmTipTreningaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 310);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTipTreninga);
            this.Name = "frmTipTreningaDetalji";
            this.Text = "frmTipTreningaDetalji";
            this.Load += new System.EventHandler(this.FrmTipTreningaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipTreninga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipTreningaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipTreninga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.BindingSource tipTreningaBindingSource;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipTreninga1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DodjeliTreneru;
    }
}