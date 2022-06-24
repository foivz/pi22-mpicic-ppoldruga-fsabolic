namespace Bibly
{
    partial class UCSkener
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
            this.txtGreske = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSken)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKamere
            // 
            this.cmbKamere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKamere.FormattingEnabled = true;
            this.cmbKamere.Location = new System.Drawing.Point(22, 18);
            this.cmbKamere.Name = "cmbKamere";
            this.cmbKamere.Size = new System.Drawing.Size(344, 28);
            this.cmbKamere.TabIndex = 0;
            // 
            // pbSken
            // 
            this.pbSken.BackColor = System.Drawing.Color.Gray;
            this.pbSken.Location = new System.Drawing.Point(22, 52);
            this.pbSken.Name = "pbSken";
            this.pbSken.Size = new System.Drawing.Size(342, 286);
            this.pbSken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSken.TabIndex = 1;
            this.pbSken.TabStop = false;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtISBN.Enabled = false;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(109, 344);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(255, 26);
            this.txtISBN.TabIndex = 2;
            this.txtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSkeniraj
            // 
            this.btnSkeniraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnSkeniraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkeniraj.Location = new System.Drawing.Point(22, 440);
            this.btnSkeniraj.Name = "btnSkeniraj";
            this.btnSkeniraj.Size = new System.Drawing.Size(167, 36);
            this.btnSkeniraj.TabIndex = 3;
            this.btnSkeniraj.Text = "Skeniraj";
            this.btnSkeniraj.UseVisualStyleBackColor = false;
            this.btnSkeniraj.Click += new System.EventHandler(this.btnSkeniraj_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(166)))));
            this.btnZaustavi.Enabled = false;
            this.btnZaustavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaustavi.Location = new System.Drawing.Point(199, 440);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(167, 36);
            this.btnZaustavi.TabIndex = 4;
            this.btnZaustavi.Text = "Zaustavi";
            this.btnZaustavi.UseVisualStyleBackColor = false;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // txtGreske
            // 
            this.txtGreske.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtGreske.Enabled = false;
            this.txtGreske.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreske.Location = new System.Drawing.Point(109, 376);
            this.txtGreske.Multiline = true;
            this.txtGreske.Name = "txtGreske";
            this.txtGreske.Size = new System.Drawing.Size(255, 58);
            this.txtGreske.TabIndex = 5;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(32, 350);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(51, 20);
            this.lblISBN.TabIndex = 7;
            this.lblISBN.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Greške:";
            // 
            // UCSkenerKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtGreske);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnSkeniraj);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.pbSken);
            this.Controls.Add(this.cmbKamere);
            this.Name = "UCSkenerKnjiga";
            this.Size = new System.Drawing.Size(384, 491);
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
        private System.Windows.Forms.TextBox txtGreske;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label3;
    }
}
