﻿namespace Bibly
{
    partial class FrmPromijeniLozinku
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStaraLozinka = new System.Windows.Forms.TextBox();
            this.btnSpremiLozinku = new System.Windows.Forms.Button();
            this.lblPotvrdaLozinke = new System.Windows.Forms.Label();
            this.txtNovaLozinka = new System.Windows.Forms.TextBox();
            this.lblNovaLozinka = new System.Windows.Forms.Label();
            this.lblStaraLozinka = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.txtPotvrdaLozinke = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtStaraLozinka);
            this.panel1.Controls.Add(this.btnSpremiLozinku);
            this.panel1.Controls.Add(this.lblPotvrdaLozinke);
            this.panel1.Controls.Add(this.txtNovaLozinka);
            this.panel1.Controls.Add(this.lblNovaLozinka);
            this.panel1.Controls.Add(this.lblStaraLozinka);
            this.panel1.Controls.Add(this.lblNaslov);
            this.panel1.Controls.Add(this.txtPotvrdaLozinke);
            this.panel1.Location = new System.Drawing.Point(53, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 546);
            this.panel1.TabIndex = 1;
            // 
            // txtStaraLozinka
            // 
            this.txtStaraLozinka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtStaraLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaraLozinka.Location = new System.Drawing.Point(201, 169);
            this.txtStaraLozinka.Name = "txtStaraLozinka";
            this.txtStaraLozinka.PasswordChar = '*';
            this.txtStaraLozinka.Size = new System.Drawing.Size(217, 22);
            this.txtStaraLozinka.TabIndex = 7;
            this.txtStaraLozinka.TextChanged += new System.EventHandler(this.txtStaraLozinka_TextChanged);
            // 
            // btnSpremiLozinku
            // 
            this.btnSpremiLozinku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnSpremiLozinku.Enabled = false;
            this.btnSpremiLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiLozinku.Location = new System.Drawing.Point(148, 407);
            this.btnSpremiLozinku.Name = "btnSpremiLozinku";
            this.btnSpremiLozinku.Size = new System.Drawing.Size(159, 39);
            this.btnSpremiLozinku.TabIndex = 4;
            this.btnSpremiLozinku.Text = "Spremi lozinku";
            this.btnSpremiLozinku.UseVisualStyleBackColor = false;
            this.btnSpremiLozinku.Click += new System.EventHandler(this.btnSpremiLozinku_Click);
            // 
            // lblPotvrdaLozinke
            // 
            this.lblPotvrdaLozinke.AutoSize = true;
            this.lblPotvrdaLozinke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotvrdaLozinke.Location = new System.Drawing.Point(32, 299);
            this.lblPotvrdaLozinke.Name = "lblPotvrdaLozinke";
            this.lblPotvrdaLozinke.Size = new System.Drawing.Size(135, 18);
            this.lblPotvrdaLozinke.TabIndex = 3;
            this.lblPotvrdaLozinke.Text = "Potvrda lozinke: ";
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtNovaLozinka.Enabled = false;
            this.txtNovaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaLozinka.Location = new System.Drawing.Point(201, 255);
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.PasswordChar = '*';
            this.txtNovaLozinka.Size = new System.Drawing.Size(217, 22);
            this.txtNovaLozinka.TabIndex = 6;
            // 
            // lblNovaLozinka
            // 
            this.lblNovaLozinka.AutoSize = true;
            this.lblNovaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaLozinka.Location = new System.Drawing.Point(51, 259);
            this.lblNovaLozinka.Name = "lblNovaLozinka";
            this.lblNovaLozinka.Size = new System.Drawing.Size(116, 18);
            this.lblNovaLozinka.TabIndex = 2;
            this.lblNovaLozinka.Text = "Nova lozinka: ";
            // 
            // lblStaraLozinka
            // 
            this.lblStaraLozinka.AutoSize = true;
            this.lblStaraLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaraLozinka.Location = new System.Drawing.Point(50, 173);
            this.lblStaraLozinka.Name = "lblStaraLozinka";
            this.lblStaraLozinka.Size = new System.Drawing.Size(117, 18);
            this.lblStaraLozinka.TabIndex = 1;
            this.lblStaraLozinka.Text = "Stara lozinka: ";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(89, 99);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(289, 31);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "PROMJENA LOZINKE";
            // 
            // txtPotvrdaLozinke
            // 
            this.txtPotvrdaLozinke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtPotvrdaLozinke.Enabled = false;
            this.txtPotvrdaLozinke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPotvrdaLozinke.Location = new System.Drawing.Point(201, 298);
            this.txtPotvrdaLozinke.Name = "txtPotvrdaLozinke";
            this.txtPotvrdaLozinke.PasswordChar = '*';
            this.txtPotvrdaLozinke.Size = new System.Drawing.Size(217, 22);
            this.txtPotvrdaLozinke.TabIndex = 5;
            // 
            // FrmPromijeniLozinku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 653);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPromijeniLozinku";
            this.Text = "FrmPromijeniLozinku";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStaraLozinka;
        private System.Windows.Forms.TextBox txtNovaLozinka;
        private System.Windows.Forms.TextBox txtPotvrdaLozinke;
        private System.Windows.Forms.Button btnSpremiLozinku;
        private System.Windows.Forms.Label lblPotvrdaLozinke;
        private System.Windows.Forms.Label lblNovaLozinka;
        private System.Windows.Forms.Label lblStaraLozinka;
        private System.Windows.Forms.Label lblNaslov;
    }
}