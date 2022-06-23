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

            lblOpisKnjige.Text = knjiga.Opis;

            OsvjeziPrimjerke();
        }

        private void OsvjeziPrimjerke()
        {

        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            OsvjeziPrimjerke();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {

        }
    }
}
