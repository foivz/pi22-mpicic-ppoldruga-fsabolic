using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prijava;

namespace Bibly
{
    public partial class FrmPrijava : FrmOpcenita
    {
        public FrmPrijava()
        {
            InitializeComponent();
            this.CenterToScreen();
            PostaviHelp("Prijava.htm");

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string lozinka = txtLozinka.Text;
            int uspjehPrijave = Autentifikator.Instanca.PrijavaKorisnika(email, lozinka);
            string poruka = "";
            switch (uspjehPrijave)
            {
                case -1:
                    poruka = "Niste popunili sva polja!";
                    break;
                case -2:
                    poruka = "E-mail ne postoji!";
                    break;
                case -3:
                    poruka = "Pogrešna lozinka!";
                    break;
                case -4:
                    poruka = "Blokirani ste! Javite se administratoru!";
                    break;
                case -5:
                    poruka = "Istekla Vam je članarina! Produljite članarinu u knjižnici!";
                    break;
                case 1:
                    FrmPocetna frm = new FrmPocetna();
                    OtvoriNovuFormu(frm);
                    break;
            }

            if (uspjehPrijave != 1)
            {
                MessageBox.Show(poruka);
            }



        }
    }
}
