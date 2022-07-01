using Prijava;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Bibly
{
    public partial class FrmRegistracija : FrmOpcenita
    {
        public FrmRegistracija()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.CenterToScreen();
            txtDatumUclanjivanja.Text = DateTime.Now.ToString();
            txtIstekClanarine.Text = DateTime.Now.AddYears(1).ToString();
            cmbBoraviste.DataSource = MjestoRepozitorij.DohvatiSvaMjesta();
            cmbPrebivaliste.DataSource = MjestoRepozitorij.DohvatiSvaMjesta();
        }

        private void btnUclani_Click(object sender, EventArgs e)
        {
            string oib = txtOIB.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string brojMobitela = txtBrojMobitela.Text;
            string email = txtEmail.Text;
            Mjesto prebivaliste = cmbPrebivaliste.SelectedItem as Mjesto;
            string adresaPrebivalista = txtAdresaPrebivalista.Text;
            Mjesto boraviste = cmbBoraviste.SelectedItem as Mjesto;
            string adresaBoravista = txtAdresaBoravista.Text;
            string lozinka = GenerirajLozinku();
            int pokusajiPrijave = 0;
            bool blokiran = false;
            TipKorisnika tipKorisnika = new TipKorisnika(2, null);
            int dobroPopunjeno = ProvjeriUnose(oib, ime, prezime, brojMobitela, email, adresaPrebivalista, adresaBoravista); 
            string poruka = "";
            switch (dobroPopunjeno)
            {
                case -1:
                    poruka = "Niste popunili sva polja!";
                    break;
                case -2:
                    poruka = "OIB je pogrešnog formata!";
                    break;
                case -3:
                    poruka = "Ime je pogrešnog formata!";
                    break;
                case -4:
                    poruka = "Prezime je pogrešnog formata!";
                    break;
                case -5:
                    poruka = "Broj mobitela je pogrešnog formata!";
                    break;
                case -6:
                    poruka = "Email je pogrešnog formata!";
                    break;
                case -7:
                    poruka = "OIB već postoji u bazi!";
                    break;
                case -8:
                    poruka = "E - mail je već unesen!";
                    break;
                case 1:
                    Korisnik korisnik = new Korisnik
                    {
                        OIB = oib,
                        Ime = ime,
                        Prezime = prezime,
                        BrojMobitela = brojMobitela,
                        Email = email,
                        Prebivaliste = prebivaliste,
                        AdresaPrebivalista = adresaPrebivalista,
                        Boraviste = boraviste,
                        AdresaBoravista = adresaBoravista,
                        DatumUclanjivanja = DateTime.Parse(txtDatumUclanjivanja.Text),
                        DatumIstekaClanarine = DateTime.Parse(txtIstekClanarine.Text),
                        Lozinka = lozinka,
                        TipKorisnika = tipKorisnika,
                        PokusajiPrijave = pokusajiPrijave,
                        Blokiran = blokiran,

                    };
                    KorisnikRepozitorij.DodajKorisnika(korisnik);
                    btnGenerirajQRKod.Enabled = true;
                    btnIsprintajQRKod.Enabled = true;
                    pbQRKod.Image = Skener.Skener.GenerirajQRKod(korisnik.Email);
                    lblUspjeh.Visible = true;
                    timer1.Start();                  
                    PosaljiLozinkuNaMail(korisnik.Lozinka, korisnik.Email, korisnik.Ime);
                    break;

            }

            if (dobroPopunjeno != 1)
            {
                MessageBox.Show(poruka);
            }
        }


        private int ProvjeriUnose(string oib, string ime, string prezime, string brojMobitela, string email, string adresaPrebivalista, string adresaBoravista)
        {
            if (string.IsNullOrEmpty(oib) || string.IsNullOrWhiteSpace(oib) || string.IsNullOrEmpty(ime) || string.IsNullOrWhiteSpace(ime) ||
                string.IsNullOrEmpty(prezime) || string.IsNullOrWhiteSpace(prezime) || string.IsNullOrEmpty(brojMobitela) || string.IsNullOrWhiteSpace(brojMobitela) ||
                string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrEmpty(adresaPrebivalista) || string.IsNullOrWhiteSpace(adresaPrebivalista) || 
                string.IsNullOrEmpty(adresaBoravista) || string.IsNullOrWhiteSpace(adresaBoravista))
            {
                return -1;
            }
            else if(!ProvjeraOIBa(oib))
            {
                return -2;
            }
            else if (!ProvjeraImena(ime)){
                return -3;
            }
            else if (!ProvjeraPrezimena(prezime))
            {
                return -4;
            }
            else if (!ProvjeraMobitela(brojMobitela))
            {
                return -5;
            }
            else if (!ProvjeraEmaila(email))
            {
                return -6;
            }
            else if (!PostojiOIB(oib))
            {
                return -7;
            }
            else if (!PostojiEmail(email))
            {
                return -8;
            }
            else
            {
                return 1;
            }
        }
        private bool ProvjeraOIBa(string unos)
        {
            if (unos.Length != 11 || !long.TryParse(unos, out long test))
            {
                return false;
            }

            int oibRacun = 10;
            int kontrolniBroj = int.Parse(unos[10].ToString());
            for (int i = 0; i < unos.Length - 1; i++)
            {
                oibRacun += int.Parse(unos[i].ToString());
                oibRacun = (oibRacun % 10) == 0 ? 10 : oibRacun % 10;
                oibRacun *= 2;
                oibRacun %= 11;
            }
            if ((11 - oibRacun) % 10 != kontrolniBroj)
            {
                return false;
            }
            return true;

        }
        private bool ProvjeraImena(string unos)
        {
            string uzorak = @"^(([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,})(([ ]|[-])([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,}))?)$";
            if (!Regex.Match(unos, uzorak).Success) return false; else return true;

        }

        private bool ProvjeraPrezimena(string unos)
        {
            string uzorak = @"^(([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,})(([ ]|[-])([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,}))?)$";
            if (!Regex.Match(unos, uzorak).Success) return false; else return true;

        }

        private bool ProvjeraMobitela(string unos)
        {
            string uzorak = @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
            if (!Regex.Match(unos, uzorak).Success) return false; else return true;
        }

        private bool ProvjeraEmaila(string unos)
        {
            string uzorak = @"^([A-Z,a-z,ČĆŽĐŠčćžđš][a-z,A-Z,0-9,ČĆŽĐŠčćžđš,_,-,.]{2,}@[a-z]{2,}[.][a-z][a-z]{1,})$";
            if (!Regex.Match(unos, uzorak).Success) return false; else return true;
        }

        private bool PostojiOIB (string unos)
        {
            if (KorisnikRepozitorij.DohvatiKorisnika_OIB(unos) != null) return false; else return true;
        }

        private bool PostojiEmail (string unos)
        {
            if (KorisnikRepozitorij.DohvatiKorisnika_Mail(unos) != null) return false; else return true;
        }

        private string GenerirajLozinku()
        {
            int duljina = 8;
            string znakovi = "ABCDEFGHIJKLMNOPQRSTUWXYZ1234567890abcdefghijklmnopqrstuwxyz";
            Random rnd = new Random();

            char[] chars = new char [duljina];
            for(int i = 0; i < duljina; i++)
            {
                chars [i] = znakovi[rnd.Next (0, znakovi.Length)];
            }

            return new string (chars);
        }

        private void PosaljiLozinkuNaMail(string lozinka, string email, string ime)
        {
            SendMail().Wait();
            
            async Task SendMail() {

                string apiKey = "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";

                var client = new SendGridClient(apiKey);

                var senderEmail = new EmailAddress("bibly.knjiznica@gmail.com");

                var recieverEmail = new EmailAddress($"{email}", $"{ime}");

                string emailSubject = "Lozinka za Bibly aplikaciju!";

                string textContent = "plain";

                string htmlContent = $"Čestitamo Vam što ste postali član najbolje knjižnice Bibly :). U aplikaciju se možete prijaviti pomoću vaše email adrese i lozinke koja se nalazi ispod. <br><br>" +
                    $"<strong>Lozinka: {lozinka}</strong>";

                var msg = MailHelper.CreateSingleEmail(senderEmail, recieverEmail, emailSubject, textContent, htmlContent);

                var resp = await client.SendEmailAsync(msg).ConfigureAwait(false);
            }
        }

        private void btnGenerirajQRKod_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Niste unijeli mail, ne može se generirati QR kod!");
                return;
            }
            pbQRKod.Image = Skener.Skener.GenerirajQRKod(txtEmail.Text);
        }

        private void btnIsprintajQRKod_Click(object sender, EventArgs e)
        {
            if (pbQRKod.Image == null)
            {
                MessageBox.Show("Niste generirali QR kod!");
                return;
            }
            Skener.Skener.Isprintaj(pbQRKod.Image);
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

