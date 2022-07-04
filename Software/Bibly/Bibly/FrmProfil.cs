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
using System.Text.RegularExpressions;

namespace Bibly
{
    public partial class FrmProfil : FrmOpcenita
    {
        public FrmProfil()
        {
            InitializeComponent();
            lblPromijeniLozinku.ForeColor = System.Drawing.Color.Blue;
            PostaviHelp("Profil.htm");
        }



        private void lblPromijeniLozinku_MouseHover(object sender, EventArgs e)
        {
            lblPromijeniLozinku.ForeColor = System.Drawing.Color.Gray;
            lblPromijeniLozinku.Font = new Font(lblPromijeniLozinku.Font, FontStyle.Italic);
        }

        private void lblPromijeniLozinku_MouseLeave(object sender, EventArgs e)
        {
            lblPromijeniLozinku.ForeColor = System.Drawing.Color.Blue;
            lblPromijeniLozinku.Font = new Font(lblPromijeniLozinku.Font, FontStyle.Regular);
        }

        private void lblPromijeniLozinku_Click(object sender, EventArgs e)
        {
            FrmPromijeniLozinku frm = new FrmPromijeniLozinku();
            frm.ShowDialog();
        }

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            Korisnik trenutniKorisnik = Autentifikator.Instanca.VratiKorisnika();
            txtOIB.Text = trenutniKorisnik.OIB;
            txtIme.Text = trenutniKorisnik.Ime;
            txtPrezime.Text = trenutniKorisnik.Prezime;
            txtBrojMobitela.Text = trenutniKorisnik.BrojMobitela;
            txtEmail.Text = trenutniKorisnik.Email;
            List<Mjesto> mjesta = MjestoRepozitorij.DohvatiSvaMjesta();
            foreach (Mjesto mjesto in mjesta)
            {
                cmbPrebivaliste.Items.Add(mjesto);
                cmbBoraviste.Items.Add(mjesto);
            }
            cmbPrebivaliste.SelectedIndex = mjesta.IndexOf(mjesta.Find(x => x.ID == trenutniKorisnik.Prebivaliste.ID));
            txtAdresaPrebivalista.Text = trenutniKorisnik.AdresaPrebivalista;
            cmbBoraviste.SelectedIndex = mjesta.IndexOf(mjesta.Find(x => x.ID == trenutniKorisnik.Boraviste.ID));
            txtAdresaBoravista.Text = trenutniKorisnik.AdresaBoravista;
            txtDatumUclanjivanja.Text = trenutniKorisnik.DatumUclanjivanja.ToString("dd/MM/yyyy");
            txtIstekClanarine.Text = trenutniKorisnik.DatumIstekaClanarine.ToString("dd/MM/yyyy");
            txtTipKorisnika.Text = trenutniKorisnik.TipKorisnika.Naziv;
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            Korisnik trenutniKorisnik = Autentifikator.Instanca.VratiKorisnika();
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
            Autentifikator.Instanca.PonovnoUcitajKorisnika();

            lblUspjeh.Visible = true;
            timer1.Start();

        }

        static int vrijeme = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (vrijeme++ == 2)
            {
                lblUspjeh.Visible = false;
                vrijeme = 0;
                timer1.Stop();
            }

        }
    }
}
