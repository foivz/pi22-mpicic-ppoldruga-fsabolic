namespace Bibly
{
    partial class FrmPregledPosudbi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtUnosKljucneRijeci = new System.Windows.Forms.TextBox();
            this.cmbKriteriji = new System.Windows.Forms.ComboBox();
            this.naslov = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvPosudbe = new System.Windows.Forms.DataGridView();
            this.cmbPrikazi = new System.Windows.Forms.ComboBox();
            this.btnProdulji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.AutoSize = true;
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(1092, 142);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(110, 32);
            this.btnPretrazi.TabIndex = 8;
            this.btnPretrazi.Text = "Pretaži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtUnosKljucneRijeci
            // 
            this.txtUnosKljucneRijeci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtUnosKljucneRijeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnosKljucneRijeci.Location = new System.Drawing.Point(885, 145);
            this.txtUnosKljucneRijeci.Name = "txtUnosKljucneRijeci";
            this.txtUnosKljucneRijeci.Size = new System.Drawing.Size(201, 26);
            this.txtUnosKljucneRijeci.TabIndex = 7;
            // 
            // cmbKriteriji
            // 
            this.cmbKriteriji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKriteriji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKriteriji.FormattingEnabled = true;
            this.cmbKriteriji.Items.AddRange(new object[] {
            "Ime i prezime korisnika",
            "Id primjeraka",
            "Naziv knjige"});
            this.cmbKriteriji.Location = new System.Drawing.Point(705, 145);
            this.cmbKriteriji.Name = "cmbKriteriji";
            this.cmbKriteriji.Size = new System.Drawing.Size(174, 28);
            this.cmbKriteriji.TabIndex = 6;
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(413, 53);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(430, 46);
            this.naslov.TabIndex = 5;
            this.naslov.Text = "PREGLED  POSUDBI";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.AutoSize = true;
            this.btnPrikazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.Location = new System.Drawing.Point(214, 143);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(121, 32);
            this.btnPrikazi.TabIndex = 11;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvPosudbe
            // 
            this.dgvPosudbe.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosudbe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPosudbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPosudbe.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPosudbe.GridColor = System.Drawing.Color.White;
            this.dgvPosudbe.Location = new System.Drawing.Point(34, 196);
            this.dgvPosudbe.Name = "dgvPosudbe";
            this.dgvPosudbe.RowTemplate.Height = 35;
            this.dgvPosudbe.Size = new System.Drawing.Size(1168, 418);
            this.dgvPosudbe.TabIndex = 12;
            // 
            // cmbPrikazi
            // 
            this.cmbPrikazi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrikazi.FormattingEnabled = true;
            this.cmbPrikazi.Items.AddRange(new object[] {
            "Sve",
            "Posudbe",
            "Rezervacije",
            "Posudbe sa zakasninom"});
            this.cmbPrikazi.Location = new System.Drawing.Point(34, 145);
            this.cmbPrikazi.Name = "cmbPrikazi";
            this.cmbPrikazi.Size = new System.Drawing.Size(174, 28);
            this.cmbPrikazi.TabIndex = 13;
            // 
            // btnProdulji
            // 
            this.btnProdulji.AutoSize = true;
            this.btnProdulji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnProdulji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdulji.Location = new System.Drawing.Point(1092, 632);
            this.btnProdulji.Name = "btnProdulji";
            this.btnProdulji.Size = new System.Drawing.Size(110, 32);
            this.btnProdulji.TabIndex = 14;
            this.btnProdulji.Text = "Produlji";
            this.btnProdulji.UseVisualStyleBackColor = false;
            this.btnProdulji.Click += new System.EventHandler(this.btnProdulji_Click);
            // 
            // FrmPregledPosudbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 687);
            this.Controls.Add(this.btnProdulji);
            this.Controls.Add(this.cmbPrikazi);
            this.Controls.Add(this.dgvPosudbe);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtUnosKljucneRijeci);
            this.Controls.Add(this.cmbKriteriji);
            this.Controls.Add(this.naslov);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPregledPosudbi";
            this.Text = "FrmPregledPosudbi";
            this.Load += new System.EventHandler(this.FrmPregledPosudbi_Load);
            this.Controls.SetChildIndex(this.naslov, 0);
            this.Controls.SetChildIndex(this.cmbKriteriji, 0);
            this.Controls.SetChildIndex(this.txtUnosKljucneRijeci, 0);
            this.Controls.SetChildIndex(this.btnPretrazi, 0);
            this.Controls.SetChildIndex(this.btnPrikazi, 0);
            this.Controls.SetChildIndex(this.dgvPosudbe, 0);
            this.Controls.SetChildIndex(this.cmbPrikazi, 0);
            this.Controls.SetChildIndex(this.btnProdulji, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtUnosKljucneRijeci;
        private System.Windows.Forms.ComboBox cmbKriteriji;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dgvPosudbe;
        private System.Windows.Forms.ComboBox cmbPrikazi;
        private System.Windows.Forms.Button btnProdulji;
    }
}