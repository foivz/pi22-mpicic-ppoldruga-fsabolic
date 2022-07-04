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
using System.Text.RegularExpressions;
using PodaciKnjige;
using PosudbeIRezervacije;
using Postavke;
namespace Bibly
{
    public partial class FrmAdminDodaj : FrmOpcenita
    {
        object TrenutniObjekt = null;
        string NazivTablice = null;
        int top = 30;
        public FrmAdminDodaj(string nazivTablice, object trenutniObjekt = null)
        {
            InitializeComponent();
            PostaviGlavniMenu(1);
            TrenutniObjekt = trenutniObjekt;
            NazivTablice = nazivTablice;
            this.AutoScroll = true;
            PostaviKontrole();
            PostaviHelp("AdminDodaj.htm");
        }

        private void PostaviKontrole()
        {
            switch (NazivTablice)
            {
                case "autor_knjige":
                    PostaviFormu_AutorKnjige();
                    break;
                case "autori":

                    PostaviFormu_Autori();
                    break;
                case "izdavaci":
                    PostaviFormu_Izdavaci();
                    break;
                case "knjige":
                    PostaviFormu_Knjige();
                    break;
                case "korisnici":
                    PostaviFormu_Korisnici();
                    break;
                case "mjesta":

                    PostaviFormu_Mjesta();
                    break;
                case "postavke":
                    PostaviFormu_Postavke();
                    break;
                case "posudbe":
                    PostaviFormu_Posudbe();
                    break;
                case "primjerci":

                    PostaviFormu_Primjerci();
                    break;

                case "tipovi_korisnika":

                    PostaviFormu_TipoviKorisnika();
                    break;
                case "zanrovi":
                    PostaviFormu_Zanrovi();
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void PostaviFormu_Postavke()
        {
            this.Controls.Add(PostaviTextBox("txtMaxBrojPosudbi", "lblMaxBrojPosudbi", "Max broj posudbi", true));
            this.Controls.Add(PostaviTextBox("txtZakasnina", "lblZakasnina", "Zakasnina", true));
            this.Controls.Add(PostaviTextBox("txtTrajanjeRezervacije", "lblTrajanjeRezervacije", "Trajanje rezervacije", true));
            this.Controls.Add(PostaviTextBox("txtTrajanjePosudbe", "lblTrajanjePosudbe", "Trajanje posudbe", true));
            this.Controls.Add(PostaviTextBox("txtTrajanjeProduljenja", "lblTrajanjeProduljenja", "Trajanje produljenja", true));
            this.Controls.Add(PostaviTextBox("txtRadnoVrijeme", "lblRadnoVrijeme", "Radno vrijeme", true));
            this.Controls.Add(PostaviTextBox("txtKontakt", "lblKontakt", "Kontakt", true));
            this.Controls.Add(PostaviTextBox("txtClanarina", "lblClanarina", "Članarina", true));
            ((TextBox)this.Controls.Find("txtMaxBrojPosudbi", true)[0]).Text = PostavkeRepozitorij.DohvatiMaksimalanBrojMogucihPosudbi().ToString();
            ((TextBox)this.Controls.Find("txtZakasnina", true)[0]).Text = PostavkeRepozitorij.DohvatiIznosZakasnine().ToString();
            ((TextBox)this.Controls.Find("txtTrajanjeRezervacije", true)[0]).Text = PostavkeRepozitorij.DohvatiTrajanjeRezervacije().ToString();
            ((TextBox)this.Controls.Find("txtTrajanjePosudbe", true)[0]).Text = PostavkeRepozitorij.DohvatiTrajanjePosudbe().ToString();
            ((TextBox)this.Controls.Find("txtTrajanjeProduljenja", true)[0]).Text = PostavkeRepozitorij.DohvatiMaksimalanBrojProduljivanjaPosudbe().ToString();
            ((TextBox)this.Controls.Find("txtRadnoVrijeme", true)[0]).Text = PostavkeRepozitorij.DohvatiRadnoVrijeme().ToString();
            ((TextBox)this.Controls.Find("txtKontakt", true)[0]).Text = PostavkeRepozitorij.DohvatiKontakt().ToString();
            ((TextBox)this.Controls.Find("txtClanarina", true)[0]).Text = PostavkeRepozitorij.DohvatiClanarinu().ToString();
            btnSpremi.Top = top + 15;
            btnSpremi.Click += new EventHandler(PostavkeValidacija);



        }

        private void PostavkeValidacija(object sender, EventArgs e)
        {
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                t.BackColor = Color.FromArgb(254, 255, 242);
            }
            if (UnesenTekst())
            {
                PostavkeRepozitorij.AzurirajInformacije(
                    int.Parse(((TextBox)this.Controls.Find("txtMaxBrojPosudbi", true)[0]).Text),
                double.Parse(((TextBox)this.Controls.Find("txtZakasnina", true)[0]).Text),
                int.Parse(((TextBox)this.Controls.Find("txtTrajanjeRezervacije", true)[0]).Text),
                int.Parse(((TextBox)this.Controls.Find("txtTrajanjePosudbe", true)[0]).Text),
                int.Parse(((TextBox)this.Controls.Find("txtTrajanjeProduljenja", true)[0]).Text),
                ((TextBox)this.Controls.Find("txtRadnoVrijeme", true)[0]).Text,
                ((TextBox)this.Controls.Find("txtKontakt", true)[0]).Text,
                double.Parse(((TextBox)this.Controls.Find("txtClanarina", true)[0]).Text)
                );
                Close();
            }
        }

        private void PostaviFormu_Knjige()
        {
            this.Controls.Add(PostaviTextBox("txtISBN", "lblISBN", "ISBN", true));
            this.Controls.Add(PostaviTextBox("txtNaziv", "lblNaziv", "Naziv", true));
            ComboBox izdavac = PostaviComboBox("cmbIzdavac", "lblIzdavac", "Izdavač");
            foreach (Izdavac i in IzdavacRepozitorij.DohvatiSveIzdavace())
            {
                izdavac.Items.Add(i);
            }
            izdavac.SelectedIndex = 0;
            this.Controls.Add(izdavac);
            ComboBox zanr = PostaviComboBox("cmbZanr", "lblZanr", "Žanr");
            foreach (Zanr z in ZanrRepozitorij.DohvatiSveZanrove())
            {
                zanr.Items.Add(z);
            }
            zanr.SelectedIndex = 0;
            this.Controls.Add(zanr);
            this.Controls.Add(PostaviTextBox("txtDatumIzdavanja", "lblDatumIzdavanja", "Datum izdavanja", true));
            this.Controls.Add(PostaviTextBox("txtBrojStranica", "lblBrojStranica", "Broj stranica", true));
            this.Controls.Add(PostaviTextBox("txtOpisKnjige", "lblOpisKnjige", "Opis knjige", true));
            this.Controls.Add(PostaviPictureBox("pbNaslovnica", "lblNaslovnica", "Naslovnica"));
            ((PictureBox)this.Controls.Find("pbNaslovnica", true)[0]).MouseClick += new MouseEventHandler(PostaviSliku);
            btnSpremi.Top = top + 15;
            btnSpremi.Click += new EventHandler(KnjigeValidacija);
            if (TrenutniObjekt != null)
            {
                Knjiga knjiga = (Knjiga)TrenutniObjekt;
                ((TextBox)this.Controls.Find("txtISBN", true)[0]).Text = knjiga.ISBN.ToString();
                ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text = knjiga.Naziv.ToString();
                List<Izdavac> izdavaci = IzdavacRepozitorij.DohvatiSveIzdavace();
                ((ComboBox)this.Controls.Find("cmbIzdavac", true)[0]).SelectedIndex = izdavaci.IndexOf(izdavaci.Find(x => x.Id == knjiga.Izdavac.Id));
                List<Zanr> zanrovi = ZanrRepozitorij.DohvatiSveZanrove();
                ((ComboBox)this.Controls.Find("cmbZanr", true)[0]).SelectedIndex = zanrovi.IndexOf(zanrovi.Find(x => x.Id == knjiga.Zanr.Id));
                ((TextBox)this.Controls.Find("txtDatumIzdavanja", true)[0]).Text = knjiga.DatumIzdavanja.ToString();
                ((TextBox)this.Controls.Find("txtBrojStranica", true)[0]).Text = knjiga.BrojStranica.ToString();
                ((TextBox)this.Controls.Find("txtOpisKnjige", true)[0]).Text = knjiga.Opis.ToString();
                ((PictureBox)this.Controls.Find("pbNaslovnica", true)[0]).Image = knjiga.Naslovnica;
            }
        }

        private void KnjigeValidacija(object sender, EventArgs e)
        {
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                t.BackColor = Color.FromArgb(254, 255, 242);
            }

            if (UnesenTekst())
            {

                Knjiga knjiga = new Knjiga(
                    ((TextBox)this.Controls.Find("txtISBN", true)[0]).Text,
                    ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text,
                    ((ComboBox)this.Controls.Find("cmbIzdavac", true)[0]).SelectedItem as Izdavac,
                    ((ComboBox)this.Controls.Find("cmbZanr", true)[0]).SelectedItem as Zanr,
                    DateTime.Parse(DateTime.Parse(((TextBox)this.Controls.Find("txtDatumIzdavanja", true)[0]).Text).Date.ToString("yyyy-MM-dd")),
                    int.Parse(((TextBox)this.Controls.Find("txtBrojStranica", true)[0]).Text),
                    ((TextBox)this.Controls.Find("txtOpisKnjige", true)[0]).Text == "" ? null : ((TextBox)this.Controls.Find("txtOpisKnjige", true)[0]).Text,
                    ((PictureBox)this.Controls.Find("pbNaslovnica", true)[0]).Image,
                    null);

                if (TrenutniObjekt == null)
                {
                    KnjigaRepozitorij.DodajKnjigu(knjiga);
                }
                else
                {
                    string stariISBN = ((Knjiga)TrenutniObjekt).ISBN;
                    KnjigaRepozitorij.AzurirajKnjigu(stariISBN, knjiga);
                }

                Close();
            }
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

        private void PostaviFormu_Posudbe()
        {
            this.Controls.Add(PostaviTextBox("txtID", "lblID", "ID", false));
            this.Controls.Add(PostaviTextBox("txtDatumPosudbe", "lblDatumPosudbe", "Datum posudbe", true));
            this.Controls.Add(PostaviTextBox("txtPredvidenDatumVracanja", "lblPredivenDatumVracanja", "Predviđen datum vraćanja", true));
            this.Controls.Add(PostaviTextBox("txtStvarniDatumVracanja", "lblStvarniDatumVracanja", "Stvarni datum vraćanja", true));
            this.Controls.Add(PostaviTextBox("txtBrojProduljivanja", "lblBrojProduljivanja", "Broj produljivanja", true));
            this.Controls.Add(PostaviTextBox("txtZakasnina", "lblZakasnina", "Zakasnina", true));
            ComboBox primjerak = PostaviComboBox("cmbPrimjerak", "lblPrimjerak", "Primjerak");
            foreach (Primjerak p in PrimjerakRepozitorij.DohvatiSvePrimjerke())
            {
                primjerak.Items.Add(p);
            }
            primjerak.SelectedIndex = 0;
            this.Controls.Add(primjerak);
            ComboBox korisnik = PostaviComboBox("cmbKorisnik", "lblKorisnik", "Korisnik");
            foreach (Korisnik k in KorisnikRepozitorij.DohvatiSveKorisnike())
            {
                korisnik.Items.Add(k);
            }
            korisnik.SelectedIndex = 0;
            this.Controls.Add(korisnik);
            this.Controls.Add(PostaviTextBox("txtDoKadaVrijediRezervacija", "lblDoKadaVrijediRezervacija", "Do kada vrijedi rezervacija", true));
            this.Controls.Add(PostaviTextBox("txtRezervacijaPotvrdena", "lblRezervacijaPotvrdena", "Rezervacija potvrđena", true));
            btnSpremi.Top = top + 15;
            btnSpremi.Click += new EventHandler(PosudbeValidacija);
            if (TrenutniObjekt != null)
            {
                Posudba posudba = (Posudba)TrenutniObjekt;
                ((TextBox)this.Controls.Find("txtID", true)[0]).Text = posudba.Id.ToString();
                ((TextBox)this.Controls.Find("txtDatumPosudbe", true)[0]).Text = posudba.DatumPosudbe == default ? "" : posudba.DatumPosudbe.ToString("dd/MM/yyyy");
                ((TextBox)this.Controls.Find("txtPredvidenDatumVracanja", true)[0]).Text = posudba.PredvideniDatumVracanja == default ? "" : posudba.PredvideniDatumVracanja.ToString("dd/MM/yyyy");
                ((TextBox)this.Controls.Find("txtStvarniDatumVracanja", true)[0]).Text = posudba.StvarniDatumVracanja == default ? "" : posudba.StvarniDatumVracanja.ToString("dd/MM/yyyy");
                ((TextBox)this.Controls.Find("txtBrojProduljivanja", true)[0]).Text = posudba.BrojProduljivanja.ToString();
                ((TextBox)this.Controls.Find("txtZakasnina", true)[0]).Text = posudba.Zakasnina.ToString();
                List<Primjerak> primjerci = PrimjerakRepozitorij.DohvatiSvePrimjerke();
                ((ComboBox)this.Controls.Find("cmbPrimjerak", true)[0]).SelectedIndex = primjerci.IndexOf(primjerci.Find(x => x.Id == posudba.Primjerak.Id));
                List<Korisnik> korisnici = KorisnikRepozitorij.DohvatiSveKorisnike();
                ((ComboBox)this.Controls.Find("cmbKorisnik", true)[0]).SelectedIndex = korisnici.IndexOf(korisnici.Find(x => x.OIB == posudba.Korisnik.OIB));
                ((TextBox)this.Controls.Find("txtDoKadaVrijediRezervacija", true)[0]).Text = posudba.DoKadaVrijediRezervacija == default ? "" : posudba.DoKadaVrijediRezervacija.ToString("dd/MM/yyyy");
                ((TextBox)this.Controls.Find("txtRezervacijaPotvrdena", true)[0]).Text = posudba.RezervacijaPotvrdena.ToString() == "-1" ? "" : posudba.RezervacijaPotvrdena.ToString();
            }
        }

        private void PosudbeValidacija(object sender, EventArgs e)
        {
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                t.BackColor = Color.FromArgb(254, 255, 242);
            }
            string id = ((TextBox)this.Controls.Find("txtID", true)[0]).Text;
            string datumPosudbe = ((TextBox)this.Controls.Find("txtDatumPosudbe", true)[0]).Text;
            string predvideniDatumVracanja = ((TextBox)this.Controls.Find("txtPredvidenDatumVracanja", true)[0]).Text;
            string stvarniDatumVracanja = ((TextBox)this.Controls.Find("txtStvarniDatumVracanja", true)[0]).Text;
            string brojProduljivanja = ((TextBox)this.Controls.Find("txtBrojProduljivanja", true)[0]).Text;
            string zakasnina = ((TextBox)this.Controls.Find("txtZakasnina", true)[0]).Text;
            string doKadaVrijediRezervacija = ((TextBox)this.Controls.Find("txtDoKadaVrijediRezervacija", true)[0]).Text;
            string rezervacijaPotvrdena = ((TextBox)this.Controls.Find("txtRezervacijaPotvrdena", true)[0]).Text;

            if ((String.IsNullOrEmpty(datumPosudbe) || String.IsNullOrWhiteSpace(datumPosudbe)) && (String.IsNullOrEmpty(doKadaVrijediRezervacija) || String.IsNullOrWhiteSpace(doKadaVrijediRezervacija)))
            {
                MessageBox.Show("Niste unijeli ni posudbu ni rezervaciju!");
                return;
            }

            if ((String.IsNullOrEmpty(datumPosudbe) || String.IsNullOrWhiteSpace(datumPosudbe)) && !(String.IsNullOrEmpty(predvideniDatumVracanja) || String.IsNullOrWhiteSpace(predvideniDatumVracanja)))
            {
                MessageBox.Show("Niste unijeli datum posudbe, a unijeli ste predviđeni datum vraćanja");
                return;
            }
            if (!(String.IsNullOrEmpty(datumPosudbe) || String.IsNullOrWhiteSpace(datumPosudbe)) && (String.IsNullOrEmpty(predvideniDatumVracanja) || String.IsNullOrWhiteSpace(predvideniDatumVracanja)))
            {
                MessageBox.Show("Niste unijeli predviđeni datum vraćanja");
                return;
            }
            if ((String.IsNullOrEmpty(datumPosudbe) || String.IsNullOrWhiteSpace(datumPosudbe)) && !(String.IsNullOrEmpty(stvarniDatumVracanja) || String.IsNullOrWhiteSpace(stvarniDatumVracanja)))
            {
                MessageBox.Show("Niste unijeli datum posudbe, a unijeli ste stvarni datum vraćanja");
                return;
            }
            if ((String.IsNullOrEmpty(predvideniDatumVracanja) || String.IsNullOrWhiteSpace(predvideniDatumVracanja)) && !(String.IsNullOrEmpty(stvarniDatumVracanja) || String.IsNullOrWhiteSpace(stvarniDatumVracanja)))
            {
                MessageBox.Show("Niste unijeli predviđeni datum vraćanja, a unijeli ste stvarni datum vraćanja");
                return;
            }

            if (!(String.IsNullOrEmpty(rezervacijaPotvrdena) || String.IsNullOrWhiteSpace(rezervacijaPotvrdena)) && (String.IsNullOrEmpty(doKadaVrijediRezervacija) || String.IsNullOrWhiteSpace(doKadaVrijediRezervacija)))
            {
                MessageBox.Show("Niste unijeli do kada vrijedi rezervacija, a unijeli ste potvrdu rezervacije");
                return;
            }
            if (!(String.IsNullOrEmpty(datumPosudbe) || String.IsNullOrWhiteSpace(datumPosudbe)) && !(String.IsNullOrEmpty(doKadaVrijediRezervacija) || String.IsNullOrWhiteSpace(doKadaVrijediRezervacija)) && (String.IsNullOrEmpty(rezervacijaPotvrdena) || String.IsNullOrWhiteSpace(rezervacijaPotvrdena)))
            {
                MessageBox.Show("Krenuli ste unositi posudbu, a niste do kraja unijeli rezervaciju");
                return;
            }

            List<TextBox> list = new List<TextBox>();
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                if (!(String.IsNullOrEmpty(t.Text) || String.IsNullOrWhiteSpace(t.Text)))
                    switch (t.Name)
                    {
                        case "txtDatumPosudbe":
                        case "txtPredvidenDatumVracanja":
                        case "txtStvarniDatumVracanja":
                        case "txtDoKadaVrijediRezervacija":
                            if (!DateTime.TryParse(t.Text, out DateTime test))
                            {
                                IspisGreske(t, "Pogrešan format datuma");
                                return;
                            }
                            break;
                        case "txtBrojProduljivanja":
                        case "txtRezervacijaPotvrdena":
                            if (!int.TryParse(t.Text, out int test1))
                            {
                                IspisGreske(t, "Nije unesen broj!");
                                return;
                            }
                            break;
                        case "txtZakasnina":
                            double test2;
                            if (!double.TryParse(t.Text, out test2))
                            {
                                IspisGreske(t, "Nije unesen pravilan decimalan broj!");
                                return;
                            }
                            else
                            {
                                if (Decimal.Round((Decimal)test2, 2) != (Decimal)test2)
                                {
                                    IspisGreske(t, "Nije unesen pravilan decimalan broj!");
                                    return;
                                }
                            }
                            break;
                    }
            }

            Posudba posudba = new Posudba(
                int.Parse(((TextBox)this.Controls.Find("txtID", true)[0]).Text == "" ? "-1" : ((TextBox)this.Controls.Find("txtID", true)[0]).Text),
            ((TextBox)this.Controls.Find("txtDatumPosudbe", true)[0]).Text == "" ? default : DateTime.Parse(((TextBox)this.Controls.Find("txtDatumPosudbe", true)[0]).Text),
            ((TextBox)this.Controls.Find("txtPredvidenDatumVracanja", true)[0]).Text == "" ? default : DateTime.Parse(((TextBox)this.Controls.Find("txtPredvidenDatumVracanja", true)[0]).Text),
            ((TextBox)this.Controls.Find("txtStvarniDatumVracanja", true)[0]).Text == "" ? default : DateTime.Parse(((TextBox)this.Controls.Find("txtStvarniDatumVracanja", true)[0]).Text),
            ((TextBox)this.Controls.Find("txtBrojProduljivanja", true)[0]).Text == "" ? 0 : int.Parse(((TextBox)this.Controls.Find("txtBrojProduljivanja", true)[0]).Text),
            ((TextBox)this.Controls.Find("txtZakasnina", true)[0]).Text == "" ? 0 : double.Parse(((TextBox)this.Controls.Find("txtZakasnina", true)[0]).Text),
            ((ComboBox)this.Controls.Find("cmbPrimjerak", true)[0]).SelectedItem as Primjerak,
            ((ComboBox)this.Controls.Find("cmbKorisnik", true)[0]).SelectedItem as Korisnik,
            ((TextBox)this.Controls.Find("txtDoKadaVrijediRezervacija", true)[0]).Text == "" ? default : DateTime.Parse(((TextBox)this.Controls.Find("txtDoKadaVrijediRezervacija", true)[0]).Text),
            ((TextBox)this.Controls.Find("txtRezervacijaPotvrdena", true)[0]).Text == "" ? -1 : int.Parse(((TextBox)this.Controls.Find("txtRezervacijaPotvrdena", true)[0]).Text) % 2
            );

            if (TrenutniObjekt != null)
            {
                PosudbaRepozitorij.AzurirajPosudbu(posudba);
            }
            else
            {
                PosudbaRepozitorij.DodajPosudbu(posudba);
            }
            Close();

        }

        private void PostaviFormu_Zanrovi()
        {
            this.Controls.Add(PostaviTextBox("txtID", "lblID", "ID", false));
            this.Controls.Add(PostaviTextBox("txtNaziv", "lblNaziv", "Naziv"));
            btnSpremi.Top = top + 15;
            btnSpremi.Click += new EventHandler(ZanrValidacija);
            if (TrenutniObjekt != null)
            {
                Zanr zanr = (Zanr)TrenutniObjekt;
                ((TextBox)this.Controls.Find("txtID", true)[0]).Text = zanr.Id.ToString();
                ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text = zanr.Naziv;
            }
        }

        private void ZanrValidacija(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>();
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                list.Add(t);
            }

            if (UnesenTekst())
            {
                Zanr zanr = new Zanr(
                ((String.IsNullOrEmpty(((TextBox)this.Controls.Find("txtID", true)[0]).Text)) ? -1 : int.Parse(((TextBox)this.Controls.Find("txtID", true)[0]).Text)),
                ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text
                );
                if (TrenutniObjekt == null)
                {
                    ZanrRepozitorij.DodajZanr(zanr);
                }
                else
                {
                    ZanrRepozitorij.AzurirajZanr(zanr);
                }

                Close();
            }
        }

        private void PostaviFormu_TipoviKorisnika()
        {
            this.Controls.Add(PostaviTextBox("txtID", "lblID", "ID", false));
            this.Controls.Add(PostaviTextBox("txtNaziv", "lblNaziv", "Naziv"));
            btnSpremi.Top = top + 15;
            btnSpremi.Click += new EventHandler(TipKorisnikaValidacija);
            if (TrenutniObjekt != null)
            {
                TipKorisnika tipKorisnika = (TipKorisnika)TrenutniObjekt;
                ((TextBox)this.Controls.Find("txtID", true)[0]).Text = tipKorisnika.ID.ToString();
                ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text = tipKorisnika.Naziv;
            }
        }

        private void TipKorisnikaValidacija(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>();
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                list.Add(t);
            }

            if (UnesenTekst())
            {
                TipKorisnika tipKorisnika = new TipKorisnika(
                ((String.IsNullOrEmpty(((TextBox)this.Controls.Find("txtID", true)[0]).Text)) ? -1 : int.Parse(((TextBox)this.Controls.Find("txtID", true)[0]).Text)),
                ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text
                );
                if (TrenutniObjekt == null)
                {
                    TipKorisnikaRepozitorij.DodajTipKorisnika(tipKorisnika);
                }
                else
                {
                    TipKorisnikaRepozitorij.AzurirajTipKorisnika(tipKorisnika);
                }

                Close();
            }
        }

        private void PostaviFormu_Primjerci()
        {
            this.Controls.Add(PostaviTextBox("txtID", "lblID", "ID", false));
            ComboBox knjiga = PostaviComboBox("cmbKnjiga", "lblKnjiga", "Knjiga");
            foreach (Knjiga k in KnjigaRepozitorij.DohvatiSveKnjige())
            {
                knjiga.Items.Add(k);
            }
            knjiga.SelectedIndex = 0;
            this.Controls.Add(knjiga);
            List<StatusPrimjerka> statusiPrimjeraka = new List<StatusPrimjerka>();
            ComboBox statusPrimjerka = PostaviComboBox("cmbStatusPrimjerka", "lblStatusPrimjerka", "Status primjerka");
            foreach (StatusPrimjerka item in Enum.GetValues(typeof(StatusPrimjerka)))
            {
                statusPrimjerka.Items.Add(item);
                statusiPrimjeraka.Add(item);
            }
            statusPrimjerka.Items.Remove(StatusPrimjerka.Greska);
            statusPrimjerka.SelectedIndex = 0;
            this.Controls.Add(statusPrimjerka);
            btnSpremi.Top = top + 15;
            btnSpremi.Click += new EventHandler(PrimjerciValidacija);
            if (TrenutniObjekt != null)
            {
                Primjerak primjerak = (Primjerak)TrenutniObjekt;
                ((TextBox)this.Controls.Find("txtID", true)[0]).Text = primjerak.Id.ToString();
                List<Knjiga> knjige = KnjigaRepozitorij.DohvatiSveKnjige();
                ((ComboBox)this.Controls.Find("cmbKnjiga", true)[0]).SelectedIndex = knjige.IndexOf(knjige.Find(x => x.ISBN == primjerak.Knjiga.ISBN));
                ((ComboBox)this.Controls.Find("cmbStatusPrimjerka", true)[0]).SelectedItem = primjerak.Status;

            }
        }

        private void PrimjerciValidacija(object sender, EventArgs e)
        {
            Primjerak primjerak = new Primjerak(
                ((String.IsNullOrEmpty(((TextBox)this.Controls.Find("txtID", true)[0]).Text)) ? -1 : int.Parse(((TextBox)this.Controls.Find("txtID", true)[0]).Text)),
                (StatusPrimjerka)((ComboBox)this.Controls.Find("cmbStatusPrimjerka", true)[0]).SelectedItem,
                (Knjiga)((ComboBox)this.Controls.Find("cmbKnjiga", true)[0]).SelectedItem,
                null
                );
            if (TrenutniObjekt == null)
            {
                PrimjerakRepozitorij.DodajPrimjerak(primjerak);
            }
            else
            {
                PrimjerakRepozitorij.AzurirajPrimjerak(primjerak);
            }
            Close();

        }

        private void PostaviFormu_Mjesta()
        {
            this.Controls.Add(PostaviTextBox("txtID", "lblID", "ID", false));
            this.Controls.Add(PostaviTextBox("txtNaziv", "lblNaziv", "Naziv"));
            btnSpremi.Top = top + 15;
            btnSpremi.Click += new EventHandler(MjestaValidacija);
            if (TrenutniObjekt != null)
            {
                Mjesto mjesto = (Mjesto)TrenutniObjekt;
                ((TextBox)this.Controls.Find("txtID", true)[0]).Text = mjesto.ID.ToString();
                ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text = mjesto.Naziv;
            }
        }

        private void MjestaValidacija(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>();
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                list.Add(t);
            }

            if (UnesenTekst())
            {
                Mjesto mjesto = new Mjesto(
                ((String.IsNullOrEmpty(((TextBox)this.Controls.Find("txtID", true)[0]).Text)) ? -1 : int.Parse(((TextBox)this.Controls.Find("txtID", true)[0]).Text)),
                ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text
                );
                if (TrenutniObjekt == null)
                {
                    MjestoRepozitorij.DodajMjesto(mjesto);
                }
                else
                {
                    MjestoRepozitorij.AzurirajMjesto(mjesto);
                }

                Close();
            }
        }

        private void PostaviFormu_Izdavaci()
        {
            this.Controls.Add(PostaviTextBox("txtID", "lblID", "ID", false));
            this.Controls.Add(PostaviTextBox("txtNaziv", "lblNaziv", "Naziv"));
            btnSpremi.Top = top + 15;
            btnSpremi.Click += new EventHandler(IzdavaciValidacija);
            if (TrenutniObjekt != null)
            {
                Izdavac izdavac = (Izdavac)TrenutniObjekt;
                ((TextBox)this.Controls.Find("txtID", true)[0]).Text = izdavac.Id.ToString();
                ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text = izdavac.Naziv;
            }
        }

        private void IzdavaciValidacija(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>();
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                list.Add(t);
            }

            if (UnesenTekst())
            {
                Izdavac izdavac = new Izdavac(
                ((String.IsNullOrEmpty(((TextBox)this.Controls.Find("txtID", true)[0]).Text)) ? -1 : int.Parse(((TextBox)this.Controls.Find("txtID", true)[0]).Text)),
                ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text
                );
                if (TrenutniObjekt == null)
                {
                    IzdavacRepozitorij.DodajIzdavaca(izdavac);
                }
                else
                {
                    IzdavacRepozitorij.AzurirajIzdavaca(izdavac);
                }

                Close();
            }
        }

        private void PostaviFormu_Autori()
        {
            this.Controls.Add(PostaviTextBox("txtID", "lblID", "ID", false));
            this.Controls.Add(PostaviTextBox("txtIme", "lblIme", "Ime"));
            this.Controls.Add(PostaviTextBox("txtPrezime", "lblPrezime", "Prezime"));
            this.Controls.Add(PostaviTextBox("txtBiografija", "lblBiografija", "Biografija"));
            btnSpremi.Top = top + 15;
            btnSpremi.Click += new EventHandler(AutoriValidacija);
            if (TrenutniObjekt != null)
            {
                Autor autor = (Autor)TrenutniObjekt;

                ((TextBox)this.Controls.Find("txtID", true)[0]).Text = autor.Id.ToString();
                ((TextBox)this.Controls.Find("txtIme", true)[0]).Text = autor.Ime;
                ((TextBox)this.Controls.Find("txtPrezime", true)[0]).Text = autor.Prezime;
                ((TextBox)this.Controls.Find("txtBiografija", true)[0]).Text = autor.Biografija;
            }
        }

        private void AutoriValidacija(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>();
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                list.Add(t);
            }

            if (UnesenTekst())
            {

                Autor autor = new Autor(
                ((String.IsNullOrEmpty(((TextBox)this.Controls.Find("txtID", true)[0]).Text)) ? -1 : int.Parse(((TextBox)this.Controls.Find("txtID", true)[0]).Text)),
                ((TextBox)this.Controls.Find("txtIme", true)[0]).Text,
                ((TextBox)this.Controls.Find("txtPrezime", true)[0]).Text,
                ((TextBox)this.Controls.Find("txtBiografija", true)[0]).Text
                );
                if (TrenutniObjekt == null)
                {
                    AutorRepozitorij.DodajAutora(autor);
                }
                else
                {
                    AutorRepozitorij.AzurirajAutora(autor);
                }

                Close();
            }
        }
        private void PostaviFormu_AutorKnjige()
        {

            ComboBox autor = PostaviComboBox("cmbAutor", "lblAutor", "Autor");
            foreach (Autor a in AutorRepozitorij.DohvatiSveAutore())
            {
                autor.Items.Add(a);
            }
            autor.SelectedIndex = 0;
            this.Controls.Add(autor);
            ComboBox knjiga = PostaviComboBox("cmbKnjiga", "lblKnjiga", "Knjiga");
            foreach (Knjiga k in KnjigaRepozitorij.DohvatiSveKnjige())
            {
                knjiga.Items.Add(k);
            }
            knjiga.SelectedIndex = 0;
            this.Controls.Add(knjiga);

            btnSpremi.Top = top + 15;

            btnSpremi.Click += new EventHandler(AutorKnjigeValidacija);
            if (TrenutniObjekt != null)
            {
                AutorKnjige autorKnjige = (AutorKnjige)TrenutniObjekt;
                List<Autor> autori = AutorRepozitorij.DohvatiSveAutore();
                ((ComboBox)this.Controls.Find("cmbAutor", true)[0]).SelectedIndex = autori.IndexOf(autori.Find(x => x.Id == autorKnjige.Autor.Id));
                List<Knjiga> knjige = KnjigaRepozitorij.DohvatiSveKnjige();
                ((ComboBox)this.Controls.Find("cmbKnjiga", true)[0]).SelectedIndex = knjige.IndexOf(knjige.Find(x => x.ISBN == autorKnjige.Knjiga.ISBN));

            }
        }

        private void AutorKnjigeValidacija(object sender, EventArgs e)
        {
            int stariID = TrenutniObjekt == null ? -1 : ((AutorKnjige)TrenutniObjekt).Autor.Id;
            string stariISBN = TrenutniObjekt == null ? "" : ((AutorKnjige)TrenutniObjekt).Knjiga.ISBN;
            AutorKnjige autorKnjige = new AutorKnjige(
                (Autor)((ComboBox)this.Controls.Find("cmbAutor", true)[0]).SelectedItem,
                (Knjiga)((ComboBox)this.Controls.Find("cmbKnjiga", true)[0]).SelectedItem
                );
            if (AutorKnjigeRepozitorij.DohvatiSveAutorKnjige().Find(x => x.Autor.Id == autorKnjige.Autor.Id && x.Knjiga.ISBN == autorKnjige.Knjiga.ISBN) != null)
            {
                MessageBox.Show("Ovaj autor je već dodijeljen toj knjizi!");
            }
            else
            {
                if (TrenutniObjekt == null)
                {
                    AutorKnjigeRepozitorij.DodajAutoraKnjige(autorKnjige);
                }
                else
                {
                    AutorKnjigeRepozitorij.AzurirajAutoraKnjige(stariID, stariISBN, autorKnjige);
                }
                Close();
            }
        }

        private void PostaviFormu_Korisnici()
        {
            this.Controls.Add(PostaviTextBox("txtOIB", "lblOIB", "OIB"));
            this.Controls.Add(PostaviTextBox("txtIme", "lblIme", "Ime"));
            this.Controls.Add(PostaviTextBox("txtPrezime", "lblPrezime", "Prezime"));
            this.Controls.Add(PostaviTextBox("txtBrojMobitela", "lblBrojMobitela", "Broj mobitela"));
            this.Controls.Add(PostaviTextBox("txtEmail", "lblEmail", "E-mail"));
            ComboBox prebivaliste = PostaviComboBox("cmbPrebivaliste", "lblPrebivaliste", "Prebivalište");
            foreach (Mjesto m in MjestoRepozitorij.DohvatiSvaMjesta())
            {
                prebivaliste.Items.Add(m);
            }
            prebivaliste.SelectedIndex = 0;
            this.Controls.Add(prebivaliste);
            this.Controls.Add(PostaviTextBox("txtAdresaPrebivalista", "lblAdresaPrebivalista", "Adresa prebivališta"));
            ComboBox boraviste = PostaviComboBox("cmbBoraviste", "lblBoraviste", "Boravište");
            foreach (Mjesto m in MjestoRepozitorij.DohvatiSvaMjesta())
            {
                boraviste.Items.Add(m);
            }
            boraviste.SelectedIndex = 0;
            this.Controls.Add(boraviste);
            this.Controls.Add(PostaviTextBox("txtAdresaBoravista", "lblAdresaBoravista", "Adresa boravišta"));
            this.Controls.Add(PostaviTextBox("txtDatumUclanjivanja", "lblDatumUclanjivanja", "Datum učlanjivanja"));
            this.Controls.Add(PostaviTextBox("txtDatumIstekaClanarine", "lblDatumIstekaClanarine", "Datum isteka članarine"));
            this.Controls.Add(PostaviTextBox("txtLozinka", "lblLozinka", "Lozinka"));
            this.Controls.Add(PostaviTextBox("txtPokusajiPrijave", "lblPokusajiPrijave", "Pokušaji prijave"));
            this.Controls.Add(PostaviCheckBox("txtBlokiran", "lblBlokiran", "Blokiran"));
            ComboBox tip_korisnika = PostaviComboBox("cmbTipKorisnika", "lblTipKorisnika", "Tip korisnika");
            foreach (TipKorisnika tk in TipKorisnikaRepozitorij.DohvatiSveTipoveKorisnika())
            {
                tip_korisnika.Items.Add(tk);
            }
            tip_korisnika.SelectedIndex = 0;
            this.Controls.Add(tip_korisnika);
            btnSpremi.Top = top + 15;
            btnSpremi.Click += new EventHandler(KorisnikValidacija);
            if (TrenutniObjekt != null)
            {
                Korisnik korisnik = TrenutniObjekt as Korisnik;
                ((TextBox)this.Controls.Find("txtOIB", true)[0]).Text = korisnik.OIB;
                ((TextBox)this.Controls.Find("txtIme", true)[0]).Text = korisnik.Ime;
                ((TextBox)this.Controls.Find("txtPrezime", true)[0]).Text = korisnik.Prezime;
                ((TextBox)this.Controls.Find("txtBrojMobitela", true)[0]).Text = korisnik.BrojMobitela;
                ((TextBox)this.Controls.Find("txtEmail", true)[0]).Text = korisnik.Email;
                List<Mjesto> mjesta = MjestoRepozitorij.DohvatiSvaMjesta();
                ((ComboBox)this.Controls.Find("cmbPrebivaliste", true)[0]).SelectedIndex = mjesta.IndexOf(mjesta.Find(x => x.ID == korisnik.Prebivaliste.ID));
                ((TextBox)this.Controls.Find("txtAdresaPrebivalista", true)[0]).Text = korisnik.AdresaPrebivalista;
                ((ComboBox)this.Controls.Find("cmbBoraviste", true)[0]).SelectedIndex = mjesta.IndexOf(mjesta.Find(x => x.ID == korisnik.Boraviste.ID));
                ((TextBox)this.Controls.Find("txtAdresaBoravista", true)[0]).Text = korisnik.AdresaBoravista;
                ((TextBox)this.Controls.Find("txtDatumUclanjivanja", true)[0]).Text = korisnik.DatumUclanjivanja.ToString("yyyy-MM-dd");
                ((TextBox)this.Controls.Find("txtDatumIstekaClanarine", true)[0]).Text = korisnik.DatumIstekaClanarine.ToString("yyyy-MM-dd");
                ((TextBox)this.Controls.Find("txtLozinka", true)[0]).Text = korisnik.Lozinka;
                ((CheckBox)this.Controls.Find("txtBlokiran", true)[0]).Checked = korisnik.Blokiran;
                List<TipKorisnika> tipoviKorisnika = TipKorisnikaRepozitorij.DohvatiSveTipoveKorisnika();
                ((ComboBox)this.Controls.Find("cmbTipKorisnika", true)[0]).SelectedIndex = tipoviKorisnika.IndexOf(tipoviKorisnika.Find(x => x.ID == korisnik.TipKorisnika.ID));
                ((TextBox)this.Controls.Find("txtPokusajiPrijave", true)[0]).Text = korisnik.PokusajiPrijave.ToString();
            }
        }

        private void KorisnikValidacija(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>();
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                list.Add(t);
            }
            string stariOIB = TrenutniObjekt == null ? "" : ((Korisnik)TrenutniObjekt).OIB;
            if (UnesenTekst())
            {
                Korisnik korisnik = new Korisnik(
                    ((TextBox)this.Controls.Find("txtOIB", true)[0]).Text,
                    ((TextBox)this.Controls.Find("txtIme", true)[0]).Text,
                    ((TextBox)this.Controls.Find("txtPrezime", true)[0]).Text,
                    ((TextBox)this.Controls.Find("txtBrojMobitela", true)[0]).Text,
                    ((TextBox)this.Controls.Find("txtEmail", true)[0]).Text,
                    ((ComboBox)this.Controls.Find("cmbPrebivaliste", true)[0]).SelectedItem as Mjesto,
                    ((TextBox)this.Controls.Find("txtAdresaPrebivalista", true)[0]).Text,
                    ((ComboBox)this.Controls.Find("cmbBoraviste", true)[0]).SelectedItem as Mjesto,
                    ((TextBox)this.Controls.Find("txtAdresaBoravista", true)[0]).Text,
                    DateTime.Parse(DateTime.Parse(((TextBox)this.Controls.Find("txtDatumUclanjivanja", true)[0]).Text).Date.ToString("yyyy-MM-dd")),
                    DateTime.Parse(DateTime.Parse(((TextBox)this.Controls.Find("txtDatumIstekaClanarine", true)[0]).Text).Date.ToString("yyyy-MM-dd")),
                    ((TextBox)this.Controls.Find("txtLozinka", true)[0]).Text,
                    ((CheckBox)this.Controls.Find("txtBlokiran", true)[0]).Checked == true ? 1 : 0,
                    ((ComboBox)this.Controls.Find("cmbTipKorisnika", true)[0]).SelectedItem as TipKorisnika,
                    int.Parse(((TextBox)this.Controls.Find("txtPokusajiPrijave", true)[0]).Text)

                );
                if (TrenutniObjekt == null)
                {
                    KorisnikRepozitorij.DodajKorisnika(korisnik);
                }
                else
                {
                    KorisnikRepozitorij.AzurirajKorisnika(stariOIB, korisnik);
                }

                Close();
            }
            else
            {
                return;
            }
        }


        private bool UnesenTekst()
        {
            string poruka = "";

            List<string> Iznimke = new List<string>()
            {
                "txtID","txtOpisKnjige"
            };
            foreach (TextBox txt in this.Controls.OfType<TextBox>()) txt.BackColor = Color.FromArgb(254, 255, 242);
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.BackColor = Color.FromArgb(254, 255, 242);

                if ((String.IsNullOrEmpty(txt.Text) || String.IsNullOrWhiteSpace(txt.Text)) && !Iznimke.Contains(txt.Name))
                {
                    txt.BackColor = Color.LightCoral;
                    poruka += txt.Name + " - nije unesena vrijednost\n";

                }

                else
                {
                    string uzorak = "";
                    switch (txt.Name)
                    {

                        case "txtOIB":
                            if (!ProvjeraOIBa(txt.Text)) return IspisGreske(txt, "Pogrešan format OIB-a");
                            if (TrenutniObjekt == null) if (KorisnikRepozitorij.DohvatiKorisnika_OIB(txt.Text) != null) return IspisGreske(txt, "OIB već postoji u bazi!");
                            break;
                        case "txtISBN":
                            if (!long.TryParse(txt.Text, out long test) || txt.Text.Length != 13) return IspisGreske(txt, "Pogrešan format ISBN-a");
                            if (TrenutniObjekt == null) if (KnjigaRepozitorij.DohvatiKnjigu(txt.Text) != null) return IspisGreske(txt, "Ovaj ISBN već postoji!");
                            break;
                        case "txtIme":
                        case "txtPrezime":

                            uzorak = @"^(([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,20})(([ ]|[-])([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,20}))?)$";

                            if (!Regex.Match(txt.Text, uzorak).Success) return IspisGreske(txt, "Pogrešan format imena/prezimena");
                            break;
                        case "txtBrojMobitela":
                            uzorak = @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
                            if (!Regex.Match(txt.Text, uzorak).Success) return IspisGreske(txt, "Pogrešan format broja mobitela");
                            break;
                        case "txtEmail":

                            uzorak = @"^([A-Z,a-z,ČĆŽĐŠčćžđš][a-z,A-Z,0-9,ČĆŽĐŠčćžđš,_,-]{2,30}@[a-z]{2,5}[.][a-z][a-z]{1,3})$";
                            if (!Regex.Match(txt.Text, uzorak).Success) return IspisGreske(txt, "Pogrešan format e-maila");
                            if (TrenutniObjekt == null) if (KorisnikRepozitorij.DohvatiKorisnika_Mail(txt.Text) != null) return IspisGreske(txt, "E-mail je već unesen!");
                            break;
                        case "txtAdresaPrebivalista":
                        case "txtAdresaBoravista":
                        case "Lozinka":
                            if (!VelicinaUnosa(txt.Text, 50)) IspisGreske(txt, "Prevelik unos");
                            break;

                        case "txtNaziv":
                        case "txtRadnoVrijeme":
                        case "kontakt":
                        case "adresa":
                            if (!VelicinaUnosa(txt.Text, 180)) IspisGreske(txt, "Prevelik unos");
                            break;

                        case "txtDatumUclanjivanja":
                        case "txtDatumIstekaClanarine":
                        case "txtDatumIzdavanja":
                            if (!DateTime.TryParse(txt.Text, out DateTime test_2)) return IspisGreske(txt, "Pogrešan format datuma");
                            break;
                        case "txtBlokiran":
                        case "txtPokusajiPrijave":
                        case "txtBrojStranica":
                        case "txtMaxBrojPosudbi":
                        case "txtTrajanjeRezervacije":
                        case "txtTrajanjePosudbe":
                        case "txtTrajanjeProduljenja":
                            if (!int.TryParse(txt.Text, out int test_1)) return IspisGreske(txt, "Nije unesen broj");
                            break;

                        case "txtZakasnina":
                        case "txtClanarina":
                            if (!double.TryParse(txt.Text, out double test_3))
                            {
                                return IspisGreske(txt, "Niste unijeli pravilan format za novac!");
                            }
                            double novac = double.Parse(txt.Text);
                            if (Decimal.Round((Decimal)novac, 2) != (Decimal)novac)
                            {
                                return IspisGreske(txt, "Niste unijeli pravilan format za novac!");
                            }
                            break;
                    }
                }
            }
            if (poruka.Length > 0)
            {
                MessageBox.Show(poruka);
                return false;
            }
            return true;
        }

        private bool IspisGreske(TextBox kontrola, string poruka)
        {
            kontrola.BackColor = Color.LightCoral;
            MessageBox.Show(kontrola.Name + " - " + poruka);
            return false;
        }


        private bool VelicinaUnosa(string unos, int max)
        {
            return !(unos.Length >= max);
        }


        private bool ProvjeraOIBa(string unos)
        {
            if (unos.Length != 11 || !long.TryParse(unos, out long test))
            {
                return false;
            }

            int oibRacun = 10;
            int kontrolniBroj = int.Parse(unos[10].ToString());
            for (int i = 0; i < unos.Length - 1; i++)
            {
                oibRacun += int.Parse(unos[i].ToString());
                oibRacun = (oibRacun % 10) == 0 ? 10 : oibRacun % 10;
                oibRacun *= 2;
                oibRacun %= 11;
            }
            if ((11 - oibRacun) % 10 != kontrolniBroj)
            {
                return false;
            }
            return true;

        }


        private TextBox PostaviTextBox(string Ime, string LabelIme, string LabelText, bool enabled = true)
        {
            TextBox txt = new TextBox();
            txt.Name = Ime;
            txt.BackColor = Color.FromArgb(254, 255, 242);
            txt.Top = top;
            txt.Left = 350;
            txt.Width = 200;
            txt.Font = new Font("Microsoft Sans Serif", 12);

            txt.Enabled = enabled;

            this.Controls.Add(PostaviLabel(LabelIme, LabelText));
            top += 50;
            return txt;
        }

        private ComboBox PostaviComboBox(string Ime, string LabelIme, string LabelText)
        {
            ComboBox cmb = new ComboBox();
            cmb.Name = Ime;
            cmb.Top = top;
            cmb.Left = 350;
            cmb.Width = 200;
            cmb.Font = new Font("Microsoft Sans Serif", 12);
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(PostaviLabel(LabelIme, LabelText));
            top += 50;
            return cmb;
        }

        private CheckBox PostaviCheckBox(string Ime, string LabelIme, string LabelText)
        {
            CheckBox cbx = new CheckBox();
            cbx.Name = Ime;
            cbx.Top = top;
            cbx.Left = 445;
            cbx.Font = new Font("Microsoft Sans Serif", 12);
            this.Controls.Add(PostaviLabel(LabelIme, LabelText));
            top += 50;
            return cbx;
        }

        private Label PostaviLabel(string Ime, string Text)
        {
            Label lbl = new Label();
            lbl.Width = 200;
            lbl.Name = Ime;
            lbl.Text = Text;
            lbl.Left = 80;
            lbl.Top = top;
            lbl.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            lbl.TextAlign = ContentAlignment.MiddleRight;
            return lbl;
        }
        private PictureBox PostaviPictureBox(string Ime, string LabelIme, string LabelText)
        {
            PictureBox pb = new PictureBox();
            pb.Name = Ime;
            pb.Top = top;
            pb.Left = 350;
            pb.Width = 200;
            pb.BackColor = Color.Gray;
            pb.Height = 240;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(PostaviLabel(LabelIme, LabelText));
            top += 250;
            return pb;
        }

    }
}
