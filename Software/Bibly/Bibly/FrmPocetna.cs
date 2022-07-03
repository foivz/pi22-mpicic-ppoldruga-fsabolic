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

        private static int left = 20;

        public FrmPocetna()
        {
            this.AutoScroll = true;
            InitializeComponent();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            listaKnjiga = KnjigaRepozitorij.DohvatiNajcitanijeKnjigaMjeseca();
            DodajUCKnjigaPocetna(listaKnjiga);

        }

        private void DodajUCKnjigaPocetna(List<Knjiga> listaKnjiga)
        {

            for(int i = 0; i < listaKnjiga.Count; i++)
            {
                UCKnjigaPocetna uc = new UCKnjigaPocetna();

                if (i < 5)
                {

                    uc.Top = 150;
                    uc.Left = left;
                    uc.PostaviLabele(listaKnjiga[i]);
                    Controls.Add(uc);
                    left += 300;

                }
                else
                {
                    uc.Top = 550;
                    uc.Left = left - 300;
                    uc.PostaviLabele(listaKnjiga[i]);
                    Controls.Add(uc);
                    left -= 300;
                }


            }

                    
        }
    }
}
