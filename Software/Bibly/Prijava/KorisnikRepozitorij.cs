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
                    "ON tk.id_tip_korisnika = k.id_tip_korisnika "+
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

        public static bool DohvatiKorisnika_OIB()
        {
            return true;
        }

        public static int TrenutniBrojPosudbi(Korisnik korisnik)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit = "SELECT COUNT(*) AS 'broj_posudbi'" +
                " FROM posudbe po" +
                " WHERE (stvarni_datum_vracanja IS NULL OR rezervacija_potvrdena != 1)" +
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
