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
using PodaciKnjige;
namespace Bibly
{
    public partial class FrmAdmin : FrmOpcenita
    {
        private string NazivTablice = null;
        private object TrenutniRed = null;
        public FrmAdmin(string nazivTablice)
        {
            InitializeComponent();
            NazivTablice = nazivTablice;
            PostaviFormu();
        }

        private void PostaviFormu()
        {
            lblNazivTablice.Text = "Tablica '" + NazivTablice + "'";
            switch (NazivTablice)
            {
                case "autor_knjige":
                    dgvTablica.DataSource = AutorKnjigeRepozitorij.DohvatiSveAutorKnjige();
                    break;
                case "autori":
                    dgvTablica.DataSource = AutorRepozitorij.DohvatiSveAutore();
                    break;
                case "izdavaci":
                    dgvTablica.DataSource = IzdavacRepozitorij.DohvatiSveIzdavace();
                    break;
                case "korisnici":
                    dgvTablica.DataSource = KorisnikRepozitorij.DohvatiSveKorisnike();
                    break;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmAdminDodaj frm = new FrmAdminDodaj(NazivTablice);
            frm.ShowDialog();
            PostaviFormu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (TrenutniRed != null)
            {
                FrmAdminDodaj frm = new FrmAdminDodaj(NazivTablice, TrenutniRed);
                frm.ShowDialog();
                PostaviFormu();
            }
            else
            {
                MessageBox.Show("Nije odabran ni jedan red");
            }
        }

        private void dgvTablica_SelectionChanged(object sender, EventArgs e)
        {
            TrenutniRed = dgvTablica.CurrentRow.DataBoundItem;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Brišete redak iz baze! Jeste li sigurni?", "Potvrdi", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (TrenutniRed == null)
                {
                    MessageBox.Show("Nije odabran ni jedan red");
                    return;
                }
                switch (NazivTablice)
                {

                    case "autor_knjige":
                        if (TrenutniRed != null)
                        {
                            AutorKnjigeRepozitorij.ObrisiAutoraKnjige((AutorKnjige)TrenutniRed);
                        }
                        PostaviFormu();
                        break;

                    case "autori":
                        if (TrenutniRed != null)
                        {
                            AutorRepozitorij.ObrisiAutora((Autor)TrenutniRed);
                        }
                        PostaviFormu();
                        break;
                    case "izdavaci":
                        if (TrenutniRed != null)
                        {
                            IzdavacRepozitorij.ObrisiIzdavaca((Izdavac)TrenutniRed);
                        }
                        PostaviFormu();
                        break;
                    case "korisnici":
                        if (TrenutniRed != null)
                        {
                            KorisnikRepozitorij.ObrisiKorisnika((Korisnik)TrenutniRed);
                        }
                        PostaviFormu();
                        break;
                }
            }
        }
    }
}
