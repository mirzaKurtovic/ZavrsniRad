namespace Wellness.WinUI.Trening
{
    partial class frmTrening
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipTreninga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumTreningaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePocetakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeKrajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maksimalnoPrisutnihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trenerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipTreningaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipTreningaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trenerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odrzan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTipTreninga = new System.Windows.Forms.ComboBox();
            this.dtpDatumTreninga = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.cbSviDatumi = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOdrzan = new System.Windows.Forms.ComboBox();
            this.numMaksimalnoPrisutnihVeceOd = new System.Windows.Forms.NumericUpDown();
            this.numMaksimalnoPrisutnihManjeOd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaksimalnoPrisutnihVeceOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaksimalnoPrisutnihManjeOd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTreninzi);
            this.groupBox1.Location = new System.Drawing.Point(15, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treninzi";
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.AutoGenerateColumns = false;
            this.dgvTreninzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.TipTreninga,
            this.datumTreningaDataGridViewTextBoxColumn,
            this.vrijemePocetakDataGridViewTextBoxColumn,
            this.vrijemeKrajDataGridViewTextBoxColumn,
            this.maksimalnoPrisutnihDataGridViewTextBoxColumn,
            this.trenerIdDataGridViewTextBoxColumn,
            this.tipTreningaIdDataGridViewTextBoxColumn,
            this.tipTreningaDataGridViewTextBoxColumn,
            this.trenerDataGridViewTextBoxColumn,
            this.Odrzan});
            this.dgvTreninzi.DataSource = this.treningBindingSource;
            this.dgvTreninzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTreninzi.Location = new System.Drawing.Point(3, 16);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreninzi.Size = new System.Drawing.Size(767, 266);
            this.dgvTreninzi.TabIndex = 0;
            this.dgvTreninzi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvTreninzi_MouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // TipTreninga
            // 
            this.TipTreninga.HeaderText = "Tip treninga";
            this.TipTreninga.Name = "TipTreninga";
            this.TipTreninga.ReadOnly = true;
            // 
            // datumTreningaDataGridViewTextBoxColumn
            // 
            this.datumTreningaDataGridViewTextBoxColumn.DataPropertyName = "DatumTreninga";
            this.datumTreningaDataGridViewTextBoxColumn.HeaderText = "DatumTreninga";
            this.datumTreningaDataGridViewTextBoxColumn.Name = "datumTreningaDataGridViewTextBoxColumn";
            this.datumTreningaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemePocetakDataGridViewTextBoxColumn
            // 
            this.vrijemePocetakDataGridViewTextBoxColumn.DataPropertyName = "VrijemePocetak";
            this.vrijemePocetakDataGridViewTextBoxColumn.HeaderText = "VrijemePocetak";
            this.vrijemePocetakDataGridViewTextBoxColumn.Name = "vrijemePocetakDataGridViewTextBoxColumn";
            this.vrijemePocetakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemeKrajDataGridViewTextBoxColumn
            // 
            this.vrijemeKrajDataGridViewTextBoxColumn.DataPropertyName = "VrijemeKraj";
            this.vrijemeKrajDataGridViewTextBoxColumn.HeaderText = "VrijemeKraj";
            this.vrijemeKrajDataGridViewTextBoxColumn.Name = "vrijemeKrajDataGridViewTextBoxColumn";
            this.vrijemeKrajDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maksimalnoPrisutnihDataGridViewTextBoxColumn
            // 
            this.maksimalnoPrisutnihDataGridViewTextBoxColumn.DataPropertyName = "MaksimalnoPrisutnih";
            this.maksimalnoPrisutnihDataGridViewTextBoxColumn.HeaderText = "MaksimalnoPrisutnih";
            this.maksimalnoPrisutnihDataGridViewTextBoxColumn.Name = "maksimalnoPrisutnihDataGridViewTextBoxColumn";
            this.maksimalnoPrisutnihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trenerIdDataGridViewTextBoxColumn
            // 
            this.trenerIdDataGridViewTextBoxColumn.DataPropertyName = "TrenerId";
            this.trenerIdDataGridViewTextBoxColumn.HeaderText = "TrenerId";
            this.trenerIdDataGridViewTextBoxColumn.Name = "trenerIdDataGridViewTextBoxColumn";
            this.trenerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.trenerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipTreningaIdDataGridViewTextBoxColumn
            // 
            this.tipTreningaIdDataGridViewTextBoxColumn.DataPropertyName = "TipTreningaId";
            this.tipTreningaIdDataGridViewTextBoxColumn.HeaderText = "TipTreningaId";
            this.tipTreningaIdDataGridViewTextBoxColumn.Name = "tipTreningaIdDataGridViewTextBoxColumn";
            this.tipTreningaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipTreningaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipTreningaDataGridViewTextBoxColumn
            // 
            this.tipTreningaDataGridViewTextBoxColumn.DataPropertyName = "TipTreninga";
            this.tipTreningaDataGridViewTextBoxColumn.HeaderText = "TipTreninga";
            this.tipTreningaDataGridViewTextBoxColumn.Name = "tipTreningaDataGridViewTextBoxColumn";
            this.tipTreningaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipTreningaDataGridViewTextBoxColumn.Visible = false;
            // 
            // trenerDataGridViewTextBoxColumn
            // 
            this.trenerDataGridViewTextBoxColumn.DataPropertyName = "Trener";
            this.trenerDataGridViewTextBoxColumn.HeaderText = "Trener";
            this.trenerDataGridViewTextBoxColumn.Name = "trenerDataGridViewTextBoxColumn";
            this.trenerDataGridViewTextBoxColumn.ReadOnly = true;
            this.trenerDataGridViewTextBoxColumn.Visible = false;
            // 
            // Odrzan
            // 
            this.Odrzan.HeaderText = "Odrzan";
            this.Odrzan.Name = "Odrzan";
            this.Odrzan.ReadOnly = true;
            // 
            // treningBindingSource
            // 
            this.treningBindingSource.DataSource = typeof(Wellness.Model.Trening);
            // 
            // cbTipTreninga
            // 
            this.cbTipTreninga.FormattingEnabled = true;
            this.cbTipTreninga.Location = new System.Drawing.Point(15, 23);
            this.cbTipTreninga.Name = "cbTipTreninga";
            this.cbTipTreninga.Size = new System.Drawing.Size(121, 21);
            this.cbTipTreninga.TabIndex = 1;
            // 
            // dtpDatumTreninga
            // 
            this.dtpDatumTreninga.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumTreninga.Location = new System.Drawing.Point(15, 67);
            this.dtpDatumTreninga.Name = "dtpDatumTreninga";
            this.dtpDatumTreninga.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumTreninga.TabIndex = 2;
            this.dtpDatumTreninga.Value = new System.DateTime(2019, 5, 18, 4, 18, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tip treninga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum treninga";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(15, 182);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(121, 23);
            this.btnTrazi.TabIndex = 5;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.BtnTrazi_Click);
            // 
            // cbSviDatumi
            // 
            this.cbSviDatumi.AutoSize = true;
            this.cbSviDatumi.Checked = true;
            this.cbSviDatumi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSviDatumi.Location = new System.Drawing.Point(158, 70);
            this.cbSviDatumi.Name = "cbSviDatumi";
            this.cbSviDatumi.Size = new System.Drawing.Size(74, 17);
            this.cbSviDatumi.TabIndex = 6;
            this.cbSviDatumi.Text = "Svaki dan";
            this.cbSviDatumi.UseVisualStyleBackColor = true;
            this.cbSviDatumi.CheckedChanged += new System.EventHandler(this.CbSviDatumi_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Odrzan";
            // 
            // cbOdrzan
            // 
            this.cbOdrzan.FormattingEnabled = true;
            this.cbOdrzan.Location = new System.Drawing.Point(15, 109);
            this.cbOdrzan.Name = "cbOdrzan";
            this.cbOdrzan.Size = new System.Drawing.Size(121, 21);
            this.cbOdrzan.TabIndex = 7;
            // 
            // numMaksimalnoPrisutnihVeceOd
            // 
            this.numMaksimalnoPrisutnihVeceOd.Location = new System.Drawing.Point(15, 145);
            this.numMaksimalnoPrisutnihVeceOd.Name = "numMaksimalnoPrisutnihVeceOd";
            this.numMaksimalnoPrisutnihVeceOd.Size = new System.Drawing.Size(51, 20);
            this.numMaksimalnoPrisutnihVeceOd.TabIndex = 9;
            // 
            // numMaksimalnoPrisutnihManjeOd
            // 
            this.numMaksimalnoPrisutnihManjeOd.Location = new System.Drawing.Point(165, 145);
            this.numMaksimalnoPrisutnihManjeOd.Name = "numMaksimalnoPrisutnihManjeOd";
            this.numMaksimalnoPrisutnihManjeOd.Size = new System.Drawing.Size(51, 20);
            this.numMaksimalnoPrisutnihManjeOd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "> Max prisutnih <";
            // 
            // frmTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numMaksimalnoPrisutnihManjeOd);
            this.Controls.Add(this.numMaksimalnoPrisutnihVeceOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbOdrzan);
            this.Controls.Add(this.cbSviDatumi);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumTreninga);
            this.Controls.Add(this.cbTipTreninga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTrening";
            this.Text = "Pregled treninga";
            this.Load += new System.EventHandler(this.FrmTrening_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaksimalnoPrisutnihVeceOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaksimalnoPrisutnihManjeOd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.BindingSource treningBindingSource;
        private System.Windows.Forms.ComboBox cbTipTreninga;
        private System.Windows.Forms.DateTimePicker dtpDatumTreninga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.CheckBox cbSviDatumi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipTreninga;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumTreningaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePocetakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeKrajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maksimalnoPrisutnihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trenerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipTreningaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipTreningaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trenerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odrzan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOdrzan;
        private System.Windows.Forms.NumericUpDown numMaksimalnoPrisutnihVeceOd;
        private System.Windows.Forms.NumericUpDown numMaksimalnoPrisutnihManjeOd;
        private System.Windows.Forms.Label label4;
    }
}