using Prijava;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bibly
{
    public partial class FrmRegistracija : FrmOpcenita
    {
        public FrmRegistracija()
        {
            InitializeComponent();
            AutoScroll = true;
            this.CenterToScreen();
            txtDatumUclanjivanja.Text = DateTime.Now.ToString();
            txtIstekClanarine.Text = DateTime.Now.AddYears(1).ToString();
            cmbBoraviste.DataSource = MjestoRepozitorij.DohvatiSvaMjesta();
            cmbPrebivaliste.DataSource = MjestoRepozitorij.DohvatiSvaMjesta();
        }

        private void btnUclani_Click(object sender, EventArgs e)
        {
            string oib = txtOIB.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string brojMobitela = txtBrojMobitela.Text;
            string email = txtEmail.Text;
            int prebivaliste = cmbPrebivaliste.SelectedIndex;
            string adresaPrebivalista = txtAdresaPrebivalista.Text;
            int boraviste = cmbBoraviste.SelectedIndex;
            string adresaBoravista = txtAdresaBoravista.Text;
            int dobroPopunjeno = ProvjeriUnose(oib, ime, prezime, brojMobitela, email, adresaPrebivalista, adresaBoravista); 
            string poruka = "";
            switch (dobroPopunjeno)
            {
                case -1:
                    poruka = "Niste popunili sva polja!";
                    break;
                case -2:
                    poruka = "OIB je neispravnog formata!";
                    break;
                case -3:
                    poruka = "Pogrešan format imena!";
                    break;
                case -4:
                    poruka = "Pogrešan format prezimena!";
                    break;
                case -5:
                    poruka = "Broj mobitela je pogrešnog formata!";
                    break;
                case -6:
                    poruka = "Email je pogrešnog formata!";
                    break;
                case 1:
                    MessageBox.Show("oddd");
                    break;
            }

            if (dobroPopunjeno != 1)
            {
                MessageBox.Show(poruka);
            }
        }

        private int ProvjeriUnose(string oib, string ime, string prezime, string brojMobitela, string email, string adresaPrebivalista, string adresaBoravista)
        {
            if (string.IsNullOrEmpty(oib) || string.IsNullOrWhiteSpace(oib) || string.IsNullOrEmpty(ime) || string.IsNullOrWhiteSpace(ime) ||
                string.IsNullOrEmpty(prezime) || string.IsNullOrWhiteSpace(prezime) || string.IsNullOrEmpty(brojMobitela) || string.IsNullOrWhiteSpace(brojMobitela) ||
                string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrEmpty(adresaPrebivalista) || string.IsNullOrWhiteSpace(adresaPrebivalista) || 
                string.IsNullOrEmpty(adresaBoravista) || string.IsNullOrWhiteSpace(adresaBoravista))
            {
                return -1;
            }
            else if(!ProvjeraOIBa(oib))
            {
                return -2;
            }
            else if (!ProvjeraImena(ime)){
                return -3;
            }
            else if (!ProvjeraPrezimena(prezime))
            {
                return -4;
            }
            else if (!ProvjeraMobitela(brojMobitela))
            {
                return -5;
            }
            else if (!ProvjeraEmaila(email))
            {
                return -6;
            }
            else
            {
                return 1;
            }
        }
        private bool ProvjeraOIBa(string unos)
        {
            if (unos.Length != 11 || !long.TryParse(unos, out long test))
            {
                return false;
            }

            int oibRacun = 10;
            int kontrolniBroj = int.Parse(unos[10].ToString());
            for (int i = 0; i < unos.Length - 1; i++)
            {
                oibRacun += int.Parse(unos[i].ToString());
                oibRacun = (oibRacun % 10) == 0 ? 10 : oibRacun % 10;
                oibRacun *= 2;
                oibRacun %= 11;
            }
            if ((11 - oibRacun) % 10 != kontrolniBroj)
            {
                return false;
            }
            return true;

        }
        private bool ProvjeraImena(string unos)
        {
            string uzorak = @"^(([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,})(([ ]|[-])([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,}))?)$";
            if (!Regex.Match(unos, uzorak).Success) return false; else return true;

        }

        private bool ProvjeraPrezimena(string unos)
        {
            string uzorak = @"^(([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,})(([ ]|[-])([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,}))?)$";
            if (!Regex.Match(unos, uzorak).Success) return false; else return true;

        }

        private bool ProvjeraMobitela(string unos)
        {
            string uzorak = @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
            if (!Regex.Match(unos, uzorak).Success) return false; else return true;
        }

        private bool ProvjeraEmaila(string unos)
        {
            string uzorak = @"^([A-Z,a-z,ČĆŽĐŠčćžđš][a-z,A-Z,0-9,ČĆŽĐŠčćžđš,_,-]{2,}@[a-z]{2,}[.][a-z][a-z]{1,})$";
            if (!Regex.Match(unos, uzorak).Success) return false; else return true;
        }


    }
}
