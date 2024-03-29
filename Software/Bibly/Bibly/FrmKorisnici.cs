﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prijava;
namespace Bibly
{
    public partial class FrmKorisnici : FrmOpcenita
    {
        private Korisnik trenutniRed = null;
        public FrmKorisnici()
        {
            InitializeComponent();
            PostaviHelp("Korisnici.htm");
            dgvKorisnici.DataSource = KorisnikRepozitorij.DohvatiSveKorisnike();
            List<string> comboboxItems = new List<string>()
            {
                "OIB","Ime","Prezime","E-mail"
            };
            foreach(string item in comboboxItems)
            {
                cmbKriterijPretrazivanja.Items.Add(item);
            }
            cmbKriterijPretrazivanja.SelectedIndex = 0;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            FrmAzurirajKorisnika frm = new FrmAzurirajKorisnika(trenutniRed);
            frm.ShowDialog();
            dgvKorisnici.DataSource = KorisnikRepozitorij.DohvatiSveKorisnike();
        }

        private void dgvKorisnici_SelectionChanged(object sender, EventArgs e)
        {
            trenutniRed = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Brišete redak iz baze! Jeste li sigurni?", "Potvrdi", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (trenutniRed != null)
                {
                    KorisnikRepozitorij.ObrisiKorisnika(trenutniRed);
                    dgvKorisnici.DataSource = KorisnikRepozitorij.DohvatiSveKorisnike();
                }
                else
                {
                    MessageBox.Show("Niste odabrali korisnika!");
                }
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvKorisnici.DataSource = KorisnikRepozitorij.PretrazivanjeKorisnika(VratiAtribut(cmbKriterijPretrazivanja.SelectedItem as string),txtPretrazivanje.Text);
        }

        private string VratiAtribut(string naziv)
        {
            if (naziv == "OIB") return naziv;
            return naziv.ToLower().Replace(" ","_").Replace("-","");
        }

        private void btnUclani_Click(object sender, EventArgs e)
        {
            FrmRegistracija frm = new FrmRegistracija();
            frm.PostaviGlavniMenu(1);
            frm.ShowDialog();
            dgvKorisnici.DataSource = KorisnikRepozitorij.DohvatiSveKorisnike();
        }
    }
}
