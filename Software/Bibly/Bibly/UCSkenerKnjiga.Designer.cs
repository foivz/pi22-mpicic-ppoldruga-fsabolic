namespace Bibly
{
    partial class UCSkenerKnjiga
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbKamere = new System.Windows.Forms.ComboBox();
            this.pbSken = new System.Windows.Forms.PictureBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnSkeniraj = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSken)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKamere
            // 
            this.cmbKamere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKamere.FormattingEnabled = true;
            this.cmbKamere.Location = new System.Drawing.Point(0, 0);
            this.cmbKamere.Name = "cmbKamere";
            this.cmbKamere.Size = new System.Drawing.Size(344, 28);
            this.cmbKamere.TabIndex = 0;
            // 
            // pbSken
            // 
            this.pbSken.BackColor = System.Drawing.Color.Gray;
            this.pbSken.Location = new System.Drawing.Point(0, 34);
            this.pbSken.Name = "pbSken";
            this.pbSken.Size = new System.Drawing.Size(342, 286);
            this.pbSken.TabIndex = 1;
            this.pbSken.TabStop = false;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtISBN.Enabled = false;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(0, 326);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(342, 26);
            this.txtISBN.TabIndex = 2;
            this.txtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSkeniraj
            // 
            this.btnSkeniraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnSkeniraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkeniraj.Location = new System.Drawing.Point(0, 358);
            this.btnSkeniraj.Name = "btnSkeniraj";
            this.btnSkeniraj.Size = new System.Drawing.Size(167, 36);
            this.btnSkeniraj.TabIndex = 3;
            this.btnSkeniraj.Text = "Skeniraj";
            this.btnSkeniraj.UseVisualStyleBackColor = false;
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(166)))));
            this.btnZaustavi.Enabled = false;
            this.btnZaustavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaustavi.Location = new System.Drawing.Point(177, 358);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(167, 36);
            this.btnZaustavi.TabIndex = 4;
            this.btnZaustavi.Text = "Zaustavi";
            this.btnZaustavi.UseVisualStyleBackColor = false;
            // 
            // UCSkenerKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnSkeniraj);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.pbSken);
            this.Controls.Add(this.cmbKamere);
            this.Name = "UCSkenerKnjiga";
            this.Size = new System.Drawing.Size(342, 394);
            ((System.ComponentModel.ISupportInitialize)(this.pbSken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKamere;
        private System.Windows.Forms.PictureBox pbSken;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnSkeniraj;
        private System.Windows.Forms.Button btnZaustavi;
    }
}
