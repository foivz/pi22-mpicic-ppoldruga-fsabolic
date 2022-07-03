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
    public partial class UCKnjigaPocetna : UserControl
    {
        private Knjiga prikazanaKnjiga = new Knjiga();

        public UCKnjigaPocetna()
        {
            InitializeComponent();
        }

        public void PostaviLabele(Knjiga knjiga)
        {
            prikazanaKnjiga = knjiga;
            lblNaslov.Text = knjiga.Naziv;
        
            string autori = "";
            int brojAutora = knjiga.ListaAutora.Count;
            for (int indexAutora = 0; indexAutora < brojAutora; indexAutora++)
            {
                autori += knjiga.ListaAutora[indexAutora].Ime + " " + knjiga.ListaAutora[indexAutora].Prezime;
                autori += (indexAutora == brojAutora - 1) ? "" : ", ";
            }
            lblAutor.Text = autori;

            pbSlikaKnjige.Image = knjiga.Naslovnica;

        }

        private void UCKnjigaPocetna_Click(object sender, EventArgs e)
        {
            FrmKatalogPrikazKnjige frm = new FrmKatalogPrikazKnjige(prikazanaKnjiga);
            FrmOpcenita forma = new FrmOpcenita();
            forma.OtvoriNovuFormu(frm);
        }
    }
}
