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
    public partial class UCKnjigaKatalog : UserControl
    {
        private Knjiga prikazanaKnjiga = new Knjiga();
        public UCKnjigaKatalog(Knjiga knjiga)
        {
            InitializeComponent();
            prikazanaKnjiga = knjiga;
            PostaviLabele();
        }

        public void PostaviLabele()
        {
            lblNaslov.Text = prikazanaKnjiga.Naziv;

            string autori = "";
            int brojAutora = prikazanaKnjiga.ListaAutora.Count;
            for (int indexAutora = 0; indexAutora < brojAutora; indexAutora++)
            {
                autori += prikazanaKnjiga.ListaAutora[indexAutora].Ime + " " + prikazanaKnjiga.ListaAutora[indexAutora].Prezime;
                autori += (indexAutora == brojAutora - 1) ? "" : ", ";
            }
            lblAutor.Text = autori;

            lblBrojStranica.Text = prikazanaKnjiga.BrojStranica.ToString();
            lblIzdavac.Text = prikazanaKnjiga.Izdavac.ToString();
            lblOpisKnjige.Text = prikazanaKnjiga.Opis;
            pbNaslovnica.Image = prikazanaKnjiga.Naslovnica;
        }

        private void UCKnjigaKataloga_Click(object sender, EventArgs e)
        {
            FrmKatalogPrikazKnjige frm = new FrmKatalogPrikazKnjige(prikazanaKnjiga);
            FrmOpcenita forma = new FrmOpcenita(); 
            forma.OtvoriNovuFormu(frm);
        }
    }
}
