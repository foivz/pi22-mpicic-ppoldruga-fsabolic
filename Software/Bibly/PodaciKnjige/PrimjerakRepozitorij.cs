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
                    ", po.datum_posudbe AS 'po.datum_posudbe'" +
                    ", po.predviden_datum_vracanja AS 'po.predviden_datum_vracanja'" +
                    ", po.stvarni_datum_vracanja AS 'po.stvarni_datum_vracanja'" +
                    ", po.do_kada_vrijedi_rezervacija AS 'po.do_kada_vrijedi_rezervacija'" +
                    ", po.rezervacija_potvrdena AS 'po.rezervacija_potvrdena'" +
                    " FROM primjerci p" +
                    " JOIN statusi_primjeraka sp" +
                    " ON sp.id_statusa = p.id_status" +
                    " JOIN knjige k" +
                    " ON k.ISBN = p.ISBN" +
                    " LEFT JOIN posudbe po" +
                    " ON po.id_primjerak = p.id_primjerak" +
                    " WHERE (po.stvarni_datum_vracanja IS NULL" +
                    " OR rezervacija_potvrdena != 1)" +
                    " AND p.ISBN = " + knjiga.ISBN;

            List<Primjerak> primjerci = new List<Primjerak>();
            string datumPosudbe, predvideniDatumVracanja, stvarniDatumVracanja,
                doKadaVrijediRezervacija;
            int rezervacijaPotvrdena;

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                //provjera statusa primjerka
                StatusPrimjerka status = new StatusPrimjerka();
                switch (reader["sp.naziv"])
                {
                    case "Dostupan":
                        status = StatusPrimjerka.Dostupan;
                        break;
                    case "Posuden":
                        status = StatusPrimjerka.Posuđen;
                        break;
                    case "Rezerviran":
                        status = StatusPrimjerka.Rezerviran;
                        break;
                }
                //provjera dostupnosti
                string doKadaJeNedostupan = "";
                datumPosudbe =reader["po.datum_posudbe"].ToString();
                predvideniDatumVracanja = reader["po.predviden_datum_vracanja"].ToString().Split(' ')[0];
                stvarniDatumVracanja = reader["po.stvarni_datum_vracanja"].ToString();
                doKadaVrijediRezervacija = reader["po.do_kada_vrijedi_rezervacija"].ToString().Split(' ')[0];
                rezervacijaPotvrdena = (!reader.IsDBNull(8)) ? int.Parse(reader["po.rezervacija_potvrdena"].ToString()) : -1;
                if (stvarniDatumVracanja == "" && datumPosudbe != "" && rezervacijaPotvrdena != 1)
                {
                    doKadaJeNedostupan = predvideniDatumVracanja;
                }
                else if (rezervacijaPotvrdena == 0)
                {
                    doKadaJeNedostupan = doKadaVrijediRezervacija;
                }
                primjerci.Add(new Primjerak(
                   int.Parse(reader["p.id_primjerak"].ToString()),
                   status,
                   KnjigaRepozitorij.DohvatiKnjigu(reader["p.ISBN"].ToString()),
                   doKadaJeNedostupan
                   ));
            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return primjerci;
        }
    }
}
