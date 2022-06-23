using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Baza;

namespace PodaciKnjige
{
    public static class KnjigaRepozitorij
    {
        public static List<Knjiga> DohvatiSveKnjige()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT k.ISBN AS 'k.ISBN'" +
                    ", k.naziv AS 'k.naziv'" +
                    ", k.id_izdavac AS 'k.id_izdavac'" +
                    ", k.id_zanr AS 'k.id_zanr'" +
                    ", k.datum_izdavanja AS 'k.datum_izdavanja'" +
                    ", k.broj_stranica AS 'k.broj_stranica'" +
                    ", k.opis_knjige AS 'k.opis_knjige'" +
                    ", k.naslovnica AS 'k.naslovnica'" +
                    ", i.id_izdavac AS 'i.id_izdavac'" +
                    ", i.naziv AS 'i.naziv'" +
                    ", z.id_zanr AS 'z.id_zanr'" +
                    ", z.naziv AS 'z.naziv'" +
                    " FROM knjige k" +
                    " JOIN izdavaci i" +
                    " ON i.id_izdavac = k.id_izdavac" +
                    " JOIN zanrovi z" +
                    " ON z.id_zanr = k.id_zanr";

            List<Knjiga> knjige = new List<Knjiga>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                knjige.Add(new Knjiga(
                   reader["k.ISBN"].ToString(),
                   reader["k.naziv"].ToString(),
                   new Izdavac(
                        int.Parse(reader["i.id_izdavac"].ToString()),
                        reader["i.naziv"].ToString()
                        ),
                   new Zanr(
                        int.Parse(reader["z.id_zanr"].ToString()),
                        reader["z.naziv"].ToString()
                        ),
                    DateTime.Parse(reader["k.datum_izdavanja"].ToString()),
                    int.Parse(reader["k.broj_stranica"].ToString()),
                    reader["k.opis_knjige"].ToString(),
                    reader["k.naslovnica"].ToString(),
                    AutorRepozitorij.DohvatiAutoreKnjige(reader["k.ISBN"].ToString())
                   ));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return knjige;
        }

        public static List<Knjiga> DohvatiNajcitanijeKnjige()
        {
            List<Knjiga> knjiga = new List<Knjiga>();
            return knjiga;
        }
        public static int DodajKnjigu(Knjiga dodanaKnjiga)
        {
            return 0;
        }
        public static int ObrisiKnjigu(Knjiga dodanaKnjiga)
        {
            return 0;
        }
        public static int AzurirajKnjigu(Knjiga dodanaKnjiga)
        {
            return 0;
        }
        public static Knjiga DohvatiKnjigu(string ISBN)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT k.ISBN AS 'k.ISBN'" +
                    ", k.naziv AS 'k.naziv'" +
                    ", k.id_izdavac AS 'k.id_izdavac'" +
                    ", k.id_zanr AS 'k.id_zanr'" +
                    ", k.datum_izdavanja AS 'k.datum_izdavanja'" +
                    ", k.broj_stranica AS 'k.broj_stranica'" +
                    ", k.opis_knjige AS 'k.opis_knjige'" +
                    ", k.naslovnica AS 'k.naslovnica'" +
                    ", i.id_izdavac AS 'i.id_izdavac'" +
                    ", i.naziv AS 'i.naziv'" +
                    ", z.id_zanr AS 'z.id_zanr'" +
                    ", z.naziv AS 'z.naziv'" +
                    " FROM knjige k" +
                    " JOIN izdavaci i" +
                    " ON i.id_izdavac = k.id_izdavac" +
                    " JOIN zanrovi z" +
                    " ON z.id_zanr = k.id_zanr" +
                    " WHERE k.ISBN = " + ISBN;

            List<Knjiga> knjige = new List<Knjiga>();
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);

            while (reader.Read())
            {
                knjige.Add(new Knjiga(
                reader["k.ISBN"].ToString(),
                reader["k.naziv"].ToString(),
                new Izdavac(
                    int.Parse(reader["i.id_izdavac"].ToString()),
                    reader["i.naziv"].ToString()
                    ),
                new Zanr(
                    int.Parse(reader["z.id_zanr"].ToString()),
                    reader["z.naziv"].ToString()
                    ),
                DateTime.Parse(reader["k.datum_izdavanja"].ToString()),
                int.Parse(reader["k.broj_stranica"].ToString()),
                reader["k.opis_knjige"].ToString(),
                reader["k.naslovnica"].ToString(),
                AutorRepozitorij.DohvatiAutoreKnjige(reader["k.ISBN"].ToString())
            ));
            }

            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return knjige[0];
        }
    }
}
