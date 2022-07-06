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
using PosudbeIRezervacije;
using Postavke;

namespace Bibly
{
    public partial class UCPosudbeKnjigaTretnutna : UserControl
    {
        private Posudba posudba = new Posudba();
        public UCPosudbeKnjigaTretnutna(Posudba odabranaPosudba)
        {
            posudba = odabranaPosudba;
            InitializeComponent();
            PostaviLabele();
        }
        public void PostaviLabele()
        {
            lblNaslov.Text = posudba.Primjerak.Knjiga.Naziv;

            lblBrojProduljivanja.Text = posudba.BrojProduljivanja.ToString();
            lblZakasnina.Text = posudba.Zakasnina.ToString() + " HRK";

            lblPosudba.Text = posudba.PredvideniDatumVracanja.ToShortDateString();

            pbNaslovnica.Image = posudba.Primjerak.Knjiga.Naslovnica;

            OmoguciGumbZaProduljenje();
            PrikaziBrojDanaDoPovratka();
        }
        private void PrikaziBrojDanaDoPovratka()
        {
            TimeSpan pomRazlikaDana = posudba.PredvideniDatumVracanja.Subtract(DateTime.Today);
            int razlikaDana = int.Parse(pomRazlikaDana.TotalDays.ToString());
            //razlike je negativna ako je datum nakon danas, a pozitivan ako je prije danas
            if (razlikaDana == 1)
            {
                lblPosudba.Text += $" (za {razlikaDana} dan)";
            }
            else if (razlikaDana > 0)
            {
                lblPosudba.Text += $" (za {razlikaDana} dana)";
            }
            else if (razlikaDana < 0)
            {
                lblPosudba.Text += $" (Kasnite s vraćanjem!)";
                lblZakasnina.Text = string.Format("{0:0.00}", posudba.IzracunajZakasninu()) + " HRK";
            }
            else
            {
                lblPosudba.Text += $" (Zadnji dan za vraćanje!)";
            }
        }
        private void btnProdulji_Click(object sender, EventArgs e)
        {
            PosudbaRepozitorij.ProduljiPosudbu(posudba);
            posudba.BrojProduljivanja += 1;
            lblBrojProduljivanja.Text = (posudba.BrojProduljivanja).ToString();
            DateTime noviDatumPosudbe = DateTime.Today.AddDays(PostavkeRepozitorij.DohvatiTrajanjePosudbe());
            lblPosudba.Text = noviDatumPosudbe.ToShortDateString();
            PrikaziBrojDanaDoPovratka();
            OmoguciGumbZaProduljenje();
        }
        private void OmoguciGumbZaProduljenje()
        {
            int brojPosudbi = PostavkeRepozitorij.DohvatiMaksimalanBrojProduljivanjaPosudbe();
            if (int.Parse(lblBrojProduljivanja.Text) >= brojPosudbi || posudba.Zakasnina != 0)
            {
                btnProdulji.Enabled = false;
                btnProdulji.BackColor = Color.Gray;
            }
        }
    }
}
