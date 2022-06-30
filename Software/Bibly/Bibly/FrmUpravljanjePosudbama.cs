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
                //Primjerak primjerak = cmbPrimjerak.SelectedItem as Primjerak;
                string idPrimjerka = "9789993329084";
                string oibKorisnika = "00960620247";
                int trenutniBrojPosudbiKorisnika = KorisnikRepozitorij.TrenutniBrojPosudbi(trenutniKorisnik);
                int maxBrojMogucihPosudbi = PostavkeRepozitorij.DohvatiMaksimalanBrojMogucihPosudbi();
                if (trenutniBrojPosudbiKorisnika + 1 <= maxBrojMogucihPosudbi)
                {
                    int trajanjeRezervacije = PostavkeRepozitorij.DohvatiTrajanjeRezervacije();
                    DateTime datumDoKojegVrijediRezervacija = DateTime.Now.Date.AddDays(trajanjeRezervacije);
                    Posudba rezervacija = new Posudba(
                        trenutniKorisnik,
                        odabraniPrimjerak,
                        datumDoKojegVrijediRezervacija
                    );
                    RezervacijaRepozitorij.DodajRezervaciju(rezervacija);
                    PrimjerakRepozitorij.AzurirajStatusPrimjerka(odabraniPrimjerak.Id, StatusPrimjerka.Rezerviran);
                    OsvjeziPrimjerke();
                }
            }
        }
    }
}
