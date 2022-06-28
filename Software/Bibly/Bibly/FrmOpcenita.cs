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
    public partial class FrmOpcenita : Form
    {
        public FrmOpcenita()
        {
            InitializeComponent();
            this.CenterToScreen();
            PostaviGlavniMenu();
        }

        public void PostaviGlavniMenu(int sakrijMenu = 0)
        {
            if (sakrijMenu == 1)
            {
                glavniMenu.Visible = false;
                return;
            }

            int uloga = Autentifikator.Instanca.UlogaKorisnika();

            if (uloga == -1 || uloga==1)
            {
                glavniMenu.Visible = false;
            }

            if (uloga < 2)
            {
            }

            if (uloga < 3)
            {
                tsmi_Korisnici.Visible = false;
            }

            if (uloga < 4)
            {
                tsmiAdmin.Visible = false;

            }
        }

        public void OtvoriNovuFormu(FrmOpcenita frm, string naslov = "Bibly")
        {
            this.Hide();
            frm.CenterToScreen();
            frm.Text = naslov;
            frm.ShowDialog();
            this.Close();
        }

        private void tsmiOdjava_Click(object sender, EventArgs e)
        {
            if (!Autentifikator.Instanca.OdjavaKorisnika())
                MessageBox.Show("Došlo je do pogreške u radu aplikacije! Ponovno upalite aplikaciju");
            FrmPrijava frm = new FrmPrijava();
            OtvoriNovuFormu(frm);
        }

        private void tsmiAutor_Knjige_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("autor_knjige");
            OtvoriNovuFormu(frm);
        }

        private void tsmiAutori_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("autori");
            OtvoriNovuFormu(frm);

        }

        private void tsmiIzdavaci_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("izdavaci");
            OtvoriNovuFormu(frm);

        }

        private void tsmiKnjige_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("knjige");
            OtvoriNovuFormu(frm);

        }

        private void tsmiKorisnici_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("korisnici");
            OtvoriNovuFormu(frm);

        }

        private void tsmiMjesta_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("mjesta");
            OtvoriNovuFormu(frm);

        }

        private void tsmiPostavke_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("postavke");
            OtvoriNovuFormu(frm);

        }

        private void tsmiPosudbe_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("posudbe");
            OtvoriNovuFormu(frm);

        }

        private void tsmiPrimjerci_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("primjerci");
            OtvoriNovuFormu(frm);

        }

        private void tsmiStatusi_Primjeraka_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("statusi_primjeraka");
            OtvoriNovuFormu(frm);

        }

        private void tsmiTipovi_Korisnika_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("tipovi_korisnika");
            OtvoriNovuFormu(frm);

        }

        private void tsmiZanrovi_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin("zanrovi");
            OtvoriNovuFormu(frm);

        }

        private void tsmiProfil_Click(object sender, EventArgs e)
        {
            FrmProfil frm = new FrmProfil();
            OtvoriNovuFormu(frm);
        }
        private void tsmi_Korisnici_Click(object sender, EventArgs e)
        {
            FrmKorisnici frm = new FrmKorisnici();
            OtvoriNovuFormu(frm);
        }

        private void tsmiKatalog_Click(object sender, EventArgs e)
        {
            FrmKatalog frm = new FrmKatalog();
            OtvoriNovuFormu(frm);
        }

        private void tsmiRezervacije(object sender, EventArgs e)
        {
            FrmRezervacije frm = new FrmRezervacije();
            OtvoriNovuFormu(frm);
        }

        private void tsmiPosudbeKorisnika_Click(object sender, EventArgs e)
        {
            FrmPosudbe frm = new FrmPosudbe();
            OtvoriNovuFormu(frm);
        }

        private void tsmiRezervacijeKorisnika_Click(object sender, EventArgs e)
        {
            FrmRezervacije frm = new FrmRezervacije();
            OtvoriNovuFormu(frm);
        }

        private void tsmiRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistracija frm = new FrmRegistracija();
            OtvoriNovuFormu(frm);
        }
    }
}
