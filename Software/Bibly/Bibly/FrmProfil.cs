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

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            Korisnik trenutniKorisnik = Autentifikator.Instanca.VratiKorisnika();
            txtOIB.Text = trenutniKorisnik.OIB;
            txtIme.Text = trenutniKorisnik.Ime;
            txtPrezime.Text = trenutniKorisnik.Prezime;
            txtBrojMobitela.Text = trenutniKorisnik.BrojMobitela;
            txtEmail.Text = trenutniKorisnik.Email;
            List<Mjesto> mjesta = MjestoRepozitorij.DohvatiSvaMjesta();
            foreach (Mjesto mjesto in mjesta)
            {
                cmbPrebivaliste.Items.Add(mjesto);
                cmbBoraviste.Items.Add(mjesto);
            }
            cmbPrebivaliste.SelectedIndex = mjesta.IndexOf(mjesta.Find(x=>x.ID==trenutniKorisnik.Prebivaliste.ID));
            txtAdresaPrebivalista.Text = trenutniKorisnik.AdresaPrebivalista;
            cmbBoraviste.SelectedIndex = mjesta.IndexOf(mjesta.Find(x => x.ID == trenutniKorisnik.Boraviste.ID));
            txtAdresaBoravista.Text = trenutniKorisnik.AdresaBoravista;
            txtDatumUclanjivanja.Text = trenutniKorisnik.DatumUclanjivanja.ToString("dd/MM/yyyy");
            txtIstekClanarine.Text = trenutniKorisnik.DatumIstekaClanarine.ToString("dd/MM/yyyy");
            txtTipKorisnika.Text = trenutniKorisnik.TipKorisnika.Naziv;
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {

        }
    }
}
