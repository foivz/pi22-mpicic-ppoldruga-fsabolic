using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PodaciKnjige;

namespace Bibly
{
    public partial class FrmInventarDodajKnjigu : FrmOpcenita
    {
        private static int top = 500;


        public FrmInventarDodajKnjigu()
        {
            InitializeComponent();
            PopuniComboBoxeve();
        }

        private void PopuniComboBoxeve()
        {
            cmbIzdavac.Items.Clear();
            cmbZanr.Items.Clear();

            List<Izdavac> izdavaci = IzdavacRepozitorij.DohvatiSveIzdavace();
            List<Zanr> zanrovi = ZanrRepozitorij.DohvatiSveZanrove();

            foreach (Zanr zanr in zanrovi)
            {
                cmbZanr.Items.Add(zanr);
            }

            foreach (Izdavac izdavac in izdavaci)
            {
                cmbIzdavac.Items.Add(izdavac);
            }

        }


        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<UCAutor>().Count<UCAutor>() > 1)
            {
                UCAutor uc = this.Controls.OfType<UCAutor>().ToList().LastOrDefault<UCAutor>() as UCAutor;
                if (uc != null)
                {
                    this.Controls.Remove(uc);
                    top -= 50;
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            List<Autor> autori = AutorRepozitorij.DohvatiSveAutore();
            UCAutor uc = new UCAutor();
            uc.Postavi(autori);
            uc.Left = 200;
            uc.Top = top;
            Controls.Add(uc);
            top += 50;

        }

        private void PostaviSliku(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OpenFileDialog OD = new OpenFileDialog();
                OD.FileName = "";
                OD.Filter = "Supported Images |*.jpg;*.jpeg;*.png";
                if (OD.ShowDialog() == DialogResult.OK)
                {
                    ((PictureBox)this.Controls.Find("pbNaslovnica", true)[0]).Load(OD.FileName);

                }
            }
            else
            {
                ((PictureBox)this.Controls.Find("pbNaslovnica", true)[0]).Image = null;
            }

        }
    }
}
