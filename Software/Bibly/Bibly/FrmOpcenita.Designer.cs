﻿namespace Bibly
{
    partial class FrmOpcenita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpcenita));
            this.glavniMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutor_Knjige = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutori = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIzdavaci = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKnjige = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKorisnici = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMjesta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPostavke = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPosudbe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrimjerci = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatusi_Primjeraka = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTipovi_Korisnika = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZanrovi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Korisnici = new System.Windows.Forms.ToolStripMenuItem();
            this.glavniMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // glavniMenu
            // 
            this.glavniMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.glavniMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.glavniMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Korisnici,
            this.tsmiAdmin,
            this.tsmiProfil,
            this.tsmiOdjava});
            this.glavniMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.glavniMenu.Location = new System.Drawing.Point(0, 0);
            this.glavniMenu.Name = "glavniMenu";
            this.glavniMenu.Size = new System.Drawing.Size(1080, 29);
            this.glavniMenu.TabIndex = 0;
            this.glavniMenu.Text = "menuStrip1";
            // 
            // tsmiAdmin
            // 
            this.tsmiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAutor_Knjige,
            this.tsmiAutori,
            this.tsmiIzdavaci,
            this.tsmiKnjige,
            this.tsmiKorisnici,
            this.tsmiMjesta,
            this.tsmiPostavke,
            this.tsmiPosudbe,
            this.tsmiPrimjerci,
            this.tsmiStatusi_Primjeraka,
            this.tsmiTipovi_Korisnika,
            this.tsmiZanrovi});
            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(68, 25);
            this.tsmiAdmin.Text = "Admin";
            // 
            // tsmiAutor_Knjige
            // 
            this.tsmiAutor_Knjige.Name = "tsmiAutor_Knjige";
            this.tsmiAutor_Knjige.Size = new System.Drawing.Size(207, 26);
            this.tsmiAutor_Knjige.Text = "autor_knjige";
            this.tsmiAutor_Knjige.Click += new System.EventHandler(this.tsmiAutor_Knjige_Click);
            // 
            // tsmiAutori
            // 
            this.tsmiAutori.Name = "tsmiAutori";
            this.tsmiAutori.Size = new System.Drawing.Size(207, 26);
            this.tsmiAutori.Text = "autori";
            this.tsmiAutori.Click += new System.EventHandler(this.tsmiAutori_Click);
            // 
            // tsmiIzdavaci
            // 
            this.tsmiIzdavaci.Name = "tsmiIzdavaci";
            this.tsmiIzdavaci.Size = new System.Drawing.Size(207, 26);
            this.tsmiIzdavaci.Text = "izdavaci";
            this.tsmiIzdavaci.Click += new System.EventHandler(this.tsmiIzdavaci_Click);
            // 
            // tsmiKnjige
            // 
            this.tsmiKnjige.Name = "tsmiKnjige";
            this.tsmiKnjige.Size = new System.Drawing.Size(207, 26);
            this.tsmiKnjige.Text = "knjige";
            this.tsmiKnjige.Click += new System.EventHandler(this.tsmiKnjige_Click);
            // 
            // tsmiKorisnici
            // 
            this.tsmiKorisnici.Name = "tsmiKorisnici";
            this.tsmiKorisnici.Size = new System.Drawing.Size(207, 26);
            this.tsmiKorisnici.Text = "korisnici";
            this.tsmiKorisnici.Click += new System.EventHandler(this.tsmiKorisnici_Click);
            // 
            // tsmiMjesta
            // 
            this.tsmiMjesta.Name = "tsmiMjesta";
            this.tsmiMjesta.Size = new System.Drawing.Size(207, 26);
            this.tsmiMjesta.Text = "mjesta";
            this.tsmiMjesta.Click += new System.EventHandler(this.tsmiMjesta_Click);
            // 
            // tsmiPostavke
            // 
            this.tsmiPostavke.Name = "tsmiPostavke";
            this.tsmiPostavke.Size = new System.Drawing.Size(207, 26);
            this.tsmiPostavke.Text = "postavke";
            this.tsmiPostavke.Click += new System.EventHandler(this.tsmiPostavke_Click);
            // 
            // tsmiPosudbe
            // 
            this.tsmiPosudbe.Name = "tsmiPosudbe";
            this.tsmiPosudbe.Size = new System.Drawing.Size(207, 26);
            this.tsmiPosudbe.Text = "posudbe";
            this.tsmiPosudbe.Click += new System.EventHandler(this.tsmiPosudbe_Click);
            // 
            // tsmiPrimjerci
            // 
            this.tsmiPrimjerci.Name = "tsmiPrimjerci";
            this.tsmiPrimjerci.Size = new System.Drawing.Size(207, 26);
            this.tsmiPrimjerci.Text = "primjerci";
            this.tsmiPrimjerci.Click += new System.EventHandler(this.tsmiPrimjerci_Click);
            // 
            // tsmiStatusi_Primjeraka
            // 
            this.tsmiStatusi_Primjeraka.Name = "tsmiStatusi_Primjeraka";
            this.tsmiStatusi_Primjeraka.Size = new System.Drawing.Size(207, 26);
            this.tsmiStatusi_Primjeraka.Text = "statusi_primjeraka";
            this.tsmiStatusi_Primjeraka.Click += new System.EventHandler(this.tsmiStatusi_Primjeraka_Click);
            // 
            // tsmiTipovi_Korisnika
            // 
            this.tsmiTipovi_Korisnika.Name = "tsmiTipovi_Korisnika";
            this.tsmiTipovi_Korisnika.Size = new System.Drawing.Size(207, 26);
            this.tsmiTipovi_Korisnika.Text = "tipovi_korisnika";
            this.tsmiTipovi_Korisnika.Click += new System.EventHandler(this.tsmiTipovi_Korisnika_Click);
            // 
            // tsmiZanrovi
            // 
            this.tsmiZanrovi.Name = "tsmiZanrovi";
            this.tsmiZanrovi.Size = new System.Drawing.Size(207, 26);
            this.tsmiZanrovi.Text = "zanrovi";
            this.tsmiZanrovi.Click += new System.EventHandler(this.tsmiZanrovi_Click);
            // 
            // tsmiProfil
            // 
            this.tsmiProfil.Name = "tsmiProfil";
            this.tsmiProfil.Size = new System.Drawing.Size(59, 25);
            this.tsmiProfil.Text = "Profil";
            this.tsmiProfil.Click += new System.EventHandler(this.tsmiProfil_Click);
            // 
            // tsmiOdjava
            // 
            this.tsmiOdjava.Name = "tsmiOdjava";
            this.tsmiOdjava.Size = new System.Drawing.Size(71, 25);
            this.tsmiOdjava.Text = "Odjava";
            this.tsmiOdjava.Click += new System.EventHandler(this.tsmiOdjava_Click);
            // 
            // tsmi_Korisnici
            // 
            this.tsmi_Korisnici.Name = "tsmi_Korisnici";
            this.tsmi_Korisnici.Size = new System.Drawing.Size(81, 25);
            this.tsmi_Korisnici.Text = "Korisnici";
            this.tsmi_Korisnici.Click += new System.EventHandler(this.tsmi_Korisnici_Click);
            // 
            // FrmOpcenita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1080, 605);
            this.Controls.Add(this.glavniMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.glavniMenu;
            this.Name = "FrmOpcenita";
            this.Text = "OpcenitaForma";
            this.glavniMenu.ResumeLayout(false);
            this.glavniMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip glavniMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiOdjava;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutor_Knjige;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutori;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzdavaci;
        private System.Windows.Forms.ToolStripMenuItem tsmiKnjige;
        private System.Windows.Forms.ToolStripMenuItem tsmiKorisnici;
        private System.Windows.Forms.ToolStripMenuItem tsmiMjesta;
        private System.Windows.Forms.ToolStripMenuItem tsmiPostavke;
        private System.Windows.Forms.ToolStripMenuItem tsmiPosudbe;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrimjerci;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatusi_Primjeraka;
        private System.Windows.Forms.ToolStripMenuItem tsmiTipovi_Korisnika;
        private System.Windows.Forms.ToolStripMenuItem tsmiZanrovi;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfil;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Korisnici;
    }
}

