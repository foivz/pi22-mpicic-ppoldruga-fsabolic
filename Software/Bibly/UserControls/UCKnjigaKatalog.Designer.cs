namespace UserControls
{
    partial class UCKnjigaKatalog
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
            this.picSlikaKnjige = new System.Windows.Forms.PictureBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblBrojStranica = new System.Windows.Forms.Label();
            this.lblOpisKnjige = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSlikaKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // picSlikaKnjige
            // 
            this.picSlikaKnjige.Location = new System.Drawing.Point(25, 26);
            this.picSlikaKnjige.Name = "picSlikaKnjige";
            this.picSlikaKnjige.Size = new System.Drawing.Size(218, 307);
            this.picSlikaKnjige.TabIndex = 0;
            this.picSlikaKnjige.TabStop = false;
            this.picSlikaKnjige.Click += new System.EventHandler(this.picSlikaKnjige_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(262, 26);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(57, 20);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "label1";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(262, 56);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(51, 20);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "label2";
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzdavac.Location = new System.Drawing.Point(262, 88);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(51, 20);
            this.lblIzdavac.TabIndex = 3;
            this.lblIzdavac.Text = "label3";
            // 
            // lblBrojStranica
            // 
            this.lblBrojStranica.AutoSize = true;
            this.lblBrojStranica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojStranica.Location = new System.Drawing.Point(262, 121);
            this.lblBrojStranica.Name = "lblBrojStranica";
            this.lblBrojStranica.Size = new System.Drawing.Size(51, 20);
            this.lblBrojStranica.TabIndex = 4;
            this.lblBrojStranica.Text = "label4";
            // 
            // lblOpisKnjige
            // 
            this.lblOpisKnjige.AutoSize = true;
            this.lblOpisKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpisKnjige.Location = new System.Drawing.Point(262, 152);
            this.lblOpisKnjige.Name = "lblOpisKnjige";
            this.lblOpisKnjige.Size = new System.Drawing.Size(51, 20);
            this.lblOpisKnjige.TabIndex = 5;
            this.lblOpisKnjige.Text = "label4";
            // 
            // UCKnjigaKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOpisKnjige);
            this.Controls.Add(this.lblBrojStranica);
            this.Controls.Add(this.lblIzdavac);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.picSlikaKnjige);
            this.Name = "UCKnjigaKatalog";
            this.Size = new System.Drawing.Size(757, 366);
            this.Load += new System.EventHandler(this.UCKnjigaKatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSlikaKnjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSlikaKnjige;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblBrojStranica;
        private System.Windows.Forms.Label lblOpisKnjige;
    }
}
