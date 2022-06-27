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

        private void PostaviFormu_Korisnici()
        {
            this.Controls.Add(PostaviTextBox("txtOIB", "lblOIB", "OIB"));
            this.Controls.Add(PostaviTextBox("txtIme", "lblIme", "Ime"));
            this.Controls.Add(PostaviTextBox("txtPrezime", "lblPrezime", "Prezime"));
            this.Controls.Add(PostaviTextBox("txtBrojMobitela", "lblBrojMobitela", "Broj mobitela"));
            this.Controls.Add(PostaviTextBox("txtEmail", "lblEmail", "E-mail"));
            ComboBox prebivaliste = PostaviComboBox("cmbPrebivaliste", "lblPrebivaliste", "Prebivalište");
            prebivaliste.DataSource = MjestoRepozitorij.DohvatiSvaMjesta();
            this.Controls.Add(prebivaliste);
            this.Controls.Add(PostaviTextBox("txtAdresaPrebivalista", "lblAdresaPrebivalista", "Adresa prebivališta"));
            ComboBox boraviste = PostaviComboBox("cmbBoraviste", "lblBoraviste", "Boravište");
            boraviste.DataSource = MjestoRepozitorij.DohvatiSvaMjesta();
            this.Controls.Add(boraviste);
            this.Controls.Add(PostaviTextBox("txtAdresaBoravista", "lblAdresaBoravista", "Adresa boravišta"));
            this.Controls.Add(PostaviTextBox("txtDatumUclanjivanja", "lblDatumUclanjivanja", "Datum učlanjivanja"));
            this.Controls.Add(PostaviTextBox("txtDatumIsteklaClanarine", "lblDatumIsteklaClanarine", "Datum istekla članarine"));
            this.Controls.Add(PostaviTextBox("txtLozinka", "lblLozinka", "Lozinka"));
            this.Controls.Add(PostaviTextBox("txtPokusajiPrijave", "lblPokusajiPrijave", "Pokušaji prijave"));
            this.Controls.Add(PostaviCheckBox("txtBlokiran", "lblBlokiran", "Blokiran"));
            ComboBox tip_korisnika = PostaviComboBox("cmbTipKorisnika", "lblTipKorisnika", "Tip korisnika");
            tip_korisnika.DataSource = TipKorisnikaRepozitorij.DohvatiSveTipoveKorisnika();
            this.Controls.Add(tip_korisnika);
            btnSpremi.Top = top + 15;
            btnSpremi.Click += new EventHandler(KorisnikValidacija);

        }

        private void KorisnikValidacija(object sender, EventArgs e)
        {
            if (UnesenTekst())
            {
            }
            else
            {
                return;
            }
        }


        private bool UnesenTekst()
        {
            string poruka = "";
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
                    Regex rg;
                    switch (txt.Name)
                    {
                        case "txtOIB":
                            if (!ProvjeraOIBa(txt.Text))
                            {
                                IspisGreske(txt, "Krivi format OIB-a");
                            }
                            break;
                        case "txtIme":
                        case "txtPrezime":
                            uzorak = @"^(([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,})(([ ]|[-])([A-Z,ČĆŽĐŠ][a-z,čćžđš]{1,}))?)$";
                            rg = new Regex(uzorak);
                            if (!Regex.Match(txt.Text, uzorak).Success) IspisGreske(txt, "Pogrešan format imena/prezimena");
                            break;
                        case "txtBrojMobitela":
                            uzorak = @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
                            rg = new Regex(uzorak);
                            if (!Regex.Match(txt.Text, uzorak).Success) IspisGreske(txt, "Pogrešan format broja mobitela");
                            break;
                        case "txtEmail":
                            uzorak = @"^([A-Z,a-z,ČĆŽĐŠčćžđš][a-z,A-Z,0-9,ČĆŽĐŠčćžđš,_,-]{2,}@[a-z]{2,}[.][a-z][a-z]{1,})$";
                            rg = new Regex(uzorak);
                            if (!Regex.Match(txt.Text, uzorak).Success) IspisGreske(txt, "Pogrešan format e-maila");
                            break;
                        case "txtDatumUclanjivanja":
                        case "txtDatumIstekaClanarine":
                            if(!DateTime.TryParse(txt.Text, out DateTime test)) IspisGreske(txt,"Pogrešan format datuma");
                            break;
                        case "txtBlokiran":
                            if (!int.TryParse(txt.Text, out int test_1)) IspisGreske(txt, "Nije unesen broj");
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

        private void IspisGreske(TextBox kontrola, string poruka)
        {
            kontrola.BackColor = Color.LightCoral;
            MessageBox.Show(kontrola.Name + " - " + poruka);
        }

        private bool ProvjeraOIBa(string unos)
        {
            if (unos.Length != 11 || !long.TryParse(unos,out long test))
            {
                return false;
            }

            int oibRacun = 10;
            int kontrolniBroj = int.Parse(unos[10].ToString());
            for (int i = 0; i < unos.Length - 1; i++)
            {
                oibRacun += int.Parse(unos[i].ToString());
                oibRacun = (oibRacun % 10)==0?10:oibRacun%10;
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
