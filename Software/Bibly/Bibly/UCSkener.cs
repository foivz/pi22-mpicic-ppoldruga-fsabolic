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
    public partial class UCSkener : UserControl
    {
        private ComboBox cmbKnjige = null;
        private ComboBox cmbKorisnici = null;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public UCSkener()
        {
            InitializeComponent();
            this.pbSken.Padding = new System.Windows.Forms.Padding(3);
            UcitajKamere();
        }

        public void PostaviUCSkener(FrmOpcenita frm, ComboBox _cmbKnjige, ComboBox _cmbKorisnici)
        {
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            cmbKnjige = _cmbKnjige;
            cmbKorisnici = _cmbKorisnici;

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
            if (!PostojiBaremJedanCMB())
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
                txtRezultat.Invoke(new MethodInvoker(delegate ()
                {
                    txtRezultat.Text = result;
                }));
                if (this.txtRezultat.InvokeRequired)
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

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (this.txtRezultat.InvokeRequired)
            {
                PrekidSkeniranjeCallback d = new PrekidSkeniranjeCallback(UspjesnoSkeniranje);
                this.Invoke(d);
                PrekidSkeniranja();
                pbSken.Image = null;

            }
            else
            {
                PrekidSkeniranja();
                pbSken.Image = null;
            }
        }

        delegate void PrekidSkeniranjeCallback();
        public void PrekidSkeniranja()
        {
            PromijeniBojuObrubaSkenera(Color.Gray);
            txtRezultat.Text = "";
            txtGreske.BackColor = Color.FromArgb(254, 255, 242);
            txtRezultat.BackColor = Color.FromArgb(254, 255, 242);
            ZaustaviSkeniranje();
        }

        private void PopuniCMBKnjige(Knjiga knjiga)
        {
            List<Knjiga> knjige = KnjigaRepozitorij.DohvatiSveKnjige();
            foreach (Knjiga k in knjige)
            {
                cmbKnjige.Items.Add(k);
            }
            cmbKnjige.SelectedIndex = knjige.IndexOf(knjige.Find(x => x.ISBN == knjiga.ISBN));
        }

        private void PopuniCMBKorisnici(Korisnik korisnik)
        {
            List<Korisnik> korisnici = KorisnikRepozitorij.DohvatiSveKorisnike();
            foreach (Korisnik k in korisnici)
            {
                cmbKorisnici.Items.Add(k);
            }
            cmbKorisnici.SelectedIndex = korisnici.IndexOf(korisnici.Find(x => x.OIB == korisnik.OIB));
        }

        delegate void UspjesnoSkeniranjeCallback();

        public void UspjesnoSkeniranje()
        {

            if (!PostojiBaremJedanCMB())
            {
                IspisGreske("-- E R R O R : Nije proslijeđen ComboBox ni za korisnike ni za knjige --");
                return;
            }


            string skeniranaVrijednost = txtRezultat.Text;
            if (UnesenISBNBroj(skeniranaVrijednost))
            {
                if (cmbKnjige == null)
                {
                    IspisGreske("Uočen barkod! Pokušajte s QR kodom!");
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

                PopuniCMBKnjige(knjiga);


            }
            else
            {
                if (cmbKorisnici == null)
                {
                    IspisGreske("Uočen QR kod! Pokušajte s barkodom!");
                    return;
                }

                Korisnik korisnik = KorisnikRepozitorij.DohvatiKorisnika_Mail(skeniranaVrijednost);
                if (korisnik == null)
                {
                    IspisGreske($"Korisnik s e-mailom {skeniranaVrijednost} nije pronađen!");
                    return;
                }

                PopuniCMBKorisnici(korisnik);

            }
            PromijeniBojuObrubaSkenera(Color.LimeGreen);
            txtGreske.Text = "";
            txtGreske.BackColor = Color.FromArgb(254, 255, 242);
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
                txtRezultat.BackColor = Color.FromArgb(254, 255, 242);
            }

        }

        private void IspisGreske(string poruka)
        {
            txtRezultat.BackColor = Color.FromArgb(254, 255, 242);
            txtGreske.BackColor = Color.LightCoral;
            txtGreske.Text = "";
            txtGreske.Text = poruka;
        }

        public void PromijeniBojuObrubaSkenera(Color boja)
        {
            pbSken.BackColor = boja;
        }

        private bool PostojiBaremJedanCMB()
        {
            return !(cmbKnjige == null && cmbKorisnici == null);
        }

        private bool UnesenISBNBroj(string unos)
        {
            long ignore = -1;
            return long.TryParse(unos, out ignore);
        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                ZaustaviSkeniranje();
            }
        }
    }
}
