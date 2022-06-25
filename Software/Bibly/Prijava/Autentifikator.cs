using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava
{
    public class Autentifikator
    {
        private Korisnik logiraniKorisnik = null;

        private static Autentifikator instanca;
        public static Autentifikator Instanca
        {
            get
            {
                if (instanca == null)
                    instanca = new Autentifikator();
                return instanca;
            }
        }
        private Autentifikator()
        {

        }

        public int PrijavaKorisnika(string email, string lozinka)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email)
                || string.IsNullOrEmpty(lozinka) || string.IsNullOrWhiteSpace(lozinka))
            {
                return -1;
            }

            Korisnik korisnik = KorisnikRepozitorij.DohvatiKorisnika_Mail(email);
            if (korisnik == null)
            {
                return -2;
            }
            else if (korisnik.Lozinka != lozinka)
            {
                return -3;
            }
            else if (korisnik.Blokiran == true)
            {
                return -4;
            }
            else if (korisnik.DatumIstekaClanarine < DateTime.Now)
            {
                return -5;
            }

            logiraniKorisnik = korisnik;
            return 1;

        }

        public int UlogaKorisnika()
        {
            if (PostojiLogiranKorisnik())
            {
                return logiraniKorisnik.TipKorisnika.ID;
            }
            return -1;
        }

        public string OIBKorisnika()
        {
            if (PostojiLogiranKorisnik())
            {
                return logiraniKorisnik.OIB;
            }
            return "";
        }

        public Korisnik VratiKorisnika()
        {
            if (PostojiLogiranKorisnik())
            {
                return logiraniKorisnik;
            }
            return null;
        }

        public bool PostojiLogiranKorisnik()
        {
            return (logiraniKorisnik == null) ? false : true;
        }

        public bool OdjavaKorisnika()
        {
            if (PostojiLogiranKorisnik())
            {
                logiraniKorisnik = null;
                return true;
            }

            return false;

        }





    }
}
