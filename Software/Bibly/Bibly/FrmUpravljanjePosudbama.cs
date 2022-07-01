using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PodaciKnjige;
using PosudbeIRezervacije;
using Prijava;
using Postavke;

namespace Bibly
{
    public partial class FrmUpravljanjePosudbama : FrmOpcenita
    {
        public FrmUpravljanjePosudbama()
        {
            InitializeComponent();
            ucSkener1.PostaviUCSkener(this, cmbPrimjerak, cmbKorisnik);
        }
        private void FrmUpravljanjePosudbama_Load(object sender, EventArgs e)
        {
            RezervacijaRepozitorij.ProvjeriIstekleRezervacije();
        }
        private void btnPosudi_Click(object sender, EventArgs e)
        {
            if (cmbPrimjerak.Text == "" || cmbKorisnik.Text == "")
            {
                MessageBox.Show("Potrebno je skrenirati korisnika i knjigu prilikom posudbe!");
                return;
            }
            Korisnik korisnik = cmbKorisnik.SelectedItem as Korisnik;
            Primjerak primjerak = cmbPrimjerak.SelectedItem as Primjerak;
            if (korisnik.JeLiKorisnikPresaoGranicuPosudivanja() && primjerak.Status != StatusPrimjerka.Rezerviran)
            {
                MessageBox.Show("Korisnik je prešao granicu broja posudbi!");
                return;
            }
            int trajanjePosudbe = PostavkeRepozitorij.DohvatiTrajanjePosudbe();
            DateTime datumDoKojegVrijediPosudba = DateTime.Now.Date.AddDays(trajanjePosudbe);
            if (primjerak.Status == StatusPrimjerka.Posuđen)
            {
                MessageBox.Show("Primjerak je posuđen!");
                return;
            }
            else if (primjerak.Status == StatusPrimjerka.Dostupan)
            {
                Posudba posudba = new Posudba {
                    DatumPosudbe = DateTime.Today,
                    PredvideniDatumVracanja = datumDoKojegVrijediPosudba,
                    Korisnik = korisnik,
                    Primjerak = primjerak
                };
                PosudbaRepozitorij.DodajPosudbuKojaNijeBilaRezervirana(posudba);
                PrimjerakRepozitorij.AzurirajStatusPrimjerka(primjerak.Id, StatusPrimjerka.Posuđen);
                primjerak.Status = StatusPrimjerka.Posuđen;
                OsvjeziPodatke(posudba);
            }
            else if(primjerak.Status == StatusPrimjerka.Rezerviran)
            {
                Posudba rezervacija = RezervacijaRepozitorij.DohvatiRezervacijuPrimjerka(primjerak);
                if(rezervacija != null)
                {
                    if(rezervacija.Korisnik.OIB == korisnik.OIB)
                    {
                        rezervacija.DatumPosudbe = DateTime.Today;
                        rezervacija.PredvideniDatumVracanja = datumDoKojegVrijediPosudba;
                        rezervacija.RezervacijaPotvrdena = 1;
                        PosudbaRepozitorij.AzurirajPosudbuKojaJeBilaRezervirana(rezervacija);
                        PrimjerakRepozitorij.AzurirajStatusPrimjerka(primjerak.Id, StatusPrimjerka.Posuđen);
                        primjerak.Status = StatusPrimjerka.Posuđen;
                        OsvjeziPodatke(rezervacija);
                    }
                    else
                    {
                        MessageBox.Show("Knjiga je rezervirana na nekog drugog. Molimo odaberite drugi primjerak.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Došlo je do pogreške. Provjerite status primjerka, jer je rezerviran, ali ne postoji trenutna rezervacija.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Došlo je do greške!");
                return;
            }
        }
        private void btnVrati_Click(object sender, EventArgs e)
        {
            if (cmbPrimjerak.Text == "")
            {
                MessageBox.Show("Potrebno je skrenirati knjigu prilikom vraćanja!");
                return;
            }
            Primjerak primjerak = cmbPrimjerak.SelectedItem as Primjerak;
            if (primjerak.Status != StatusPrimjerka.Posuđen)
            {
                MessageBox.Show("Knjigu se ne može vratiti, jer je pod statusom: Dostupan!");
                return;
            }
            Posudba posudba = PosudbaRepozitorij.DohvatiPosudbuPrimjerka(primjerak);
            posudba.StvarniDatumVracanja = DateTime.Today;
            if (posudba.StvarniDatumVracanja > posudba.PredvideniDatumVracanja)
            { 
                posudba.IzracunajZakasninu();
            }
            else
            {
                posudba.Zakasnina = 0;
            }
            PosudbaRepozitorij.ZatvortiPosudbu(posudba);
            PrimjerakRepozitorij.AzurirajStatusPrimjerka(primjerak.Id, StatusPrimjerka.Dostupan);
            primjerak.Status = StatusPrimjerka.Dostupan;
            OsvjeziPodatke(posudba);
        }
        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if (cmbPrimjerak.Text == "" || cmbKorisnik.Text == "")
            {
                MessageBox.Show("Potrebno je skrenirati korisnika i knjigu prilikom posudbe!");
                return;
            }
            Korisnik korisnik = cmbKorisnik.SelectedItem as Korisnik;
            Primjerak primjerak = cmbPrimjerak.SelectedItem as Primjerak;
            if (korisnik.JeLiKorisnikPresaoGranicuPosudivanja())
            {
                MessageBox.Show("Korisnik je prešao granicu broja posudbi!");
                return;
            }
            if(primjerak.Status != StatusPrimjerka.Dostupan)
            {
                MessageBox.Show("Primjerak nije dostupan!");
                return;
            }
            int trajanjeRezervacije = PostavkeRepozitorij.DohvatiTrajanjeRezervacije();
            DateTime datumDoKojegVrijediRezervacija = DateTime.Now.Date.AddDays(trajanjeRezervacije);
            Posudba rezervacija = new Posudba
            {
                Korisnik = korisnik,
                Primjerak = primjerak,
                DoKadaVrijediRezervacija = datumDoKojegVrijediRezervacija
            };
            RezervacijaRepozitorij.DodajRezervaciju(rezervacija);
            PrimjerakRepozitorij.AzurirajStatusPrimjerka(primjerak.Id, StatusPrimjerka.Rezerviran);
            primjerak.Status = StatusPrimjerka.Rezerviran;
            OsvjeziPodatke(rezervacija);
            }
        private void OsvjeziPodatke(Posudba posudba)
        {
            lblVrijediDo.Text = (posudba.PredvideniDatumVracanja != DateTime.MinValue) ? posudba.PredvideniDatumVracanja.ToShortDateString() : posudba.DoKadaVrijediRezervacija.ToShortDateString();
            lblZakasnina.Text = (posudba.StvarniDatumVracanja > posudba.PredvideniDatumVracanja) ? string.Format("{0:0.00}", posudba.IzracunajZakasninu()) + " HRK" : "0.00 HRK";
            lblBrojProduljivanja.Text = posudba.BrojProduljivanja.ToString(); 
        }
    }
}
