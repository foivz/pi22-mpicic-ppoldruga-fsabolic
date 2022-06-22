namespace Bibly
{
    partial class FrmKatalogPrikazKnjige
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKatalogPrikazKnjige));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.naslov = new System.Windows.Forms.Label();
            this.pboxNaslovnica = new System.Windows.Forms.PictureBox();
            this.lblNaslovKnjige = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblIzdanje = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNaslovnica)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 426);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnRezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezerviraj.Location = new System.Drawing.Point(629, 511);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(110, 32);
            this.btnRezerviraj.TabIndex = 6;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = false;
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(308, 61);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(219, 46);
            this.naslov.TabIndex = 5;
            this.naslov.Text = "PREGLED";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboxNaslovnica
            // 
            this.pboxNaslovnica.Location = new System.Drawing.Point(32, 152);
            this.pboxNaslovnica.Name = "pboxNaslovnica";
            this.pboxNaslovnica.Size = new System.Drawing.Size(179, 215);
            this.pboxNaslovnica.TabIndex = 7;
            this.pboxNaslovnica.TabStop = false;
            // 
            // lblNaslovKnjige
            // 
            this.lblNaslovKnjige.AutoSize = true;
            this.lblNaslovKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovKnjige.Location = new System.Drawing.Point(232, 152);
            this.lblNaslovKnjige.Name = "lblNaslovKnjige";
            this.lblNaslovKnjige.Size = new System.Drawing.Size(114, 20);
            this.lblNaslovKnjige.TabIndex = 8;
            this.lblNaslovKnjige.Text = "Naslov knjige";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(232, 181);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(51, 20);
            this.lblAutor.TabIndex = 9;
            this.lblAutor.Text = "Autori";
            // 
            // lblIzdanje
            // 
            this.lblIzdanje.AutoSize = true;
            this.lblIzdanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzdanje.Location = new System.Drawing.Point(232, 210);
            this.lblIzdanje.Name = "lblIzdanje";
            this.lblIzdanje.Size = new System.Drawing.Size(61, 20);
            this.lblIzdanje.TabIndex = 10;
            this.lblIzdanje.Text = "Izdanje";
            // 
            // lblOpis
            // 
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(236, 245);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(568, 122);
            this.lblOpis.TabIndex = 11;
            this.lblOpis.Text = resources.GetString("lblOpis.Text");
            // 
            // FrmKatalogPrikazKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 681);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblIzdanje);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNaslovKnjige);
            this.Controls.Add(this.pboxNaslovnica);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmKatalogPrikazKnjige";
            this.Text = "Pregled knjige";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNaslovnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.PictureBox pboxNaslovnica;
        private System.Windows.Forms.Label lblNaslovKnjige;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblIzdanje;
        private System.Windows.Forms.Label lblOpis;
    }
}