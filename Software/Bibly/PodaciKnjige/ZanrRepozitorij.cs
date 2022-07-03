using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza;
using System.Data;
using PodaciKnjige;

namespace PodaciKnjige
{
    public static class ZanrRepozitorij
    {
        public static List<Zanr> DohvatiSveZanrove()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                   "SELECT * FROM zanrovi";


            List<Zanr> zanrovi = new List<Zanr>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                zanrovi.Add(new Zanr(
                  int.Parse(reader["id_zanr"].ToString()),
                  reader["naziv"].ToString()
                   ));


            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return zanrovi;
        }
        public static int DodajZanr(Zanr zanr)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"INSERT INTO zanrovi VALUES('{zanr.Naziv}')";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }
        public static int AzurirajZanr(Zanr zanr)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"UPDATE zanrovi SET naziv='{zanr.Naziv}' WHERE id_zanr={zanr.Id}";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }
        public static int ObrisiZanr(Zanr zanr)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"DELETE FROM zanrovi WHERE id_zanr = {zanr.Id}";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }
    }
}
