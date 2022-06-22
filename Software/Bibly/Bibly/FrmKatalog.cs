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
    public partial class FrmKatalog : Form
    {
        static int top = 200;
        static int noviId = 1;
        static int noviId2 = 1;
        public FrmKatalog()
        {
            InitializeComponent();
        }

        private void FrmKatalog_Load(object sender, EventArgs e)
        {
            KnjigaRepozitorij repozitorij = new KnjigaRepozitorij();
            List<Knjiga> listaKnjiga = repozitorij.DohvatiSveKnjige();
            UCKnjigaKatalog uCKnjigaKatalog = new UCKnjigaKatalog();
            //foreach (Knjiga knjiga in listaKnjiga)
            //{
            Knjiga knjiga = listaKnjiga[16];
            uCKnjigaKatalog.Top = top;
            uCKnjigaKatalog.PostaviLabele(knjiga);
            this.Controls.Add(uCKnjigaKatalog);
            //}
            
        }
    }
}
