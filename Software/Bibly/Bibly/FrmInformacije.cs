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
    public partial class FrmInformacije : FrmOpcenita
    {
        public FrmInformacije()
        {
            InitializeComponent();
            AutoScroll = true;
            PostaviHelp("Informacije.htm");
        }

        private void FrmInformacije_Load(object sender, EventArgs e)
        {
            PopuniTextBokseve();
            int uloga = Prijava.Autentifikator.Instanca.UlogaKorisnika();
            if (uloga != 4)
            {
                btnSpremi.Hide();
                btnUredi.Hide();

            }
            if (uloga == 4)
            {

                btnUredi.Show();
                btnSpremi.Show();
                btnSpremi.Enabled = false;
            }
        }

        private void PopuniTextBokseve()
        {
            txtRadnoVrijeme.Text = Postavke.PostavkeRepozitorij.DohvatiRadnoVrijeme().ToString();
            txtTelefon.Text = Postavke.PostavkeRepozitorij.DohvatiKontakt().ToString();
            txtZakasnina.Text = Postavke.PostavkeRepozitorij.DohvatiIznosZakasnine().ToString();
            txtClanarina.Text = Postavke.PostavkeRepozitorij.DohvatiClanarinu().ToString();
            txtMaxBrojPosudbi.Text = Postavke.PostavkeRepozitorij.DohvatiMaksimalanBrojMogucihPosudbi().ToString();
            txtTrajanjeRezervacije.Text = Postavke.PostavkeRepozitorij.DohvatiTrajanjeRezervacije().ToString();
            txtTrajanjePosudbi.Text = Postavke.PostavkeRepozitorij.DohvatiTrajanjePosudbe().ToString();
            txtTrajanjeProduljenja.Text = Postavke.PostavkeRepozitorij.DohvatiMaksimalanBrojProduljivanjaPosudbe().ToString();

            txtRadnoVrijeme.Enabled = false;
            txtClanarina.Enabled = false;
            txtMaxBrojPosudbi.Enabled = false;
            txtTelefon.Enabled = false;
            txtTrajanjePosudbi.Enabled = false;
            txtTrajanjeProduljenja.Enabled = false;
            txtTrajanjeRezervacije.Enabled = false;
            txtZakasnina.Enabled = false;

            txtRadnoVrijeme.BackColor = Color.FromArgb(224, 224, 224); 
            txtRadnoVrijeme.BorderStyle = BorderStyle.None;
            txtTelefon.BorderStyle = BorderStyle.None;
            txtTelefon.BackColor = Color.FromArgb(224, 224, 224);
            txtZakasnina.BackColor = Color.FromArgb(224, 224, 224);
            txtZakasnina.BorderStyle = BorderStyle.None;
            txtClanarina.BorderStyle = BorderStyle.None;
            txtClanarina.BackColor = Color.FromArgb(224, 224, 224);
            txtMaxBrojPosudbi.BackColor = Color.FromArgb(224, 224, 224);
            txtMaxBrojPosudbi.BorderStyle = BorderStyle.None;
            txtTrajanjePosudbi.BorderStyle = BorderStyle.None;
            txtTrajanjePosudbi.BackColor = Color.FromArgb(224, 224, 224);
            txtTrajanjeProduljenja.BackColor = Color.FromArgb(224, 224, 224);
            txtTrajanjeProduljenja.BorderStyle = BorderStyle.None;
            txtTrajanjeRezervacije.BackColor = Color.FromArgb(224, 224, 224);
            txtTrajanjeRezervacije.BorderStyle = BorderStyle.None;

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            btnUredi.Enabled = false;
            btnSpremi.Enabled = true;

            txtRadnoVrijeme.Enabled = true;
            txtClanarina.Enabled = true;
            txtMaxBrojPosudbi.Enabled = true;
            txtTelefon.Enabled = true;
            txtTrajanjePosudbi.Enabled = true;
            txtTrajanjeProduljenja.Enabled = true;
            txtTrajanjeRezervacije.Enabled = true;
            txtZakasnina.Enabled = true;

            txtRadnoVrijeme.BackColor = Color.White;
            txtRadnoVrijeme.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.BorderStyle = BorderStyle.FixedSingle;
            txtTelefon.BackColor = Color.White;
            txtZakasnina.BackColor = Color.White;
            txtZakasnina.BorderStyle = BorderStyle.FixedSingle;
            txtClanarina.BorderStyle = BorderStyle.FixedSingle;
            txtClanarina.BackColor = Color.White;
            txtMaxBrojPosudbi.BackColor = Color.White;
            txtMaxBrojPosudbi.BorderStyle = BorderStyle.FixedSingle;
            txtTrajanjePosudbi.BorderStyle = BorderStyle.FixedSingle;
            txtTrajanjePosudbi.BackColor = Color.White;
            txtTrajanjeProduljenja.BackColor = Color.White;
            txtTrajanjeProduljenja.BorderStyle = BorderStyle.FixedSingle;
            txtTrajanjeRezervacije.BackColor = Color.White;
            txtTrajanjeRezervacije.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            btnSpremi.Enabled = false;
            btnUredi.Enabled = true;

            int maxBrojPosudbi = int.Parse(txtMaxBrojPosudbi.Text);
            double zakasnina = double.Parse(txtZakasnina.Text);
            int trajanjeRezervacije = int.Parse(txtTrajanjeRezervacije.Text);
            int trajanjePosudbe = int.Parse(txtTrajanjePosudbi.Text);
            int trajanjeProduljenja = int.Parse(txtTrajanjeProduljenja.Text);
            string radnoVrijeme = txtRadnoVrijeme.Text;
            string kontakt = txtTelefon.Text;
            double clanarina = double.Parse(txtClanarina.Text);

            Postavke.PostavkeRepozitorij.AzurirajInformacije(maxBrojPosudbi, zakasnina, trajanjeRezervacije, trajanjePosudbe, trajanjeProduljenja, radnoVrijeme, kontakt, clanarina);

            PopuniTextBokseve();
        }

    }
}
