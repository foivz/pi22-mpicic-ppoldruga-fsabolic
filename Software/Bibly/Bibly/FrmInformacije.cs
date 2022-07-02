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
        }

        private void FrmInformacije_Load(object sender, EventArgs e)
        {
            PopuniTextBokseve();
            int uloga = Prijava.Autentifikator.Instanca.UlogaKorisnika();
            if (uloga != 4)
            {
                btnUredi.Hide();
                txtRadnoVrijeme.Enabled = false;
                txtClanarina.Enabled = false;
                txtMaxBrojPosudbi.Enabled = false;
                txtTelefon.Enabled = false;
                txtTrajanjePosudbi.Enabled = false;
                txtTrajanjeProduljenja.Enabled = false;
                txtTrajanjeRezervacije.Enabled = false;
                txtZakasnina.Enabled = false;
            }
            if (uloga == 4)
            {
                txtRadnoVrijeme.Enabled = false;
                txtClanarina.Enabled = false;
                txtMaxBrojPosudbi.Enabled = false;
                txtTelefon.Enabled = false;
                txtTrajanjePosudbi.Enabled = false;
                txtTrajanjeProduljenja.Enabled = false;
                txtTrajanjeRezervacije.Enabled = false;
                txtZakasnina.Enabled = false;
                btnUredi.Show();
            }
        }

        private void PopuniTextBokseve()
        {
            txtRadnoVrijeme.Text = Postavke.PostavkeRepozitorij.DohvatiRadnoVrijeme().ToString();
            txtTelefon.Text = Postavke.PostavkeRepozitorij.DohvatiTelefon().ToString();
            txtZakasnina.Text = Postavke.PostavkeRepozitorij.DohvatiIznosZakasnine().ToString() + "  HRK  po danu";
            txtClanarina.Text = Postavke.PostavkeRepozitorij.DohvatiIznosClanarine().ToString() + "  HRK  (godišnja)";
            txtMaxBrojPosudbi.Text = Postavke.PostavkeRepozitorij.DohvatiMaksimalanBrojMogucihPosudbi().ToString();
            txtTrajanjeRezervacije.Text = Postavke.PostavkeRepozitorij.DohvatiTrajanjeRezervacije().ToString() + " dana";
            txtTrajanjePosudbi.Text = Postavke.PostavkeRepozitorij.DohvatiTrajanjePosudbe().ToString() + " dana";
            txtTrajanjeProduljenja.Text = Postavke.PostavkeRepozitorij.DohvatiMaksimalanBrojProduljivanjaPosudbe().ToString() + " puta (max)";

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            btnUredi.Enabled = false;
            btnSpremi.Show();
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
            btnSpremi.Hide();
            btnUredi.Enabled = true;
        }
    }
}
