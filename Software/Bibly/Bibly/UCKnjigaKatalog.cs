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
            for (int i = 0; i < brojAutora; i++)
            {
                autori += knjiga.ListaAutora[i].Ime + " " + knjiga.ListaAutora[i].Prezime;
                autori += (i == brojAutora - 1) ? "" : ", ";
            }
            lblAutor.Text = autori;

        }
    }
}
