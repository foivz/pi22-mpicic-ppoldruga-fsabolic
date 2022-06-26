namespace Bibly
{
    partial class UCRezervacijeKnjiga
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRezervacija = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 250);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.White;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(244, 41);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(57, 20);
            this.lblNaslov.TabIndex = 11;
            this.lblNaslov.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblRezervacija);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 299);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rezervacija vrijedi do:";
            // 
            // lblRezervacija
            // 
            this.lblRezervacija.AutoSize = true;
            this.lblRezervacija.BackColor = System.Drawing.Color.White;
            this.lblRezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezervacija.Location = new System.Drawing.Point(403, 61);
            this.lblRezervacija.Name = "lblRezervacija";
            this.lblRezervacija.Size = new System.Drawing.Size(46, 17);
            this.lblRezervacija.TabIndex = 21;
            this.lblRezervacija.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(166)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(227, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 51);
            this.button1.TabIndex = 22;
            this.button1.Text = "Otkaži rezervaciju";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UCRezervacijeKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.panel1);
            this.Name = "UCRezervacijeKnjiga";
            this.Size = new System.Drawing.Size(614, 339);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRezervacija;
        private System.Windows.Forms.Label label2;
    }
}
