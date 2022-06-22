using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using QRCoder;
using ZXing;

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

        public static string DesifrirajBarKod(Image barkod)
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

    }
}
