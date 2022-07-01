namespace Bibly
{
    partial class FrmProfil
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
            this.components = new System.ComponentModel.Container();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblBrojMobitela = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPrebivaliste = new System.Windows.Forms.Label();
            this.lblAdresaPrebivalista = new System.Windows.Forms.Label();
            this.lblBoraviste = new System.Windows.Forms.Label();
            this.lblAdresaBoravista = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDatumUclanjivanja = new System.Windows.Forms.Label();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.lblPromijeniLozinku = new System.Windows.Forms.Label();
            this.lblTipKorisnika = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtBrojMobitela = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresaPrebivalista = new System.Windows.Forms.TextBox();
            this.txtAdresaBoravista = new System.Windows.Forms.TextBox();
            this.txtDatumUclanjivanja = new System.Windows.Forms.TextBox();
            this.txtIstekClanarine = new System.Windows.Forms.TextBox();
            this.txtTipKorisnika = new System.Windows.Forms.TextBox();
            this.cmbPrebivaliste = new System.Windows.Forms.ComboBox();
            this.cmbBoraviste = new System.Windows.Forms.ComboBox();
            this.lblUspjeh = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(258, 52);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(163, 46);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "PROFIL";
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOIB.Location = new System.Drawing.Point(204, 170);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(45, 20);
            this.lblOIB.TabIndex = 2;
            this.lblOIB.Text = "OIB:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(205, 218);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(44, 20);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(166, 266);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(83, 20);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime: ";
            // 
            // lblBrojMobitela
            // 
            this.lblBrojMobitela.AutoSize = true;
            this.lblBrojMobitela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojMobitela.Location = new System.Drawing.Point(125, 314);
            this.lblBrojMobitela.Name = "lblBrojMobitela";
            this.lblBrojMobitela.Size = new System.Drawing.Size(124, 20);
            this.lblBrojMobitela.TabIndex = 5;
            this.lblBrojMobitela.Text = "Broj mobitela: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(180, 362);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail: ";
            // 
            // lblPrebivaliste
            // 
            this.lblPrebivaliste.AutoSize = true;
            this.lblPrebivaliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrebivaliste.Location = new System.Drawing.Point(138, 410);
            this.lblPrebivaliste.Name = "lblPrebivaliste";
            this.lblPrebivaliste.Size = new System.Drawing.Size(111, 20);
            this.lblPrebivaliste.TabIndex = 7;
            this.lblPrebivaliste.Text = "Prebivalište: ";
            // 
            // lblAdresaPrebivalista
            // 
            this.lblAdresaPrebivalista.AutoSize = true;
            this.lblAdresaPrebivalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresaPrebivalista.Location = new System.Drawing.Point(77, 458);
            this.lblAdresaPrebivalista.Name = "lblAdresaPrebivalista";
            this.lblAdresaPrebivalista.Size = new System.Drawing.Size(172, 20);
            this.lblAdresaPrebivalista.TabIndex = 8;
            this.lblAdresaPrebivalista.Text = "Adresa prebivališta: ";
            // 
            // lblBoraviste
            // 
            this.lblBoraviste.AutoSize = true;
            this.lblBoraviste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoraviste.Location = new System.Drawing.Point(155, 500);
            this.lblBoraviste.Name = "lblBoraviste";
            this.lblBoraviste.Size = new System.Drawing.Size(94, 20);
            this.lblBoraviste.TabIndex = 9;
            this.lblBoraviste.Text = "Boravište: ";
            // 
            // lblAdresaBoravista
            // 
            this.lblAdresaBoravista.AutoSize = true;
            this.lblAdresaBoravista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresaBoravista.Location = new System.Drawing.Point(95, 548);
            this.lblAdresaBoravista.Name = "lblAdresaBoravista";
            this.lblAdresaBoravista.Size = new System.Drawing.Size(154, 20);
            this.lblAdresaBoravista.TabIndex = 10;
            this.lblAdresaBoravista.Text = "Adresa boravišta: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(112, 644);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Istek članarine: ";
            // 
            // lblDatumUclanjivanja
            // 
            this.lblDatumUclanjivanja.AutoSize = true;
            this.lblDatumUclanjivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumUclanjivanja.Location = new System.Drawing.Point(79, 596);
            this.lblDatumUclanjivanja.Name = "lblDatumUclanjivanja";
            this.lblDatumUclanjivanja.Size = new System.Drawing.Size(170, 20);
            this.lblDatumUclanjivanja.TabIndex = 11;
            this.lblDatumUclanjivanja.Text = "Datum učlanjivanja: ";
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnSpremiPromjene.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiPromjene.Location = new System.Drawing.Point(252, 763);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(169, 33);
            this.btnSpremiPromjene.TabIndex = 13;
            this.btnSpremiPromjene.Text = "Spremi promjene";
            this.btnSpremiPromjene.UseVisualStyleBackColor = false;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // lblPromijeniLozinku
            // 
            this.lblPromijeniLozinku.AutoSize = true;
            this.lblPromijeniLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromijeniLozinku.Location = new System.Drawing.Point(273, 808);
            this.lblPromijeniLozinku.Name = "lblPromijeniLozinku";
            this.lblPromijeniLozinku.Size = new System.Drawing.Size(121, 18);
            this.lblPromijeniLozinku.TabIndex = 14;
            this.lblPromijeniLozinku.Text = "Promijeni lozinku";
            this.lblPromijeniLozinku.Click += new System.EventHandler(this.lblPromijeniLozinku_Click);
            this.lblPromijeniLozinku.MouseLeave += new System.EventHandler(this.lblPromijeniLozinku_MouseLeave);
            this.lblPromijeniLozinku.MouseHover += new System.EventHandler(this.lblPromijeniLozinku_MouseHover);
            // 
            // lblTipKorisnika
            // 
            this.lblTipKorisnika.AutoSize = true;
            this.lblTipKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipKorisnika.Location = new System.Drawing.Point(130, 692);
            this.lblTipKorisnika.Name = "lblTipKorisnika";
            this.lblTipKorisnika.Size = new System.Drawing.Size(119, 20);
            this.lblTipKorisnika.TabIndex = 15;
            this.lblTipKorisnika.Text = "Tip korisnika: ";
            // 
            // txtOIB
            // 
            this.txtOIB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtOIB.Enabled = false;
            this.txtOIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOIB.Location = new System.Drawing.Point(281, 168);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(223, 26);
            this.txtOIB.TabIndex = 16;
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(281, 216);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(223, 24);
            this.txtIme.TabIndex = 17;
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(281, 264);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(223, 24);
            this.txtPrezime.TabIndex = 18;
            // 
            // txtBrojMobitela
            // 
            this.txtBrojMobitela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtBrojMobitela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojMobitela.Location = new System.Drawing.Point(281, 312);
            this.txtBrojMobitela.Name = "txtBrojMobitela";
            this.txtBrojMobitela.Size = new System.Drawing.Size(223, 24);
            this.txtBrojMobitela.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(281, 360);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 24);
            this.txtEmail.TabIndex = 20;
            // 
            // txtAdresaPrebivalista
            // 
            this.txtAdresaPrebivalista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtAdresaPrebivalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresaPrebivalista.Location = new System.Drawing.Point(281, 453);
            this.txtAdresaPrebivalista.Name = "txtAdresaPrebivalista";
            this.txtAdresaPrebivalista.Size = new System.Drawing.Size(223, 24);
            this.txtAdresaPrebivalista.TabIndex = 21;
            // 
            // txtAdresaBoravista
            // 
            this.txtAdresaBoravista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtAdresaBoravista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresaBoravista.Location = new System.Drawing.Point(281, 550);
            this.txtAdresaBoravista.Name = "txtAdresaBoravista";
            this.txtAdresaBoravista.Size = new System.Drawing.Size(223, 24);
            this.txtAdresaBoravista.TabIndex = 22;
            // 
            // txtDatumUclanjivanja
            // 
            this.txtDatumUclanjivanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtDatumUclanjivanja.Enabled = false;
            this.txtDatumUclanjivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumUclanjivanja.Location = new System.Drawing.Point(281, 594);
            this.txtDatumUclanjivanja.Name = "txtDatumUclanjivanja";
            this.txtDatumUclanjivanja.Size = new System.Drawing.Size(223, 26);
            this.txtDatumUclanjivanja.TabIndex = 23;
            // 
            // txtIstekClanarine
            // 
            this.txtIstekClanarine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtIstekClanarine.Enabled = false;
            this.txtIstekClanarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIstekClanarine.Location = new System.Drawing.Point(281, 642);
            this.txtIstekClanarine.Name = "txtIstekClanarine";
            this.txtIstekClanarine.Size = new System.Drawing.Size(223, 26);
            this.txtIstekClanarine.TabIndex = 24;
            // 
            // txtTipKorisnika
            // 
            this.txtTipKorisnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.txtTipKorisnika.Enabled = false;
            this.txtTipKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipKorisnika.Location = new System.Drawing.Point(281, 690);
            this.txtTipKorisnika.Name = "txtTipKorisnika";
            this.txtTipKorisnika.Size = new System.Drawing.Size(223, 26);
            this.txtTipKorisnika.TabIndex = 25;
            // 
            // cmbPrebivaliste
            // 
            this.cmbPrebivaliste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrebivaliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrebivaliste.FormattingEnabled = true;
            this.cmbPrebivaliste.Location = new System.Drawing.Point(281, 408);
            this.cmbPrebivaliste.Name = "cmbPrebivaliste";
            this.cmbPrebivaliste.Size = new System.Drawing.Size(223, 28);
            this.cmbPrebivaliste.TabIndex = 26;
            // 
            // cmbBoraviste
            // 
            this.cmbBoraviste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoraviste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoraviste.FormattingEnabled = true;
            this.cmbBoraviste.Location = new System.Drawing.Point(281, 501);
            this.cmbBoraviste.Name = "cmbBoraviste";
            this.cmbBoraviste.Size = new System.Drawing.Size(223, 28);
            this.cmbBoraviste.TabIndex = 27;
            // 
            // lblUspjeh
            // 
            this.lblUspjeh.AutoSize = true;
            this.lblUspjeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUspjeh.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUspjeh.Location = new System.Drawing.Point(246, 118);
            this.lblUspjeh.Name = "lblUspjeh";
            this.lblUspjeh.Size = new System.Drawing.Size(175, 20);
            this.lblUspjeh.TabIndex = 28;
            this.lblUspjeh.Text = "Uspješno ažuriran profil";
            this.lblUspjeh.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 928);
            this.Controls.Add(this.lblUspjeh);
            this.Controls.Add(this.cmbBoraviste);
            this.Controls.Add(this.cmbPrebivaliste);
            this.Controls.Add(this.txtTipKorisnika);
            this.Controls.Add(this.txtIstekClanarine);
            this.Controls.Add(this.txtDatumUclanjivanja);
            this.Controls.Add(this.txtAdresaBoravista);
            this.Controls.Add(this.txtAdresaPrebivalista);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBrojMobitela);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.lblTipKorisnika);
            this.Controls.Add(this.lblPromijeniLozinku);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblDatumUclanjivanja);
            this.Controls.Add(this.lblAdresaBoravista);
            this.Controls.Add(this.lblBoraviste);
            this.Controls.Add(this.lblAdresaPrebivalista);
            this.Controls.Add(this.lblPrebivaliste);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBrojMobitela);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.lblNaslov);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmProfil";
            this.Text = "FrmProfil";
            this.Load += new System.EventHandler(this.FrmProfil_Load);
            this.Controls.SetChildIndex(this.lblNaslov, 0);
            this.Controls.SetChildIndex(this.lblOIB, 0);
            this.Controls.SetChildIndex(this.lblIme, 0);
            this.Controls.SetChildIndex(this.lblPrezime, 0);
            this.Controls.SetChildIndex(this.lblBrojMobitela, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblPrebivaliste, 0);
            this.Controls.SetChildIndex(this.lblAdresaPrebivalista, 0);
            this.Controls.SetChildIndex(this.lblBoraviste, 0);
            this.Controls.SetChildIndex(this.lblAdresaBoravista, 0);
            this.Controls.SetChildIndex(this.lblDatumUclanjivanja, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.btnSpremiPromjene, 0);
            this.Controls.SetChildIndex(this.lblPromijeniLozinku, 0);
            this.Controls.SetChildIndex(this.lblTipKorisnika, 0);
            this.Controls.SetChildIndex(this.txtOIB, 0);
            this.Controls.SetChildIndex(this.txtIme, 0);
            this.Controls.SetChildIndex(this.txtPrezime, 0);
            this.Controls.SetChildIndex(this.txtBrojMobitela, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtAdresaPrebivalista, 0);
            this.Controls.SetChildIndex(this.txtAdresaBoravista, 0);
            this.Controls.SetChildIndex(this.txtDatumUclanjivanja, 0);
            this.Controls.SetChildIndex(this.txtIstekClanarine, 0);
            this.Controls.SetChildIndex(this.txtTipKorisnika, 0);
            this.Controls.SetChildIndex(this.cmbPrebivaliste, 0);
            this.Controls.SetChildIndex(this.cmbBoraviste, 0);
            this.Controls.SetChildIndex(this.lblUspjeh, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblBrojMobitela;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPrebivaliste;
        private System.Windows.Forms.Label lblAdresaPrebivalista;
        private System.Windows.Forms.Label lblBoraviste;
        private System.Windows.Forms.Label lblAdresaBoravista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDatumUclanjivanja;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Label lblPromijeniLozinku;
        private System.Windows.Forms.Label lblTipKorisnika;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtBrojMobitela;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresaPrebivalista;
        private System.Windows.Forms.TextBox txtAdresaBoravista;
        private System.Windows.Forms.TextBox txtDatumUclanjivanja;
        private System.Windows.Forms.TextBox txtIstekClanarine;
        private System.Windows.Forms.TextBox txtTipKorisnika;
        private System.Windows.Forms.ComboBox cmbPrebivaliste;
        private System.Windows.Forms.ComboBox cmbBoraviste;
        private System.Windows.Forms.Label lblUspjeh;
        private System.Windows.Forms.Timer timer1;
    }
}