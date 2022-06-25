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
            OsvjeziPrimjerke();
        }

        private void OsvjeziPrimjerke()
        {
            List<Primjerak> listaPrimjeraka = PrimjerakRepozitorij.DohvatiPrimjerkeKnjige(knjiga);
            dgvPrimjerci.DataSource = listaPrimjeraka;
            dgvPrimjerci.Columns[0].Width = 120;
            dgvPrimjerci.Columns[1].Width = 150;
            dgvPrimjerci.Columns[2].Visible = false;
            dgvPrimjerci.Columns[3].HeaderText = "Nedostupno do";
            dgvPrimjerci.Columns[3].Width = 383;
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
                int trajanjeRezervacije = PostavkeRepozitorij.VratiTrajanjeRezervacije();
                DateTime datumDoKojegVrijediRezervacija = DateTime.Now.Date.AddDays(trajanjeRezervacije);
                Posudba rezervacija = new Posudba(
                    trenutniKorisnik,
                    odabraniPrimjerak,
                    datumDoKojegVrijediRezervacija
                );
                int trenutniBrojPosudbiKorisnika = KorisnikRepozitorij.TrenutniBrojPosudbi(trenutniKorisnik);
                int maxBrojMogucihPosudbi = PostavkeRepozitorij.VratiMaksimalanBrojMogucihPosudbi();
                if (trenutniBrojPosudbiKorisnika + 1 <= maxBrojMogucihPosudbi)
                {
                    if (RezervacijaRepozitorij.DodajRezervaciju(rezervacija) == 1)
                    {
                        PrimjerakRepozitorij.AzurirajStatusPrimjerka(odabraniPrimjerak.Id, StatusPrimjerka.Rezerviran);
                        OsvjeziPrimjerke();
                    }
                    else
                    {
                        MessageBox.Show("Rezervacija nije moguća! Primjerak nije dostupan.");
                    }
                }
                else
                {
                    MessageBox.Show($"Rezervacija nije moguća! Prešli ste maximalan broj posudbi. Maksimalan broj posudbi je {maxBrojMogucihPosudbi}.");
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
