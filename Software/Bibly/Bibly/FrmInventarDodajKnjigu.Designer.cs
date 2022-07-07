namespace Bibly
{
    partial class FrmInventarDodajKnjigu
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
            this.btnSpremiKnjigu = new System.Windows.Forms.Button();
            this.pbNaslovnica = new System.Windows.Forms.PictureBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtBrojStranica = new System.Windows.Forms.TextBox();
            this.txtDatumIzdavanja = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cmbIzdavac = new System.Windows.Forms.ComboBox();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.btnDodajIzdavaca = new System.Windows.Forms.Button();
            this.btnDodajZanr = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.ucAutor1 = new Bibly.UCAutor();
            this.btnDodajAutora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbNaslovnica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremiKnjigu
            // 
            this.btnSpremiKnjigu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnSpremiKnjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiKnjigu.Location = new System.Drawing.Point(160, 190);
            this.btnSpremiKnjigu.Name = "btnSpremiKnjigu";
            this.btnSpremiKnjigu.Size = new System.Drawing.Size(214, 75);
            this.btnSpremiKnjigu.TabIndex = 1;
            this.btnSpremiKnjigu.Text = "Spremi knjigu";
            this.btnSpremiKnjigu.UseVisualStyleBackColor = false;
            this.btnSpremiKnjigu.Click += new System.EventHandler(this.btnSpremiKnjigu_Click);
            // 
            // pbNaslovnica
            // 
            this.pbNaslovnica.BackColor = System.Drawing.Color.Gray;
            this.pbNaslovnica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNaslovnica.Location = new System.Drawing.Point(51, 372);
            this.pbNaslovnica.Name = "pbNaslovnica";
            this.pbNaslovnica.Size = new System.Drawing.Size(425, 546);
            this.pbNaslovnica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNaslovnica.TabIndex = 3;
            this.pbNaslovnica.TabStop = false;
            this.pbNaslovnica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PostaviSliku);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(671, 73);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(469, 69);
            this.lblNaslov.TabIndex = 4;
            this.lblNaslov.Text = "DODAJ KNJIGU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(767, 230);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(492, 35);
            this.txtISBN.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(531, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datum izdavanja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(566, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Broj stranica:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 1075);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Žanr:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(657, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Opis:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(625, 974);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Izdavač:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Slika naslovnice:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(767, 309);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(492, 35);
            this.txtNaziv.TabIndex = 14;
            // 
            // txtBrojStranica
            // 
            this.txtBrojStranica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtBrojStranica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojStranica.Location = new System.Drawing.Point(767, 378);
            this.txtBrojStranica.Name = "txtBrojStranica";
            this.txtBrojStranica.Size = new System.Drawing.Size(492, 35);
            this.txtBrojStranica.TabIndex = 15;
            // 
            // txtDatumIzdavanja
            // 
            this.txtDatumIzdavanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtDatumIzdavanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumIzdavanja.Location = new System.Drawing.Point(767, 460);
            this.txtDatumIzdavanja.Name = "txtDatumIzdavanja";
            this.txtDatumIzdavanja.Size = new System.Drawing.Size(492, 35);
            this.txtDatumIzdavanja.TabIndex = 16;
            // 
            // txtOpis
            // 
            this.txtOpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(767, 545);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(894, 373);
            this.txtOpis.TabIndex = 17;
            // 
            // cmbIzdavac
            // 
            this.cmbIzdavac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzdavac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIzdavac.FormattingEnabled = true;
            this.cmbIzdavac.Location = new System.Drawing.Point(767, 971);
            this.cmbIzdavac.Name = "cmbIzdavac";
            this.cmbIzdavac.Size = new System.Drawing.Size(425, 37);
            this.cmbIzdavac.TabIndex = 18;
            // 
            // cmbZanr
            // 
            this.cmbZanr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(767, 1067);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(425, 37);
            this.cmbZanr.TabIndex = 19;
            // 
            // btnDodajIzdavaca
            // 
            this.btnDodajIzdavaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnDodajIzdavaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajIzdavaca.Location = new System.Drawing.Point(1359, 967);
            this.btnDodajIzdavaca.Name = "btnDodajIzdavaca";
            this.btnDodajIzdavaca.Size = new System.Drawing.Size(244, 41);
            this.btnDodajIzdavaca.TabIndex = 20;
            this.btnDodajIzdavaca.Text = "Dodaj izdavača";
            this.btnDodajIzdavaca.UseVisualStyleBackColor = false;
            this.btnDodajIzdavaca.Click += new System.EventHandler(this.btnDodajIzdavaca_Click);
            // 
            // btnDodajZanr
            // 
            this.btnDodajZanr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnDodajZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajZanr.Location = new System.Drawing.Point(1359, 1064);
            this.btnDodajZanr.Name = "btnDodajZanr";
            this.btnDodajZanr.Size = new System.Drawing.Size(244, 41);
            this.btnDodajZanr.TabIndex = 21;
            this.btnDodajZanr.Text = "Dodaj žanr";
            this.btnDodajZanr.UseVisualStyleBackColor = false;
            this.btnDodajZanr.Click += new System.EventHandler(this.btnDodajZanr_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(856, 1152);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(72, 54);
            this.btnPlus.TabIndex = 22;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(166)))));
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(1024, 1152);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(72, 54);
            this.btnMinus.TabIndex = 23;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // ucAutor1
            // 
            this.ucAutor1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucAutor1.Location = new System.Drawing.Point(662, 1254);
            this.ucAutor1.Name = "ucAutor1";
            this.ucAutor1.Size = new System.Drawing.Size(586, 66);
            this.ucAutor1.TabIndex = 24;
            // 
            // btnDodajAutora
            // 
            this.btnDodajAutora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnDodajAutora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajAutora.Location = new System.Drawing.Point(1359, 1254);
            this.btnDodajAutora.Name = "btnDodajAutora";
            this.btnDodajAutora.Size = new System.Drawing.Size(244, 41);
            this.btnDodajAutora.TabIndex = 25;
            this.btnDodajAutora.Text = "Dodaj autora";
            this.btnDodajAutora.UseVisualStyleBackColor = false;
            this.btnDodajAutora.Click += new System.EventHandler(this.btnDodajAutora_Click);
            // 
            // FrmInventarDodajKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(30, 30);
            this.ClientSize = new System.Drawing.Size(1724, 1482);
            this.Controls.Add(this.btnDodajAutora);
            this.Controls.Add(this.ucAutor1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDodajZanr);
            this.Controls.Add(this.btnDodajIzdavaca);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.cmbIzdavac);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtDatumIzdavanja);
            this.Controls.Add(this.txtBrojStranica);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.pbNaslovnica);
            this.Controls.Add(this.btnSpremiKnjigu);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmInventarDodajKnjigu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInventarDodajKnjigu";
            this.Load += new System.EventHandler(this.FrmInventarDodajKnjigu_Load);
            this.Controls.SetChildIndex(this.btnSpremiKnjigu, 0);
            this.Controls.SetChildIndex(this.pbNaslovnica, 0);
            this.Controls.SetChildIndex(this.lblNaslov, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtISBN, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtNaziv, 0);
            this.Controls.SetChildIndex(this.txtBrojStranica, 0);
            this.Controls.SetChildIndex(this.txtDatumIzdavanja, 0);
            this.Controls.SetChildIndex(this.txtOpis, 0);
            this.Controls.SetChildIndex(this.cmbIzdavac, 0);
            this.Controls.SetChildIndex(this.cmbZanr, 0);
            this.Controls.SetChildIndex(this.btnDodajIzdavaca, 0);
            this.Controls.SetChildIndex(this.btnDodajZanr, 0);
            this.Controls.SetChildIndex(this.btnPlus, 0);
            this.Controls.SetChildIndex(this.btnMinus, 0);
            this.Controls.SetChildIndex(this.ucAutor1, 0);
            this.Controls.SetChildIndex(this.btnDodajAutora, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbNaslovnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremiKnjigu;
        private System.Windows.Forms.PictureBox pbNaslovnica;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtBrojStranica;
        private System.Windows.Forms.TextBox txtDatumIzdavanja;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ComboBox cmbIzdavac;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.Button btnDodajIzdavaca;
        private System.Windows.Forms.Button btnDodajZanr;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private UCAutor ucAutor1;
        private System.Windows.Forms.Button btnDodajAutora;
    }
}