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
using Skener;
namespace Bibly
{
    public partial class FrmAzurirajKorisnika : FrmOpcenita
    {
        Korisnik trenutniKorisnik = null;
        public FrmAzurirajKorisnika(Korisnik korisnik)
        {
            InitializeComponent();
            this.CenterToScreen();
            trenutniKorisnik = korisnik;
            PopuniFormu();

        }

        private void PopuniFormu()
        {
            List<Mjesto> mjesta = MjestoRepozitorij.DohvatiSvaMjesta();
            txtOIB.Text = trenutniKorisnik.OIB;
            txtIme.Text = trenutniKorisnik.Ime;
            txtPrezime.Text = trenutniKorisnik.Prezime;
            txtBrojMobitela.Text = trenutniKorisnik.BrojMobitela;
            txtEmail.Text = trenutniKorisnik.Email;
            foreach (Mjesto mjesto in mjesta)
            {
                cmbPrebivaliste.Items.Add(mjesto);
                cmbBoraviste.Items.Add(mjesto);
            }
            cmbPrebivaliste.SelectedIndex = mjesta.IndexOf(mjesta.Find(x => x.ID == trenutniKorisnik.Prebivaliste.ID));
            cmbBoraviste.SelectedIndex = mjesta.IndexOf(mjesta.Find(x => x.ID == trenutniKorisnik.Boraviste.ID));
            txtAdresaPrebivalista.Text = trenutniKorisnik.AdresaPrebivalista;
            txtAdresaBoravista.Text = trenutniKorisnik.AdresaBoravista;
            txtDatumUclanjivanja.Text = trenutniKorisnik.DatumUclanjivanja.ToString("dd/MM/yyyy");
            txtIstekClanarine.Text = trenutniKorisnik.DatumIstekaClanarine.ToString("dd/MM/yyyy");
        }

        private void btnGenerirajQRKod_Click(object sender, EventArgs e)
        {
            pbQRKod.Image = Skener.Skener.GenerirajQRKod(trenutniKorisnik.Email);
        }

        private void btnIsprintaj_Click(object sender, EventArgs e)
        {
            if (pbQRKod.Image == null)
            {
                pbQRKod.Image = Skener.Skener.GenerirajQRKod(trenutniKorisnik.Email);
            }

            Skener.Skener.Isprintaj(pbQRKod.Image);

        }
    }
}
