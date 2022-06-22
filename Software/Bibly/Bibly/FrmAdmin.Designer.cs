namespace Bibly
{
    partial class FrmAdmin
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.dgvTablica = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblNazivTablice = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.cmbKriterijPretrazivanja = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblNaslov.Location = new System.Drawing.Point(494, 54);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(148, 46);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "ADMIN";
            // 
            // dgvTablica
            // 
            this.dgvTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablica.Location = new System.Drawing.Point(32, 183);
            this.dgvTablica.Name = "dgvTablica";
            this.dgvTablica.Size = new System.Drawing.Size(1002, 398);
            this.dgvTablica.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(631, 587);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 33);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(781, 587);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(105, 33);
            this.btnAzuriraj.TabIndex = 5;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(166)))));
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(929, 587);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 33);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtPretrazivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretrazivanje.Location = new System.Drawing.Point(707, 148);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(193, 24);
            this.txtPretrazivanje.TabIndex = 7;
            // 
            // lblNazivTablice
            // 
            this.lblNazivTablice.AutoSize = true;
            this.lblNazivTablice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivTablice.Location = new System.Drawing.Point(28, 152);
            this.lblNazivTablice.Name = "lblNazivTablice";
            this.lblNazivTablice.Size = new System.Drawing.Size(59, 20);
            this.lblNazivTablice.TabIndex = 8;
            this.lblNazivTablice.Text = "Tablica";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(906, 144);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(128, 33);
            this.btnPretrazi.TabIndex = 9;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            // 
            // cmbKriterijPretrazivanja
            // 
            this.cmbKriterijPretrazivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKriterijPretrazivanja.FormattingEnabled = true;
            this.cmbKriterijPretrazivanja.Location = new System.Drawing.Point(580, 148);
            this.cmbKriterijPretrazivanja.Name = "cmbKriterijPretrazivanja";
            this.cmbKriterijPretrazivanja.Size = new System.Drawing.Size(121, 26);
            this.cmbKriterijPretrazivanja.TabIndex = 10;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 654);
            this.Controls.Add(this.cmbKriterijPretrazivanja);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblNazivTablice);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvTablica);
            this.Controls.Add(this.lblNaslov);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Controls.SetChildIndex(this.lblNaslov, 0);
            this.Controls.SetChildIndex(this.dgvTablica, 0);
            this.Controls.SetChildIndex(this.btnDodaj, 0);
            this.Controls.SetChildIndex(this.btnAzuriraj, 0);
            this.Controls.SetChildIndex(this.btnObrisi, 0);
            this.Controls.SetChildIndex(this.txtPretrazivanje, 0);
            this.Controls.SetChildIndex(this.lblNazivTablice, 0);
            this.Controls.SetChildIndex(this.btnPretrazi, 0);
            this.Controls.SetChildIndex(this.cmbKriterijPretrazivanja, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.DataGridView dgvTablica;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblNazivTablice;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.ComboBox cmbKriterijPretrazivanja;
    }
}