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
        private ComboBox cmbPrimjerci = null;
        private ComboBox cmbKorisnici = null;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public UCSkener()
        {
            InitializeComponent();
            this.pbSken.Padding = new System.Windows.Forms.Padding(3);
            UcitajKamere();
        }

        public void PostaviUCSkener(FrmOpcenita frm, ComboBox _cmbPrimjerci, ComboBox _cmbKorisnici)
        {
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            cmbPrimjerci = _cmbPrimjerci;
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
                IspisGreske("-- E R R O R : Nije proslijeđen ComboBox ni za korisnike ni za primjerke --");

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

        private void PopuniCMBPrimjerci(Primjerak primjerak)
        {
                cmbPrimjerci.Items.Add(primjerak);
                cmbPrimjerci.SelectedItem = primjerak;
        }

        private void PopuniCMBKorisnici(Korisnik korisnik)
        {
            cmbKorisnici.Items.Add(korisnik);
            cmbKorisnici.SelectedItem = korisnik;
        }

        delegate void UspjesnoSkeniranjeCallback();

        public void UspjesnoSkeniranje()
        {

            if (!PostojiBaremJedanCMB())
            {
                IspisGreske("-- E R R O R : Nije proslijeđen ComboBox ni za korisnike ni za primjerke --");
                return;
            }


            string skeniranaVrijednost = txtRezultat.Text;
            if (UnesenBroj(skeniranaVrijednost))
            {
                if (cmbPrimjerci == null)
                {
                    IspisGreske("Uočen barkod! Pokušajte s QR kodom!");
                    return;
                }

                if (skeniranaVrijednost.Length > 9)
                {
                    IspisGreske($"Primjerak s ID-om {skeniranaVrijednost} nije pronađen!");
                    return;
                }

                Primjerak primjerak = PrimjerakRepozitorij.DohvatiPrimjerak(int.Parse(skeniranaVrijednost));
                if (primjerak == null)
                {
                    IspisGreske($"Primjerak s ID-om {skeniranaVrijednost} nije pronađen!");
                    return;
                }

                PopuniCMBPrimjerci(primjerak);


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
            return !(cmbPrimjerci == null && cmbKorisnici == null);
        }

        private bool UnesenBroj(string unos)
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
