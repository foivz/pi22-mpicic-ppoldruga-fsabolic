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
                    $" AND p.ISBN = '{knjiga.ISBN}'";
            List<Primjerak> primjerci = new List<Primjerak>();
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int rezervacijaPotvrdena = (!reader.IsDBNull(8)) ? int.Parse(reader["po.rezervacija_potvrdena"].ToString()) : -1;
                int idPrimjerka = int.Parse(reader["p.id_primjerak"].ToString());
                string doKadaJeDostupno = VratiDostupnost(idPrimjerka, reader["po.datum_posudbe"].ToString(), 
                    reader["po.predviden_datum_vracanja"].ToString(), reader["po.stvarni_datum_vracanja"].ToString(), 
                    reader["po.do_kada_vrijedi_rezervacija"].ToString(), rezervacijaPotvrdena);
                primjerci.Add(new Primjerak(
                   idPrimjerka,
                   VratiStatusKaoEnum(reader["sp.naziv"].ToString()),
                   KnjigaRepozitorij.DohvatiKnjigu(reader["p.ISBN"].ToString()),
                   doKadaJeDostupno
                   ));
            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
            return primjerci;
        }
        public static Primjerak DohvatiPrimjerak(int idPrimjerka)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            string upit =
                    "SELECT p.ISBN AS 'p.ISBN'" +
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
                    $" AND p.id_primjerak = '{idPrimjerka}'";
            List<Primjerak> primjerci = new List<Primjerak>();
            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int rezervacijaPotvrdena = (!reader.IsDBNull(8)) ? int.Parse(reader["po.rezervacija_potvrdena"].ToString()) : -1;
                string doKadaJeDostupno = VratiDostupnost(idPrimjerka, reader["po.datum_posudbe"].ToString(),
                    reader["po.predviden_datum_vracanja"].ToString(), reader["po.stvarni_datum_vracanja"].ToString(),
                    reader["po.do_kada_vrijedi_rezervacija"].ToString(), rezervacijaPotvrdena);
                primjerci.Add(new Primjerak(
                   idPrimjerka,
                   VratiStatusKaoEnum(reader["sp.naziv"].ToString()),
                   KnjigaRepozitorij.DohvatiKnjigu(reader["p.ISBN"].ToString()),
                   doKadaJeDostupno
                   ));
            }
            reader.Close();
            BazaPodataka.Instanca.PrekiniVezu();
            return primjerci[0];
        }

        public static int AzurirajStatusPrimjerka(int idPrimjerka, StatusPrimjerka noviStatus)
        {
            BazaPodataka.Instanca.UspostaviVezu();
            int brojStatusa = VratiStatusKaoBroj(noviStatus);
            string upit = $"UPDATE primjerci " +
                $"SET id_status = '{brojStatusa}' WHERE id_primjerak = {idPrimjerka}";
            int i = BazaPodataka.Instanca.IzvrsiNaredbu(upit);
            BazaPodataka.Instanca.PrekiniVezu();
            return i;
        }

        private static int VratiStatusKaoBroj(StatusPrimjerka status)
        {
            int brojStatusa = 0;
            switch (status)
            {
                case StatusPrimjerka.Dostupan:
                    brojStatusa = 1;
                    break;
                case StatusPrimjerka.Posuđen:
                    brojStatusa = 2;
                    break;
                case StatusPrimjerka.Rezerviran:
                    brojStatusa = 3;
                    break;
            }
            return brojStatusa;
        }

        private static StatusPrimjerka VratiStatusKaoEnum(string status)
        {
            switch (status)
            {
                case "Dostupan":
                    return StatusPrimjerka.Dostupan;
                case "Posuden":
                    return StatusPrimjerka.Posuđen;
                case "Rezerviran":
                    return StatusPrimjerka.Rezerviran;
            }
            return StatusPrimjerka.Greska;
        }

        private static string VratiDostupnost(int idPrimjerka, string datumPosudbe, string predvideniDatumVracanja, string stvarniDatumVracanja, string doKadaVrijediRezervacija, int rezervacijaPotvrdena)
        {
            if (stvarniDatumVracanja == "" && datumPosudbe != "" && rezervacijaPotvrdena != 1)
            {
                //format je yyyy-mm-dd hh:mm:ss i želim uzeti samo datum
                return predvideniDatumVracanja.Split(' ')[0];
            }
            else if (rezervacijaPotvrdena == 0)
            {
                return doKadaVrijediRezervacija.Split(' ')[0];
            }
            else
            {
                return "";
            }
        }
    }
}
