namespace Bibly
{
    partial class FrmKatalog
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
            this.cboxKriteriji = new System.Windows.Forms.ComboBox();
            this.tboxUnosKljucneRijeci = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(433, 81);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(215, 46);
            this.naslov.TabIndex = 0;
            this.naslov.Text = "KATALOG";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxKriteriji
            // 
            this.cboxKriteriji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxKriteriji.FormattingEnabled = true;
            this.cboxKriteriji.Location = new System.Drawing.Point(282, 167);
            this.cboxKriteriji.Name = "cboxKriteriji";
            this.cboxKriteriji.Size = new System.Drawing.Size(174, 28);
            this.cboxKriteriji.TabIndex = 2;
            this.cboxKriteriji.Text = "Kriterij pretraživanja";
            // 
            // tboxUnosKljucneRijeci
            // 
            this.tboxUnosKljucneRijeci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.tboxUnosKljucneRijeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUnosKljucneRijeci.Location = new System.Drawing.Point(462, 169);
            this.tboxUnosKljucneRijeci.Name = "tboxUnosKljucneRijeci";
            this.tboxUnosKljucneRijeci.Size = new System.Drawing.Size(201, 26);
            this.tboxUnosKljucneRijeci.TabIndex = 3;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(669, 166);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(110, 32);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretaži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            // 
            // FrmKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1049, 622);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.tboxUnosKljucneRijeci);
            this.Controls.Add(this.cboxKriteriji);
            this.Controls.Add(this.naslov);
            this.Name = "FrmKatalog";
            this.Text = "Katalog knjiga";
            this.Load += new System.EventHandler(this.FrmKatalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.ComboBox cboxKriteriji;
        private System.Windows.Forms.TextBox tboxUnosKljucneRijeci;
        private System.Windows.Forms.Button btnPretrazi;
    }
}