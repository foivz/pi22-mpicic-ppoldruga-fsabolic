using PodaciKnjige;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibly
{
    public partial class FrmPocetna : FrmOpcenita
    {
        List<Knjiga> listaKnjiga = new List<Knjiga>();

        private static int top = 200;

        public FrmPocetna()
        {
            this.AutoScroll = true;
            InitializeComponent();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            listaKnjiga = KnjigaRepozitorij.DohvatiNajcitanijeKnjigaMjeseca();
            DodajUCKnjigaPocetna(listaKnjiga);
            top = 200;
        }

        private void DodajUCKnjigaPocetna(List<Knjiga> listaKnjiga)
        {
            foreach (Knjiga knjiga in listaKnjiga)
            {
                UCKnjigaPocetna uc = new UCKnjigaPocetna();
                uc.Top = top;
                uc.Left = 20;
                uc.PostaviLabele(knjiga);
                Controls.Add(uc);
                top += 450;
            }
        }
    }
}
