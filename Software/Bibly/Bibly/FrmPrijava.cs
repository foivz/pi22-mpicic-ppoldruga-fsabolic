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
    public partial class FrmPrijava : FrmOpcenita
    {
        public FrmPrijava()
        {
            InitializeComponent();
            lblUclanjivanje.ForeColor = System.Drawing.Color.Blue;
        }

        private void lblUclanjivanje_MouseHover(object sender, EventArgs e)
        {
            lblUclanjivanje.ForeColor = System.Drawing.Color.Gray;
            lblUclanjivanje.Font = new Font(lblUclanjivanje.Font, FontStyle.Italic);
        }

        private void lblUclanjivanje_MouseLeave(object sender, EventArgs e)
        {

            lblUclanjivanje.ForeColor = System.Drawing.Color.Blue;
            lblUclanjivanje.Font = new Font(lblUclanjivanje.Font, FontStyle.Regular);
        }
    }
}
