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

        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            if (cmbPrimjerak.Text == "" || cmbKorisnik.Text == "")
            {
                MessageBox.Show("Potrebno je skrenirati korisnika i knjigu prilikom posudbe!");
                return;
            }
            Korisnik korisnik = cmbKorisnik.SelectedItem as Korisnik;
            if (korisnik.JeLiKorisnikPresaoGranicuPosudivanja())
            {
                MessageBox.Show("Korisnik je prešao granicu broja posudbi!");
                return;
            }
            Primjerak primjerak = cmbPrimjerak.SelectedItem as Primjerak;
            int trajanjePosudbe = PostavkeRepozitorij.DohvatiTrajanjePosudbe();
            DateTime datumDoKojegVrijediPosudba = DateTime.Now.Date.AddDays(trajanjePosudbe);
            if (primjerak.Status == StatusPrimjerka.Posuđen)
            {
                MessageBox.Show("Primjerak bi trebao biti posuđen!");
                return;
            }
            else if (primjerak.Status == StatusPrimjerka.Dostupan)
            {
                Posudba posudba = new Posudba(
                    DateTime.Today,
                    datumDoKojegVrijediPosudba,
                    korisnik,
                    primjerak
                );
                PosudbaRepozitorij.DodajPosudbuKojaNijeBilaRezervirana(posudba);
                PrimjerakRepozitorij.AzurirajStatusPrimjerka(primjerak.Id, StatusPrimjerka.Posuđen);
            }
            else if(primjerak.Status == StatusPrimjerka.Rezerviran)
            {
                Posudba rezervacija = RezervacijaRepozitorij.DohvatiRezervacijuPrimjerka(primjerak);
                if(rezervacija != null)
                {
                    if(rezervacija.Korisnik.OIB == korisnik.OIB || rezervacija.DoKadaVrijediRezervacija > DateTime.Today)
                    {
                        rezervacija.DatumPosudbe = DateTime.Today;
                        rezervacija.PredvideniDatumVracanja = datumDoKojegVrijediPosudba;
                        rezervacija.RezervacijaPotvrdena = 1;
                        PosudbaRepozitorij.AzurirajPosudbuKojaJeBilaRezervirana(rezervacija);
                        PrimjerakRepozitorij.AzurirajStatusPrimjerka(primjerak.Id, StatusPrimjerka.Posuđen);
                    }
                    else
                    {
                        MessageBox.Show("Knjiga je rezervirana na nekog drugog. Molimo odaberite drugi primjerak.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("PONOVI KAO DA JE DOSTUPNA KNJIGA. DODAJ FUNKCIJU KOJU DVA PUTA POZIVAS");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Došlo je do greške!");
                return;
            }
        }
    }
}
