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
    public partial class FrmInventarDodajZanr : Form
    {
        public FrmInventarDodajZanr()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string unos = txtNaziv.Text;

            string poruka = "";

            int dobroPopunjeno = ProvjeriUnos(unos);

            switch (dobroPopunjeno)
            {
                case -1:
                    poruka = "Niste unijeli naziv!";
                    break;
                case 1:
                    Zanr novi = new Zanr
                    {
                        Naziv = unos
                    };
                    ZanrRepozitorij.DodajZanr(novi);
                    this.Close();
                    break;

            }

            if (dobroPopunjeno != 1)
            {
                MessageBox.Show(poruka);
            }
        }

        private int ProvjeriUnos(string unos)
        {
            if (string.IsNullOrEmpty(unos) || string.IsNullOrWhiteSpace(unos))
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
