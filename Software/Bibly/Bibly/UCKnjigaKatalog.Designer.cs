namespace Bibly
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblBrojStranica = new System.Windows.Forms.Label();
            this.lblOpisKnjige = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(228, 53);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(57, 20);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "label1";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(228, 84);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(51, 20);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "label2";
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzdavac.Location = new System.Drawing.Point(228, 113);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(46, 17);
            this.lblIzdavac.TabIndex = 2;
            this.lblIzdavac.Text = "label3";
            // 
            // lblBrojStranica
            // 
            this.lblBrojStranica.AutoSize = true;
            this.lblBrojStranica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojStranica.Location = new System.Drawing.Point(228, 143);
            this.lblBrojStranica.Name = "lblBrojStranica";
            this.lblBrojStranica.Size = new System.Drawing.Size(46, 17);
            this.lblBrojStranica.TabIndex = 3;
            this.lblBrojStranica.Text = "label4";
            // 
            // lblOpisKnjige
            // 
            this.lblOpisKnjige.AutoSize = true;
            this.lblOpisKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpisKnjige.Location = new System.Drawing.Point(228, 172);
            this.lblOpisKnjige.Name = "lblOpisKnjige";
            this.lblOpisKnjige.Size = new System.Drawing.Size(46, 17);
            this.lblOpisKnjige.TabIndex = 4;
            this.lblOpisKnjige.Text = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 250);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UCKnjigaKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOpisKnjige);
            this.Controls.Add(this.lblBrojStranica);
            this.Controls.Add(this.lblIzdavac);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNaslov);
            this.Name = "UCKnjigaKatalog";
            this.Size = new System.Drawing.Size(637, 365);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblBrojStranica;
        private System.Windows.Forms.Label lblOpisKnjige;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
