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
    public partial class FrmKorisnici : FrmOpcenita
    {
        public FrmKorisnici()
        {
            InitializeComponent();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            FrmAzurirajKorisnika frm = new FrmAzurirajKorisnika();
            frm.ShowDialog();
        }
    }
}
