namespace Bibly
{
    partial class FrmPrijava
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUclanjivanje = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPrijava = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUclanjivanje);
            this.panel1.Controls.Add(this.btnPrijava);
            this.panel1.Controls.Add(this.txtLozinka);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblLozinka);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblPrijava);
            this.panel1.Location = new System.Drawing.Point(107, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 363);
            this.panel1.TabIndex = 1;
            // 
            // lblUclanjivanje
            // 
            this.lblUclanjivanje.AutoSize = true;
            this.lblUclanjivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUclanjivanje.Location = new System.Drawing.Point(166, 292);
            this.lblUclanjivanje.Name = "lblUclanjivanje";
            this.lblUclanjivanje.Size = new System.Drawing.Size(120, 18);
            this.lblUclanjivanje.TabIndex = 6;
            this.lblUclanjivanje.Text = "Kako se učlaniti?";
            this.lblUclanjivanje.MouseLeave += new System.EventHandler(this.lblUclanjivanje_MouseLeave);
            this.lblUclanjivanje.MouseHover += new System.EventHandler(this.lblUclanjivanje_MouseHover);
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(178, 256);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(94, 33);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            // 
            // txtLozinka
            // 
            this.txtLozinka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.Location = new System.Drawing.Point(115, 174);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(219, 24);
            this.txtLozinka.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(115, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.Location = new System.Drawing.Point(28, 176);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(81, 20);
            this.lblLozinka.TabIndex = 2;
            this.lblLozinka.Text = "Lozinka: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 112);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail: ";
            // 
            // lblPrijava
            // 
            this.lblPrijava.AutoSize = true;
            this.lblPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblPrijava.Location = new System.Drawing.Point(152, 24);
            this.lblPrijava.Name = "lblPrijava";
            this.lblPrijava.Size = new System.Drawing.Size(142, 46);
            this.lblPrijava.TabIndex = 0;
            this.lblPrijava.Text = "Prijava";
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 497);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPrijava";
            this.Text = "Prijava";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrijava;
        private System.Windows.Forms.Label lblUclanjivanje;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblEmail;
    }
}