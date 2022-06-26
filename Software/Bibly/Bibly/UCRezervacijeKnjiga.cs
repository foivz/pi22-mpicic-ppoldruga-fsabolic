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
        private Posudba odabranaRezervacija = new Posudba();
        public UCRezervacijeKnjiga()
        {
            InitializeComponent();
        }
        public void PostaviLabele(Posudba posudba)
        {
            odabranaRezervacija = posudba;
            lblNaslov.Text = posudba.Primjerak.Knjiga.Naziv;
            lblRezervacija.Text = posudba.DoKadaVrijediRezervacija.ToShortDateString();
        }

        private void btnOtkaziRezervaciju_Click(object sender, EventArgs e)
        {
            RezervacijaRepozitorij.ZatvoriRezervaciju(odabranaRezervacija.Id, odabranaRezervacija.Primjerak.Id);
            lblRezervacija.Text = "Otkazano";
            btnOtkaziRezervaciju.Enabled = false;
        }
    }
}
