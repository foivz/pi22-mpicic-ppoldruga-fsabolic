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

    }
}
