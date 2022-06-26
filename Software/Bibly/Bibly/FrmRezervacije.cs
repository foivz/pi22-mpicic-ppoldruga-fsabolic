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
                UCRezervacijeKnjiga ucRezervacijeKnjigaa = new UCRezervacijeKnjiga();
                ucRezervacijeKnjigaa.Top = top;
                ucRezervacijeKnjigaa.Left = 20;
                ucRezervacijeKnjigaa.PostaviLabele(posudba);
                Controls.Add(ucRezervacijeKnjigaa);
                top += 350;
            }
        }
    }
}
