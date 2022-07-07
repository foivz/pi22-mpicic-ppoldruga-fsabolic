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

namespace Bibly
{
    public partial class FrmRezervacije : FrmOpcenita
    {
        private static int top = 200;
        private List<Posudba> listaRezervacija = new List<Posudba>();
        public FrmRezervacije()
        {
            InitializeComponent();
            PostaviHelp("Pregled rezervacija.htm");
        }

        private void FrmRezervacije_Load(object sender, EventArgs e)
        {
            lblObavijest.Visible = false;
            RezervacijaRepozitorij.ProvjeriIstekleRezervacije();
            listaRezervacija = RezervacijaRepozitorij.DohvatiTrenutneRezervacijeKorisnika(Autentifikator.Instanca.VratiKorisnika());
            if(listaRezervacija != null)
            {
                DodajUCRezervacijeKnjiga(listaRezervacija);
                lblObavijest.Visible = false;
            }
            else
            {
                lblObavijest.Visible = true;
            }
            top = 200;
        }
        private void DodajUCRezervacijeKnjiga(List<Posudba> listaRezervacija)
        {
            foreach (Posudba posudba in listaRezervacija)
            {
                UCRezervacijeKnjiga ucRezervacijeKnjigaa = new UCRezervacijeKnjiga(posudba);
                ucRezervacijeKnjigaa.Top = top;
                ucRezervacijeKnjigaa.Left = 20;
                Controls.Add(ucRezervacijeKnjigaa);
                top += 350;
            }
        }
    }
}
