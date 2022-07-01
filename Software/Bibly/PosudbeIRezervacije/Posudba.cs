using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodaciKnjige;
using Prijava;
using Postavke;

namespace PosudbeIRezervacije
{
    public class Posudba
    {
        public int Id { get; set; }
        public DateTime DatumPosudbe { get; set; }
        public DateTime PredvideniDatumVracanja { get; set; }
        public DateTime StvarniDatumVracanja { get; set; }
        public int BrojProduljivanja { get; set; }
        public double Zakasnina { get; set; }
        public Korisnik Korisnik { get; set; }
        public Primjerak Primjerak { get; set; }
        public DateTime DoKadaVrijediRezervacija { get; set; }
        public int RezervacijaPotvrdena { get; set; }
        public Posudba()
        {

        }

        //konstruktor za Prošle posudbe
        public Posudba(int id, DateTime datumPosudbe, DateTime predvideniDatumVracanja, DateTime stvarniDatumVracanja, int brojProduljivanja, double zakasnina, Korisnik korisnik, Primjerak primjerak)
        {
            Id = id;
            DatumPosudbe = datumPosudbe;
            PredvideniDatumVracanja = predvideniDatumVracanja;
            StvarniDatumVracanja = stvarniDatumVracanja;
            BrojProduljivanja = brojProduljivanja;
            Zakasnina = zakasnina;
            Korisnik = korisnik;
            Primjerak = primjerak;
        }
        //konstruktor za Trenutne posudbe
        public Posudba(int id, DateTime datumPosudbe, DateTime predvideniDatumVracanja, int brojProduljivanja, double zakasnina, Korisnik korisnik, Primjerak primjerak)
        {
            Id = id;
            DatumPosudbe = datumPosudbe;
            PredvideniDatumVracanja = predvideniDatumVracanja;
            BrojProduljivanja = brojProduljivanja;
            Zakasnina = zakasnina;
            Korisnik = korisnik;
            Primjerak = primjerak;
        }
        //konstruktori za Rezervaciju
        public Posudba(Korisnik korisnik, Primjerak primjerak, DateTime doKadaVrijediRezervacija)
        {
            Korisnik = korisnik;
            Primjerak = primjerak;
            DoKadaVrijediRezervacija = doKadaVrijediRezervacija;
        }
        public Posudba(int id, Korisnik korisnik, Primjerak primjerak, DateTime doKadaVrijediRezervacija)
        {
            Id = id;
            Korisnik = korisnik;
            Primjerak = primjerak;
            DoKadaVrijediRezervacija = doKadaVrijediRezervacija;
        }

        public bool JeLiKorisnikPresaoGranicuPosudivanja()
        {
            Korisnik trenutniKorisnik = Autentifikator.Instanca.VratiKorisnika();
            int trenutniBrojPosudbiKorisnika = KorisnikRepozitorij.TrenutniBrojPosudbi(trenutniKorisnik);
            int maxBrojMogucihPosudbi = PostavkeRepozitorij.DohvatiMaksimalanBrojMogucihPosudbi();
            if (trenutniBrojPosudbiKorisnika + 1 <= maxBrojMogucihPosudbi)
            {
                return true;
            }
            return false;
        }
    }
}
