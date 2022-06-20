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
    public partial class FrmOpcenita : Form
    {
        public FrmOpcenita()
        {
            InitializeComponent();
            this.CenterToScreen();
            PostaviGlavniMenu();
        }

        private void PostaviGlavniMenu(int sakrijMenu = 0)
        {
            if (sakrijMenu == 1)
            {
                glavniMenu.Visible = false;
                return;
            }

            // --  TO DO --
            //Dohvaćanje uloge iz autentifikatora
            // int uloga = Autentifikator.VratiUlogu();
            // --  TO DO --

            //trenutno za potrebe testiranja koristim ovu varijablu (uloga):

            int uloga = 1;
            if (uloga == 1)
            {
                glavniMenu.Visible = false;
            }

            if (uloga < 2)
            {
                //tsmiItem.Visible = false...
            }

            if (uloga < 3)
            {
                //tsmiItem.Visible = false...
            }

            if (uloga < 4)
            {
                //tsmiItem.Visible = false...

            }
        }

        private void tsmiOdjava_Click(object sender, EventArgs e)
        {
            FrmPrijava frm = new FrmPrijava();
            OtvoriNovuFormu(frm);
        }

        private void katalogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OtvoriNovuFormu(FrmOpcenita frm, string naslov = "Bibly")
        {
            this.Hide();
            frm.Text = naslov;
            frm.ShowDialog();
            this.Close();
        }

    }
}
