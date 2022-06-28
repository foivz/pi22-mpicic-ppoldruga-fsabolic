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
        }

        private void PostaviKontrole()
        {
            switch (NazivTablice)
            {
                case "autor_knjige":
                    PostaviFormu_AutorKnjige();
                    break;
                case "autori":

                    break;
                case "izdavaci":

                    break;
                case "knjige":

                    break;
                case "korisnici":
                    PostaviFormu_Korisnici();
                    break;
                case "mjesta":

                    break;
                case "postavke":

                    break;
                case "posudbe":

                    break;
                case "primjerci":

                    break;
                case "statusi_primjeraka":

                    break;
                case "tipovi_korisnika":

                    break;
                case "zanrovi":

                    break;
                default:
                    this.Close();
                    break;
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
            if (AutorKnjigeRepozitorij.DohvatiSveAutorKnjige().Find(x=>x.Autor.Id==autorKnjige.Autor.Id && x.Knjiga.ISBN==autorKnjige.Knjiga.ISBN) != null)
            {
                MessageBox.Show("Ovaj autor je već dodijeljen toj knjizi!");
            }
            else
            {
                if (TrenutniObjekt==null)
                {
                    AutorKnjigeRepozitorij.DodajAutoraKnjige(autorKnjige);
                }
                else
                {
                    AutorKnjigeRepozitorij.AzurirajAutoraKnjige(stariID,stariISBN,autorKnjige);
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
            foreach (TextBox txt in this.Controls.OfType<TextBox>()) txt.BackColor = Color.FromArgb(254, 255, 242);
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.BackColor = Color.FromArgb(254, 255, 242);
                if (String.IsNullOrEmpty(txt.Text) || String.IsNullOrWhiteSpace(txt.Text))
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
                            if (!ProvjeraOIBa(txt.Text)) return IspisGreske(txt, "Krivi format OIB-a");
                            if (TrenutniObjekt == null) if (KorisnikRepozitorij.DohvatiKorisnika_OIB(txt.Text) != null) return IspisGreske(txt, "OIB već postoji u bazi!");
                            break;
                        case "txtIme":
                        case "txtPrezime":
                            uzorak = @"^(([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,})(([ ]|[-])([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,}))?)$";
                            if (!Regex.Match(txt.Text, uzorak).Success) return IspisGreske(txt, "Pogrešan format imena/prezimena");
                            break;
                        case "txtBrojMobitela":
                            uzorak = @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
                            if (!Regex.Match(txt.Text, uzorak).Success) return IspisGreske(txt, "Pogrešan format broja mobitela");
                            break;
                        case "txtEmail":
                            uzorak = @"^([A-Z,a-z,ČĆŽĐŠčćžđš][a-z,A-Z,0-9,ČĆŽĐŠčćžđš,_,-]{2,}@[a-z]{2,}[.][a-z][a-z]{1,})$";
                            if (!Regex.Match(txt.Text, uzorak).Success) return IspisGreske(txt, "Pogrešan format e-maila");
                            if (TrenutniObjekt == null) if (KorisnikRepozitorij.DohvatiKorisnika_Mail(txt.Text) != null) return IspisGreske(txt, "E-mail je već unesen!");
                            break;
                        case "txtDatumUclanjivanja":
                        case "txtDatumIstekaClanarine":
                            if (!DateTime.TryParse(txt.Text, out DateTime test)) return IspisGreske(txt, "Pogrešan format datuma");
                            break;
                        case "txtBlokiran":
                        case "txtPokusajiPrijave":
                            if (!int.TryParse(txt.Text, out int test_1)) return IspisGreske(txt, "Nije unesen broj");
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

        private TextBox PostaviTextBox(string Ime, string LabelIme, string LabelText)
        {
            TextBox txt = new TextBox();
            txt.Name = Ime;
            txt.BackColor = Color.FromArgb(254, 255, 242);
            txt.Top = top;
            txt.Left = 350;
            txt.Width = 200;
            txt.Font = new Font("Microsoft Sans Serif", 12);
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

    }
}
