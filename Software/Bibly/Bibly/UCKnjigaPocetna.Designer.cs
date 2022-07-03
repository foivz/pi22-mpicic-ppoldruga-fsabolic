namespace Bibly
{
    partial class UCKnjigaPocetna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.pbSlikaKnjige = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblAutor);
            this.panel1.Controls.Add(this.lblNaslov);
            this.panel1.Controls.Add(this.pbSlikaKnjige);
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 551);
            this.panel1.TabIndex = 11;
            this.panel1.Click += new System.EventHandler(this.UCKnjigaPocetna_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoEllipsis = true;
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.White;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(26, 457);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.MaximumSize = new System.Drawing.Size(300, 60);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(64, 25);
            this.lblAutor.TabIndex = 14;
            this.lblAutor.Text = "label2";
            this.lblAutor.Click += new System.EventHandler(this.UCKnjigaPocetna_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoEllipsis = true;
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.White;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(26, 374);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslov.MaximumSize = new System.Drawing.Size(250, 90);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(85, 29);
            this.lblNaslov.TabIndex = 13;
            this.lblNaslov.Text = "label1";
            this.lblNaslov.Click += new System.EventHandler(this.UCKnjigaPocetna_Click);
            // 
            // pbSlikaKnjige
            // 
            this.pbSlikaKnjige.Location = new System.Drawing.Point(31, 32);
            this.pbSlikaKnjige.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbSlikaKnjige.Name = "pbSlikaKnjige";
            this.pbSlikaKnjige.Size = new System.Drawing.Size(271, 312);
            this.pbSlikaKnjige.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaKnjige.TabIndex = 12;
            this.pbSlikaKnjige.TabStop = false;
            this.pbSlikaKnjige.Click += new System.EventHandler(this.UCKnjigaPocetna_Click);
            // 
            // UCKnjigaPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCKnjigaPocetna";
            this.Size = new System.Drawing.Size(369, 591);
            this.Click += new System.EventHandler(this.UCKnjigaPocetna_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaKnjige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSlikaKnjige;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblNaslov;
    }
}
