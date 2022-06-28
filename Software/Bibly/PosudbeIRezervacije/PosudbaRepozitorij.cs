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
using Postavke;

namespace PosudbeIRezervacije
{
    public static class PosudbaRepozitorij
    {
        public static void ProduljiPosudbu(Posudba posudba, DateTime noviDatumVracanja)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit = $"UPDATE posudbe " +
                $"SET broj_produljivanja = {posudba.BrojProduljivanja}, predviden_datum_vracanja = '{noviDatumVracanja.ToString("yyyy-MM-dd")}' WHERE id_posudba = {posudba.Id}";
            BazaPodataka.Instanca.IzvrsiNaredbu(upit);
            BazaPodataka.Instanca.PrekiniVezu();
        }
        public static void AzurirajZakasninu(int idPosudbe, double zakasnina)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit = $"UPDATE posudbe " +
                $"SET zakasnina = {zakasnina} WHERE id_posudba = {idPosudbe}";
            BazaPodataka.Instanca.IzvrsiNaredbu(upit);
            BazaPodataka.Instanca.PrekiniVezu();
        }
        public static List<Posudba> DohvatiTrenutnePosudbeKorisnika(Korisnik korisnik)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit =
                    "SELECT id_posudba" +
                    ", datum_posudbe" +
                    ", predviden_datum_vracanja" +
                    ", broj_produljivanja" +
                    ", zakasnina" +
                    ", id_primjerak" +
                    " FROM posudbe" +
                    " WHERE stvarni_datum_vracanja IS NULL" +
                    " AND datum_posudbe IS NOT NULL" +
                    $" AND id_korisnik = '{korisnik.OIB}'";
            List<Posudba> trenutnePosudbeKorisnika = new List<Posudba>();
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int idPosudbe = int.Parse(reader["id_posudba"].ToString());
                int idPrimjerka = int.Parse(reader["id_primjerak"].ToString());
                trenutnePosudbeKorisnika.Add(new Posudba(
                    idPosudbe,
                    DateTime.Parse(reader["datum_posudbe"].ToString()),
                    DateTime.Parse(reader["predviden_datum_vracanja"].ToString()),
                    int.Parse(reader["broj_produljivanja"].ToString()),
                    double.Parse(reader["zakasnina"].ToString()),
                    korisnik,
                    PrimjerakRepozitorij.DohvatiPrimjerak(idPrimjerka)
                ));
            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
            if (trenutnePosudbeKorisnika.Count == 0)
            {
                return null;
            }
            return trenutnePosudbeKorisnika;
        }
        public static List<Posudba> DohvatiProslePosudbeKorisnika(Korisnik korisnik)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit =
                    "SELECT id_posudba" +
                    ", datum_posudbe" +
                    ", predviden_datum_vracanja" +
                    ", stvarni_datum_vracanja" +
                    ", broj_produljivanja" +
                    ", zakasnina" +
                    ", id_primjerak" +
                    " FROM posudbe" +
                    " WHERE stvarni_datum_vracanja IS NOT NULL" +
                    $" AND id_korisnik = '{korisnik.OIB}'";
            List<Posudba> proslePosudbeKorisnika = new List<Posudba>();
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int idPosudbe = int.Parse(reader["id_posudba"].ToString());
                int idPrimjerka = int.Parse(reader["id_primjerak"].ToString());
                proslePosudbeKorisnika.Add(new Posudba(
                    idPosudbe,
                    DateTime.Parse(reader["datum_posudbe"].ToString()),
                    DateTime.Parse(reader["predviden_datum_vracanja"].ToString()),
                    DateTime.Parse(reader["stvarni_datum_vracanja"].ToString()),
                    int.Parse(reader["broj_produljivanja"].ToString()),
                    double.Parse(reader["zakasnina"].ToString()),
                    korisnik,
                    PrimjerakRepozitorij.DohvatiPrimjerak(idPrimjerka)
                ));
            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
            if (proslePosudbeKorisnika.Count == 0)
            {
                return null;
            }
            return proslePosudbeKorisnika;
        }
    }
}