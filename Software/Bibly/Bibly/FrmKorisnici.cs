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
    public partial class FrmKorisnici : FrmOpcenita
    {
        private Korisnik trenutniRed = null;
        public FrmKorisnici()
        {
            InitializeComponent();
            dgvKorisnici.DataSource = KorisnikRepozitorij.DohvatiSveKorisnike();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            FrmAzurirajKorisnika frm = new FrmAzurirajKorisnika(trenutniRed);
            frm.ShowDialog();
            dgvKorisnici.DataSource = KorisnikRepozitorij.DohvatiSveKorisnike();
        }

        private void dgvKorisnici_SelectionChanged(object sender, EventArgs e)
        {
            trenutniRed = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Brišete redak iz baze! Jeste li sigurni?", "Potvrdi", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (trenutniRed != null)
                {
                    KorisnikRepozitorij.ObrisiKorisnika(trenutniRed);
                    dgvKorisnici.DataSource = KorisnikRepozitorij.DohvatiSveKorisnike();
                }
                else
                {
                    MessageBox.Show("Niste odabrali korisnika!");
                }
            }
        }
    }
}
