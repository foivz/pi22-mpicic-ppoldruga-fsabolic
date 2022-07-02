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
    public partial class FrmKatalogPrikazKnjige : FrmOpcenita
    {
        private Knjiga knjiga = new Knjiga();
        public FrmKatalogPrikazKnjige(Knjiga prikazanaKnjiga)
        {
            InitializeComponent();
            knjiga = prikazanaKnjiga;
            groupBox1.Visible = (Autentifikator.Instanca.UlogaKorisnika() > 2) ? true : false;
        }

        private void FrmKatalogPrikazKnjige_Load(object sender, EventArgs e)
        {
            lblNaslov.Text = knjiga.Naziv;
            string autori = "";
            int brojAutora = knjiga.ListaAutora.Count;
            for (int indexAutora = 0; indexAutora < brojAutora; indexAutora++)
            {
                autori += knjiga.ListaAutora[indexAutora].Ime + " " + knjiga.ListaAutora[indexAutora].Prezime;
                autori += (indexAutora == brojAutora - 1) ? "" : ", ";
            }
            lblAutor.Text = autori;
            lblBrojStranica.Text = knjiga.BrojStranica.ToString();
            lblIzdavac.Text = knjiga.Izdavac.ToString();
            lblZanr.Text = knjiga.Zanr.ToString();
            lblISBN.Text = knjiga.ISBN;
            lblOpisKnjige.Text = knjiga.Opis;
            pbNaslovnica.Image = knjiga.Naslovnica;
            List<string> listaEmailova = new List<string>();
            foreach(Korisnik korisnik in KorisnikRepozitorij.DohvatiSveKorisnike())
            {
                listaEmailova.Add(korisnik.Email);
            }
            cmbKorisnik.DataSource = listaEmailova;
            OsvjeziPrimjerke();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            Primjerak odabraniPrimjerak = dgvPrimjerci.CurrentRow.DataBoundItem as Primjerak;
            if(odabraniPrimjerak.Status != StatusPrimjerka.Dostupan)
            {
                MessageBox.Show("Ne možete rezervirati primjerak koji nije dostupan!");
            }
            else
            {
                Korisnik trenutniKorisnik = Autentifikator.Instanca.VratiKorisnika();
                if (!trenutniKorisnik.JeLiKorisnikPresaoGranicuPosudivanja())
                {
                    int trajanjeRezervacije = PostavkeRepozitorij.DohvatiTrajanjeRezervacije();
                    DateTime datumDoKojegVrijediRezervacija = DateTime.Now.Date.AddDays(trajanjeRezervacije);
                    Posudba rezervacija = new Posudba
                    {
                        Korisnik = trenutniKorisnik,
                        Primjerak = odabraniPrimjerak,
                        DoKadaVrijediRezervacija = datumDoKojegVrijediRezervacija
                    };
                    RezervacijaRepozitorij.DodajRezervaciju(rezervacija);
                    PrimjerakRepozitorij.AzurirajStatusPrimjerka(odabraniPrimjerak.Id, StatusPrimjerka.Rezerviran);
                    OsvjeziPrimjerke();
                }
                else
                {
                    MessageBox.Show($"Rezervacija nije moguća! Prešli ste maximalan broj posudbi.");
                }
            }
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnPosudi_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = KorisnikRepozitorij.DohvatiKorisnika_Mail(cmbKorisnik.SelectedItem as string);
            Primjerak primjerak = dgvPrimjerci.CurrentRow.DataBoundItem as Primjerak;
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
                OsvjeziPrimjerke();
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
                        OsvjeziPrimjerke();
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
            Primjerak primjerak = dgvPrimjerci.CurrentRow.DataBoundItem as Primjerak;
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
            PosudbaRepozitorij.ZatvoriPosudbu(posudba);
            PrimjerakRepozitorij.AzurirajStatusPrimjerka(primjerak.Id, StatusPrimjerka.Dostupan);
            primjerak.Status = StatusPrimjerka.Dostupan;
            OsvjeziPrimjerke();
        }
        private void btnRezerviraj2_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = KorisnikRepozitorij.DohvatiKorisnika_Mail(cmbKorisnik.SelectedItem as string);
            Primjerak primjerak = dgvPrimjerci.CurrentRow.DataBoundItem as Primjerak;
            if (korisnik.JeLiKorisnikPresaoGranicuPosudivanja())
            {
                MessageBox.Show("Korisnik je prešao granicu broja posudbi!");
                return;
            }
            if (primjerak.Status != StatusPrimjerka.Dostupan)
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
            OsvjeziPrimjerke();
        }
        private void OsvjeziPrimjerke()
        {
            RezervacijaRepozitorij.ProvjeriIstekleRezervacije();
            List<Primjerak> listaPrimjeraka = PrimjerakRepozitorij.DohvatiPrimjerkeKnjige(knjiga);
            if (listaPrimjeraka != null)
            {
                dgvPrimjerci.DataSource = listaPrimjeraka;
                dgvPrimjerci.Columns[0].Width = 120;
                dgvPrimjerci.Columns[1].Width = 150;
                dgvPrimjerci.Columns[2].Visible = false;
                dgvPrimjerci.Columns[3].HeaderText = "Nedostupno do";
                dgvPrimjerci.Columns[3].Width = 383;
            }
        }
    }
}
