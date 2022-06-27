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
    }
}
