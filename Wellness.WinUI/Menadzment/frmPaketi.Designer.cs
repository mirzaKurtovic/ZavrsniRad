namespace Wellness.WinUI.Menadzment
{
    partial class frmPaketi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCijenaVeceOd = new System.Windows.Forms.TextBox();
            this.txtCijenaManjeOd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivPaketa = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.cbSortiranje = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPaketi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaCustom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pristupGrupnimTreninzimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neogranicenPristupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePristupaOdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemePristupaOdCustom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePristupaDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemePristupaDoCustom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.displayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtCijenaVeceOd
            // 
            this.txtCijenaVeceOd.Location = new System.Drawing.Point(35, 76);
            this.txtCijenaVeceOd.Name = "txtCijenaVeceOd";
            this.txtCijenaVeceOd.Size = new System.Drawing.Size(47, 20);
            this.txtCijenaVeceOd.TabIndex = 1;
            // 
            // txtCijenaManjeOd
            // 
            this.txtCijenaManjeOd.Location = new System.Drawing.Point(159, 76);
            this.txtCijenaManjeOd.Name = "txtCijenaManjeOd";
            this.txtCijenaManjeOd.Size = new System.Drawing.Size(47, 20);
            this.txtCijenaManjeOd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "<   cijena   >";
            // 
            // txtNazivPaketa
            // 
            this.txtNazivPaketa.Location = new System.Drawing.Point(35, 38);
            this.txtNazivPaketa.Name = "txtNazivPaketa";
            this.txtNazivPaketa.Size = new System.Drawing.Size(171, 20);
            this.txtNazivPaketa.TabIndex = 4;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(35, 158);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(171, 23);
            this.btnTrazi.TabIndex = 5;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.BtnTrazi_Click);
            // 
            // cbSortiranje
            // 
            this.cbSortiranje.FormattingEnabled = true;
            this.cbSortiranje.Location = new System.Drawing.Point(35, 120);
            this.cbSortiranje.Name = "cbSortiranje";
            this.cbSortiranje.Size = new System.Drawing.Size(171, 21);
            this.cbSortiranje.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sortiraj po";
            // 
            // dgvPaketi
            // 
            this.dgvPaketi.AllowUserToAddRows = false;
            this.dgvPaketi.AllowUserToDeleteRows = false;
            this.dgvPaketi.AutoGenerateColumns = false;
            this.dgvPaketi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaketi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaketi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.CijenaCustom,
            this.opisDataGridViewTextBoxColumn,
            this.pristupGrupnimTreninzimaDataGridViewTextBoxColumn,
            this.neogranicenPristupDataGridViewTextBoxColumn,
            this.vrijemePristupaOdDataGridViewTextBoxColumn,
            this.VrijemePristupaOdCustom,
            this.vrijemePristupaDoDataGridViewTextBoxColumn,
            this.VrijemePristupaDoCustom,
            this.slikaDataGridViewImageColumn,
            this.displayDataGridViewTextBoxColumn});
            this.dgvPaketi.DataSource = this.paketBindingSource;
            this.dgvPaketi.Location = new System.Drawing.Point(37, 227);
            this.dgvPaketi.Name = "dgvPaketi";
            this.dgvPaketi.ReadOnly = true;
            this.dgvPaketi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaketi.Size = new System.Drawing.Size(626, 197);
            this.dgvPaketi.TabIndex = 8;
            this.dgvPaketi.DoubleClick += new System.EventHandler(this.DgvPaketi_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // CijenaCustom
            // 
            this.CijenaCustom.HeaderText = "Cijena";
            this.CijenaCustom.Name = "CijenaCustom";
            this.CijenaCustom.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisDataGridViewTextBoxColumn.Visible = false;
            // 
            // pristupGrupnimTreninzimaDataGridViewTextBoxColumn
            // 
            this.pristupGrupnimTreninzimaDataGridViewTextBoxColumn.DataPropertyName = "PristupGrupnimTreninzima";
            this.pristupGrupnimTreninzimaDataGridViewTextBoxColumn.HeaderText = "Pristup grupnim treninzima";
            this.pristupGrupnimTreninzimaDataGridViewTextBoxColumn.Name = "pristupGrupnimTreninzimaDataGridViewTextBoxColumn";
            this.pristupGrupnimTreninzimaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // neogranicenPristupDataGridViewTextBoxColumn
            // 
            this.neogranicenPristupDataGridViewTextBoxColumn.DataPropertyName = "NeogranicenPristup";
            this.neogranicenPristupDataGridViewTextBoxColumn.HeaderText = "Neogranicen pristup";
            this.neogranicenPristupDataGridViewTextBoxColumn.Name = "neogranicenPristupDataGridViewTextBoxColumn";
            this.neogranicenPristupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemePristupaOdDataGridViewTextBoxColumn
            // 
            this.vrijemePristupaOdDataGridViewTextBoxColumn.DataPropertyName = "VrijemePristupaOd";
            this.vrijemePristupaOdDataGridViewTextBoxColumn.HeaderText = "Vrijeme pristupa od";
            this.vrijemePristupaOdDataGridViewTextBoxColumn.Name = "vrijemePristupaOdDataGridViewTextBoxColumn";
            this.vrijemePristupaOdDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrijemePristupaOdDataGridViewTextBoxColumn.Visible = false;
            // 
            // VrijemePristupaOdCustom
            // 
            this.VrijemePristupaOdCustom.HeaderText = "Vrijeme pristupa od";
            this.VrijemePristupaOdCustom.Name = "VrijemePristupaOdCustom";
            this.VrijemePristupaOdCustom.ReadOnly = true;
            // 
            // vrijemePristupaDoDataGridViewTextBoxColumn
            // 
            this.vrijemePristupaDoDataGridViewTextBoxColumn.DataPropertyName = "VrijemePristupaDo";
            this.vrijemePristupaDoDataGridViewTextBoxColumn.HeaderText = "Vrijeme pristupa do";
            this.vrijemePristupaDoDataGridViewTextBoxColumn.Name = "vrijemePristupaDoDataGridViewTextBoxColumn";
            this.vrijemePristupaDoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrijemePristupaDoDataGridViewTextBoxColumn.Visible = false;
            // 
            // VrijemePristupaDoCustom
            // 
            this.VrijemePristupaDoCustom.HeaderText = "Vrijeme pristupa do";
            this.VrijemePristupaDoCustom.Name = "VrijemePristupaDoCustom";
            this.VrijemePristupaDoCustom.ReadOnly = true;
            // 
            // slikaDataGridViewImageColumn
            // 
            this.slikaDataGridViewImageColumn.DataPropertyName = "Slika";
            this.slikaDataGridViewImageColumn.HeaderText = "Slika";
            this.slikaDataGridViewImageColumn.Name = "slikaDataGridViewImageColumn";
            this.slikaDataGridViewImageColumn.ReadOnly = true;
            this.slikaDataGridViewImageColumn.Visible = false;
            // 
            // displayDataGridViewTextBoxColumn
            // 
            this.displayDataGridViewTextBoxColumn.DataPropertyName = "Display";
            this.displayDataGridViewTextBoxColumn.HeaderText = "Display";
            this.displayDataGridViewTextBoxColumn.Name = "displayDataGridViewTextBoxColumn";
            this.displayDataGridViewTextBoxColumn.ReadOnly = true;
            this.displayDataGridViewTextBoxColumn.Visible = false;
            // 
            // paketBindingSource
            // 
            this.paketBindingSource.DataSource = typeof(Wellness.Model.Paket);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(439, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "________________________________________________________________________";
            // 
            // frmPaketi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 440);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvPaketi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSortiranje);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtNazivPaketa);
            this.Controls.Add(this.txtCijenaManjeOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCijenaVeceOd);
            this.Controls.Add(this.label1);
            this.Name = "frmPaketi";
            this.Text = "frmPaketi";
            this.Load += new System.EventHandler(this.FrmPaketi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCijenaVeceOd;
        private System.Windows.Forms.TextBox txtCijenaManjeOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivPaketa;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.ComboBox cbSortiranje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPaketi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource paketBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaCustom;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pristupGrupnimTreninzimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn neogranicenPristupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePristupaOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemePristupaOdCustom;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePristupaDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemePristupaDoCustom;
        private System.Windows.Forms.DataGridViewImageColumn slikaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayDataGridViewTextBoxColumn;
    }
}