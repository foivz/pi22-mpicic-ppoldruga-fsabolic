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
using Postavke;

namespace Bibly
{
    public partial class FrmPregledPosudbi : FrmOpcenita
    {
        private List<Posudba> listaPosudbi = new List<Posudba>();
        public FrmPregledPosudbi()
        {
            InitializeComponent();
        }

        private void FrmPregledPosudbi_Load(object sender, EventArgs e)
        {
            cmbKriteriji.SelectedIndex = 0;
            cmbPrikazi.SelectedIndex = 0;
            RezervacijaRepozitorij.ProvjeriIstekleRezervacije();
            listaPosudbi = PosudbaRepozitorij.DohvatiSvePosudbe();
            foreach(Posudba posudba in listaPosudbi)
            {
                if(posudba.RezervacijaPotvrdena != 0)
                {
                    if (posudba.StvarniDatumVracanja == DateTime.MinValue &&
                        DateTime.Now > posudba.PredvideniDatumVracanja)
                    {
                        posudba.IzracunajZakasninu();
                    }
                }
            }
            OsvjeziPosudbe();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            List<Posudba> pomListaPosudbi = new List<Posudba>();
            switch (cmbPrikazi.Text)
            {
                case "Posudbe":
                    {
                        foreach (Posudba posudba in listaPosudbi)
                        {
                            if (posudba.DatumPosudbe > DateTime.MinValue)
                            {
                                pomListaPosudbi.Add(posudba);
                            }
                        }
                        dgvPosudbe.DataSource = pomListaPosudbi;
                        break;
                    }
                case "Rezervacije":
                    {
                        foreach (Posudba posudba in listaPosudbi)
                        {
                            if (posudba.DoKadaVrijediRezervacija > DateTime.MinValue)
                            {
                                pomListaPosudbi.Add(posudba);
                            }
                        }
                        dgvPosudbe.DataSource = pomListaPosudbi;
                        break;
                    }
                case "Posudbe sa zakasninom":
                    {
                        foreach (Posudba posudba in listaPosudbi)
                        {
                            if (posudba.Zakasnina > 0)
                            {
                                pomListaPosudbi.Add(posudba);
                            }
                        }
                        dgvPosudbe.DataSource = pomListaPosudbi;
                        break;
                    }
                default:
                    {
                        dgvPosudbe.DataSource = listaPosudbi;
                        break;
                    }
            }
        }

        private void btnProdulji_Click(object sender, EventArgs e)
        {
            Posudba posudba = dgvPosudbe.CurrentRow.DataBoundItem as Posudba;
            if (posudba.DatumPosudbe == DateTime.MinValue)
            {
                MessageBox.Show("Pokušavate produljiti rezervaciju.");
                return;
            }
            if (posudba.StvarniDatumVracanja != DateTime.MinValue)
            {
                MessageBox.Show("Pokušavate produljiti posudbu koja je završila.");
                return;
            }
            if (posudba.Zakasnina > 0)
            {
                MessageBox.Show("Pokušavate produljiti posudbu koja kasni s vraćanjem.");
                return;
            }
            if (posudba.BrojProduljivanja + 1 > PostavkeRepozitorij.DohvatiMaksimalanBrojProduljivanjaPosudbe())
            {
                MessageBox.Show("Posudba je produljenja max dozovljenih puta.");
                return;
            }
            PosudbaRepozitorij.ProduljiPosudbu(posudba);
            OsvjeziPosudbe();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            List<Posudba> pomListaPosudbi = new List<Posudba>();
            string rijecPretrazivanja = txtUnosKljucneRijeci.Text.ToLower();
            if (rijecPretrazivanja != "")
            {
                switch (cmbKriteriji.Text)
                {
                    case "Ime i prezime korisnika":
                        {
                            foreach (Posudba posudba in listaPosudbi)
                            {
                                string imePrezimeKorisnika = posudba.Korisnik.Ime.ToLower() + " " + posudba.Korisnik.Prezime.ToLower();
                                if (imePrezimeKorisnika.Contains(rijecPretrazivanja))
                                {
                                    pomListaPosudbi.Add(posudba);
                                }
                            }
                            dgvPosudbe.DataSource = pomListaPosudbi;
                            break;
                        }
                    case "Id primjeraka":
                        {
                            foreach (Posudba posudba in listaPosudbi)
                            {
                                string idPrimjerka = posudba.Primjerak.Id.ToString();
                                if (idPrimjerka.Contains(rijecPretrazivanja))
                                {
                                    pomListaPosudbi.Add(posudba);
                                }
                            }
                            dgvPosudbe.DataSource = pomListaPosudbi;
                            break;
                        }
                    case "Naziv knjige":
                        {
                            foreach (Posudba posudba in listaPosudbi)
                            {
                                if (posudba.Primjerak.Knjiga.Naziv.ToLower().Contains(rijecPretrazivanja))
                                {
                                    pomListaPosudbi.Add(posudba);
                                }
                            }
                            dgvPosudbe.DataSource = pomListaPosudbi;
                            break;
                        }
                    default:
                        {
                            dgvPosudbe.DataSource = listaPosudbi;
                            break;
                        }
                }
            }
            else
            {
                dgvPosudbe.DataSource = listaPosudbi;
            }
        }

        private void OsvjeziPosudbe()
        {
            listaPosudbi = PosudbaRepozitorij.DohvatiSvePosudbe();
            dgvPosudbe.DataSource = listaPosudbi;
            dgvPosudbe.Columns[0].Width = 80;
            dgvPosudbe.Columns[1].Width = 120;
            dgvPosudbe.Columns[1].HeaderText = "Datum posudbe";
            dgvPosudbe.Columns[2].Width = 120;
            dgvPosudbe.Columns[2].HeaderText = "Vrijedi do";
            dgvPosudbe.Columns[3].Width = 120;
            dgvPosudbe.Columns[3].HeaderText = "Datum vraćanja";
            dgvPosudbe.Columns[4].Width = 120;
            dgvPosudbe.Columns[4].HeaderText = "Produljivanja";
            dgvPosudbe.Columns[5].Width = 120;
            dgvPosudbe.Columns[6].Width = 190;
            dgvPosudbe.Columns[7].Width = 190;
            dgvPosudbe.Columns[8].Width = 120;
            dgvPosudbe.Columns[8].HeaderText = "Vrijedi do";
            dgvPosudbe.Columns[9].Width = 120;
            dgvPosudbe.Columns[9].HeaderText = "Status rezervacije";
        }
    }
}
