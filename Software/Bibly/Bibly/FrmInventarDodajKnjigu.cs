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
        Knjiga OdabranaKnjiga = null;

        private static int topcina = 650;

        public FrmInventarDodajKnjigu(Knjiga odabranaKnjiga = null)
        {
            InitializeComponent();
            PostaviGlavniMenu(1);
            PostaviHelp("Dodaj knjigu.htm");
            OdabranaKnjiga = odabranaKnjiga;
            PopuniComboBoxeve();
            cmbIzdavac.SelectedIndex = 0;
            cmbZanr.SelectedIndex = 0;

            if (OdabranaKnjiga != null)
            {
                ((TextBox)this.Controls.Find("txtISBN", true)[0]).Text = odabranaKnjiga.ISBN.ToString();
                ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text = odabranaKnjiga.Naziv.ToString();
                List<Izdavac> izdavaci = IzdavacRepozitorij.DohvatiSveIzdavace();
                ((ComboBox)this.Controls.Find("cmbIzdavac", true)[0]).SelectedIndex = izdavaci.IndexOf(izdavaci.Find(x => x.Id == odabranaKnjiga.Izdavac.Id));
                List<Zanr> zanrovi = ZanrRepozitorij.DohvatiSveZanrove();
                ((ComboBox)this.Controls.Find("cmbZanr", true)[0]).SelectedIndex = zanrovi.IndexOf(zanrovi.Find(x => x.Id == odabranaKnjiga.Zanr.Id));
                ((TextBox)this.Controls.Find("txtDatumIzdavanja", true)[0]).Text = odabranaKnjiga.DatumIzdavanja.ToString();
                ((TextBox)this.Controls.Find("txtBrojStranica", true)[0]).Text = odabranaKnjiga.BrojStranica.ToString();
                ((TextBox)this.Controls.Find("txtOpis", true)[0]).Text = odabranaKnjiga.Opis.ToString();
                ((PictureBox)this.Controls.Find("pbNaslovnica", true)[0]).Image = odabranaKnjiga.Naslovnica;
                this.Controls.Remove(ucAutor1);
                topcina =800;
                List<Autor> autori = AutorRepozitorij.DohvatiAutoreKnjige(odabranaKnjiga.ISBN);
                foreach(Autor autor in autori)
                {
                    UCAutor uc = new UCAutor();
                    uc.Top = topcina;
                    uc.Left = 440;
                    uc.PostaviAutora(autor);
                    Controls.Add(uc);
                    topcina += 50;
                }

                
            }

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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            UCAutor uc = new UCAutor();
            uc.Top = topcina;
            uc.Left = 440;
            Controls.Add(uc);
            topcina += 50;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<UCAutor>().Count<UCAutor>() > 1)
            {
                UCAutor uc = this.Controls.OfType<UCAutor>().ToList().LastOrDefault<UCAutor>() as UCAutor;
                if (uc != null)
                {
                    this.Controls.Remove(uc);
                    if (topcina > 650) topcina -= 50;
                }
            }
        }

        private void btnDodajIzdavaca_Click(object sender, EventArgs e)
        {
            FrmInventarDodajIzdavaca frm = new FrmInventarDodajIzdavaca();
            frm.ShowDialog();
            PopuniComboBoxeve();
        }

        private void btnDodajZanr_Click(object sender, EventArgs e)
        {
            FrmInventarDodajZanr frm = new FrmInventarDodajZanr();
            frm.ShowDialog();
            PopuniComboBoxeve();
        }

        private void btnDodajAutora_Click(object sender, EventArgs e)
        {
            FrmInventarDodajAutora frm = new FrmInventarDodajAutora();
            frm.ShowDialog();
            ucAutor1.PopuniComboBox();
        }


        private void btnSpremiKnjigu_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            string naziv = txtISBN.Text;
            string opisKnjige = txtOpis.Text;
            string datum = txtDatumIzdavanja.Text;

            List<Autor> autori = new List<Autor>();
            foreach(UCAutor uc in this.Controls.OfType<UCAutor>())
            {
                int zbroj = 0;
                foreach(UCAutor uc1 in this.Controls.OfType<UCAutor>())
                {
                    if(uc.VratiVrijednost().Id == uc1.VratiVrijednost().Id)
                    {
                        zbroj++;
                    }
                }
                if (zbroj == 1)
                {
                    autori.Add(uc.VratiVrijednost());
                }
                else
                {
                    MessageBox.Show("Unijeli ste više istih autora!");
                    return;
                }
            }


            int dobroPopunjeno = ProvjeriUnose(isbn, naziv, txtBrojStranica.Text.ToString(), txtDatumIzdavanja.Text.ToString(), opisKnjige,
                cmbIzdavac.Text.ToString(), cmbZanr.Text.ToString());
            string poruka = "";
            switch (dobroPopunjeno)
            {
                case -1:
                    poruka = "Niste popunili sva polja!";
                    break;
                case -2:
                    poruka = "ISBN je pogrešnog formata. Mora sadržavati 13 znakova!";
                    break;
                case -3:
                    poruka = "Ovaj ISBN već postoji!";
                    break;
                case -4:
                    poruka = "Pogrešan format datuma!";
                    break;
                case -5:
                    poruka = "Za broj stranica ste unijeli tekst, a ne broj!";
                    break;
                case 1:
                    Knjiga knjiga = new Knjiga(
                     ((TextBox)this.Controls.Find("txtISBN", true)[0]).Text,
                     ((TextBox)this.Controls.Find("txtNaziv", true)[0]).Text,
                     ((ComboBox)this.Controls.Find("cmbIzdavac", true)[0]).SelectedItem as Izdavac,
                     ((ComboBox)this.Controls.Find("cmbZanr", true)[0]).SelectedItem as Zanr,
                     DateTime.Parse(DateTime.Parse(((TextBox)this.Controls.Find("txtDatumIzdavanja", true)[0]).Text).Date.ToString("yyyy-MM-dd")),
                     int.Parse(((TextBox)this.Controls.Find("txtBrojStranica", true)[0]).Text),
                     ((TextBox)this.Controls.Find("txtOpis", true)[0]).Text == "" ? null : ((TextBox)this.Controls.Find("txtOpis", true)[0]).Text,
                     ((PictureBox)this.Controls.Find("pbNaslovnica", true)[0]).Image,
                     null);

                    if (OdabranaKnjiga == null)
                    {
                        KnjigaRepozitorij.DodajKnjigu(knjiga);
                        foreach(Autor autor in autori)
                        {
                            AutorKnjigeRepozitorij.DodajAutoraKnjige(new AutorKnjige(autor,knjiga));
                            
                        }
                        this.Close();
                        
                    }
                    else
                    {
                        string stariISBN = OdabranaKnjiga.ISBN;
                        List<Autor> stariAutori = AutorRepozitorij.DohvatiAutoreKnjige(stariISBN);
                        foreach(Autor stariAutor in stariAutori)
                        {
                            AutorKnjigeRepozitorij.ObrisiAutoraKnjige(new AutorKnjige(stariAutor,OdabranaKnjiga));
                        }
                        foreach (Autor autor in autori)
                        {
                            AutorKnjigeRepozitorij.DodajAutoraKnjige(new AutorKnjige(autor, knjiga));
                        }
                        KnjigaRepozitorij.AzurirajKnjigu(stariISBN, knjiga);
                        this.Close();
                    }
                    break;
            }

            if (dobroPopunjeno != 1)
            {
                MessageBox.Show(poruka);
            }

        }

        private int ProvjeriUnose(string isbn, string naziv, string brStr, string datum, string opis, string izdavac, string zanr)
        {
            if (string.IsNullOrEmpty(isbn) || string.IsNullOrWhiteSpace(isbn) || string.IsNullOrEmpty(naziv) || string.IsNullOrWhiteSpace(naziv) ||
                string.IsNullOrEmpty(brStr) || string.IsNullOrWhiteSpace(brStr) || string.IsNullOrEmpty(datum) || string.IsNullOrWhiteSpace(datum) ||
                string.IsNullOrEmpty(opis) || string.IsNullOrWhiteSpace(opis) || string.IsNullOrEmpty(izdavac) || string.IsNullOrWhiteSpace(izdavac) ||
                string.IsNullOrEmpty(zanr) || string.IsNullOrWhiteSpace(zanr) || cmbIzdavac.SelectedItem == null || cmbZanr.SelectedItem == null)
            {
                return -1;
            }
            else if (!ProvjeraISBN(isbn))
            {
                return -2;
            }
            else if (!PostojiISBN(isbn))
            {
                return -3;
            }
            else if (!ProvjeriDatum(datum))
            {
                return -4;
            }
            else if (!ProvjeriBrojStranica(brStr))
            {
                return -5;
            }
            else
            {
                return 1;
            }
        }

        private bool ProvjeriBrojStranica(string brStr)
        {
            if (!int.TryParse(brStr, out int test_3))
            {
                return false;
            }
            else return true;
        }

        private bool ProvjeriDatum(string datum)
        {
            if (!DateTime.TryParse(datum, out DateTime test_2))
            {
                return false;
            }
            else return true;
                
        }

        private bool PostojiISBN(string isbn)
        {
            if (OdabranaKnjiga == null)
            {
                if (KnjigaRepozitorij.DohvatiKnjigu(isbn) != null) return false;
            } 
            return true;
        }

        private bool ProvjeraISBN(string isbn)
        {
            if (isbn.Length != 13)
            {
                return false;
            }
            else return true;
        }

        private void FrmInventarDodajKnjigu_Load(object sender, EventArgs e)
        {

        }
    }

}
