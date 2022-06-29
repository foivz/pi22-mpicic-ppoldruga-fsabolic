using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Baza;

namespace Prijava
{
    public static class KorisnikRepozitorij
    {
        public static List<Korisnik> DohvatiSveKorisnike()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT " +
                    "k.OIB as 'k.OIB'," +
                    "k.ime AS 'k.ime'," +
                    "k.prezime AS 'k.prezime'," +
                    "k.broj_mobitela AS 'k.broj_mobitela'," +
                    "k.email AS 'k.email'," +
                    "m1.id_mjesto AS 'm1.id_mjesto'," +
                    "m1.naziv AS 'm1.naziv' ," +
                    "k.adresa_prebivalista AS 'k.adresa_prebivalista'," +
                    "m.id_mjesto AS 'm.id_mjesto'," +
                    "m.naziv AS 'm.naziv'," +
                    "k.adresa_boravista AS 'k.adresa_boravista'," +
                    "k.datum_uclanjivanja AS 'k.datum_uclanjivanja'," +
                    "k.datum_isteka_clanarine AS 'k.datum_isteka_clanarine'," +
                    "k.lozinka AS 'k.lozinka'," +
                    "k.pokusaji_prijave AS 'k.pokusaji_prijave'," +
                    "k.blokiran AS 'k.blokiran'," +
                    "tk.id_tip_korisnika AS 'tk.id_tip_korisnika'," +
                    "tk.naziv AS 'tk.naziv' " +
                    "FROM korisnici k " +
                    "JOIN mjesta m " +
                    "ON m.id_mjesto = k.boraviste " +
                    "JOIN mjesta m1 " +
                    "ON m1.id_mjesto = k.prebivaliste " +
                    "JOIN tipovi_korisnika tk " +
                    "ON tk.id_tip_korisnika = k.id_tip_korisnika";


            List<Korisnik> korisnici = new List<Korisnik>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                korisnici.Add(new Korisnik(
                   reader[0].ToString(),
                   reader["k.ime"].ToString(),
                   reader["k.prezime"].ToString(),
                   reader["k.broj_mobitela"].ToString(),
                   reader["k.email"].ToString(),
                   new Mjesto(
                        int.Parse(reader["m1.id_mjesto"].ToString()),
                        reader["m1.naziv"].ToString()
                        ),

                    reader["k.adresa_prebivalista"].ToString(),
                    new Mjesto(
                        int.Parse(reader["m.id_mjesto"].ToString()),
                        reader["m.naziv"].ToString()
                        ),

                    reader["k.adresa_boravista"].ToString(),
                    DateTime.Parse(reader["k.datum_uclanjivanja"].ToString()),
                    DateTime.Parse(reader["k.datum_isteka_clanarine"].ToString()),
                    reader["k.lozinka"].ToString(),
                    int.Parse(reader["k.blokiran"].ToString()),
                    new TipKorisnika(
                        int.Parse(reader["tk.id_tip_korisnika"].ToString()),
                        reader["tk.naziv"].ToString()
                        )

                   ));


            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return korisnici;
        }

        public static Korisnik DohvatiKorisnika_Mail(string email)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit =
                    "SELECT " +
                    "k.OIB as 'k.OIB'," +
                    "k.ime AS 'k.ime'," +
                    "k.prezime AS 'k.prezime'," +
                    "k.broj_mobitela AS 'k.broj_mobitela'," +
                    "k.email AS 'k.email'," +
                    "m1.id_mjesto AS 'm1.id_mjesto'," +
                    "m1.naziv AS 'm1.naziv' ," +
                    "k.adresa_prebivalista AS 'k.adresa_prebivalista'," +
                    "m.id_mjesto AS 'm.id_mjesto'," +
                    "m.naziv AS 'm.naziv'," +
                    "k.adresa_boravista AS 'k.adresa_boravista'," +
                    "k.datum_uclanjivanja AS 'k.datum_uclanjivanja'," +
                    "k.datum_isteka_clanarine AS 'k.datum_isteka_clanarine'," +
                    "k.lozinka AS 'k.lozinka'," +
                    "k.pokusaji_prijave AS 'k.pokusaji_prijave'," +
                    "k.blokiran AS 'k.blokiran'," +
                    "tk.id_tip_korisnika AS 'tk.id_tip_korisnika'," +
                    "tk.naziv AS 'tk.naziv' " +
                    "FROM korisnici k " +
                    "JOIN mjesta m " +
                    "ON m.id_mjesto = k.boraviste " +
                    "JOIN mjesta m1 " +
                    "ON m1.id_mjesto = k.prebivaliste " +
                    "JOIN tipovi_korisnika tk " +
                    "ON tk.id_tip_korisnika = k.id_tip_korisnika " +
                    $"WHERE k.email='{email}'";
            Korisnik korisnik = null;
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                korisnik = new Korisnik(
                    reader[0].ToString(),
                    reader["k.ime"].ToString(),
                    reader["k.prezime"].ToString(),
                    reader["k.broj_mobitela"].ToString(),
                    reader["k.email"].ToString(),
                    new Mjesto(
                         int.Parse(reader["m1.id_mjesto"].ToString()),
                         reader["m1.naziv"].ToString()
                         ),

                     reader["k.adresa_prebivalista"].ToString(),
                     new Mjesto(
                         int.Parse(reader["m.id_mjesto"].ToString()),
                         reader["m.naziv"].ToString()
                         ),

                     reader["k.adresa_boravista"].ToString(),
                     DateTime.Parse(reader["k.datum_uclanjivanja"].ToString()),
                     DateTime.Parse(reader["k.datum_isteka_clanarine"].ToString()),
                     reader["k.lozinka"].ToString(),
                     int.Parse(reader["k.blokiran"].ToString()),
                     new TipKorisnika(
                         int.Parse(reader["tk.id_tip_korisnika"].ToString()),
                         reader["tk.naziv"].ToString()
                         )
                    );


            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
            return korisnik;
        }

        public static Korisnik DohvatiKorisnika_OIB(string oib)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT " +
                    "k.OIB as 'k.OIB'," +
                    "k.ime AS 'k.ime'," +
                    "k.prezime AS 'k.prezime'," +
                    "k.broj_mobitela AS 'k.broj_mobitela'," +
                    "k.email AS 'k.email'," +
                    "m1.id_mjesto AS 'm1.id_mjesto'," +
                    "m1.naziv AS 'm1.naziv' ," +
                    "k.adresa_prebivalista AS 'k.adresa_prebivalista'," +
                    "m.id_mjesto AS 'm.id_mjesto'," +
                    "m.naziv AS 'm.naziv'," +
                    "k.adresa_boravista AS 'k.adresa_boravista'," +
                    "k.datum_uclanjivanja AS 'k.datum_uclanjivanja'," +
                    "k.datum_isteka_clanarine AS 'k.datum_isteka_clanarine'," +
                    "k.lozinka AS 'k.lozinka'," +
                    "k.pokusaji_prijave AS 'k.pokusaji_prijave'," +
                    "k.blokiran AS 'k.blokiran'," +
                    "tk.id_tip_korisnika AS 'tk.id_tip_korisnika'," +
                    "tk.naziv AS 'tk.naziv' " +
                    "FROM korisnici k " +
                    "JOIN mjesta m " +
                    "ON m.id_mjesto = k.boraviste " +
                    "JOIN mjesta m1 " +
                    "ON m1.id_mjesto = k.prebivaliste " +
                    "JOIN tipovi_korisnika tk " +
                    "ON tk.id_tip_korisnika = k.id_tip_korisnika " +
                    $"WHERE k.OIB='{oib}'";


            Korisnik korisnik = null;

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                korisnik = new Korisnik(
                    reader[0].ToString(),
                    reader["k.ime"].ToString(),
                    reader["k.prezime"].ToString(),
                    reader["k.broj_mobitela"].ToString(),
                    reader["k.email"].ToString(),
                    new Mjesto(
                         int.Parse(reader["m1.id_mjesto"].ToString()),
                         reader["m1.naziv"].ToString()
                         ),

                     reader["k.adresa_prebivalista"].ToString(),
                     new Mjesto(
                         int.Parse(reader["m.id_mjesto"].ToString()),
                         reader["m.naziv"].ToString()
                         ),

                     reader["k.adresa_boravista"].ToString(),
                     DateTime.Parse(reader["k.datum_uclanjivanja"].ToString()),
                     DateTime.Parse(reader["k.datum_isteka_clanarine"].ToString()),
                     reader["k.lozinka"].ToString(),
                     int.Parse(reader["k.blokiran"].ToString()),
                     new TipKorisnika(
                         int.Parse(reader["tk.id_tip_korisnika"].ToString()),
                         reader["tk.naziv"].ToString()
                         )
                    );


            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return korisnik;
        }

        public static int DodajKorisnika(Korisnik korisnik)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = $"INSERT INTO korisnici VALUES ('{korisnik.OIB}','{korisnik.Ime}','{korisnik.Prezime}','{korisnik.BrojMobitela}','{korisnik.Email}',{korisnik.Prebivaliste.ID},'{korisnik.AdresaPrebivalista}',{korisnik.Boraviste.ID},'{korisnik.AdresaBoravista}','{korisnik.DatumUclanjivanja.Date.ToString("yyyy-MM-dd")}','{korisnik.DatumIstekaClanarine.ToString("yyyy-MM-dd")}','{korisnik.Lozinka}',{korisnik.PokusajiPrijave},{(korisnik.Blokiran==true?1:0)},{korisnik.TipKorisnika.ID})";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }

        public static int AzurirajKorisnika(string stariOIB, Korisnik korisnik)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = $"UPDATE korisnici set OIB='{korisnik.OIB}',ime='{korisnik.Ime}'," +
                $"prezime='{korisnik.Prezime}',broj_mobitela='{korisnik.BrojMobitela}',email='{korisnik.Email}'," +
                $"prebivaliste = {korisnik.Prebivaliste.ID},adresa_prebivalista='{korisnik.AdresaPrebivalista}'," +
                $"boraviste = {korisnik.Boraviste.ID},adresa_boravista = '{korisnik.AdresaBoravista}',datum_uclanjivanja = '{korisnik.DatumUclanjivanja.Date.ToString("yyyy-MM-dd")}'," +
                $"datum_isteka_clanarine = '{korisnik.DatumIstekaClanarine.ToString("yyyy-MM-dd")}',lozinka = '{korisnik.Lozinka}'," +
                $"pokusaji_prijave = {korisnik.PokusajiPrijave},blokiran = {(korisnik.Blokiran == true ? 1 : 0)},id_tip_korisnika = {korisnik.TipKorisnika.ID} WHERE OIB='{stariOIB}'";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }

        public static int AzurirajKorisnika_Lozinka(Korisnik korisnik,string lozinka)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = $"UPDATE korisnici SET lozinka = '{lozinka}' WHERE OIB='{korisnik.OIB}'";
            
            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }

        public static int AzurirajKorisnika_DatumIstekaClanarine(Korisnik korisnik,DateTime noviDatum)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = $"UPDATE korisnici SET "+
                $"datum_isteka_clanarine = '{noviDatum.ToString("yyyy-MM-dd")}' WHERE OIB='{korisnik.OIB}'";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }

        public static int ObrisiKorisnika(Korisnik korisnik)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = $"DELETE FROM korisnici WHERE OIB='{korisnik.OIB}'";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }

        public static int TrenutniBrojPosudbi(Korisnik korisnik)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit = "SELECT COUNT(*) AS 'broj_posudbi'" +
                " FROM posudbe po" +
                " WHERE (po.rezervacija_potvrdena = 0" +
                " OR (po.datum_posudbe IS NOT NULL AND po.stvarni_datum_vracanja IS NULL))" +
                $" AND id_korisnik = '{korisnik.OIB}'";
            List<int> brojPosudbi = new List<int>();
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                brojPosudbi.Add(int.Parse(reader["broj_posudbi"].ToString()));
            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
            return brojPosudbi[0];
        }
    }
}
