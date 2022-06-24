using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Baza;
using PodaciKnjige;
using Prijava;

namespace PosudbeIRezervacije
{
    public static class RezervacijaRepozitorij
    {
        public static int DodajRezervaciju(Posudba rezervacija)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = "INSERT INTO posudbe " +
                "(id_primjerak, id_korisnik, do_kada_vrijedi_rezervacija, rezervacija_potvrdena)" +
                " VALUES" +
                "(" + rezervacija.Primjerak.Id +
                ", '" + rezervacija.Korisnik.OIB + "'" +
                ", '" + rezervacija.DoKadaVrijediRezervacija.ToShortDateString() + "'" +
                ", 0)";

            int i = BazaPodataka.Instanca.IzvrsiNaredbu(upit);
            BazaPodataka.Instanca.PrekiniVezu();

            return i;
        }
    }
}
