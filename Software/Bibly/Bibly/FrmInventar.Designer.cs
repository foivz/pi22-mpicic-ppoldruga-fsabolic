namespace Bibly
{
    partial class FrmInventar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.dgvInventar = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPregledajKnjigu = new System.Windows.Forms.Button();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(592, 82);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(659, 69);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "INVENTAR KNJIŽNICE";
            // 
            // dgvInventar
            // 
            this.dgvInventar.AllowUserToAddRows = false;
            this.dgvInventar.AllowUserToDeleteRows = false;
            this.dgvInventar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventar.Location = new System.Drawing.Point(105, 297);
            this.dgvInventar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInventar.Name = "dgvInventar";
            this.dgvInventar.ReadOnly = true;
            this.dgvInventar.RowHeadersWidth = 62;
            this.dgvInventar.RowTemplate.Height = 35;
            this.dgvInventar.Size = new System.Drawing.Size(1628, 604);
            this.dgvInventar.TabIndex = 4;
            this.dgvInventar.SelectionChanged += new System.EventHandler(this.dgvInventar_SelectionChanged);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(166)))));
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(1510, 940);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(223, 52);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPregledajKnjigu
            // 
            this.btnPregledajKnjigu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnPregledajKnjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledajKnjigu.Location = new System.Drawing.Point(743, 940);
            this.btnPregledajKnjigu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPregledajKnjigu.Name = "btnPregledajKnjigu";
            this.btnPregledajKnjigu.Size = new System.Drawing.Size(223, 52);
            this.btnPregledajKnjigu.TabIndex = 11;
            this.btnPregledajKnjigu.Text = "Pregledaj knjigu";
            this.btnPregledajKnjigu.UseVisualStyleBackColor = false;
            this.btnPregledajKnjigu.Click += new System.EventHandler(this.btnPregledajKnjigu_Click);
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnDodajKnjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKnjigu.Location = new System.Drawing.Point(1002, 940);
            this.btnDodajKnjigu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(223, 52);
            this.btnDodajKnjigu.TabIndex = 12;
            this.btnDodajKnjigu.Text = "Dodaj knjigu";
            this.btnDodajKnjigu.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1259, 940);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ažuriraj knjigu";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrmInventar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1850, 1106);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDodajKnjigu);
            this.Controls.Add(this.btnPregledajKnjigu);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvInventar);
            this.Controls.Add(this.lblNaslov);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmInventar";
            this.Text = "FrmInventar";
            this.Controls.SetChildIndex(this.lblNaslov, 0);
            this.Controls.SetChildIndex(this.dgvInventar, 0);
            this.Controls.SetChildIndex(this.btnObrisi, 0);
            this.Controls.SetChildIndex(this.btnPregledajKnjigu, 0);
            this.Controls.SetChildIndex(this.btnDodajKnjigu, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.DataGridView dgvInventar;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPregledajKnjigu;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.Button button2;
    }
}