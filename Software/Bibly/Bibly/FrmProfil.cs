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
    public partial class FrmProfil : FrmOpcenita
    {
        public FrmProfil()
        {
            InitializeComponent();
            lblPromijeniLozinku.ForeColor = System.Drawing.Color.Blue;
        }

        private void lblPromijeniLozinku_MouseHover(object sender, EventArgs e)
        {
            lblPromijeniLozinku.ForeColor = System.Drawing.Color.Gray;
            lblPromijeniLozinku.Font = new Font(lblPromijeniLozinku.Font, FontStyle.Italic);
        }

        private void lblPromijeniLozinku_MouseLeave(object sender, EventArgs e)
        {
            lblPromijeniLozinku.ForeColor = System.Drawing.Color.Blue;
            lblPromijeniLozinku.Font = new Font(lblPromijeniLozinku.Font, FontStyle.Regular);
        }

        private void lblPromijeniLozinku_Click(object sender, EventArgs e)
        {
            FrmPromijeniLozinku frm = new FrmPromijeniLozinku();
            frm.ShowDialog();
        }
    }
}
