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

namespace Bibly
{
    public partial class FrmInventarPregledKnjige : FrmOpcenita
    {
        private Knjiga knjiga = new Knjiga();
        public FrmInventarPregledKnjige(Knjiga odabranaKnjiga)
        {
            knjiga = odabranaKnjiga;
            InitializeComponent();
            PostaviGlavniMenu(1);
        }

        private void FrmInventarPregledKnjige_Load(object sender, EventArgs e)
        {
            lblNaslovKnjige.Text = knjiga.Naziv;
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
            lblISBN.Text = knjiga.ISBN;
            lblOpisKnjige.Text = knjiga.Opis;
            pbNaslovnica.Image = knjiga.Naslovnica;
            OsvjeziPrimjerke();
        }

        private void OsvjeziPrimjerke()
        {
            RezervacijaRepozitorij.ProvjeriIstekleRezervacije();
            List<Primjerak> listaPrimjeraka = PrimjerakRepozitorij.DohvatiPrimjerkeKnjige(knjiga);
            if (listaPrimjeraka != null)
            {
                dgvPrimjerci.DataSource = listaPrimjeraka;
                dgvPrimjerci.Columns[0].Width = 120;
                dgvPrimjerci.Columns[1].Width = 150;
                dgvPrimjerci.Columns[2].Visible = false;
                dgvPrimjerci.Columns[3].HeaderText = "Nedostupno do";
                dgvPrimjerci.Columns[3].Width = 383;
            }
        }

    }
}
