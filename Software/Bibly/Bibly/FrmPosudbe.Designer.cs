namespace Bibly
{
    partial class FrmPosudbe
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
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(387, 80);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(224, 46);
            this.naslov.TabIndex = 1;
            this.naslov.Text = "POSUDBE";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 565);
            this.Controls.Add(this.naslov);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPosudbe";
            this.Text = "Bibly";
            this.Load += new System.EventHandler(this.FrmPosudbe_Load);
            this.Controls.SetChildIndex(this.naslov, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
    }
}