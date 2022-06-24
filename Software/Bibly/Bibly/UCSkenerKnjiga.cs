using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using Prijava;
using Skener;
using PodaciKnjige;
namespace Bibly
{
    public partial class UCSkenerKnjiga : UserControl
    {
        private ComboBox cmbKnjige = null;
        private ComboBox cmbKorisnici = null;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public UCSkenerKnjiga()
        {
            InitializeComponent();
            this.pbSken.Padding = new System.Windows.Forms.Padding(3);
            UcitajKamere();
        }

        private void UcitajKamere()
        {
            cmbKamere.Items.Clear();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cmbKamere.Items.Add(device.Name);
            }
            cmbKamere.SelectedIndex = 0;
        }

        private void btnSkeniraj_Click(object sender, EventArgs e)
        {
            if (cmbKnjige == null && cmbKorisnici == null)
            {
                IspisGreske("-- E R R O R : Nije proslijeđen ComboBox ni za korisnike ni za knjige --");

            }
            else
            {
                btnSkeniraj.Enabled = false;
                btnZaustavi.Enabled = true;
                ZapocniSkeniranje();
            }
        }

        private void IspisGreske(string poruka)
        {
            txtISBN.BackColor = Color.FromArgb(254, 255, 242);
            txtGreske.BackColor = Color.LightCoral;
            txtGreske.Text = "";
            txtGreske.Text = poruka;
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (this.txtISBN.InvokeRequired)
            {
                PrekidSkeniranjeCallback d = new PrekidSkeniranjeCallback(UspjesnoSkeniranje);
                this.Invoke(d);
                PrekidSkeniranja();
                pbSken.Image = null;

            }
            else
            {
                ZaustaviSkeniranje();
                PrekidSkeniranja();
                pbSken.Image = null;
            }
        }

        delegate void PrekidSkeniranjeCallback();

        private void ZapocniSkeniranje()
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbKamere.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Image a = (Image)eventArgs.Frame;
            string result = Skener.Skener.DesifrirajKod(a);
            if (result != "")
            {
                txtISBN.Invoke(new MethodInvoker(delegate ()
                {
                    txtISBN.Text = result;
                }));
                if (this.txtISBN.InvokeRequired)
                {
                    UspjesnoSkeniranjeCallback d = new UspjesnoSkeniranjeCallback(UspjesnoSkeniranje);
                    this.Invoke(d);

                }
                else
                {
                    ZaustaviSkeniranje();
                }
            }
            else
            {
                PromijeniBojuObrubaSkenera(Color.Red);
                pbSken.Image = (Bitmap)a.Clone();
            }

        }

        delegate void UspjesnoSkeniranjeCallback();

        public void UspjesnoSkeniranje()
        {

            if (cmbKnjige == null && cmbKorisnici == null)
            {
                IspisGreske("-- E R R O R : Nije proslijeđen ComboBox ni za korisnike ni za knjige --");
                return;
            }


            string skeniranaVrijednost = txtISBN.Text;
            long ignore = -1;
            if (long.TryParse(skeniranaVrijednost, out ignore))
            {
                if (cmbKnjige == null)
                {
                    IspisGreske("Uočen barkod! Traži se QR kod!");
                    return;
                }

                if (skeniranaVrijednost.Length > 13)
                {
                    IspisGreske($"Knjiga s ISBN-om {skeniranaVrijednost} nije pronađena!");
                    return;
                }

                Knjiga knjiga = KnjigaRepozitorij.DohvatiKnjigu(skeniranaVrijednost);
                if (knjiga == null)
                {
                    IspisGreske($"Knjiga s ISBN-om {skeniranaVrijednost} nije pronađena!");
                    return;
                }

                List<Knjiga> knjige = KnjigaRepozitorij.DohvatiSveKnjige();
                foreach (Knjiga k in knjige)
                {
                    cmbKnjige.Items.Add(k);
                }
                cmbKnjige.SelectedIndex = knjige.IndexOf(knjige.Find(x => x.ISBN == knjiga.ISBN));


            }
            else
            {
                if (cmbKorisnici == null)
                {
                    IspisGreske("Uočen QR kod! Traži se barkod!");
                    return;
                }

                Korisnik korisnik = KorisnikRepozitorij.DohvatiKorisnika_Mail(skeniranaVrijednost);
                if (korisnik == null)
                {
                    IspisGreske($"Korisnik s e-mailom {skeniranaVrijednost} nije pronađen!");
                    return;
                }

                List<Korisnik> korisnici = KorisnikRepozitorij.DohvatiSveKorisnike();
                foreach (Korisnik k in korisnici)
                {
                    cmbKorisnici.Items.Add(k);
                }
                cmbKorisnici.SelectedIndex = korisnici.IndexOf(korisnici.Find(x => x.OIB == korisnik.OIB));

            }
            PromijeniBojuObrubaSkenera(Color.LimeGreen);
            txtGreske.Text = "";
            txtGreske.BackColor = Color.FromArgb(254, 255, 242);
            ZaustaviSkeniranje();
        }

        public void PrekidSkeniranja()
        {
            PromijeniBojuObrubaSkenera(Color.Gray);
            txtISBN.Text = "";
            txtGreske.BackColor = Color.FromArgb(254, 255, 242);
            txtISBN.BackColor = Color.FromArgb(254, 255, 242);
            ZaustaviSkeniranje();
        }
        public void ZaustaviSkeniranje()
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                btnSkeniraj.Enabled = true;
                btnZaustavi.Enabled = false;
                txtGreske.Text = "";
                txtISBN.BackColor = Color.FromArgb(254, 255, 242);

            }

        }

        public void PromijeniBojuObrubaSkenera(Color boja)
        {
            pbSken.BackColor = boja;
        }

        public void PostaviUCSkener(ComboBox _cmbKnjige, ComboBox _cmbKorisnici)
        {
            cmbKnjige = _cmbKnjige;
            cmbKorisnici = _cmbKorisnici;

        }
    }
}
