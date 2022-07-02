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
            this.cmbKriteriji = new System.Windows.Forms.ComboBox();
            this.txtUnosKljucneRijeci = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(482, 81);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(215, 46);
            this.naslov.TabIndex = 0;
            this.naslov.Text = "KATALOG";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbKriteriji
            // 
            this.cmbKriteriji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKriteriji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKriteriji.FormattingEnabled = true;
            this.cmbKriteriji.Items.AddRange(new object[] {
            "Autor",
            "Izdavač",
            "Naslov knjige",
            "Žanr"});
            this.cmbKriteriji.Location = new System.Drawing.Point(331, 167);
            this.cmbKriteriji.Name = "cmbKriteriji";
            this.cmbKriteriji.Size = new System.Drawing.Size(174, 28);
            this.cmbKriteriji.TabIndex = 2;
            // 
            // txtUnosKljucneRijeci
            // 
            this.txtUnosKljucneRijeci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtUnosKljucneRijeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnosKljucneRijeci.Location = new System.Drawing.Point(511, 169);
            this.txtUnosKljucneRijeci.Name = "txtUnosKljucneRijeci";
            this.txtUnosKljucneRijeci.Size = new System.Drawing.Size(201, 26);
            this.txtUnosKljucneRijeci.TabIndex = 3;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.AutoSize = true;
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(718, 166);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(110, 32);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretaži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // FrmKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1172, 622);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtUnosKljucneRijeci);
            this.Controls.Add(this.cmbKriteriji);
            this.Controls.Add(this.naslov);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmKatalog";
            this.Text = "Katalog knjiga";
            this.Load += new System.EventHandler(this.FrmKatalog_Load);
            this.Controls.SetChildIndex(this.naslov, 0);
            this.Controls.SetChildIndex(this.cmbKriteriji, 0);
            this.Controls.SetChildIndex(this.txtUnosKljucneRijeci, 0);
            this.Controls.SetChildIndex(this.btnPretrazi, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.ComboBox cmbKriteriji;
        private System.Windows.Forms.TextBox txtUnosKljucneRijeci;
        private System.Windows.Forms.Button btnPretrazi;
    }
}