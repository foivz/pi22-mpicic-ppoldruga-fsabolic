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
            }
            else
            {
                Primjerak primjerak = cmbPrimjerak.SelectedItem as Primjerak;
                Korisnik korisnik = new Korisnik();
                int trenutniBrojPosudbiKorisnika = KorisnikRepozitorij.TrenutniBrojPosudbi(korisnik);
                int maxBrojMogucihPosudbi = PostavkeRepozitorij.DohvatiMaksimalanBrojMogucihPosudbi();
                if (trenutniBrojPosudbiKorisnika + 1 <= maxBrojMogucihPosudbi)
                {
                    int trajanjeRezervacije = PostavkeRepozitorij.DohvatiTrajanjeRezervacije();
                    DateTime datumDoKojegVrijediRezervacija = DateTime.Now.Date.AddDays(trajanjeRezervacije);
                    Posudba rezervacija = new Posudba(
                        korisnik,
                        primjerak,
                        datumDoKojegVrijediRezervacija
                    );
                    RezervacijaRepozitorij.DodajRezervaciju(rezervacija);
                    PrimjerakRepozitorij.AzurirajStatusPrimjerka(primjerak.Id, StatusPrimjerka.Rezerviran);
                    //OsvjeziPrimjerke();
                }
            }
        }
    }
}
