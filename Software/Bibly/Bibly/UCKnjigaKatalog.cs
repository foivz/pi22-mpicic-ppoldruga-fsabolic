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
        public UCKnjigaKatalog()
        {
            InitializeComponent();
        }

        public void PostaviLabele(Knjiga knjiga)
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

            lblOpisKnjige.Text = knjiga.Opis;
        }
    }
}
