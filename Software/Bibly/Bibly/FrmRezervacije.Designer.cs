namespace Bibly
{
    partial class FrmRezervacije
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
            this.naslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblObavijest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(189, 68);
            this.naslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(307, 46);
            this.naslov.TabIndex = 1;
            this.naslov.Text = "REZERVACIJE";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trenutne rezervacije:";
            // 
            // lblObavijest
            // 
            this.lblObavijest.AutoSize = true;
            this.lblObavijest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObavijest.Location = new System.Drawing.Point(79, 210);
            this.lblObavijest.Name = "lblObavijest";
            this.lblObavijest.Size = new System.Drawing.Size(186, 13);
            this.lblObavijest.TabIndex = 3;
            this.lblObavijest.Text = "Trenutno nemate nikakve rezervacije.";
            this.lblObavijest.Visible = false;
            // 
            // FrmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(720, 584);
            this.Controls.Add(this.lblObavijest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naslov);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmRezervacije";
            this.Text = "Bibly";
            this.Load += new System.EventHandler(this.FrmRezervacije_Load);
            this.Controls.SetChildIndex(this.naslov, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblObavijest, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblObavijest;
    }
}