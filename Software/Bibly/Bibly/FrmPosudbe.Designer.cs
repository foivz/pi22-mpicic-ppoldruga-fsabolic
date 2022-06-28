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
            this.lblObavijest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObavijest2 = new System.Windows.Forms.Label();
            this.lblProslePosudbe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(217, 76);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(224, 46);
            this.naslov.TabIndex = 1;
            this.naslov.Text = "POSUDBE";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblObavijest
            // 
            this.lblObavijest.AutoSize = true;
            this.lblObavijest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObavijest.Location = new System.Drawing.Point(68, 200);
            this.lblObavijest.Name = "lblObavijest";
            this.lblObavijest.Size = new System.Drawing.Size(218, 13);
            this.lblObavijest.TabIndex = 6;
            this.lblObavijest.Text = "Trenutno nemate nikakve trenutne posudbe.";
            this.lblObavijest.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trenutne posudbe:";
            // 
            // lblObavijest2
            // 
            this.lblObavijest2.AutoSize = true;
            this.lblObavijest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObavijest2.Location = new System.Drawing.Point(68, 277);
            this.lblObavijest2.Name = "lblObavijest2";
            this.lblObavijest2.Size = new System.Drawing.Size(207, 13);
            this.lblObavijest2.TabIndex = 8;
            this.lblObavijest2.Text = "Trenutno nemate nikakve prošle posudbe.";
            this.lblObavijest2.Visible = false;
            // 
            // lblProslePosudbe
            // 
            this.lblProslePosudbe.AutoSize = true;
            this.lblProslePosudbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProslePosudbe.Location = new System.Drawing.Point(38, 242);
            this.lblProslePosudbe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProslePosudbe.Name = "lblProslePosudbe";
            this.lblProslePosudbe.Size = new System.Drawing.Size(138, 20);
            this.lblProslePosudbe.TabIndex = 7;
            this.lblProslePosudbe.Text = "Prošle posudbe:";
            this.lblProslePosudbe.Visible = false;
            // 
            // FrmPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(675, 565);
            this.Controls.Add(this.lblObavijest2);
            this.Controls.Add(this.lblProslePosudbe);
            this.Controls.Add(this.lblObavijest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.naslov);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPosudbe";
            this.Text = "Bibly";
            this.Load += new System.EventHandler(this.FrmPosudbe_Load);
            this.Controls.SetChildIndex(this.naslov, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblObavijest, 0);
            this.Controls.SetChildIndex(this.lblProslePosudbe, 0);
            this.Controls.SetChildIndex(this.lblObavijest2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Label lblObavijest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblObavijest2;
        private System.Windows.Forms.Label lblProslePosudbe;
    }
}