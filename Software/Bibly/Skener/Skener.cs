using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using QRCoder;
using ZXing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Skener
{
    public static class Skener
    {
        public static Image GenerirajQRKod(string unos)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData podaci = qrGenerator.CreateQrCode(unos, QRCodeGenerator.ECCLevel.Q);
            QRCode qrKod = new QRCode(podaci);
            return qrKod.GetGraphic(5);
        }

        public static Image GenerirajBarKod(string unos)
        {
            BarcodeWriter barKodGenerator = new BarcodeWriter()
            {
                Format = BarcodeFormat.CODE_128
            };

            return barKodGenerator.Write(unos);
        }

        public static string DesifrirajKod(Image barkod)
        {
            BarcodeReader barKodCitac = new BarcodeReader();
            
            var rezultat = barKodCitac.Decode((Bitmap)barkod);
            if (rezultat != null)
            {
                return rezultat.Text;
            }
            else
            {
                return "";
            }
        }

        private static void Isprintaj(Image slika)
        {
            //OVO SE MORA UKLJUČIT GORE JER INAČE NE RADI
            //using System.Drawing;
            //using System.Drawing.Printing;
            PrintDialog pd = new PrintDialog();
            PrintDocument printDocument1 = new PrintDocument();
            
            printDocument1.PrintPage += delegate (object sender, PrintPageEventArgs e) { printDocument1_PrintPage(sender, e, slika); };
            pd.Document = printDocument1;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private static void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e,Image slika)
        {
            //OVA ZAKOMENTIRANA LINIJA GOVORI ŠTA DA SE PRINTA, U NAŠEM SLUČAJU SLIKA IZ PICTUREBOXA
            e.Graphics.DrawImage(slika, 0, 0);

        }

    }
}
