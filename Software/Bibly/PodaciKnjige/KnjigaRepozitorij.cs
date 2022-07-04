using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Baza;
using System.Drawing;
using System.IO;

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
                    DohvatiNaslovnicuKnjige(reader),
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
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = "INSERT INTO knjige" +
                        "(ISBN" +
                        ", naziv" +
                        ", id_izdavac" +
                        ", id_zanr" +
                        ", datum_izdavanja" +
                        ", broj_stranica" +
                        ", opis_knjige" +
                        $", naslovnica) VALUES('{dodanaKnjiga.ISBN}','{dodanaKnjiga.Naziv}',{dodanaKnjiga.Izdavac.Id},{dodanaKnjiga.Zanr.Id},'{dodanaKnjiga.DatumIzdavanja.Date.ToString("yyyy-MM-dd")}'," +
                        $"{dodanaKnjiga.BrojStranica},'{dodanaKnjiga.Opis}',NULL)";


            int i = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            if(dodanaKnjiga.Naslovnica!=null) DodajNaslovnicuKnjige(dodanaKnjiga.ISBN, dodanaKnjiga.Naslovnica);

            return i;
        }
        public static void DodajNaslovnicuKnjige(string ISBN, Image slika)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = $"UPDATE knjige SET naslovnica = @slika WHERE ISBN='{ISBN}'";

            BazaPodataka.Instanca.IzvrsiNaredbuParamImage(upit, slika);

            BazaPodataka.Instanca.PrekiniVezu();
        }
        public static int ObrisiKnjigu(Knjiga dodanaKnjiga)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = $"DELETE FROM knjige WHERE ISBN='{dodanaKnjiga.ISBN}'";

            BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();
            return 0;
        }
        public static int AzurirajKnjigu(string isbn,Knjiga dodanaKnjiga)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit = "UPDATE knjige" +
                        $" SET ISBN='{dodanaKnjiga.ISBN}',naziv = '{dodanaKnjiga.Naziv}',id_izdavac = {dodanaKnjiga.Izdavac.Id}," +
                        $"id_zanr = {dodanaKnjiga.Zanr.Id},datum_izdavanja = '{dodanaKnjiga.DatumIzdavanja.Date.ToString("yyyy-MM-dd")}'," +
                        $"broj_stranica = {dodanaKnjiga.BrojStranica},opis_knjige = '{dodanaKnjiga.Opis}',naslovnica = NULL WHERE ISBN = '{isbn}'";


            int i = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            if (dodanaKnjiga.Naslovnica != null) DodajNaslovnicuKnjige(dodanaKnjiga.ISBN, dodanaKnjiga.Naslovnica);

            return i;
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
                    " WHERE k.ISBN = '" + ISBN + "'";

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
                DohvatiNaslovnicuKnjige(reader),
                AutorRepozitorij.DohvatiAutoreKnjige(reader["k.ISBN"].ToString())
            ));
            }

            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();
            if (knjige.Count == 0)
            {
                return null;
            }

            return knjige[0];
        }
        private static Image DohvatiNaslovnicuKnjige(IDataReader reader)
        {
            Image slika = null;
            if (!reader.IsDBNull(7))
            {
                MemoryStream stream = new MemoryStream(((SqlDataReader)reader).GetSqlBytes(7).Buffer);
                slika = Image.FromStream(stream);
            }
            return slika;
        }

        public static List<Knjiga> DohvatiNajcitanijeKnjigaMjeseca()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                "select TOP 10 k.ISBN as 'k.ISBN',count(po.id_posudba) AS broj_posudbi from posudbe po RIGHT join primjerci pr ON pr.id_primjerak = po.id_primjerak LEFT JOIN knjige k ON k.ISBN = pr.ISBN WHERE(datum_posudbe >= DATEADD(DAY, -30, GETDATE()) AND datum_posudbe <= GETDATE()) OR(datum_posudbe is null AND po.do_kada_vrijedi_rezervacija is null) GROUP BY k.ISBN ORDER BY count(po.id_posudba) desc";

            List<Knjiga> knjige = new List<Knjiga>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);

            while (reader.Read())
            {
                knjige.Add(DohvatiKnjigu(reader["k.ISBN"].ToString()));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return knjige;

        }
    }
}
