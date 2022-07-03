using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosudbeIRezervacije;

namespace Bibly
{
    public partial class UCPosudbeKnjigaProsla : UserControl
    {
        public UCPosudbeKnjigaProsla()
        {
            InitializeComponent();
        }
        public void PostaviLabele(Posudba posudba)
        {
            lblNaslov.Text = posudba.Primjerak.Knjiga.Naziv;
            lblZakasnina.Text = posudba.Zakasnina.ToString() + " HRK";
            lblPosudba.Text = posudba.StvarniDatumVracanja.ToShortDateString();
            pbNaslovnica.Image = posudba.Primjerak.Knjiga.Naslovnica;
        }
    }
}
