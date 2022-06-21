using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijava
{
    public class Korisnik
    {
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojMobitela { get; set; }
        public string Email { get; set; }

        public Mjesto Prebivaliste { get; set; }
        public string AdresaPrebivalista { get; set; }
        public Mjesto Boraviste { get; set; }
        public string AdresaBoravista { get; set; }

        public DateTime DatumUclanjivanja { get; set; }
        public DateTime DatumIstekaClanarine { get; set; }

        public string Lozinka { get; set; }
        public bool Blokiran { get; set; }

        public TipKorisnika TipKorisnika { get; set; }

        public Korisnik()
        {

        }
        public Korisnik(string oib, string ime, string prezime, string brojMobitela, string email,
            Mjesto prebivaliste, string adresaPrebivalista, Mjesto boraviste, string adresaBoravista,
            DateTime datumUclanjivanja, DateTime datumIstekaClanarine, string lozinka, bool blokiran,TipKorisnika tipKorisnika)
        {
            OIB = oib;
            Ime = ime;
            Prezime = prezime;
            BrojMobitela = brojMobitela;
            Email = email;
            Prebivaliste = prebivaliste;
            AdresaPrebivalista = adresaPrebivalista;
            Boraviste = boraviste;
            AdresaBoravista = adresaBoravista;
            DatumUclanjivanja = datumUclanjivanja;
            DatumIstekaClanarine = datumIstekaClanarine;
            Lozinka = lozinka;
            Blokiran = blokiran;
            TipKorisnika = tipKorisnika;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }
}
