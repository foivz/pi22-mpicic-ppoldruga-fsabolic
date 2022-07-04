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
    public partial class FrmKatalog : FrmOpcenita
    {
        private static int top = 200;

        private List<Knjiga> listaKnjiga = new List<Knjiga>();

        public FrmKatalog()
        {
            InitializeComponent();
            
        }

        private void FrmKatalog_Load(object sender, EventArgs e)
        {
            listaKnjiga = KnjigaRepozitorij.DohvatiSveKnjige();
            DodajUCKnjigaKatalog(listaKnjiga);
            cmbKriteriji.SelectedIndex = 0;
            top = 200;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls.OfType<UCKnjigaKatalog>().ToList())
            {
                Controls.Remove(item);
            }
            top = 200;
            string kriterijPretrazivanja = cmbKriteriji.Text;
            string kljucnaRijec = txtUnosKljucneRijeci.Text.ToLower();
            List<Knjiga> listaKnjiga2 = new List<Knjiga>();
            if (kljucnaRijec == "" )
            {
                listaKnjiga2 = KnjigaRepozitorij.DohvatiSveKnjige();
            }
            else
            {
                switch (kriterijPretrazivanja)
                {
                    case "Izdavač":
                        {
                            foreach (Knjiga knjiga in listaKnjiga)
                            {
                                if (knjiga.Izdavac.Naziv.ToLower().Contains(kljucnaRijec))
                                {
                                    listaKnjiga2.Add(knjiga);
                                }
                            }
                            break;
                        }
                    case "Autor":
                        {
                            foreach (Knjiga knjiga in listaKnjiga)
                            {
                                foreach(Autor autor in knjiga.ListaAutora)
                                {
                                    if((autor.Ime.ToLower().Contains(kljucnaRijec) || autor.Prezime.ToLower().Contains(kljucnaRijec)) && !listaKnjiga2.Contains(knjiga))
                                    {
                                        listaKnjiga2.Add(knjiga);
                                    }
                                }
                            }
                            break;
                        }
                    case "Naslov knjige":
                        {
                            foreach (Knjiga knjiga in listaKnjiga)
                            {
                                if (knjiga.Naziv.ToLower().Contains(kljucnaRijec))
                                {
                                    listaKnjiga2.Add(knjiga);
                                }
                            }
                            break;
                        }
                    case "Žanr":
                        {
                            foreach (Knjiga knjiga in listaKnjiga)
                            {
                                if (knjiga.Zanr.Naziv.Contains(kljucnaRijec))
                                {
                                    listaKnjiga2.Add(knjiga);
                                }
                            }
                            break;
                        }
                }
            }
            DodajUCKnjigaKatalog(listaKnjiga2);
        }

        private void DodajUCKnjigaKatalog(List<Knjiga> listaKnjiga)
        {
            foreach (Knjiga knjiga in listaKnjiga)
            {
                UCKnjigaKatalog ucKnjigaKataloga = new UCKnjigaKatalog(knjiga);
                ucKnjigaKataloga.Top = top;
                ucKnjigaKataloga.Left = 20;
                Controls.Add(ucKnjigaKataloga);
                top += 350;
            }
        }
    }
}
