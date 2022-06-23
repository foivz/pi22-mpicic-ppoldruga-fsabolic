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
    public static class PrimjerakRepozitorij
    {
        public static List<Primjerak> DohvatiPrimjerkeKnjige(Knjiga knjiga)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    "SELECT p.id_primjerak AS 'p.id_primjerak'" +
                    ", p.ISBN AS 'p.ISBN'" +
                    ", p.id_status AS 'p.id_status'" +
                    ", sp.naziv AS 'sp.naziv'" +
                    " FROM primjerci p" +
                    " JOIN statusi_primjeraka sp" +
                    " ON sp.id_statusa = p.id_status" +
                    " JOIN knjige k" +
                    " ON k.ISBN = p.ISBN" +
                    " WHERE p.ISBN = " + knjiga.ISBN;

            List<Primjerak> primjerci = new List<Primjerak>();
            DateTime datumPosudbe, predvideniDatumVracanja, stvarniDatumVracanja, 
                doKadaVrijediRezervacija;
            int rezervacijaPotvrdena;

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                primjerci.Add(new Primjerak(
                   int.Parse(reader["p.id_primjerak"].ToString()),
                   StatusPrimjerka.Dostupan,
                   KnjigaRepozitorij.DohvatiKnjigu(reader["p.ISBN"].ToString())
                   ));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return primjerci;
        }
    }
}
