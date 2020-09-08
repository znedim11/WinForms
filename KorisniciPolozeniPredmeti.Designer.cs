namespace WinForms
{
    partial class KorisniciPolozeniPredmeti
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
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.dtpDatumPologanja = new System.Windows.Forms.DateTimePicker();
            this.btnDodajPolozeni = new System.Windows.Forms.Button();
            this.dgvPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(12, 12);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(121, 21);
            this.cmbPredmeti.TabIndex = 0;
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(139, 12);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(100, 20);
            this.txtOcjena.TabIndex = 1;
            // 
            // dtpDatumPologanja
            // 
            this.dtpDatumPologanja.Location = new System.Drawing.Point(254, 12);
            this.dtpDatumPologanja.Name = "dtpDatumPologanja";
            this.dtpDatumPologanja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumPologanja.TabIndex = 2;
            // 
            // btnDodajPolozeni
            // 
            this.btnDodajPolozeni.Location = new System.Drawing.Point(479, 11);
            this.btnDodajPolozeni.Name = "btnDodajPolozeni";
            this.btnDodajPolozeni.Size = new System.Drawing.Size(75, 23);
            this.btnDodajPolozeni.TabIndex = 3;
            this.btnDodajPolozeni.Text = "Dodaj";
            this.btnDodajPolozeni.UseVisualStyleBackColor = true;
            this.btnDodajPolozeni.Click += new System.EventHandler(this.btnDodajPolozeni_Click);
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.AllowUserToAddRows = false;
            this.dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Ocjena,
            this.Datum});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(13, 40);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.ReadOnly = true;
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(541, 150);
            this.dgvPolozeniPredmeti.TabIndex = 4;
            this.dgvPolozeniPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolozeniPredmeti_CellContentClick);
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            this.Predmet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // KorisniciPolozeniPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 207);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Controls.Add(this.btnDodajPolozeni);
            this.Controls.Add(this.dtpDatumPologanja);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.cmbPredmeti);
            this.Name = "KorisniciPolozeniPredmeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KorisniciPolozeniPredmeti";
            this.Load += new System.EventHandler(this.KorisniciPolozeniPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.DateTimePicker dtpDatumPologanja;
        private System.Windows.Forms.Button btnDodajPolozeni;
        private System.Windows.Forms.DataGridView dgvPolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
    }
}