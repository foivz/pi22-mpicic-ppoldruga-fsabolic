using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class UCKnjigaKatalog : UserControl
    {
        public UCKnjigaKatalog()
        {
            InitializeComponent();
        }

        private void picSlikaKnjige_Click(object sender, EventArgs e)
        { 
            FrmKatalogPrikazKnjige forma = new FrmKatalogPrikazKnjige();
            forma.ShowDialog();
            forma.Close();
        }

        private void UCKnjigaKatalog_Load(object sender, EventArgs e)
        {
        }
    }
}
