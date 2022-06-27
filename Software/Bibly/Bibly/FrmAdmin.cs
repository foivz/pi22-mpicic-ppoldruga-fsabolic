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
    public partial class FrmAdmin : FrmOpcenita
    {
        private string NazivTablice = null;
        public FrmAdmin(string nazivTablice)
        {
            InitializeComponent();
            NazivTablice = nazivTablice;
            PostaviFormu();
        }

        private void PostaviFormu()
        {
            lblNazivTablice.Text = "Tablica '"+NazivTablice+"'";
            switch (NazivTablice)
            {
                case "korisnici":
                    dgvTablica.DataSource = KorisnikRepozitorij.DohvatiSveKorisnike();
                    break;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmAdminDodaj frm = new FrmAdminDodaj(NazivTablice);
            frm.ShowDialog();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            FrmAdminDodaj frm = new FrmAdminDodaj(NazivTablice,dgvTablica.CurrentRow.DataBoundItem);
            frm.ShowDialog();
        }
    }
}
