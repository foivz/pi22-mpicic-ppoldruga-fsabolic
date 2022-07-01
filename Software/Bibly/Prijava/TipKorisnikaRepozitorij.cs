using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza;
using System.Data;
namespace Prijava
{
    public static class TipKorisnikaRepozitorij
    {
        public static List<TipKorisnika> DohvatiSveTipoveKorisnika()
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                   "SELECT * FROM tipovi_korisnika";


            List<TipKorisnika> tipoviKorisnika = new List<TipKorisnika>();

            IDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                tipoviKorisnika.Add(new TipKorisnika(
                  int.Parse(reader["id_tip_korisnika"].ToString()),
                  reader["naziv"].ToString()
                   ));


            }
            reader.Close();

            BazaPodataka.Instanca.PrekiniVezu();

            return tipoviKorisnika;
        }

        public static int DodajTipKorisnika(TipKorisnika tipKorisnika)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"INSERT INTO tipovi_korisnika VALUES('{tipKorisnika.Naziv}')";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }
        public static int AzurirajTipKorisnika(TipKorisnika tipKorisnika)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"UPDATE tipovi_korisnika SET naziv='{tipKorisnika.Naziv}' WHERE id_tip_korisnika={tipKorisnika.ID}";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }

        public static int ObrisiTipKorisnika(TipKorisnika tipKorisnika)
        {
            BazaPodataka.Instanca.UspostaviVezu();

            string upit =
                    $"DELETE FROM tipovi_korisnika WHERE id_tip_korisnika={tipKorisnika.ID}";

            int uspjeh = BazaPodataka.Instanca.IzvrsiNaredbu(upit);

            BazaPodataka.Instanca.PrekiniVezu();

            return uspjeh;
        }

    }
}
