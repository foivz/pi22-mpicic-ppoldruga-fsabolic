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
        public static List<Posudba> DohvatiTrenutneRezervacijeKorisnika(Korisnik korisnik)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit =
                    "SELECT id_posudba" +
                    ", id_primjerak" +
                    ", do_kada_vrijedi_rezervacija" +
                    " FROM posudbe" + 
                    " WHERE datum_posudbe IS NULL" +
                    " AND rezervacija_potvrdena = 0" +
                    $" AND id_korisnik = '{korisnik.OIB}'";
            List<Posudba> trenutneRezervacijeKorisnika = new List<Posudba>();
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int idRezervacije = int.Parse(reader["id_posudba"].ToString());
                int idPrimjerka = int.Parse(reader["id_primjerak"].ToString());
                DateTime doKadaVrijediRezervacija = DateTime.Parse(reader["do_kada_vrijedi_rezervacija"].ToString());
                trenutneRezervacijeKorisnika.Add(new Posudba(
                    idRezervacije,
                    korisnik,
                    PrimjerakRepozitorij.DohvatiPrimjerak(idPrimjerka),
                    doKadaVrijediRezervacija
                ));
            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
            if (trenutneRezervacijeKorisnika.Count == 0)
            {
                return null;
            }
            return trenutneRezervacijeKorisnika;
        }
        public static void ProvjeriIstekleRezervacije()
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit =
                    "SELECT id_posudba" +
                    ", id_primjerak" +
                    ", do_kada_vrijedi_rezervacija" +
                    " FROM posudbe" +
                    " WHERE rezervacija_potvrdena = 0";
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int idRezervacije = int.Parse(reader["id_posudba"].ToString());
                int idPrimjerka = int.Parse(reader["id_primjerak"].ToString());
                DateTime doKadaVrijediRezervacija = DateTime.Parse(reader["do_kada_vrijedi_rezervacija"].ToString());
                if (DateTime.Compare(doKadaVrijediRezervacija.Date, DateTime.Now.Date) < 0)
                {
                    ZatvoriRezervaciju(idRezervacije, idPrimjerka);
                }
            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
        }
        public static Posudba DohvatiRezervacijuPrimjerka(Primjerak primjerak)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit =
                    "SELECT id_posudba" +
                    ", id_korisnik" +
                    ", do_kada_vrijedi_rezervacija" +
                    " FROM posudbe" +
                    " WHERE rezervacija_potvrdena = 0 " +
                    $" AND id_primjerak = {primjerak.Id}";
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            List<Posudba> rezervacija = new List<Posudba>();
            while (reader.Read())
            {
                rezervacija.Add(new Posudba(
                        int.Parse(reader["id_posudba"].ToString()),
                        KorisnikRepozitorij.DohvatiKorisnika_OIB(reader["id_korisnik"].ToString()),
                        primjerak,
                        DateTime.Parse(reader["do_kada_vrijedi_rezervacija"].ToString())
                    ));
            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
            if(rezervacija.Count == 0)
            {
                return null;
            }
            return rezervacija[0];
        }

        public static int ZatvoriRezervaciju(int idRezervacije, int idPrimjerka)
        {
            PrimjerakRepozitorij.AzurirajStatusPrimjerka(idPrimjerka, StatusPrimjerka.Dostupan);
            BazaPodataka.Instanca.UspostaviVezu();
            string upit = $"UPDATE posudbe " +
                $"SET rezervacija_potvrdena = 1 WHERE id_posudba = {idRezervacije}";
            int i = BazaPodataka.Instanca.IzvrsiNaredbu(upit);
            BazaPodataka.Instanca.PrekiniVezu();
            return i;
        }
        public static int DodajRezervaciju(Posudba rezervacija)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit = "INSERT INTO posudbe " +
                "(id_primjerak, id_korisnik, do_kada_vrijedi_rezervacija, rezervacija_potvrdena)" +
                " VALUES" +
                "(" + rezervacija.Primjerak.Id +
                ", '" + rezervacija.Korisnik.OIB + "'" +
                ", '" + rezervacija.DoKadaVrijediRezervacija.ToString("yyyy-MM-dd") + "'" +
                ", 0)";

            int i = BazaPodataka.Instanca.IzvrsiNaredbu(upit);
            BazaPodataka.Instanca.PrekiniVezu();
            return i;
        }
    }
}
