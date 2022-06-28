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
        private Posudba odabranaPosudba = new Posudba();
        public UCPosudbeKnjigaTretnutna()
        {
            InitializeComponent();
        }
        public void PostaviLabele(Posudba posudba)
        {
            odabranaPosudba = posudba;
            lblNaslov.Text = posudba.Primjerak.Knjiga.Naziv;

            lblBrojProduljivanja.Text = posudba.BrojProduljivanja.ToString();
            lblZakasnina.Text = posudba.Zakasnina.ToString() + " HRK";

            lblPosudba.Text = posudba.PredvideniDatumVracanja.ToShortDateString();

            OmoguciGumbZaProduljenje();
            PrikaziBrojDanaDoPovratka();
        }
        private void PrikaziBrojDanaDoPovratka()
        {
            TimeSpan pomRazlikaDana = odabranaPosudba.PredvideniDatumVracanja.Subtract(DateTime.Today);
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
                double iznosZakasnine = PostavkeRepozitorij.DohvatiIznosZakasnine();
                double zakasnina = (-1)*(iznosZakasnine*razlikaDana);
                odabranaPosudba.Zakasnina = zakasnina;
                lblZakasnina.Text = string.Format("{0:0.00}", zakasnina) + " HRK";
                PosudbaRepozitorij.AzurirajZakasninu(odabranaPosudba.Id, zakasnina);
            }
            else
            {
                lblPosudba.Text += $" (Zadnji dan za vraćanje!)";
            }
        }
        private void btnProdulji_Click(object sender, EventArgs e)
        {
            odabranaPosudba.BrojProduljivanja += 1;
            DateTime noviDatumPosudbe = DateTime.Today.AddDays(PostavkeRepozitorij.DohvatiTrajanjePosudbe());
            PosudbaRepozitorij.ProduljiPosudbu(odabranaPosudba, noviDatumPosudbe);
            lblBrojProduljivanja.Text = (odabranaPosudba.BrojProduljivanja).ToString();
            lblPosudba.Text = noviDatumPosudbe.ToShortDateString();
            PrikaziBrojDanaDoPovratka();
            OmoguciGumbZaProduljenje();
        }
        private void OmoguciGumbZaProduljenje()
        {
            int brojPosudbi = PostavkeRepozitorij.DohvatiMaksimalanBrojProduljivanjaPosudbe();
            if (int.Parse(lblBrojProduljivanja.Text) >= brojPosudbi || odabranaPosudba.Zakasnina != 0)
            {
                btnProdulji.Enabled = false;
                btnProdulji.BackColor = Color.Gray;
            }
        }
    }
}
