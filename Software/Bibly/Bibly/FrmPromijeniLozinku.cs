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
using Prijava;

namespace Bibly
{
    public partial class FrmPromijeniLozinku : FrmOpcenita
    {
        Korisnik trenutniKorisnik = null;
        public FrmPromijeniLozinku()
        {
            InitializeComponent();
            PostaviGlavniMenu(1);
            this.Text = "Bibly";
            this.CenterToScreen();
            trenutniKorisnik = Autentifikator.Instanca.VratiKorisnika();
            PostaviHelp("PromijeniLozinku.htm");
        }

        private void btnSpremiLozinku_Click(object sender, EventArgs e)
        {

            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                if ((string.IsNullOrEmpty(text.Text) || string.IsNullOrWhiteSpace(text.Text)) && text.Name!="txtStaraLozinka")
                {
                    MessageBox.Show("Nisu popunjena sva polja!");
                    return;
                }
            }
            string uzorak = "";
            uzorak = @"^[A-Z,a-z,ŠĐČĆŽšđčćž,0-9,!#$%&/()=?*@{}]{8,50}$";
            if (!Regex.Match(txtNovaLozinka.Text, uzorak).Success)
            {
                MessageBox.Show("Lozinka mora sadržavati 8 znakova (slova,brojevi i/ili posebne znakove !#$%&/()=?*@{})");
                return;
            }
            if(txtNovaLozinka.Text != txtPotvrdaLozinke.Text)
            {
                MessageBox.Show("Nova lozinka i potvrda lozinke se ne podudaraju!");
                return;
            }

            KorisnikRepozitorij.AzurirajKorisnika_Lozinka(trenutniKorisnik, txtNovaLozinka.Text);
            Close();
        }

        private void txtStaraLozinka_TextChanged(object sender, EventArgs e)
        {
            if (txtStaraLozinka.Text == trenutniKorisnik.Lozinka)
            {
                txtNovaLozinka.Enabled = true;
                txtPotvrdaLozinke.Enabled = true;
                btnSpremiLozinku.Enabled = true;
            }
            else
            {
                txtNovaLozinka.Enabled = false;
                txtPotvrdaLozinke.Enabled = false;
                btnSpremiLozinku.Enabled = false;
            }
        }
    }
}
