namespace Bibly
{
    partial class FrmUpravljanjePosudbama
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
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.ucSkener1 = new Bibly.UCSkener();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.cmbPrimjerak = new System.Windows.Forms.ComboBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBrojProduljivanja = new System.Windows.Forms.Label();
            this.lblZakasnina = new System.Windows.Forms.Label();
            this.lblVrijediDo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPodNaslov = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(237, 79);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(605, 46);
            this.naslov.TabIndex = 6;
            this.naslov.Text = "UPRAVLJANJE  POSUDBAMA";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnRezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezerviraj.Location = new System.Drawing.Point(871, 352);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(127, 32);
            this.btnRezerviraj.TabIndex = 22;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = false;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // ucSkener1
            // 
            this.ucSkener1.BackColor = System.Drawing.Color.White;
            this.ucSkener1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucSkener1.Location = new System.Drawing.Point(47, 182);
            this.ucSkener1.Name = "ucSkener1";
            this.ucSkener1.Size = new System.Drawing.Size(384, 491);
            this.ucSkener1.TabIndex = 27;
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(577, 280);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(421, 28);
            this.cmbKorisnik.TabIndex = 30;
            // 
            // cmbPrimjerak
            // 
            this.cmbPrimjerak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrimjerak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrimjerak.FormattingEnabled = true;
            this.cmbPrimjerak.Location = new System.Drawing.Point(577, 230);
            this.cmbPrimjerak.Name = "cmbPrimjerak";
            this.cmbPrimjerak.Size = new System.Drawing.Size(421, 28);
            this.cmbPrimjerak.TabIndex = 31;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.White;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(480, 233);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(88, 20);
            this.lblNaslov.TabIndex = 32;
            this.lblNaslov.Text = "Primjerak:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Korisnik:";
            // 
            // btnPosudi
            // 
            this.btnPosudi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnPosudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosudi.Location = new System.Drawing.Point(577, 352);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(127, 32);
            this.btnPosudi.TabIndex = 34;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = false;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnVrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVrati.Location = new System.Drawing.Point(724, 352);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(127, 32);
            this.btnVrati.TabIndex = 35;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = false;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(458, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 233);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblBrojProduljivanja);
            this.panel2.Controls.Add(this.lblZakasnina);
            this.panel2.Controls.Add(this.lblVrijediDo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblPodNaslov);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(458, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 232);
            this.panel2.TabIndex = 37;
            // 
            // lblBrojProduljivanja
            // 
            this.lblBrojProduljivanja.AutoSize = true;
            this.lblBrojProduljivanja.BackColor = System.Drawing.Color.White;
            this.lblBrojProduljivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojProduljivanja.Location = new System.Drawing.Point(207, 176);
            this.lblBrojProduljivanja.Name = "lblBrojProduljivanja";
            this.lblBrojProduljivanja.Size = new System.Drawing.Size(18, 20);
            this.lblBrojProduljivanja.TabIndex = 44;
            this.lblBrojProduljivanja.Text = "0";
            // 
            // lblZakasnina
            // 
            this.lblZakasnina.AutoSize = true;
            this.lblZakasnina.BackColor = System.Drawing.Color.White;
            this.lblZakasnina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZakasnina.Location = new System.Drawing.Point(153, 131);
            this.lblZakasnina.Name = "lblZakasnina";
            this.lblZakasnina.Size = new System.Drawing.Size(78, 20);
            this.lblZakasnina.TabIndex = 43;
            this.lblZakasnina.Text = "0.00 HRK";
            // 
            // lblVrijediDo
            // 
            this.lblVrijediDo.AutoSize = true;
            this.lblVrijediDo.BackColor = System.Drawing.Color.White;
            this.lblVrijediDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijediDo.Location = new System.Drawing.Point(139, 86);
            this.lblVrijediDo.Name = "lblVrijediDo";
            this.lblVrijediDo.Size = new System.Drawing.Size(54, 20);
            this.lblVrijediDo.TabIndex = 42;
            this.lblVrijediDo.Text = "datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Broj produljivanja:";
            // 
            // lblPodNaslov
            // 
            this.lblPodNaslov.AutoSize = true;
            this.lblPodNaslov.BackColor = System.Drawing.Color.White;
            this.lblPodNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodNaslov.ForeColor = System.Drawing.Color.Black;
            this.lblPodNaslov.Location = new System.Drawing.Point(22, 26);
            this.lblPodNaslov.Name = "lblPodNaslov";
            this.lblPodNaslov.Size = new System.Drawing.Size(195, 26);
            this.lblPodNaslov.TabIndex = 40;
            this.lblPodNaslov.Text = "Podaci o posudbi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Zakasnina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Vrijedi do:";
            // 
            // FrmUpravljanjePosudbama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1117, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.cmbPrimjerak);
            this.Controls.Add(this.cmbKorisnik);
            this.Controls.Add(this.ucSkener1);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmUpravljanjePosudbama";
            this.Text = "FrmUpravljanjePosudbama";
            this.Load += new System.EventHandler(this.FrmUpravljanjePosudbama_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.naslov, 0);
            this.Controls.SetChildIndex(this.btnRezerviraj, 0);
            this.Controls.SetChildIndex(this.ucSkener1, 0);
            this.Controls.SetChildIndex(this.cmbKorisnik, 0);
            this.Controls.SetChildIndex(this.cmbPrimjerak, 0);
            this.Controls.SetChildIndex(this.lblNaslov, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnPosudi, 0);
            this.Controls.SetChildIndex(this.btnVrati, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Button btnRezerviraj;
        private UCSkener ucSkener1;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.ComboBox cmbPrimjerak;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPodNaslov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrojProduljivanja;
        private System.Windows.Forms.Label lblZakasnina;
        private System.Windows.Forms.Label lblVrijediDo;
    }
}