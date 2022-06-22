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
    public partial class FrmAdmin : FrmOpcenita
    {
        private string NazivTablice = null;
        public FrmAdmin(string nazivTablice)
        {
            InitializeComponent();
            NazivTablice = nazivTablice;
            PostaviFormu();
        }

        private void PostaviFormu()
        {
            lblNazivTablice.Text = "Tablica '"+NazivTablice+"'";
        }
    }
}
