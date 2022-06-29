using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prijava;
using Skener;
using System.Text.RegularExpressions;

namespace Bibly
{
    public partial class FrmAzurirajKorisnika : FrmOpcenita
    {
        Korisnik trenutniKorisnik = null;
        public FrmAzurirajKorisnika(Korisnik korisnik)
        {
            InitializeComponent();
            this.CenterToScreen();
            trenutniKorisnik = korisnik;
            PopuniFormu();
            PostaviBtnProduljivanje();

        }

        private void PopuniFormu()
        {
            List<Mjesto> mjesta = MjestoRepozitorij.DohvatiSvaMjesta();
            txtOIB.Text = trenutniKorisnik.OIB;
            txtIme.Text = trenutniKorisnik.Ime;
            txtPrezime.Text = trenutniKorisnik.Prezime;
            txtBrojMobitela.Text = trenutniKorisnik.BrojMobitela;
            txtEmail.Text = trenutniKorisnik.Email;
            foreach (Mjesto mjesto in mjesta)
            {
                cmbPrebivaliste.Items.Add(mjesto);
                cmbBoraviste.Items.Add(mjesto);
            }
            cmbPrebivaliste.SelectedIndex = mjesta.IndexOf(mjesta.Find(x => x.ID == trenutniKorisnik.Prebivaliste.ID));
            cmbBoraviste.SelectedIndex = mjesta.IndexOf(mjesta.Find(x => x.ID == trenutniKorisnik.Boraviste.ID));
            txtAdresaPrebivalista.Text = trenutniKorisnik.AdresaPrebivalista;
            txtAdresaBoravista.Text = trenutniKorisnik.AdresaBoravista;
            txtDatumUclanjivanja.Text = trenutniKorisnik.DatumUclanjivanja.ToString("dd/MM/yyyy");
            txtIstekClanarine.Text = trenutniKorisnik.DatumIstekaClanarine.ToString("dd/MM/yyyy");
        }

        private void btnGenerirajQRKod_Click(object sender, EventArgs e)
        {
            pbQRKod.Image = Skener.Skener.GenerirajQRKod(trenutniKorisnik.Email);
        }

        private void btnIsprintaj_Click(object sender, EventArgs e)
        {
            if (pbQRKod.Image == null)
            {
                pbQRKod.Image = Skener.Skener.GenerirajQRKod(trenutniKorisnik.Email);
            }

            Skener.Skener.Isprintaj(pbQRKod.Image);

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(text.Text) || string.IsNullOrWhiteSpace(text.Text))
                {
                    MessageBox.Show("Nisu popunjena sva polja!");
                    return;
                }
                string uzorak = "";
                switch (text.Name)
                {
                    case "txtIme":
                    case "txtPrezime":
                        uzorak = @"^(([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,20})(([ ]|[-])([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,20}))?)$";
                        if (!Regex.Match(text.Text, uzorak).Success)
                        {
                            MessageBox.Show("Pogrešan format imena/prezimena!");
                            return;
                        }
                        break;
                    case "txtBrojMobitela":
                        uzorak = @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
                        if (!Regex.Match(text.Text, uzorak).Success)
                        {
                            MessageBox.Show("Pogrešan format broja mobitela");
                            return;
                        }
                        break;
                    case "txtEmail":
                        uzorak = @"^([A-Z,a-z,ČĆŽĐŠčćžđš][a-z,A-Z,0-9,ČĆŽĐŠčćžđš,_,-]{2,30}@[a-z]{2,5}[.][a-z][a-z]{1,3})$";
                        if (!Regex.Match(text.Text, uzorak).Success)
                        {
                            MessageBox.Show("Pogrešan format e-maila");
                            return;
                        }
                        Korisnik korisnikProvjera = KorisnikRepozitorij.DohvatiKorisnika_Mail(text.Text);
                        if (korisnikProvjera != null)
                        {
                            if (korisnikProvjera.Email != trenutniKorisnik.Email)
                            {
                                MessageBox.Show("E-mail je već zauzet!");
                                return;
                            }
                        }
                        break;
                    case "txtAdresaPrebivalista":
                    case "txtAdresaBoravista":
                        if (text.Text.Length > 50)
                        {
                            MessageBox.Show("Prevelik unos!");
                            return;
                        }
                        break;
                }
            }

            Korisnik azuriranKorisnik = trenutniKorisnik;
            azuriranKorisnik.Ime = txtIme.Text;
            azuriranKorisnik.Prezime = txtPrezime.Text;
            azuriranKorisnik.BrojMobitela = txtBrojMobitela.Text;
            azuriranKorisnik.Email = txtEmail.Text;
            azuriranKorisnik.Prebivaliste = (Mjesto)cmbPrebivaliste.SelectedItem;
            azuriranKorisnik.AdresaPrebivalista = txtAdresaPrebivalista.Text;
            azuriranKorisnik.Boraviste = (Mjesto)cmbBoraviste.SelectedItem;
            azuriranKorisnik.AdresaBoravista = txtAdresaBoravista.Text;
            KorisnikRepozitorij.AzurirajKorisnika(azuriranKorisnik.OIB, azuriranKorisnik);
            Close();
        }

        private void btnProdulji_Click(object sender, EventArgs e)
        {
            DateTime trenutniDatumIsteka = DateTime.Parse(txtIstekClanarine.Text);
            DateTime noviDatumIsteka = trenutniDatumIsteka.AddYears(1);
            KorisnikRepozitorij.AzurirajKorisnika_DatumIstekaClanarine(trenutniKorisnik,noviDatumIsteka);
            trenutniKorisnik = KorisnikRepozitorij.DohvatiKorisnika_OIB(trenutniKorisnik.OIB);
            txtIstekClanarine.Text = trenutniKorisnik.DatumIstekaClanarine.ToString("dd/MM/yyyy");
            PostaviBtnProduljivanje();
        }

        private void PostaviBtnProduljivanje()
        {
            DateTime danas = DateTime.Now;
            DateTime datumIsteka = DateTime.Parse(txtIstekClanarine.Text);
            if (RazlikaDatuma(datumIsteka,danas) > 365)
            {
                btnProdulji.Enabled = false;
            }
            else
            {
                btnProdulji.Enabled = true;
            }
        }

        private int RazlikaDatuma(DateTime a,DateTime b)
        {
            return int.Parse((DateTime.Parse(txtIstekClanarine.Text) - DateTime.Parse(txtDatumUclanjivanja.Text)).TotalDays.ToString());
        }

    }
}
