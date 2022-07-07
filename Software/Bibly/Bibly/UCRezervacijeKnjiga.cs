using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosudbeIRezervacije;
using PodaciKnjige;

namespace Bibly
{
    public partial class UCRezervacijeKnjiga : UserControl
    {
        private Posudba rezervacija = new Posudba();
        public UCRezervacijeKnjiga(Posudba odabranaRezervacija)
        {
            rezervacija = odabranaRezervacija;
            InitializeComponent();
            PostaviLabele();
        }
        public void PostaviLabele()
        {
            lblNaslov.Text = rezervacija.Primjerak.Knjiga.Naziv;
            lblRezervacija.Text = rezervacija.DoKadaVrijediRezervacija.ToShortDateString();
            pbNaslovnica.Image = rezervacija.Primjerak.Knjiga.Naslovnica;
        }

        private void btnOtkaziRezervaciju_Click(object sender, EventArgs e)
        {
            RezervacijaRepozitorij.ZatvoriRezervaciju(rezervacija.Id, rezervacija.Primjerak.Id);
            lblRezervacija.Text = "Otkazano";
            btnOtkaziRezervaciju.Enabled = false;
        }
    }
}
