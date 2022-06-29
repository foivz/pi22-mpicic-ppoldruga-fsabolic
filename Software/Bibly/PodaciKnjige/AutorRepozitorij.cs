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
    public static class AutorRepozitorij
    {
        public static List<Autor> DohvatiAutoreKnjige(string ISBN)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT " +
                    "a.id_autor AS 'a.id_autor'" +
                    ",a.ime AS 'a.ime'" +
                    ", a.prezime AS 'a.prezime'" +
                    ",a.biografija AS 'a.biografija'" +
                    " FROM autori a" +
                    " JOIN autor_knjige ak" +
                    " ON a.id_autor = ak.id_autor" +
                    " JOIN knjige k" +
                    " ON k.ISBN = ak.ISBN" +
                    $" WHERE k.ISBN = '{ISBN}'";

            List<Autor> autori = new List<Autor>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                autori.Add(new Autor(
                    int.Parse(reader["a.id_autor"].ToString()),
                   reader["a.ime"].ToString(),
                   reader["a.prezime"].ToString(),
                   reader["a.biografija"].ToString()
                   ));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return autori;
        }

        public static List<Autor> DohvatiSveAutore()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT * FROM autori";

            List<Autor> autori = new List<Autor>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                autori.Add(new Autor(
                    int.Parse(reader["id_autor"].ToString()),
                   reader["ime"].ToString(),
                   reader["prezime"].ToString(),
                   reader["biografija"].ToString()

                   ));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return autori;
        }
        public static int DodajAutora(Autor autor)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"INSERT INTO autori VALUES('{autor.Ime}','{autor.Prezime}','{autor.Biografija}')";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }
        public static int AzurirajAutora(Autor autor)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"UPDATE autori SET ime='{autor.Ime}',prezime='{autor.Prezime}',biografija='{autor.Biografija}' WHERE id_autor={autor.Id}";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }
        public static int ObrisiAutora(Autor autor)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"DELETE FROM autori WHERE id_autor={autor.Id}";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }
    }
}
