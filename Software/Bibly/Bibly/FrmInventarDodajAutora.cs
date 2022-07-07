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
    public partial class FrmInventarDodajAutora : Form
    {
        public FrmInventarDodajAutora()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;

            string prezime = txtPrezime.Text;

            string biografija = txtBiografija.Text;

            string poruka = "";

            int dobroPopunjeno = ProvjeriUnos(ime, prezime, biografija);

            switch (dobroPopunjeno)
            {
                case -1:
                    poruka = "Niste unijeli ime!";
                    break;
                case -2:
                    poruka = "Niste unijeli prezime!";
                    break;
                case -3:
                    poruka = "Niste unijeli biografiju!";
                    break;
                case 1:
                    AutorRepozitorij.DodajAutora(new Autor
                    {
                        Ime = ime,
                        Prezime = prezime,
                        Biografija = biografija
                    });
                    this.Close();
                    break;

            }

            if (dobroPopunjeno != 1)
            {
                MessageBox.Show(poruka);
            }
        }

        private int ProvjeriUnos(string ime, string prezime, string biografija)
        {
            if (string.IsNullOrEmpty(ime) || string.IsNullOrWhiteSpace(ime))
            {
                return -1;
            }
            else if (string.IsNullOrEmpty(prezime) || string.IsNullOrWhiteSpace(prezime))
            {
                return -2;
            }
            else if (string.IsNullOrEmpty(biografija) || string.IsNullOrWhiteSpace(biografija))
            {
                return -3;
            }
            else
            {
                return 1;
            }
        }
    }
}
