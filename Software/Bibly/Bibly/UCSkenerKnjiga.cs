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
using Skener;
namespace Bibly
{
    public partial class UCSkenerKnjiga : UserControl
    {
        private ComboBox cmbKnjige = null;

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
            btnSkeniraj.Enabled = false;
            btnZaustavi.Enabled = true;
            ZapocniSkeniranje();
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (this.txtISBN.InvokeRequired)
            {
                PrekidSkeniranjeCallback  d = new PrekidSkeniranjeCallback(UspjesnoSkeniranje);
                this.Invoke(d);

            }
            else
            {
                ZaustaviSkeniranje();
            }
            PrekidSkeniranja();
            pbSken.Image = null;
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
                PromijeniBoju(Color.Red);
                pbSken.Image = (Bitmap)a.Clone();
            }

        }

        delegate void UspjesnoSkeniranjeCallback();

        public void UspjesnoSkeniranje()
        {
            PromijeniBoju(Color.LimeGreen);
            ZaustaviSkeniranje();
        }

        public void PrekidSkeniranja()
        {
            PromijeniBoju(Color.Gray);
            ZaustaviSkeniranje();
        }
        public void ZaustaviSkeniranje()
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                btnSkeniraj.Enabled = true;
                btnZaustavi.Enabled = false;
            }

        }


        public void PromijeniBoju(Color boja)
        {
            pbSken.BackColor = boja;
        }
    }
}
