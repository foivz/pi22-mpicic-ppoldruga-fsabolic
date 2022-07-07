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
using Prijava;

namespace Bibly
{
    public partial class FrmPosudbe : FrmOpcenita
    {
        private static int top = 200;
        private List<Posudba> listaPosudbi = new List<Posudba>();
        public FrmPosudbe()
        {
            InitializeComponent();
            PostaviHelp("Pregled posudbi.htm");
        }
        private void FrmPosudbe_Load(object sender, EventArgs e)
        {
            top = 200;
            DohvatiTrenutneRezervacije();
            DohvatiProsleRezervacije();
        }
        private void DohvatiTrenutneRezervacije()
        {
            listaPosudbi = PosudbaRepozitorij.DohvatiTrenutnePosudbeKorisnika(Autentifikator.Instanca.VratiKorisnika());
            if (listaPosudbi != null)
            {
                DodajUCPosudbeKnjigaTretnutna(listaPosudbi);
                lblObavijest.Visible = false;
            }
            else
            {
                lblObavijest.Visible = true;
                top = lblObavijest.Top + 50;
            }
        }
        private void DodajUCPosudbeKnjigaTretnutna(List<Posudba> listaPosudbi)
        {
            foreach (Posudba posudba in listaPosudbi)
            {
                UCPosudbeKnjigaTretnutna ucPosudbeKnjigaTretnutna = new UCPosudbeKnjigaTretnutna(posudba);
                ucPosudbeKnjigaTretnutna.Top = top;
                ucPosudbeKnjigaTretnutna.Left = 20;
                Controls.Add(ucPosudbeKnjigaTretnutna);
                top += 350;
            }
        }
        private void DohvatiProsleRezervacije()
        {
            lblProslePosudbe.Visible = true;
            lblProslePosudbe.Top = top;
            top += 50;
            listaPosudbi = PosudbaRepozitorij.DohvatiProslePosudbeKorisnika(Autentifikator.Instanca.VratiKorisnika());
            if (listaPosudbi != null)
            {
                DodajUCPosudbeKnjigaProsla(listaPosudbi);
                lblObavijest2.Visible = false;
            }
            else
            {
                lblObavijest2.Visible = true;
                lblObavijest2.Top = top;
            }
        }
        private void DodajUCPosudbeKnjigaProsla(List<Posudba> listaPosudbi)
        {
            foreach (Posudba posudba in listaPosudbi)
            {
                UCPosudbeKnjigaProsla ucPosudbeKnjigaProsla = new UCPosudbeKnjigaProsla(posudba);
                ucPosudbeKnjigaProsla.Top = top;
                ucPosudbeKnjigaProsla.Left = 20;
                Controls.Add(ucPosudbeKnjigaProsla);
                top += 350;
            }
        }
    }
}
